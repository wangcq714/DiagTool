using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using J2534DotNet;
using Sample;
using System.Runtime.InteropServices;  //dll using this namespace
using System.Reflection;   //反射
using System.Threading;

namespace Diag_Tool_leon
{
    public partial class Leon : Form
    {
        public Leon()
        {
            InitializeComponent();
        }
        /*
         *  初始化相关
         */
        DataTable DTCANRxScroll = new DataTable();
        J2534 passThru = new J2534();
        List<J2534Device> availableJ2534Devices = J2534Detect.ListDevices();
        J2534Err J2534Error;
        string strDataID = "";
        string strDatebyte = "";
        int deviceId = 0;  //设备编号，可选择不同的设备
        private bool OpenADevice = false;   //用于表示是否成功连接一个设备
        int baudRate = 500000;          //波特率 
        int channelId = 0; //选择设备的不同通道
        int filterId = 0;
        int numMsgs = 100;
        long Sum_Message = 0;
      //  long Old_Timestamp=0;
        long INIT_Timestamp = 0;
        byte SelecIndForSecur = 0;
        static public string Flash_File_path = "";

        //Form 大小相关
        float Xratio = 1;
        float Yratio = 1;
        Size originalSize;

        private void Form1_Load(object sender, EventArgs e)
        {
            originalSize=this.Size;
            DTCANRxScroll.Columns.Add("Sum", typeof(int));
           // DTCANRxScroll.Columns.Add("delata_Time");
            DTCANRxScroll.Columns.Add("Type");
            DTCANRxScroll.Columns.Add("ArbID");
            DTCANRxScroll.Columns.Add("Length", typeof(int));
            DTCANRxScroll.Columns.Add("Data");
            DTCANRxScroll.Columns.Add("TimeStamp");
            dgvCANRx.DataSource = DTCANRxScroll;
            dgvCANRx.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dgvCANRx.Columns[0].Width = 60;
            dgvCANRx.Columns[1].Width = 60;
            dgvCANRx.Columns[2].Width = 60;
            dgvCANRx.Columns[3].Width = 70;
            dgvCANRx.Columns[4].Width = 460;
            dgvCANRx.Columns[5].Width = 200;
            //dgvCANRx.DefaultCellStyle.Font.FontFamily = ;
            if (availableJ2534Devices.Count == 0)
            {
                MessageBox.Show("请检查设备驱动哦！");
                return;
            }
            foreach (J2534Device device in availableJ2534Devices)
                AllDevice.Items.Add(device.Name);
            AllDevice.SelectedIndex = 0;
            button1.Image = Image.FromFile("stop.png");
            RequestID.Text = "710";
            ResponseID.Text = "718";

            Diag_Function.Items.Add("诊断");
            Diag_Function.Items.Add("刷新");
            Diag_Function.SelectedIndex = 0;

            comboBox1.Items.Add("27 01/02");
            comboBox1.Items.Add("27 03/04");
            comboBox1.Items.Add("27 05/06");
            comboBox1.SelectedIndex = 0;

            File_path.Text = "";
            Require_cont.Text = "";
            OpenADevice = false;
            label4.Text = "NOK";

            //3E相关
            checkBox1.Checked = true;
            comboBox2.Items.Add("3E 00");
            comboBox2.Items.Add("3E 80");
            comboBox2.SelectedIndex = 1;
        }


        //发送
        private void button4_Click(object sender, EventArgs e)
        {
            if (!OpenADevice)
                return;
            if ((RequestID.Text.Trim() == "") || (Require_cont.Text.Trim() == ""))
                return;

            Transmit_Message(RequestID.Text, Require_cont.Text);
        }

