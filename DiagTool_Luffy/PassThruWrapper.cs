using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using J2534DotNet;

namespace DiagTool_Luffy
{
    class PassThruWrapper
    {
        public List<J2534Device> availableJ2534Devices = J2534Detect.ListDevices();
        public J2534 passThru = new J2534();
        public int deviceId = 0;  //设备编号，可选择不同的设备       
        public int channelId = 0; //选择设备的不同通道
        public int filterId = 0;


        /* Check device driver */
        public bool DeviceConnectInit(Action<List<J2534Device>> Callback)
        {
            bool retState = false;

            if (availableJ2534Devices.Count != 0)
            {
                Callback(availableJ2534Devices);
                retState = true;
            }

            return retState;
        }

        public bool ConnectDevice(int DeviceSelect, string RequestID, string ResponseID, BaudRate baudRate)
        {
            bool bConnectState = false;
            J2534Err J2534ErrStatus;

            passThru.LoadLibrary(availableJ2534Devices[DeviceSelect]);
            J2534ErrStatus = passThru.Open(ref deviceId);

            if ((J2534ErrStatus == J2534Err.STATUS_NOERROR))
            {
                // OpenADevice = connectCAN();
                bConnectState = ConnectIso15765(RequestID, ResponseID, baudRate);
            }

            return bConnectState;
        }

        public bool ConnectIso15765(string RequestID, string ResponseID, BaudRate baudRate)
        {
            J2534Err J2534ErrStatus;
            List<byte> value = new List<byte>();

            J2534ErrStatus = passThru.Connect(deviceId, ProtocolID.ISO15765, ConnectFlag.NONE, baudRate, ref channelId);
            if (J2534Err.STATUS_NOERROR != J2534ErrStatus)
            {
                return false;
            }

            PassThruMsg maskMsg = new PassThruMsg();
            PassThruMsg patternMsg = new PassThruMsg();
            PassThruMsg flowControlMsg = new PassThruMsg();

            for (byte i = 0; i < 1; i++)
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

                J2534ErrStatus = passThru.StartMsgFilter(channelId, FilterType.FLOW_CONTROL_FILTER, ref maskMsg, ref patternMsg, ref flowControlMsg, ref filterId);
                if (J2534Err.STATUS_NOERROR != J2534ErrStatus)
                {
                    passThru.Disconnect(channelId);
                    return false;
                }
            }
            return true;
        }


        //private bool connectCAN()
        //{
        //    J2534Error = passThru.Connect(deviceId, ProtocolID.CAN, ConnectFlag.NONE, baudRate, ref channelId);

        //    if (J2534Error == J2534Err.STATUS_NOERROR)
        //    {
        //        PassThruMsg maskMsg = new PassThruMsg(ProtocolID.CAN, TxFlag.NONE, new byte[] { 0x00, 0x00, 0x00, 0x00 });   //all to receive
        //        PassThruMsg patternMsg = new PassThruMsg(ProtocolID.CAN, TxFlag.NONE, new byte[] { 0x00, 0x00, 0x00, 0x00 });
        //        passThru.StartMsgFilter(channelId, FilterType.PASS_FILTER, ref maskMsg, ref patternMsg, ref filterId);
        //        passThru.ClearRxBuffer(channelId);
        //        return true;
        //    }
        //    else
        //        return false;
        //}


        public void deviceClose()
        {
            passThru.StopMsgFilter(channelId, filterId);
            passThru.Disconnect(channelId);
            passThru.Close(deviceId);
            passThru.FreeLibrary();
        }

