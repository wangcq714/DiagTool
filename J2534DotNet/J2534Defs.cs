using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace J2534DotNet
{
    public class PassThruMsg
    {
        public ProtocolID ProtocolID { get; set; }
        public RxStatus RxStatus { get; set; }
        public TxFlag TxFlags { get; set; }
        public int Timestamp { get; set; }
        public int ExtraDataIndex { get; set; }
        public byte[] Data { get; set; }

        public PassThruMsg() { }
        public PassThruMsg(ProtocolID myProtocolId, TxFlag myTxFlag, byte[] myByteArray)
        {
            ProtocolID = myProtocolId;
            TxFlags = myTxFlag;
            Data = myByteArray;
        }
    }

    public enum ProtocolID
    {
        J1850VPW = 0x01,
        J1850PWM = 0x02,
        ISO9141 = 0x03,
        ISO14230 = 0x04,
        CAN = 0x05,
        ISO15765 = 0x06,
        SCI_A_ENGINE = 0x07,
        SCI_A_TRANS = 0x08,
        SCI_B_ENGINE = 0x09,
        SCI_B_TRANS = 0x0A
    }

    [Flags]
    public enum RxStatus
    {
        NONE=0x00000000,
        TX_MSG_TYPE=0x00000001,
        START_OF_MESSAGE=0x00000002,
        RX_BREAK=0x00000004,
        TX_INDICATION=0x00000008,
        ISO15765_PADDING_ERROR=0x00000010,
        ISO15765_ADDR_TYPE=0x00000080,
        CAN_29BIT_ID=0x00000100
    }

    [Flags]
    public enum ConnectFlag
    {
        NONE=0x000,
        ISO9141_K_LINE_ONLY = 0x1000,
        CAN_ID_BOTH = 0x0800,
        ISO9141_NO_CHECKSUM = 0x0200,
        CAN_29BIT_ID = 0x0100
    }

    [Flags]
    public enum TxFlag
    {
        NONE=0x00000000,
        SCI_TX_VOLTAGE=0x00800000,
        SCI_MODE=0x00400000,
        WAIT_P3_MIN_ONLY=0x00000200,
        CAN_29BIT_ID=0x00000100,
        ISO15765_ADDR_TYPE=0x00000080,
        ISO15765_FRAME_PAD=0x00000040
    }

    [Flags]
    public enum BaudRate
    {
        ISO15765=500000,
        ISO15765_125000=125000,
        ISO15765_250000=250000,
        ISO15765_500000=500000,
        CAN=500000,
        CAN_125000=125000,
        CAN_250000=250000,
        CAN_500000=500000,
    }

    public enum PinNumber
    {
        AUX=0,
        PIN_6=6,
        PIN_9=9,
        PIN_11=11,
        PIN_12=12,
        PIN_13=13,
        PIN_14=14,
        PIN_15=15
    }

    public enum FilterType
    {
        PASS_FILTER=0x01,
        BLOCK_FILTER=0x02,
        FLOW_CONTROL_FILTER=0x03
    }

    enum Ioctl
    {
        GET_CONFIG=0x01,
        SET_CONFIG=0x02,
        READ_VBATT=0x03,
        FIVE_BAUD_INIT=0x04,
        FAST_INIT=0x05,
        CLEAR_TX_BUFFER=0x07,
        CLEAR_RX_BUFFER=0x08,
        CLEAR_PERIODIC_MSGS=0x09,
        CLEAR_MSG_FILTERS=0x0A,
        CLEAR_FUNCT_MSG_LOOKUP_TABLE=0x0B,
        ADD_TO_FUNCT_MSG_LOOKUP_TABLE=0x0C,
        DELETE_FROM_FUNCT_MSG_LOOKUP_TABLE=0x0D,
        READ_PRO_VOLTAGE=0x0E
    }
   
    public enum J2534Err
    {
        STATUS_NOERROR = 0x00,
        ERR_NOT_SUPPORTED = 0x01,
        ERR_INVALID_CHANNEL_ID = 0x02,
        ERR_INVALID_PROTOCOL_ID = 0x03,
        ERR_NULL_PARAMETER = 0x04,
        ERR_INVALID_FLAGS = 0x06,
        ERR_FAILED = 0x07,
        ERR_DEVICE_NOT_CONNECTED = 0x08,
        ERR_TIMEOUT = 0x09,
        ERR_INVALID_MSG = 0x0A,
        ERR_INVALID_TIME_INTERVAL = 0x0B,
        ERR_EXCEEDED_LIMIT = 0x0C,
        ERR_INVALID_MSG_ID = 0x0D,
        ERR_DEVICE_IN_USE = 0x0E,
        ERR_INVALID_IOCTL_ID = 0x0F,
        ERR_BUFFER_EMPTY = 0x10,
        ERR_BUFFER_FULL = 0x11,
        ERR_BUFFER_OVERFLOW = 0x12,
        ERR_PIN_INVALID = 0x13,
        ERR_CHANNEL_IN_USE = 0x14,
        ERR_MSG_PROTOCOL_ID = 0x15,
        ERR_INVALID_FILTER_ID = 0x16,
        ERR_NO_FLOW_CONTROL = 0x17,
        ERR_NOT_UNIQUE = 0x18,
        ERR_INVALID_BAUDRATE = 0x19,
        ERR_INVALID_DEVICE_ID = 0x1A
    }

    public enum ConfigPara
    {
        DATA_RATE=0x01,
        ISO15765_BS=0x1E,
        ISO15765_STMIN=0x1F,
        BS_TX=0x22,
        STMIN_TX=0x23,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SConfig
    {
        public int Parameter;
        public int Value;
    }

    //leon added 0105
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SConfig_List
    {
        // [MarshalAs(UnmanagedType.ByValArray)]
        public int NumOfParams;
        [MarshalAs(UnmanagedType.ByValArray)]//SizeConst = 1
        public IntPtr[] ConfigPtr;
        // public SConfig[] ConfigPtr;  //r=new SConfig[3] 
    }


}