        //连接设备
        private void button1_Click(object sender, EventArgs e)
        {
            connectToDevice();
        }
        public void connectToDevice()
        {
            if (!OpenADevice)
            {
                passThru.LoadLibrary(availableJ2534Devices[AllDevice.SelectedIndex]);
                J2534Error = passThru.Open(ref deviceId);

                if ((J2534Error == J2534Err.STATUS_NOERROR))
                {
                    // OpenADevice = connectCAN();
                    OpenADevice = ConnectIso15765(RequestID.Text, ResponseID.Text);
                    if (OpenADevice)
                    {
                        button1.Image = Image.FromFile("run.png");
                        label4.Text = "OK";
                        timer1.Start();

                        Diag_Function.Enabled = false;
                        RequestID.Enabled = false;
                        ResponseID.Enabled = false;
                        AllDevice.Enabled = false;
                    }
                    else
                    {
                        deviceClose();
                        MessageBox.Show("请检查设备连接！", "Error");
                    }
                }
                else
                {
                    OpenADevice = false;
                    MessageBox.Show("请检查设备连接！！", "Error");
                }
            }
            else
            {
                deviceClose();
                Diag_Function.Enabled = true;
                RequestID.Enabled = true;
                ResponseID.Enabled = true;
                AllDevice.Enabled = true;
            }
        }

        public bool ConnectIso15765(string RequestID, string ResponseID)
        {
            List<byte> value = new List<byte>();

            J2534Error = passThru.Connect(deviceId, ProtocolID.ISO15765, ConnectFlag.NONE, BaudRate.ISO15765, ref channelId);
            if (J2534Err.STATUS_NOERROR != J2534Error)
            {
                return false;
            }

            PassThruMsg maskMsg = new PassThruMsg();
            PassThruMsg patternMsg = new PassThruMsg();
            PassThruMsg flowControlMsg = new PassThruMsg();

            byte i;
            for (i = 0; i < 1; i++)
            {
                maskMsg.ProtocolID = ProtocolID.ISO15765;
                maskMsg.TxFlags = TxFlag.ISO15765_FRAME_PAD;
                maskMsg.Data = new byte[] { 0xff, 0xff, 0xff, 0xff };  //4 "FF" for stand ID,5 "FF" for extend ID

                byte ReqID_1 = (byte)Convert.ToUInt16(RequestID.Trim().ToUpper().Substring(0, 1), 16);
                byte ReqID_2 = (byte)Convert.ToUInt16(RequestID.Trim().ToUpper().Substring(1, 2), 16);

                byte RespID_1 = (byte)Convert.ToUInt16(ResponseID.Trim().ToUpper().Substring(0, 1), 16);
                byte RespID_2 = (byte)Convert.ToUInt16(ResponseID.Trim().ToUpper().Substring(1, 2), 16);

                patternMsg.ProtocolID = ProtocolID.ISO15765;
                patternMsg.TxFlags = TxFlag.ISO15765_FRAME_PAD;
                patternMsg.Data = new byte[] { 0x00, 0x00, RespID_1, RespID_2 };

                flowControlMsg.ProtocolID = ProtocolID.ISO15765;
                flowControlMsg.TxFlags = TxFlag.ISO15765_FRAME_PAD;
                flowControlMsg.Data = new byte[] { 0x00, 0x00, ReqID_1, ReqID_2 };

                J2534Error = passThru.StartMsgFilter(channelId, FilterType.FLOW_CONTROL_FILTER, ref maskMsg, ref patternMsg, ref flowControlMsg, ref filterId);
                if (J2534Err.STATUS_NOERROR != J2534Error)
                {
                    passThru.Disconnect(channelId);
                    return false;
                }
            }
            return true;
        }
        

