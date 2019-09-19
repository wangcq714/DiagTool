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
    public partial class ScriptForm : Form
    {
        public ScriptForm()
        {
            InitializeComponent();
        }

        /*Redefine FormClosing action*/
        private void ScriptFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void RunScript()
        {
            string[] cmdarry = this.ScriptTextBox.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string cmd in cmdarry)
            {
                Global.passThruWrapper.TxMsg(Global.diagUsercontrol.ReqIDTextBox_Text, cmd.Trim(), Global.diagUsercontrol.TxRxMsgUpdateDiagDataGridViewCallback);
                Thread.Sleep(100);
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Thread childThread = new Thread(RunScript);
            childThread.Start();

        }
    }
}
