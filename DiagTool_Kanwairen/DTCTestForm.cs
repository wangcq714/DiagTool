using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DiagTool_Kanwairen
{
    public partial class DTCTestForm : Form
    {
        public DTCTestForm()
        {
            InitializeComponent();
        }

        /*Redefine FormClosing action*/
        private void DTCTestFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void ReadDTC()
        {
            string dataStr = "";
            string DTCStr = "";
            int NumDTC = 0;
            int i = 0;

            Global.passThruWrapper.TxMsg(Global.diagUsercontrol.ReqIDTextBox_Text, this.DTCTestComboBox.Text.Trim(), Global.diagUsercontrol.TxRxMsgUpdateDiagDataGridViewCallback);
            Thread.Sleep(1000);
            dataStr = Global.diagUsercontrol.RxDataTextBox_Text;
            dataStr = dataStr.Replace(" ", "");
            if (dataStr != "")
            {
                if(dataStr.Substring(0, 2) == "59")
                {
                    NumDTC = (dataStr.Length - 6) / 8;
                    for(i=0; i<NumDTC; i++)
                    {
                        DTCStr += dataStr.Substring(6 + 8 * i, 8);
                        DTCStr += "\r\n";
                    }
                    this.DTCTestTextBox.Text = DTCStr;
                }
            }
        }

        private void ReadDTCButton_Click(object sender, EventArgs e)
        {
            Thread childThread = new Thread(ReadDTC);
            childThread.Start();           
        }
    }
}