        private bool connectCAN()
        {
            J2534Error = passThru.Connect(deviceId, ProtocolID.CAN, ConnectFlag.NONE, baudRate, ref channelId);

            if (J2534Error == J2534Err.STATUS_NOERROR)
            {
                PassThruMsg maskMsg = new PassThruMsg(ProtocolID.CAN, TxFlag.NONE, new byte[] { 0x00, 0x00, 0x00, 0x00 });   //all to receive
                PassThruMsg patternMsg = new PassThruMsg(ProtocolID.CAN, TxFlag.NONE, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                passThru.StartMsgFilter(channelId, FilterType.PASS_FILTER, ref maskMsg, ref patternMsg, ref filterId);
                passThru.ClearRxBuffer(channelId);
                return true;
            }
            else
                return false;
        }



        private void deviceDisconnect()
        {
            if (OpenADevice)
            {
                passThru.StopMsgFilter(channelId, filterId);
                passThru.Disconnect(channelId);
            }
        }

        private void deviceClose()
        {
            timer1.Stop();
            deviceDisconnect();
            if (OpenADevice)
            {
                passThru.Close(deviceId);
                passThru.FreeLibrary();
                OpenADevice = false;
            }
            button1.Image = Image.FromFile("stop.png");
            label4.Text = "NOK";
        }

        public void Transmit_Message(string DID_REAL,string MessageToSend)
        {
            int DID = Convert.ToInt32(DID_REAL.Trim(), 16);
            string[] dataStr = MessageToSend.Trim().Split(' ');
            int[] byteStr = new int[dataStr.Length + 4];
            byteStr[0] = 0;
            byteStr[1] = 0;
            byteStr[2] = (byte)((int)DID / 256);
            byteStr[3] = (byte)((int)DID % 256);

            strDatebyte = "";
            for (int i = 0; i < dataStr.Length; i++)
            {
                byteStr[i + 4] = Convert.ToInt32(dataStr[i], 16);
            }

            PassThruMsg TxMsg = new PassThruMsg();
            TxMsg.ProtocolID = ProtocolID.ISO15765;   //SEND
            TxMsg.TxFlags = TxFlag.ISO15765_FRAME_PAD;
            //TxMsg.ProtocolID = ProtocolID.CAN;
            //TxMsg.TxFlags = TxFlag.NONE;

            TxMsg.Data = new byte[byteStr.Length];
            for (int i = 0; i < byteStr.Length; i++)
            {
                TxMsg.Data[i] = (byte)byteStr[i];
            }
            for (int i = 0; i < (TxMsg.Data.Length - 4); i++)
                strDatebyte += string.Format("{0:X2}", TxMsg.Data[i + 4]) + " ";

            passThru.ClearRxBuffer(channelId);
            int numMsgs = 1;    //to be tested later
            J2534Error = passThru.WriteMsgs(channelId, ref TxMsg, ref numMsgs, 50);

            if (strDatebyte.Substring(0, 2)=="3E")
                return;

            Sum_Message = DTCANRxScroll.Rows.Count;

            DataRow canRow;
            canRow = DTCANRxScroll.NewRow();
            canRow[0] = Sum_Message + 1;
            canRow[1] = "Tx";
            canRow[2] = "0x" + RequestID.Text.Trim();
            canRow[3] = TxMsg.Data.Length - 4;
            canRow[4] = strDatebyte;
            canRow[5] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");//string.Format("{0:G}", System.DateTime.Now);//结果为：2009-3-20 15:39:27
            DTCANRxScroll.Rows.Add(canRow);
            INIT_Timestamp = TxMsg.Timestamp;
            dgvCANRx.FirstDisplayedScrollingRowIndex = dgvCANRx.RowCount - 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!OpenADevice)
                return;
            if(Diag_Function.SelectedIndex == 1)
            {
                RequestID.Enabled=false;
                Require_cont.Enabled = false;
                button4.Enabled = false;
            }
            else if (Diag_Function.SelectedIndex == 0)
            {
               // RequestID.Enabled = true;
                Require_cont.Enabled = true;
                button4.Enabled = true;
            }


            List<PassThruMsg> rxMsgs = new List<PassThruMsg>();
            J2534Err status = J2534Err.STATUS_NOERROR;
            numMsgs = 10;//test line
            status = passThru.ReadMsgs(channelId,ref rxMsgs, ref numMsgs,0);  /////////////////////
            int count = rxMsgs.Count;
            for (int k = 0; k < count; k++)  
            {
                strDataID = "";
                strDatebyte = "";
                if (rxMsgs[k].Data.Length > 4)   //前四个字节是地址  //长帧回的第一帧猜测只是ID的4个字节
                {
                    for (int i = 0; i < 4; i++)
                        strDataID += string.Format("{0:X2}", rxMsgs[k].Data[i]);   //转2个16进制表示的数字
                    if (strDataID.TrimStart('0') == ResponseID.Text.Trim().ToUpper())
                    {
                        for (int i = 0; i < (rxMsgs[k].Data.Length - 4); i++)
                            strDatebyte += string.Format("{0:X2}", rxMsgs[k].Data[i + 4]) + " ";
                        if (status == J2534Err.STATUS_NOERROR)    //maybe no use
                        {
                            int rowindex = DTCANRxScroll.Rows.Count;
                            DataRow canRow;
                            canRow = DTCANRxScroll.NewRow();
                            canRow[0] = rowindex + 1;
                            canRow[1] = "Rx";
                            canRow[2] = "0x" + strDataID.TrimStart('0');
                            canRow[3] = rxMsgs[k].Data.Length - 4;
                            canRow[4] = strDatebyte;
                            canRow[5] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");//string.Format("{0:G}", System.DateTime.Now);

                            //canRow[1] = ((float)(rxMsgs[k].Timestamp - INIT_Timestamp) / 1000).ToString("F2");//float 保留两位小数？
                            DTCANRxScroll.Rows.Add(canRow);
                            DTCANRxScroll.AcceptChanges();
                            //INIT_Timestamp = rxMsgs[k].Timestamp;
                            dgvCANRx.FirstDisplayedScrollingRowIndex = dgvCANRx.RowCount - 1;

                            if ((SelecIndForSecur > 0) && ((strDatebyte.Substring(0, 5) == "67 01") || (strDatebyte.Substring(0, 5) == "67 03") || (strDatebyte.Substring(0, 5) == "67 05"))) Security_DLL(rxMsgs[k].Data);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (checkBox1.Checked == true)
            {
                timer2.Start();
            }
            else
            {
                timer2.Stop();
            }
        }
//        System.Reflection命名空间
//(1)   AppDomain:应用程序域，可以将其理解为一组程序集的逻辑容器
//(2)   Assembly:程序集类
//(3)   Module:模块类
//(4)   Type:使用反射得到类型信息的最核心的类
//他们之间是一种从属关系，也就是说，一个AppDomain可以包含N个Assembly,一个Assembly可以包含N个Module,而一个Module可以包含N个Type.


        //在要使用dll的文件中先定一个委托

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void doDllFunction(ref byte seed_value, ref byte key_value);
        //public delegate void doDllFunction(string seed_value, string key_value);

        private void Security_DLL(byte[] DataReceive)
        { 
            byte[] key= new byte[4];
            byte[] seed = new byte[4];
            strDatebyte = "";
            //string KEY1 = "";
            //string SEE1 = "";

            for (int i = 0; i < 4; i++)
            {
                seed[i] = DataReceive[6 + i];
              //  SEE1 += string.Format("{0:X2}", seed[i]);
            }

            if ((DataReceive[5] == 01) || (DataReceive[5] == 03) || (DataReceive[5] == 05))
            {
                if ((importDiag.Dll_Path) != "")
                {
                    DllTest dllinvoke = new DllTest(importDiag.Dll_Path);   //实例化 或者satatic方法
                    doDllFunction show = (doDllFunction)dllinvoke.Invoke("CalcKeys1", typeof(doDllFunction));//InitFunction为需要执行的函数名
                    show(ref seed[0], ref key[0]);

                    switch (DataReceive[5])
                    {
                        case 01:
                            strDatebyte+="27 02 ";
                            break;
                        case 03:
                            strDatebyte += "27 04 ";
                            break;
                        case 05:
                            strDatebyte += "27 06 ";
                            break;
                        default:
                            break;
                    }
                   
                    for (int i = 0; i < 4; i++)
                        strDatebyte += string.Format("{0:X2}", key[i]) + " ";

                    Transmit_Message(RequestID.Text, strDatebyte);
                }
            }

        }
        private void dgvCANRx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
              //contextMenuStrip1.Show(e.X + this.Left, e.Y + this.Top);
            }
        }

        private void 删除本行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int COUNT = dgvCANRx.Rows.Count;
            if ((dgvCANRx.Rows.Count > 1) && (dgvCANRx.CurrentRow.Index<COUNT))
                dgvCANRx.Rows.Remove(dgvCANRx.CurrentRow);
        }

        private void 清除所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int COUNT = dgvCANRx.Rows.Count;
            //for (int i = COUNT - 1; i >= 0; i--)  //倒序删，因为正序删会变索引
            {
                DTCANRxScroll.Clear();   //dgvCANRx.Rows.RemoveAt(i);不能用，不知为何？
            }
        }

