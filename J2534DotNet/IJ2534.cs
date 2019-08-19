using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace J2534DotNet
{
    public interface IJ2534
    {
        bool LoadLibrary(J2534Device device);
        bool FreeLibrary();
        J2534Err Open(ref int deviceId);
        J2534Err Close(int deviceId);
        J2534Err Connect(int deviceId, ProtocolID protocolId, ConnectFlag flags, BaudRate baudRate, ref int channelId);
        J2534Err Connect(int deviceId, ProtocolID protocolId, ConnectFlag flags, int baudRate, ref int channelId);
        J2534Err Disconnect(int channelId);
        J2534Err ReadMsgs(int channelId, ref List<PassThruMsg> msgs, ref int numMsgs, int timeout);
        J2534Err WriteMsgs(int channelId, ref PassThruMsg msg, ref int numMsgs, int timeout);
        J2534Err StartPeriodicMsg(int channelId, ref PassThruMsg msg, ref int msgId, int timeInterval);
        J2534Err StopPeriodicMsg(int channelId, int msgId);
        J2534Err StartMsgFilter
        (
            int channelid,
            FilterType filterType,
            ref PassThruMsg maskMsg,
            ref PassThruMsg patternMsg,
            ref PassThruMsg flowControlMsg,
            ref int filterId
        );
        J2534Err StopMsgFilter(int channelId, int filterId);
        J2534Err SetProgrammingVoltage(int deviceid, PinNumber pinNumber, int voltage);
        J2534Err ReadVersion(int deviceId, ref string firmwareVersion, ref string dllVersion, ref string apiVersion);
        J2534Err GetLastError(ref string errorDescription);
        J2534Err GetConfig(int channelId, ref List<SConfig> config);
        //J2534Err SetConfig(int channelId, SConfig_List config);
        J2534Err SetConfig(int channelId, int Parameter, int Value);
        J2534Err ReadBatteryVoltage(int deviceId, ref int voltage);
        J2534Err FiveBaudInit(int channelId, byte targetAddress, ref byte keyword1, ref byte keyword2);
        J2534Err FastInit(int channelId, PassThruMsg txMsg, ref PassThruMsg rxMsg);
        J2534Err ClearTxBuffer(int channelId);
        J2534Err ClearRxBuffer(int channelId);
        J2534Err ClearPeriodicMsgs(int channelId);
        J2534Err ClearMsgFilters(int channelId);
        J2534Err ClearFunctMsgLookupTable(int channelId);
        J2534Err AddToFunctMsgLookupTable(int channelId);
        J2534Err DeleteFromFunctMsgLookupTable(int channelId);
    }
}
