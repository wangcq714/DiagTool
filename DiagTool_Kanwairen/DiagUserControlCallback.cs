using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using J2534DotNet;

namespace DiagTool_Kanwairen
{
    public partial class DiagUserControl
    {
        /*DeviceConnectInit init callback*/
        public void DeviceConnectInitCallback(List<J2534Device> availableJ2534Devices)
        {
            foreach (J2534Device device in availableJ2534Devices)
            {
                this.DeviceSelectComboBox.Items.Add(device.Name);
            }
            this.DeviceSelectComboBox.SelectedIndex = 0;
        }

        /*TxRxMsg callback*/
        public void TxRxMsgUpdateDiagDataGridViewCallback(string strDataID, int strDateLen, string strDatebyte, string type)
        {
            DataRow canRow;

            if (this.FilterAppMsgCheckBox.Checked)
            {
                if (!(strDataID == this.ReqIDTextBox.Text.Trim() || strDataID == this.ResIDTextBox.Text.Trim()))
                {
                    return;
                }
            }

            canRow = Global.diagUsercontrol.DTCANRxScroll.NewRow();
            canRow[0] = Global.diagUsercontrol.DTCANRxScroll.Rows.Count + 1;
            canRow[1] = type;
            canRow[2] = "0x" + strDataID.TrimStart('0');
            canRow[3] = strDateLen;
            canRow[4] = strDatebyte;
            canRow[5] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");//string.Format("{0:G}", System.DateTime.Now);

            //canRow[1] = ((float)(rxMsgs[k].Timestamp - INIT_Timestamp) / 1000).ToString("F2");//float 保留两位小数？
            Global.diagUsercontrol.DTCANRxScroll.Rows.Add(canRow);
            Global.diagUsercontrol.DTCANRxScroll.AcceptChanges();
            //INIT_Timestamp = rxMsgs[k].Timestamp;
            this.TxRxDataGridView.FirstDisplayedScrollingRowIndex = this.TxRxDataGridView.RowCount - 1;

            /* Regardless of Tx or Rx, clear RxDataTextBox. */
            RxDataTextBox.Text = "";
            /* if Recieve Msg， update RxDataTextBox. */
            if (type == "Rx")
            {
                RxDataTextBox.Text = strDatebyte;
            }
        }

        /*TxRxMsg callback*/
        public void TxRxMsgNotUpdateDiagDataGridViewCallback(string strDataID, int strDateLen, string strDatebyte, string type)
        {
            /* Do nothing */
        }

        /*TxRxMsg callback*/
        public void TxRxMsgCallDllCallback(byte[] Data)
        {
            string dataStr = "";
            if (Data[4] == 67)
            {
                dataStr = Global.diag.Security_DLL(Data, ImportForm.DllPathname);
                Global.passThruWrapper.TxMsg(ReqIDTextBox.Text, dataStr, TxRxMsgUpdateDiagDataGridViewCallback);
            }
        }
    }
}