        private void 导入dllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importDiag Form1 = new importDiag();
            Form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Transmit_Message(RequestID.Text, "27 01");   //send 
                    SelecIndForSecur = 1;
                    break;
                case 1:
                    Transmit_Message(RequestID.Text, "27 03");
                    SelecIndForSecur = 2;
                    break;
                case 2:
                    Transmit_Message(RequestID.Text, "27 05");
                    SelecIndForSecur = 3;
                    break;
                default:
                    break;
            }
        }
        void ChangeFormSize()
        {
            //自动调整大小
            Xratio = (float)this.Size.Width / (float)originalSize.Width;
            Yratio = (float)this.Size.Height / (float)originalSize.Height;
            foreach (Control a in this.Controls)
            {
                a.Size = new Size((int)(a.Size.Width * Xratio), (int)(a.Size.Height * Yratio));
                a.Location = new Point((int)(a.Location.X * Xratio), (int)(a.Location.Y * Yratio));
            }
            originalSize = this.Size;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!OpenADevice)
                return;
            if (comboBox2.SelectedIndex==0) 
                Transmit_Message(RequestID.Text, "3E 00");
            else
                Transmit_Message(RequestID.Text, "3E 80");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           // ChangeFormSize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Diag_Function.SelectedIndex == 1)
            {
                OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
                OpenFileDialog1.Filter = "HEX Files (*.hex)|*.hex|All files (*.*)|*.*";
                OpenFileDialog1.RestoreDirectory = true;
                OpenFileDialog1.FilterIndex = 1;
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File_path.Text = OpenFileDialog1.FileName;
                    Flash_File_path = File_path.Text;
                    //FlashForm Form2 = new FlashForm();
                    //Form2.ShowDialog();
                }

            }
            else 
            {
                MessageBox.Show("Hey.buddy.请选择刷新模式啊!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Diag_Function.SelectedIndex == 0)
            {
                MessageBox.Show("Hey.buddy.请选择刷新模式啊!");
            }
            else if (File_path.Text == "")
            {
                MessageBox.Show("Hey.buddy.请选择刷新hex啊!");
            }
            //else if (!OpenADevice)    //Annotate the code to test the flash function.   
            //{
            //    MessageBox.Show("Hey.buddy.请连接设备先啊!");
            //}
            else
            {
                //connectToDevice();
               // deviceClose();
                //不清楚为什么要加这一行，总之测了万千遍，这行加了刷新就没事了。
                passThru.LoadLibrary(availableJ2534Devices[AllDevice.SelectedIndex]);

                FlashForm FlashForm1 = new FlashForm();
                FlashForm1.ShowDialog();
            }
        }

        private void Require_cont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)   //enter 
            {
                button4_Click(sender,e);
            }
        }

        private void dgvCANRx_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dgvCANRx.CurrentCell.Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HexToAsciiFunc(textBox1.Text);
        }

        private void HexToAsciiFunc(string HexValue)
        {
            UInt16 HEXVALUE;
            textBox2.Text = "";
            string[] HEX1 = HexValue.Trim().Split(' ');

            foreach (string HexHexIndex in HEX1)
            {
                HEXVALUE = Convert.ToUInt16(HexHexIndex, 16);
                textBox2.Text+=((char)HEXVALUE).ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (OpenADevice)
            {
                string[] EEP_Init = new string[] { "10 01", "10 60", "27 61", "27 62 55 AA AA 55", "31 01 F0 04" };
                foreach (string Eep_Com in EEP_Init)
                {
                    Transmit_Message(RequestID.Text, Eep_Com);
                    Thread.Sleep(50);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)   //enter 
            {
                button6_Click(sender, e);
            }
        }

        private void 简介1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没什么内容，诊断，刷新，诊断测试而已.\n爱是一道光，如此美妙");
        }
    }
}
