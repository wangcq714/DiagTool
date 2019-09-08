using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DiagTool_Kanwairen
{
    /* This timer should be millisecond precision theoretically ,
     * but actully by the test verify that minimum precision is 2ms. */
    public class MMTimer : IDisposable
    {
        //Lib API declarations
        [DllImport("Winmm.dll", CharSet = CharSet.Auto)]
        static extern uint timeSetEvent(uint uDelay, uint uResolution, TimerCallback lpTimeProc, UIntPtr dwUser,
                                        uint fuEvent);

        [DllImport("Winmm.dll", CharSet = CharSet.Auto)]
        static extern uint timeKillEvent(uint uTimerID);

        [DllImport("Winmm.dll", CharSet = CharSet.Auto)]
        static extern uint timeGetTime();

        [DllImport("Winmm.dll", CharSet = CharSet.Auto)]
        static extern uint timeBeginPeriod(uint uPeriod);

        [DllImport("Winmm.dll", CharSet = CharSet.Auto)]
        static extern uint timeEndPeriod(uint uPeriod);

        //Timer type definitions
        [Flags]
        public enum fuEvent : uint
        {
            TIME_ONESHOT = 0, //Event occurs once, after uDelay milliseconds. 
            TIME_PERIODIC = 1,
            TIME_CALLBACK_FUNCTION = 0x0000, /* callback is function */
            //TIME_CALLBACK_EVENT_SET = 0x0010, /* callback is event - use SetEvent */
            //TIME_CALLBACK_EVENT_PULSE = 0x0020  /* callback is event - use PulseEvent */
        }

        //Delegate definition for the API callback
        public delegate void TimerCallback(uint uTimerID, uint uMsg, UIntPtr dwUser, UIntPtr dw1, UIntPtr dw2);

        //IDisposable code
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Stop();
                }
            }
            disposed = true;
        }

        ~MMTimer()
        {
            Dispose(false);
        }

        /// <summary>
        /// The current timer instance ID
        /// </summary>
        uint id = 0;

        /// <summary>
        /// The callback used by the the API
        /// </summary>
        TimerCallback thisCB;

        /// <summary>
        /// The timer elapsed event 
        /// </summary>
        public event EventHandler Timer;

        protected virtual void OnTimer(EventArgs e)
        {
            if (Timer != null)
            {
                Timer(this, e);
            }
        }

        public MMTimer(TimerCallback CBFunc)
        {
            //Initialize the API callback
            thisCB = CBFunc;
        }

        /// <summary>
        /// Stop the current timer instance (if any)
        /// </summary>
        public void Stop()
        {
            lock (this)
            {
                if (id != 0)
                {
                    timeKillEvent(id);
                    timeEndPeriod(1);
                    Debug.WriteLine("MMTimer " + id.ToString() + " stopped");
                    id = 0;
                }
            }
        }

        /// <summary>
        /// Start a timer instance
        /// </summary>
        /// <param name="ms">Timer interval in milliseconds</param>
        /// <param name="repeat">If true sets a repetitive event, otherwise sets a one-shot</param>
        public void Start(uint ms, bool repeat)
        {
            //Kill any existing timer
            Stop();
            timeBeginPeriod(1);
            //Set the timer type flags
            fuEvent f = fuEvent.TIME_CALLBACK_FUNCTION | (repeat ? fuEvent.TIME_PERIODIC : fuEvent.TIME_ONESHOT);

            lock (this)
            {
                id = timeSetEvent(ms, 0, thisCB, UIntPtr.Zero, (uint)f);
                if (id == 0)
                {
                    throw new Exception("timeSetEvent error");
                }
                Debug.WriteLine("MMTimer " + id.ToString() + " started");
            }
        }
        //long count;
        //volatile int ttt;
        //int pre = 0;
        //void CBFunc(uint uTimerID, uint uMsg, UIntPtr dwUser, UIntPtr dw1, UIntPtr dw2)
        //{
        //    //Callback from the MMTimer API that fires the Timer event. Note we are in a different thread here
        //    OnTimer(new EventArgs());
        //    count++;
        //    ttt = DateTime.Now.Millisecond;
        //    //Console.WriteLine("{0}, {1}, {2}", ttt - pre, ttt, count);
        //    Console.WriteLine("{0}, {1}", ttt - pre, count);
        //    pre = ttt;
        //}
    }



    /* This timer should be microsecond precision theoretically ,
     * but actully by the test verify that the timer always has 150ms interval per second don't know what the CPU do, don't know why this is. */
    /// <summary>
    /// 基于系统性能计数器的定时器，计数单位是1微秒=1/1000毫秒
    /// 注意：该定时器会独占一个CPU核心，尝试定时器与主程序运行在同一核心将导致程序失去响应
    /// </summary>
    public class MTimer
    {
        /// <summary>
        /// 获取当前系统性能计数
        /// </summary>
        /// <param name="lpPerformanceCount"></param>
        /// <returns></returns>
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
        /// <summary>
        /// 获取当前系统性能频率
        /// </summary>
        /// <param name="lpFrequency"></param>
        /// <returns></returns>
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);
        /// <summary>
        /// 指定某一特定线程运行在指定的CPU核心
        /// </summary>
        /// <param name="hThread"></param>
        /// <param name="dwThreadAffinityMask"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        static extern UIntPtr SetThreadAffinityMask(IntPtr hThread, UIntPtr dwThreadAffinityMask);
        /// <summary>
        /// 获取当前线程的Handler
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        static extern IntPtr GetCurrentThread();
        /// <summary>
        /// 是否销毁定时器
        /// </summary>
        private bool _Dispose = false;
        /// <summary>
        /// 是否正在运行定时器
        /// </summary>
        private bool _BRunTimer = false;
        /// <summary>
        /// 首次启动延时（微秒）
        /// </summary>
        private uint _Delay = 0;
        /// <summary>
        /// 定时器周期（微秒）
        /// </summary>
        private long _Period = 10;
        /// <summary>
        /// 定时器运行时独占的CPU核心索引序号
        /// </summary>
        private byte _CpuIndex = 0;
        /// <summary>
        /// 系统性能计数频率（每秒）
        /// </summary>
        private long _Freq = 0;
        /// <summary>
        /// 系统性能计数频率（每微秒）
        /// </summary>
        private long _Freqmms = 0;
        /// <summary>
        /// 回调函数定义
        /// </summary>
        private OnTickHandle Tick;
        /// <summary>
        /// 根据CPU的索引序号获取CPU的标识序号
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        private ulong GetCpuID(int idx)
        {
            ulong cpuid = 0;
            if (idx < 0 || idx >= System.Environment.ProcessorCount)
            {
                idx = 0;
            }
            cpuid |= 1UL << idx;
            return cpuid;
        }
        /// <summary>
        /// 定时器构造函数
        /// </summary>
        /// <param name="delay">首次启动定时器延时时间（微秒）</param>
        /// <param name="period">定时器触发的周期（微秒）</param>
        /// <param name="cpuIndex">指定定时器线程独占的CPU核心索引，必须>0，不允许为定时器分配0#CPU</param>
        /// <param name="tick">定时器触发时的回调函数</param>
        public MTimer(uint delay, uint period, byte cpuIndex, OnTickHandle tick)
        {
            Tick = tick;
            _Delay = delay;
            _Period = period;
            _CpuIndex = cpuIndex;
            long freq = 0;
            QueryPerformanceFrequency(out freq);
            if (freq > 0)
            {
                _Freq = freq;
                _Freqmms = freq / 1000000;//每微秒性能计数器跳跃次数
            }
            else
            {
                throw new Exception("初始化定时器失败");
            }
            if (_CpuIndex == 0)
            {
                throw new Exception("定时器不允许被分配到0#CPU");
            }
            if (_CpuIndex >= System.Environment.ProcessorCount)
            {
                throw new Exception("为定时器分配了超出索引的CPU");
            }
        }
        private System.Threading.Thread _threadRumTimer;
        /// <summary>
        /// 开启定时器
        /// </summary>
        public void Open()
        {
            if (Tick != null)
            {
                _threadRumTimer = new System.Threading.Thread(new System.Threading.ThreadStart(RunTimer));
                _threadRumTimer.Start();
            }
        }
        /// <summary>
        /// 运行定时器
        /// </summary>
        private void RunTimer()
        {
            UIntPtr up = UIntPtr.Zero;
            if (_CpuIndex != 0)
                up = SetThreadAffinityMask(GetCurrentThread(), new UIntPtr(GetCpuID(_CpuIndex)));
            if (up == UIntPtr.Zero)
            {
                throw new Exception("为定时器分配CPU核心时失败");
            }
            long q1, q2;
            QueryPerformanceCounter(out q1);
            QueryPerformanceCounter(out q2);
            if (_Delay > 0)
            {
                while (q2 < q1 + _Delay * _Freqmms)
                {
                    QueryPerformanceCounter(out q2);
                }
            }
            QueryPerformanceCounter(out q1);
            QueryPerformanceCounter(out q2);
            while (!_Dispose)
            {
                _BRunTimer = true;
                QueryPerformanceCounter(out q2);
                if (q2 > q1 + _Freqmms * _Period)
                {
                    //***********回调***********//
                    if (!_Dispose)
                        Tick(this, (q2 - q1) / (_Freqmms * _Period), (q2 - q1) / _Freqmms);
                    q1 = q2;
                    //System.Windows.Forms.Application.DoEvents();//会导致线程等待windows消息循环，时间损失15ms以上
                }
                _BRunTimer = false;
            }
        }
        /// <summary>
        /// 销毁当前定时器所占用的资源
        /// </summary>
        public void Dispose()
        {
            _Dispose = true;
            while (_BRunTimer)
                System.Windows.Forms.Application.DoEvents();//在工作未完成之前，允许处理消息队列，防止调用者挂起
            if (_threadRumTimer != null)
                _threadRumTimer.Abort();
        }
        /// <summary>
        /// 定时器事件的委托定义
        /// </summary>
        /// <param name="sender">事件的发起者，即定时器对象</param>
        /// <param name="JumpPeriod">上次调用和本次调用跳跃的周期数</param>
        /// <param name="interval">上次调用和本次调用之间的间隔时间（微秒）</param>
        public delegate void OnTickHandle(object sender, long JumpPeriod, long interval);

        static int count = 0;
        static int p = 0;
        public static void fun(object sender, long JumpPeriod, long interval)
        {
            count++;
            Console.WriteLine("{0}, {1}, {2}, {3}", DateTime.Now.Millisecond - p, count, JumpPeriod, interval);
            p = DateTime.Now.Millisecond;
        }
        //MTimer m;
        //private void fun(object sender, long JumpPeriod, long interval)
        //{
        //    Console.WriteLine(DateTime.Now.Millisecond);
        //}
        //private void OnOpen(object sender, EventArgs e)
        //{
        //    m = new MTimer(100, 500, 1, fun);
        //    m.Open();
        //}
        //private void OnClose(object sender, EventArgs e)
        //{
        //    m.Dispose();
        //}
    }


}
