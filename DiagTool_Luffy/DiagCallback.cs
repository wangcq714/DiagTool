using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using J2534DotNet;

namespace DiagTool_Luffy
{
    public partial class MainWindow
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
                this.DTCANRxScroll.AcceptChanges();
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
                this.RxDataTextBox.Text = text;
                this.RxDataTextBox.Refresh();
            }
            
        }

        /* This delegate enables asynchronous calls for setting
         * the text property on a TextBox control.*/
        private delegate void DoTxRxMsgUpdateDiagDataGridView(string type, string id, string len, string data, string ts);
        /* This method demonstrates a pattern for making thread-safe
         * calls on a Windows Forms control. 
         * If the calling thread is different from the thread that
         * created the TextBox control, this method creates a
         * SetTextCallback and calls itself asynchronously using the
         * Invoke method.
         * If the calling thread is the same as the thread that created
         * the TextBox control, the Text property is set directly. */
        private void UpdateTxRxMsgUpdateDiagDataGridView(string type, string id, string len, string data, string ts)
        {
            lock (DiagDataGridViewAddRowLocker)
            {
                /* InvokeRequired required compares the thread ID of the
                 * calling thread to the thread ID of the creating thread.
                 * If these threads are different, it returns true. */
                if (this.TxRxDataGridView.InvokeRequired)
                {
                    DoTxRxMsgUpdateDiagDataGridView UpdateData = new DoTxRxMsgUpdateDiagDataGridView(UpdateTxRxMsgUpdateDiagDataGridView);
                    this.Invoke(UpdateData, new object[] { type, id, len, data, ts });
                }
                else
                {
                    int index = this.TxRxDataGridView.Rows.Add();

                    this.TxRxDataGridView.Rows[index].Cells[0].Value = index;
                    this.TxRxDataGridView.Rows[index].Cells[1].Value = type;
                    this.TxRxDataGridView.Rows[index].Cells[2].Value = id;
                    this.TxRxDataGridView.Rows[index].Cells[3].Value = len;
                    this.TxRxDataGridView.Rows[index].Cells[4].Value = data;
                    this.TxRxDataGridView.Rows[index].Cells[5].Value = ts;
                    this.TxRxDataGridView.FirstDisplayedScrollingRowIndex = this.TxRxDataGridView.RowCount - 1;

                    this.TxRxDataGridView.Refresh();
                }
            }
        }

        private delegate void DoLoopTextBoxText(string text);
        /* This method demonstrates a pattern for making thread-safe
         * calls on a Windows Forms control. 
         * If the calling thread is different from the thread that
         * created the TextBox control, this method creates a
         * SetTextCallback and calls itself asynchronously using the
         * Invoke method.
         * If the calling thread is the same as the thread that created
         * the TextBox control, the Text property is set directly. */
        private void UpdateLoopTextBoxText(string text)
        {
            /* InvokeRequired required compares the thread ID of the
             * calling thread to the thread ID of the creating thread.
             * If these threads are different, it returns true. */
            if (this.LoopTextBox.InvokeRequired)
            {
                DoLoopTextBoxText UpdateText = new DoLoopTextBoxText(UpdateLoopTextBoxText);
                this.Invoke(UpdateText, new object[] { text });
            }
            else
            {
                this.LoopTextBox.Text = text;
                this.LoopTextBox.Refresh();
            }
        }

        /*TxRxMsg callback*/
        public void TxRxMsgUpdateUIDataCallback(string msgIdStr, string dataLenStr, string dataStr, string typeStr, string timeStampStr)
        {
            DataGridViewRowDataPushQueue(msgIdStr, dataLenStr, dataStr, typeStr, timeStampStr);
        }

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

        /*TxRxMsg callback*/
        public void TxRxMsgNotUpdateUIDataCallback(string strDataID, string strDateLen, string strDatebyte, string type, string timeStampStr)
        {
            /* Do nothing */
        }

        /*TxRxMsg callback*/
        public void TxRxMsgCallDllCallback(byte[] Data)
        {
            string dataStr = "";

            if (Data[4] == 0x67 && Data[5] == SecuritAccessReqSeedSubFunction)
            {
                SecuritAccessReqSeedSubFunction = 0;
                dataStr = securityAlgorithm.Security_DLL(Data, Global.SecurityAccessDllPathname);
                if(dataStr != "")
                {
                    SecuritAccessKey = dataStr.Substring(6);
                } 
                else
                {
                    SecuritAccessKey = "";
                    isCallKeyToSeedDll = false;
                    return;
                }              
            }

            /* if "isCallKeyToSeedDll==true", that need to do security verification automaticaly */
            if (isCallKeyToSeedDll)
            {              
                passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(dataStr), TxRxMsgUpdateUIDataCallback);
                isCallKeyToSeedDll = false;
            }
        }

        /* Synchronous data for other moudle when rx related data */
        public void TxRxMsgCallSyncCallback(byte[] Data)
        {
            if (Data[4] == 0x59)
            {
                UpdateDTCDisplayTextBox_Text(Data);
            }
        }      
    }
}
