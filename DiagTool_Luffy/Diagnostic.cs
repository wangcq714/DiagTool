using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagTool_Luffy
{
    public partial class MainWindow
    {
        private SecurityAlgorithm securityAlgorithm = new SecurityAlgorithm();
        private static DiagDataGridViewRowData[] DiagDataGridViewRowDatas = new DiagDataGridViewRowData[64];
        private static GenericQueue DiagDataGridViewRowDataQueue = new GenericQueue(DiagDataGridViewRowDatas);


        private void DataGridViewRowDataPushQueue(string msgIdStr, string dataLenStr, string dataStr, string typeStr, string timeStampStr)
        {
            DiagDataGridViewRowData RowData = new DiagDataGridViewRowData();
            RowData.type = typeStr;
            RowData.id = msgIdStr;
            RowData.len = dataLenStr;
            RowData.data = dataStr;
            RowData.ts = timeStampStr;
            if (!DiagDataGridViewRowDataQueue.FullFlag)
            {
                DiagDataGridViewRowDataQueue.PushQueue(RowData);
            }
        }

        private string Diagnostic_PackSendMsg(string Server, string SubFunction, string Data)
        {
            return Server.Trim() + " " + SubFunction.Trim() + " " + Data.Trim();
        }

        public void Diagnostic_Send(string msgData)
        {
            passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(msgData), TxRxMsgUpdateUIDataCallback);
        }

        public void Diagnostic_SendNoUpdateUI(string msgData)
        {
            passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(msgData), TxRxMsgNotUpdateUIDataCallback);
        }

        public void Diagnostic_Rreceive()
        {
            passThruWrapper.RxMsg(TxRxMsgUpdateUIDataCallback, SecurityAccessCallDllCallback, SyncUIComponentCallback);
        }

        private string Diagnostic_SecurityAccessSeedToKey(string Data)
        {
            return securityAlgorithm.SecurityAccessSeedToKey(Data, Global.SecurityAccessDllPathname);
        }


    }
}
