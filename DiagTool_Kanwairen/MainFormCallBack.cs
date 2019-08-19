using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

using J2534DotNet;

namespace DiagTool_Kanwairen
{
    partial class MainWindow
    {
        public void SetupInitCallback(List<J2534Device> availableJ2534Devices)
        {
            foreach (J2534Device device in availableJ2534Devices)
            {
                this.DeviceSelectComboBox.Items.Add(device.Name);
            }
            this.DeviceSelectComboBox.SelectedIndex = 0;       
        }

        public void TxRxMsgUpdateDiagDataGridViewCallback(string strDataID, int strDateLen, string strDatebyte, string type)
        {
            DataRow canRow;

            canRow = DTCANRxScroll.NewRow();
            canRow[0] = DTCANRxScroll.Rows.Count + 1;
            canRow[1] = type;
            canRow[2] = "0x" + strDataID.TrimStart('0');
            canRow[3] = strDateLen;
            canRow[4] = strDatebyte;
            canRow[5] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");//string.Format("{0:G}", System.DateTime.Now);

            //canRow[1] = ((float)(rxMsgs[k].Timestamp - INIT_Timestamp) / 1000).ToString("F2");//float 保留两位小数？
            DTCANRxScroll.Rows.Add(canRow);
            DTCANRxScroll.AcceptChanges();
            //INIT_Timestamp = rxMsgs[k].Timestamp;
            this.DiagDataGridView.FirstDisplayedScrollingRowIndex = this.DiagDataGridView.RowCount - 1;

            /* Regardless of Tx or Rx, clear RxDataTextBox. */
            RxDataTextBox.Text = "";
            /* if Recieve Msg， update RxDataTextBox. */
            if (type == "Rx")
            {
                RxDataTextBox.Text = strDatebyte;
            }
        }

        public void TxRxMsgNotUpdateDiagDataGridViewCallback(string strDataID, int strDateLen, string strDatebyte, string type)
        {     
            /* do nothing */
        }

        public void TxRxMsgCallDllCallback(byte[] Data)
        {
            string dataStr = "";
            if (Data[4] == 67)
            {
                dataStr = diag.Security_DLL(Data, ImportForm.DllPathname);
                passThruWrapper.TxMsg(ReqIDTextBox.Text, dataStr, TxRxMsgUpdateDiagDataGridViewCallback);
            }
        }
    }
}
