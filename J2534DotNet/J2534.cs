using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace J2534DotNet
{
    public class J2534 : IJ2534
    {
        private J2534Device m_device;
        private J2534DllWrapper m_wrapper;

        public bool LoadLibrary(J2534Device device)
        {
            m_device = device;
            m_wrapper = new J2534DllWrapper();
            return m_wrapper.LoadJ2534Library(m_device.FunctionLibrary);
        }

        public bool FreeLibrary()
        {
            return m_wrapper.FreeLibrary();
        }

        public J2534Err Open(ref int deviceId)
        {
            int nada = 0;
            return (J2534Err)m_wrapper.Open(nada, ref deviceId);
        }

        public J2534Err Close(int deviceId)
        {
            return (J2534Err)m_wrapper.Close(deviceId);
        }

        public J2534Err Connect(int deviceId, ProtocolID protocolId, ConnectFlag flags, BaudRate baudRate, ref int channelId)
        {
            return (J2534Err)m_wrapper.Connect(deviceId, (int)protocolId, (int)flags, (int)baudRate, ref channelId);
        }

        public J2534Err Connect(int deviceId, ProtocolID protocolId, ConnectFlag flags, int baudRate, ref int channelId)
        {
            return (J2534Err)m_wrapper.Connect(deviceId, (int)protocolId, (int)flags, baudRate, ref channelId);
        }

        public J2534Err Disconnect(int channelId)
        {
            return (J2534Err)m_wrapper.Disconnect(channelId);
        }

        public J2534Err ReadMsgs(int channelId, ref List<PassThruMsg> msgs, ref int numMsgs, int timeout)
        {
            IntPtr pMsg = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(UnsafePassThruMsg)) * 50);
            IntPtr pNextMsg = IntPtr.Zero;
            //IntPtr[] pMsgs = new IntPtr[50];
            UnsafePassThruMsg[] pMsgs = new UnsafePassThruMsg[numMsgs];
            //J2534Err returnValue = (J2534Err)m_wrapper.ReadMsgs(channelId, pMsg, ref numMsgs, timeout);
            J2534Err returnValue = (J2534Err)m_wrapper.ReadMsgs(channelId, ref pMsgs[0], ref numMsgs, timeout);
            if (returnValue == J2534Err.STATUS_NOERROR)
            {
                for (int i = 0; i < numMsgs; i++)
                {
                    //pNextMsg = (IntPtr)(Marshal.SizeOf(typeof(UnsafePassThruMsg)) * i + (int)pMsg);
                    //UnsafePassThruMsg uMsg = (UnsafePassThruMsg)Marshal.PtrToStructure(pMsg, typeof(UnsafePassThruMsg));
                    //msgs.Add(ConvertPassThruMsg(uMsg));
                    msgs.Add(ConvertPassThruMsg(pMsgs[i]));
                }
            }
            Marshal.FreeHGlobal(pMsg);
            return returnValue;
        }

        public J2534Err WriteMsgs(int channelId, ref PassThruMsg msg, ref int numMsgs, int timeout)
        {
            UnsafePassThruMsg uMsg = ConvertPassThruMsg(msg);
            // TODO: change function to accept a list? of PassThruMsg
            return (J2534Err)m_wrapper.WriteMsgs(channelId, ref uMsg, ref numMsgs, timeout);
        }

        public J2534Err StartPeriodicMsg(int channelId, ref PassThruMsg msg, ref int msgId, int timeInterval)
        {
            UnsafePassThruMsg uMsg = ConvertPassThruMsg(msg);
            return (J2534Err)m_wrapper.StartPeriodicMsg(channelId, ref uMsg, ref msgId, timeInterval);
        }

        public J2534Err StopPeriodicMsg(int channelId, int msgId)
        {
            return (J2534Err)m_wrapper.StopPeriodicMsg(channelId, msgId);
        }

        public J2534Err StartMsgFilter
       (
           int channelid,
           FilterType filterType,
           ref PassThruMsg maskMsg,
           ref PassThruMsg patternMsg,
           ref PassThruMsg flowControlMsg,
           ref int filterId
       )
        {
            UnsafePassThruMsg uMaskMsg = ConvertPassThruMsg(maskMsg);
            UnsafePassThruMsg uPatternMsg = ConvertPassThruMsg(patternMsg);
            UnsafePassThruMsg uFlowControlMsg = ConvertPassThruMsg(flowControlMsg);
            return (J2534Err)m_wrapper.StartMsgFilter
                    (
                        channelid,
                        (int)filterType,
                        ref uMaskMsg,
                        ref uPatternMsg,
                        ref uFlowControlMsg,
                        ref filterId
                    );
        }

        public J2534Err StartMsgFilter
       (
           int channelid,
           FilterType filterType,
           ref PassThruMsg maskMsg,
           ref PassThruMsg patternMsg,
           ref int filterId
       )
        {
            int nada = 0;
            UnsafePassThruMsg uMaskMsg = ConvertPassThruMsg(maskMsg);
            UnsafePassThruMsg uPatternMsg = ConvertPassThruMsg(patternMsg);
            return (J2534Err)m_wrapper.StartPassBlockMsgFilter
                    (
                        channelid,
                        (int)filterType,
                        ref uMaskMsg,
                        ref uPatternMsg,
                        nada,
                        ref filterId
                    );
        }

        public J2534Err StopMsgFilter(int channelId, int filterId)
        {
            return (J2534Err)m_wrapper.StopMsgFilter(channelId, filterId);
        }

        public J2534Err SetProgrammingVoltage(int deviceId, PinNumber pinNumber, int voltage)
        {
            return (J2534Err)m_wrapper.SetProgrammingVoltage(deviceId, (int)pinNumber, voltage);
        }

        public J2534Err ReadVersion(int deviceId, ref string firmwareVersion, ref string dllVersion, ref string apiVersion)
        {
            IntPtr pFirmwareVersion = Marshal.AllocHGlobal(120);
            IntPtr pDllVersion = Marshal.AllocHGlobal(120);
            IntPtr pApiVersion = Marshal.AllocHGlobal(120);
            J2534Err returnValue = (J2534Err)m_wrapper.ReadVersion(deviceId, pFirmwareVersion, pDllVersion, pApiVersion);
            if (returnValue == J2534Err.STATUS_NOERROR)
            {
                firmwareVersion = Marshal.PtrToStringAnsi(pFirmwareVersion);
                dllVersion = Marshal.PtrToStringAnsi(pDllVersion);
                apiVersion = Marshal.PtrToStringAnsi(pApiVersion);
            }

            Marshal.FreeHGlobal(pFirmwareVersion);
            Marshal.FreeHGlobal(pDllVersion);
            Marshal.FreeHGlobal(pApiVersion);

            return returnValue;
        }

        public J2534Err GetLastError(ref string errorDescription)
        {
            IntPtr pErrorDescription = Marshal.AllocHGlobal(120);
            J2534Err returnValue = (J2534Err)m_wrapper.GetLastError(pErrorDescription);
            if (returnValue == J2534Err.STATUS_NOERROR)
            {
                errorDescription = Marshal.PtrToStringAnsi(pErrorDescription);
            }

            Marshal.FreeHGlobal(pErrorDescription);

            return returnValue;
        }

        public J2534Err GetConfig(int channelId, ref List<SConfig> config)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;

            return (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.GET_CONFIG, input, output);
        }

        public J2534Err SetConfig(int channelId, int Parameter,int Value)  //leon changed 20190105
       //  public J2534Err SetConfig(int channelId, SConfig_List config)
        {
            J2534Err J2534Err1;
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;

            SConfig sconfig = new SConfig();
            sconfig.Parameter = Parameter;
            sconfig.Value = Value;
            IntPtr[] intptrr = new IntPtr[1];
            intptrr[0] = Marshal.AllocHGlobal(Marshal.SizeOf(sconfig));
            try
            {
                Marshal.StructureToPtr(sconfig, intptrr[0], true);

                SConfig_List sconfig_list = new SConfig_List();
                sconfig_list.NumOfParams = 1;
                sconfig_list.ConfigPtr = intptrr;

                input = Marshal.AllocCoTaskMem(Marshal.SizeOf(sconfig_list));
                Marshal.StructureToPtr(sconfig_list, input, true);
                J2534Err1 = (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.SET_CONFIG, input, output);
            }
            finally
            {
                Marshal.FreeHGlobal(input);
            }
            return J2534Err1;

            ////IntPtr InPut = Marshal.AllocHGlobal(Marshal.SizeOf(config));
            //IntPtr InPut = Marshal.AllocCoTaskMem(Marshal.SizeOf(config));
            ////  IntPtr output = IntPtr.Zero;
            //try
            //{
            //    Marshal.StructureToPtr(config, InPut, true);
            //    unsafe
            //    {
            //        //InPut.ToPointer();
            //        J2534Err1 = (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.SET_CONFIG, InPut, output);
            //    }

            //}
            //finally
            //{
            //    Marshal.FreeHGlobal(InPut);
            //}
            //return J2534Err1;
            
        }

        public J2534Err ReadBatteryVoltage(int deviceId, ref int voltage)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = Marshal.AllocHGlobal(8);

            J2534Err returnValue = (J2534Err)m_wrapper.Ioctl(deviceId, (int)Ioctl.READ_VBATT, input, output);
            if (returnValue == J2534Err.STATUS_NOERROR)
            {
                voltage = Marshal.ReadInt32(output);
            }

            Marshal.FreeHGlobal(output);

            return returnValue;
        }

        public J2534Err FiveBaudInit(int channelId, byte targetAddress, ref byte keyword1, ref byte keyword2)
        {
            J2534Err returnValue;
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;

            SByteArray inputArray = new SByteArray();
            SByteArray outputArray = new SByteArray();
            inputArray.NumOfBytes = 1;
            unsafe
            {
                //inputArray.BytePtr[0] = targetAddress;
                outputArray.NumOfBytes = 2;

                Marshal.StructureToPtr(inputArray, input, true);
                Marshal.StructureToPtr(outputArray, output, true);

                returnValue = (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.FIVE_BAUD_INIT, input, output);

                Marshal.PtrToStructure(output, outputArray);
            }
            return returnValue;
        }

        public J2534Err FastInit(int channelId, PassThruMsg txMsg, ref PassThruMsg rxMsg)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;
            UnsafePassThruMsg uTxMsg = ConvertPassThruMsg(txMsg);
            UnsafePassThruMsg uRxMsg = new UnsafePassThruMsg();

            Marshal.StructureToPtr(uTxMsg, input, true);
            Marshal.StructureToPtr(uRxMsg, output, true);

            J2534Err returnValue = (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.FAST_INIT, input, output);
            if (returnValue == J2534Err.STATUS_NOERROR)
            {
                Marshal.PtrToStructure(output, uRxMsg);
            }

            rxMsg = ConvertPassThruMsg(uRxMsg);
            return returnValue;
        }

        public J2534Err ClearTxBuffer(int channelId)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;

            return (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.CLEAR_TX_BUFFER, input, output);
        }

        public J2534Err ClearRxBuffer(int channelId)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;

            return (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.CLEAR_RX_BUFFER, input, output);
        }

        public J2534Err ClearPeriodicMsgs(int channelId)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;

            return (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.CLEAR_PERIODIC_MSGS, input, output);
        }

        public J2534Err ClearMsgFilters(int channelId)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;

            return (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.CLEAR_MSG_FILTERS, input, output);
        }

        public J2534Err ClearFunctMsgLookupTable(int channelId)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;

            return (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.CLEAR_FUNCT_MSG_LOOKUP_TABLE, input, output);
        }

        public J2534Err AddToFunctMsgLookupTable(int channelId)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;
            // TODO: fix this
            return (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.ADD_TO_FUNCT_MSG_LOOKUP_TABLE, input, output);
        }

        public J2534Err DeleteFromFunctMsgLookupTable(int channelId)
        {
            IntPtr input = IntPtr.Zero;
            IntPtr output = IntPtr.Zero;
            // TODO: fix this
            return (J2534Err)m_wrapper.Ioctl(channelId, (int)Ioctl.DELETE_FROM_FUNCT_MSG_LOOKUP_TABLE, input, output);
        }


        private UnsafePassThruMsg ConvertPassThruMsg(PassThruMsg msg)
        {
            UnsafePassThruMsg uMsg = new UnsafePassThruMsg();

            uMsg.ProtocolID = (int)msg.ProtocolID;
            uMsg.RxStatus = (int)msg.RxStatus;
            uMsg.Timestamp = msg.Timestamp;
            uMsg.TxFlags = (int)msg.TxFlags;
            uMsg.ExtraDataIndex = msg.ExtraDataIndex;
            uMsg.DataSize = msg.Data.Length;
            unsafe
            {
                for (int i = 0; i < msg.Data.Length; i++)
                {
                    uMsg.Data[i] = msg.Data[i];
                }
            }

            return uMsg;
        }

        private static PassThruMsg ConvertPassThruMsg(UnsafePassThruMsg uMsg)
        {
            PassThruMsg msg = new PassThruMsg();
            msg.ProtocolID = (ProtocolID)uMsg.ProtocolID;
            msg.RxStatus = (RxStatus)uMsg.RxStatus;
            msg.Timestamp = uMsg.Timestamp;
            msg.TxFlags = (TxFlag)uMsg.TxFlags;
            msg.ExtraDataIndex = uMsg.ExtraDataIndex;
            msg.Data = new byte[uMsg.DataSize];
            unsafe
            {
                for (int i = 0; i < uMsg.DataSize; i++)
                {
                    msg.Data[i] = uMsg.Data[i];
                }
            }
            return msg;
        }

        [StructLayout(LayoutKind.Sequential)]
        private unsafe struct SByteArray
        {
            public int NumOfBytes;
            public fixed byte BytePtr[2];
        }



    }
}
