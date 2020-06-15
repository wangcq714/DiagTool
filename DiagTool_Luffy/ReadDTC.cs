using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagTool_Luffy
{
    public partial class MainWindow
    {
        /* Run when ReadDTCComboBox_SelectedIndexChanged */
        private void ReadDTCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ReadDTCComboBox.Text.Substring(3, 2) == "04" || this.ReadDTCComboBox.Text.Substring(3, 2) == "06")
            {
                this.DTCHighByteTextBox.Enabled = true;
                this.DTCLowByteTextBox.Enabled = true;
                this.DTCFaultTypeTextBox.Enabled = true;
                this.RecordNumberTextBox.Enabled = true;
            }
            else
            {
                this.DTCHighByteTextBox.Enabled = false;
                this.DTCLowByteTextBox.Enabled = false;
                this.DTCFaultTypeTextBox.Enabled = false;
                this.RecordNumberTextBox.Enabled = false;
            }

            if (this.ReadDTCComboBox.Text.Substring(3, 2) == "01" || this.ReadDTCComboBox.Text.Substring(3, 2) == "02")
            {
                this.TestFailedCheckBox.Enabled = true;
                this.TestFailedThisMonitoringCycleCheckBox.Enabled = true;
                this.PendingDTCCheckBox.Enabled = true;
                this.ConfirmedDTCCheckBox.Enabled = true;
                this.TestNotCompletedSinceLastClearCheckBox.Enabled = true;
                this.TestFailedSinceLastClearCheckBox.Enabled = true;
                this.TestNotCompletedThisMonitoringCycleCheckBox.Enabled = true;
                this.WarningIndicatorRequestedCheckBox.Enabled = true;
            }
            else
            {
                this.TestFailedCheckBox.Enabled = false;
                this.TestFailedThisMonitoringCycleCheckBox.Enabled = false;
                this.PendingDTCCheckBox.Enabled = false;
                this.ConfirmedDTCCheckBox.Enabled = false;
                this.TestNotCompletedSinceLastClearCheckBox.Enabled = false;
                this.TestFailedSinceLastClearCheckBox.Enabled = false;
                this.TestNotCompletedThisMonitoringCycleCheckBox.Enabled = false;
                this.WarningIndicatorRequestedCheckBox.Enabled = false;
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

        /* Update DTC display list */
        public void UpdateDTCDisplayTextBox_Text(byte[] Data)
        {
            string strDTC = "";
            int NumDTC = 0;

            NumDTC = (Data.Length - 7) / 4;
            for (int i = 0; i < NumDTC; i++)
            {
                strDTC += Data[i * 4 + 7].ToString("X2");
                strDTC += Data[i * 4 + 8].ToString("X2");
                strDTC += Data[i * 4 + 9].ToString("X2") + " ";
                strDTC += Data[i * 4 + 10].ToString("X2") + "\r\n";
            }

            UpdateDTCDisplayTextBoxText(strDTC);
        }

        /* Get DTC mask for 19 01 and 19 02 */
        private void GetMask(ref byte mask)
        {
            if (this.TestFailedCheckBox.Checked)
            {
                mask |= (1 << 0);
            }
            if (this.TestFailedThisMonitoringCycleCheckBox.Checked)
            {
                mask |= (1 << 1);
            }
            if (this.PendingDTCCheckBox.Checked)
            {
                mask |= (1 << 2);
            }
            if (this.ConfirmedDTCCheckBox.Checked)
            {
                mask |= (1 << 3);
            }
            if (this.TestNotCompletedSinceLastClearCheckBox.Checked)
            {
                mask |= (1 << 4);
            }
            if (this.TestFailedSinceLastClearCheckBox.Checked)
            {
                mask |= (1 << 5);
            }
            if (this.TestNotCompletedThisMonitoringCycleCheckBox.Checked)
            {
                mask |= (1 << 6);
            }
            if (this.WarningIndicatorRequestedCheckBox.Checked)
            {
                mask |= (1 << 7);
            }
        }

        /* Check DTC highbyte,lowbyte,faulttype,record number legality for 19 04 and 19 05 */
        private bool CheckDTCInputLegality()
        {
            bool retValue = true;

            if (this.DTCHighByteTextBox.Text.Length != 2)
            {
                retValue = false;
                MessageBox.Show("Please input legal DTC highbyte value");
            }
            if (this.DTCLowByteTextBox.Text.Length != 2)
            {
                retValue = false;
                MessageBox.Show("Please input legal DTC lowbyte value");
            }
            if (this.DTCFaultTypeTextBox.Text.Length != 2)
            {
                retValue = false;
                MessageBox.Show("Please input legal DTC fault type value");
            }
            if (this.RecordNumberTextBox.Text.Length != 2)
            {
                retValue = false;
                MessageBox.Show("Please input legal DTC record number value");
            }

            return retValue;
        }

        /* Get message data for Tx function */
        private void GetMsgData(ref string msgData)
        {
            byte mask = 0;

            if ((this.ReadDTCComboBox.Text.Substring(3, 2) == "01") || this.ReadDTCComboBox.Text.Substring(3, 2) == "02")
            {
                GetMask(ref mask);
                msgData = this.ReadDTCComboBox.Text.Substring(0, 5) + " " + Convert.ToString(mask, 16).ToUpper();

            }
            else if ((this.ReadDTCComboBox.Text.Substring(3, 2) == "04") || (this.ReadDTCComboBox.Text.Substring(3, 2) == "06"))
            {
                if (CheckDTCInputLegality())
                {
                    msgData = this.ReadDTCComboBox.Text.Substring(0, 5) + " " + this.DTCHighByteTextBox.Text.ToUpper() + " " + this.DTCLowByteTextBox.Text.ToUpper() + " " +
                          this.DTCFaultTypeTextBox.Text.ToUpper() + " " + this.RecordNumberTextBox.Text.ToUpper();
                }
            }
            else if (this.ReadDTCComboBox.Text.Substring(3, 2) == "0A")
            {
                msgData = this.ReadDTCComboBox.Text.Substring(0, 5);
            }
        }

        /* Clear DTCList when Tx 19 02 XX or 19 0A*/
        private void ClearDTCDisplay()
        {
            if ((this.ReadDTCComboBox.Text.Substring(3, 2) == "02") || (this.ReadDTCComboBox.Text.Substring(3, 2) == "0A"))
            {
                /* Clear DTCList display*/
                UpdateDTCDisplayTextBoxText(""); ;
            }
        }

        private void ReadDTC()
        {
            string msgData = "";

            if (!bDeviceConnectState)
                return;

            GetMsgData(ref msgData);
            ClearDTCDisplay();
            if (msgData != "")
            {
                passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(msgData), TxRxMsgUpdateUIDataCallback);
            }
        }


        private void ClearDTC()
        {
            string msgData = "14 FF FF FF";

            if (!bDeviceConnectState)
                return;

            UpdateDTCDisplayTextBoxText("");

            passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(msgData), TxRxMsgUpdateUIDataCallback);
        }
    }
}
