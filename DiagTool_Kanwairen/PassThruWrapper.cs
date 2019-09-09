using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using J2534DotNet;

namespace DiagTool_Kanwairen
{
    class PassThruWrapper
    {
        public List<J2534Device> availableJ2534Devices = J2534Detect.ListDevices();
        public J2534Err J2534ErrStatus;     //J2534状态
        public J2534 passThru = new J2534();
        public int deviceId = 0;  //设备编号，可选择不同的设备       
        public int channelId = 0; //选择设备的不同通道
        public int filterId = 0;
        public bool IsConnectDevice = false;   //用于表示是否成功连接一个设备


        public retstate connectToDevice(int DeviceSelect, string RequestID, string ResponseID, BaudRate baudRate)
        {

            retstate ret = retstate.OK;

            if (!IsConnectDevice)
            {
                passThru.LoadLibrary(availableJ2534Devices[DeviceSelect]);
                J2534ErrStatus = passThru.Open(ref deviceId);

                if ((J2534ErrStatus == J2534Err.STATUS_NOERROR))
                {
                    // OpenADevice = connectCAN();
                    IsConnectDevice = ConnectIso15765(RequestID, ResponseID, baudRate);
                    if (!IsConnectDevice)
                    {
                        ret = retstate.NOT_OK;
                    }
                }
                else
                {
                    ret = retstate.NOT_OK;
                }
            }

            return ret;
        }

        public bool ConnectIso15765(string RequestID, string ResponseID, BaudRate baudRate)
        {
            List<byte> value = new List<byte>();

            J2534ErrStatus = passThru.Connect(deviceId, ProtocolID.ISO15765, ConnectFlag.NONE, baudRate, ref channelId);
            if (J2534Err.STATUS_NOERROR != J2534ErrStatus)
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
            if (IsConnectDevice)
            {
                passThru.StopMsgFilter(channelId, filterId);
                passThru.Disconnect(channelId);
                passThru.Close(deviceId);
                passThru.FreeLibrary();
                IsConnectDevice = false;
            }
        }

        public void TxMsg(string msgID, string msgData, Action<string, int, string, string> Callback)
        {
            string strDatebyte = "";
            int ID = Convert.ToInt32(msgID.Trim(), 16);
            string[] dataStr = msgData.Trim().Split(' ');
            int[] byteStr = new int[dataStr.Length + 4];
            byteStr[0] = 0;
            byteStr[1] = 0;
            byteStr[2] = (byte)((int)ID / 256);
            byteStr[3] = (byte)((int)ID % 256);

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
            J2534ErrStatus = passThru.WriteMsgs(channelId, ref TxMsg, ref numMsgs, 50);

            //Console.Write("Debug"); // Debug

            /* Update UI */
            Callback(msgID, TxMsg.Data.Length - 4, strDatebyte, "Tx");

        }

        public void RxMsg(TextBox ResponseID, Action<string, int, string, string> Callback, Action<byte[]> CallDllCallback)
        {
            int numMsgs = 100;
            int msgCount = 0;
            string strDataID = "";
            string strDatebyte = "";
            List<PassThruMsg> rxMsgs = new List<PassThruMsg>();
            J2534Err status = J2534Err.STATUS_NOERROR;

            /* if not connect device, return */
            if (!IsConnectDevice)
                return;

            numMsgs = 10;//test line
            status = passThru.ReadMsgs(channelId, ref rxMsgs, ref numMsgs, 0);  /////////////////////
            if (status == J2534Err.STATUS_NOERROR)    //maybe no use
            {
                msgCount = rxMsgs.Count;
                for (int k = 0; k < msgCount; k++)
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
                            {
                                strDatebyte += string.Format("{0:X2}", rxMsgs[k].Data[i + 4]) + " ";
                            }    
                            /*Update UI*/
                            Callback(strDataID.TrimStart('0'), rxMsgs[k].Data.Length - 4, strDatebyte, "Rx");
                            /*calldll caculate  key by receive seed*/
                            CallDllCallback(rxMsgs[k].Data); 
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}
