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

        /* This delegate enables asynchronous calls for setting
         * the text property on a TextBox control.*/
        private delegate void DoFirstDisplayedScrollingRowIndex(int index);
        /* This method demonstrates a pattern for making thread-safe
         * calls on a Windows Forms control. 
         * If the calling thread is different from the thread that
         * created the TextBox control, this method creates a
         * SetTextCallback and calls itself asynchronously using the
         * Invoke method.
         * If the calling thread is the same as the thread that created
         * the TextBox control, the Text property is set directly. */
        private void UpdateFirstDisplayedScrollingRowIndex(int index)
        {
            /* InvokeRequired required compares the thread ID of the
             * calling thread to the thread ID of the creating thread.
             * If these threads are different, it returns true. */
            if (this.TxRxDataGridView.InvokeRequired)
            {
                DoFirstDisplayedScrollingRowIndex UpdateIndex = new DoFirstDisplayedScrollingRowIndex(UpdateFirstDisplayedScrollingRowIndex);
                this.Invoke(UpdateIndex, new object[] { index });
            }
            else
            {
                Global.diagUsercontrol.DTCANRxScroll.AcceptChanges();
                this.TxRxDataGridView.FirstDisplayedScrollingRowIndex = this.TxRxDataGridView.RowCount - 1;

            }
        }

        private delegate void DoRxDataTextBoxText(string text);
        /* This method demonstrates a pattern for making thread-safe
         * calls on a Windows Forms control. 
         * If the calling thread is different from the thread that
         * created the TextBox control, this method creates a
         * SetTextCallback and calls itself asynchronously using the
         * Invoke method.
         * If the calling thread is the same as the thread that created
         * the TextBox control, the Text property is set directly. */
        private void UpdateRxDataTextBoxText(string text)
        {
            /* InvokeRequired required compares the thread ID of the
             * calling thread to the thread ID of the creating thread.
             * If these threads are different, it returns true. */
            if (this.RxDataTextBox.InvokeRequired)
            {
                DoRxDataTextBoxText UpdateText = new DoRxDataTextBoxText(UpdateRxDataTextBoxText);
                this.Invoke(UpdateText, new object[] { text });
            }
            else
            {
                RxDataTextBox.Text = text;

            }
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

            UpdateFirstDisplayedScrollingRowIndex(this.TxRxDataGridView.RowCount - 1);

            /* Regardless of Tx or Rx, clear RxDataTextBox. */
            UpdateRxDataTextBoxText("");
            /* if Recieve Msg， update RxDataTextBox. */
            if (type == "Rx")
            {
                UpdateRxDataTextBoxText(strDatebyte);
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

            /* if "isCallKeyToSeedDll==true", that need to do security verification automaticaly */
            if (isCallKeyToSeedDll)
            {              
                if (Data[4] == 0x67 && Data[5] == subFunctionSeedkey)
                {
                    dataStr = Global.diag.Security_DLL(Data, ImportForm.DllPathname);
                    Global.passThruWrapper.TxMsg(ReqIDTextBox.Text, dataStr, TxRxMsgUpdateDiagDataGridViewCallback);
                }

                isCallKeyToSeedDll = false;
            }          
        }

        /* Synchronous data for other moudle when rx related data */
        public void TxRxMsgCallSyncCallback(byte[] Data)
        {
            if (Data[4] == 0x59 && Global.readDTCForm.updateDTCDisplay)
            {
                Global.readDTCForm.UpdateDTCDisplayTextBox_Text(Data);
            }
        }
    }
}
