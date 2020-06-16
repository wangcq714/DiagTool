using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagTool_Luffy
{
    public partial class MainWindow
    {
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

        private delegate void DoUpdateDTCDisplayTextBoxTextText(string text);
        /* This method demonstrates a pattern for making thread-safe
         * calls on a Windows Forms control. 
         * If the calling thread is different from the thread that
         * created the TextBox control, this method creates a
         * SetTextCallback and calls itself asynchronously using the
         * Invoke method.
         * If the calling thread is the same as the thread that created
         * the TextBox control, the Text property is set directly. */
        private void UpdateDTCDisplayTextBoxText(string text)
        {
            /* InvokeRequired required compares the thread ID of the
             * calling thread to the thread ID of the creating thread.
             * If these threads are different, it returns true. */
            if (this.DTCDisplayTextBox.InvokeRequired)
            {
                DoUpdateDTCDisplayTextBoxTextText UpdateText = new DoUpdateDTCDisplayTextBoxTextText(UpdateDTCDisplayTextBoxText);
                this.Invoke(UpdateText, new object[] { text });
            }
            else
            {
                this.DTCDisplayTextBox.Text = text;

            }
        }
    }
}