        public void TxMsg(UInt32 RequestID, byte[] msgData, Action<string, string, string, string, string> UpdateUICallback)
        {
            J2534Err J2534ErrStatus;
            int numMsgs = 1;
            PassThruMsg TxMsg = new PassThruMsg();
            TxMsg.ProtocolID = ProtocolID.ISO15765;   //SEND
            TxMsg.TxFlags = TxFlag.ISO15765_FRAME_PAD;
            //TxMsg.ProtocolID = ProtocolID.CAN;
            //TxMsg.TxFlags = TxFlag.NONE;

            TxMsg.Data = PackMsgTxData(RequestID, msgData);

            //passThru.ClearRxBuffer(channelId);
            J2534ErrStatus = passThru.WriteMsgs(channelId, ref TxMsg, ref numMsgs, 10);

            UpdateUICallback(string.Format("{0:X}", RequestID), Convert.ToString(TxMsg.Data.Length - 4), GetMsgDataString(TxMsg.Data), "Tx", DateTime.Now.ToString("HH:mm:ss:fff:ffffff"));
        }

        private byte[] PackMsgTxData(UInt32 RequestID, byte[] msgData)
        {
            byte[] Result = new byte[msgData.Length + 4];

            Result[0] = Convert.ToByte((RequestID >> 24) & 0xFF);
            Result[1] = Convert.ToByte((RequestID >> 16) & 0xFF);
            Result[2] = Convert.ToByte((RequestID >> 8) & 0xFF);
            Result[3] = Convert.ToByte((RequestID >> 0) & 0xFF);

            for (int i = 0; i < msgData.Length; i++)
            {
                Result[i + 4] = msgData[i];
            }

            return Result;
        }

        public void RxMsg(Action<string, string, string, string, string> UpdateUICallback, Action<byte[]> CallDllCallback, Action<byte[]> CallSyncCallback)
        {
            int numMsgs = 0x10;
            List<PassThruMsg> rxMsgs = new List<PassThruMsg>();

            if (J2534Err.STATUS_NOERROR == passThru.ReadMsgs(channelId, ref rxMsgs, ref numMsgs, 0))
            {
                for (int k = 0; k < rxMsgs.Count; k++)
                {
                    if(rxMsgs[k].RxStatus == RxStatus.NONE)
                    {
                            
                        UpdateUICallback(string.Format("{0:X}", GetMsgID(rxMsgs[k].Data)), GetMsgDataLengthString(rxMsgs[k].Data), GetMsgDataString(rxMsgs[k].Data), "Rx", DateTime.Now.ToString("HH:mm:ss:fff:ffffff"));
                        /*calldll caculate  key by receive seed*/
                        //CallDllCallback(rxMsgs[k].Data);
                        /* synchronous rx data for other module */
                        //CallSyncCallback(rxMsgs[k].Data);
                    }
                    else if ((rxMsgs[k].RxStatus == (RxStatus.TX_MSG_TYPE | RxStatus.TX_INDICATION)))
                    {
                        //UpdateUICallback(string.Format("{0:X}", GetMsgID(rxMsgs[k].Data)), GetMsgDataLengthString(rxMsgs[k].Data), GetMsgDataString(rxMsgs[k].Data), "Tx", ConvertMsgTimeStampToString(rxMsgs[k].Timestamp));
                    }
                }
            }
        }

        private UInt32 GetMsgID(byte[] Data)
        {
            UInt32 Result = 0;

            for (int i = 0; i < 4; i++)
            {
                Result <<= 8;
                Result += Data[i];
            }

            return Result;
        }

        private string GetMsgDataLengthString(byte[] Data)
        {
            string Result = String.Empty;

            Result = Convert.ToString(Data.Length - 4);

            return Result;
        }

        private string GetMsgDataString(byte[] Data)
        {
            string Result = String.Empty;

            for (int i = 0; i < (Data.Length - 4); i++)
            {
                Result += string.Format("{0:X2}", Data[i + 4]) + " ";
            }

            return Result;
        }

        private string ConvertMsgTimeStampToString(int Timestamp)
        {
            string Result = String.Empty;

            string second = Convert.ToString(Timestamp / (1000 * 1000));
            string millisecond = Convert.ToString(Timestamp / 1000 % 1000).PadLeft(3, '0');
            string microsecond = Convert.ToString(Timestamp % 1000).PadLeft(3, '0');
            Result = second + "." + millisecond + "." + microsecond;

            return Result;
        }

    }
}
