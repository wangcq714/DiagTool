using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

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

        /* Parse script and Tx */
        private void parseScript(string[] cmdarry, int time)
        {
            bool preCmdIsSleep = false;  // Represent previous cmd is or not Sleep(n)
            int indexCmd = 0;
            int numCmd = cmdarry.Length;

            foreach (string cmd in cmdarry)
            {
                if (!Regex.IsMatch(cmd, @"Sleep\([0-9]+\)"))
                {
                    /* If previous cmd is not Sleep(n), then sleep by default time interval */
                    if (!preCmdIsSleep)
                    {
                        Thread.Sleep(time);
                    }
                    if (Regex.IsMatch(cmd, "27 [0-9]{2}"))
                    {
                        if (indexCmd < numCmd)
                        {
                            if (Regex.IsMatch(cmdarry[indexCmd + 1], "27 [0-9]{2}=67 [0-9]{2}"))
                            {
                                indexCmd++;
                                Global.diagUsercontrol.isCallKeyToSeedDll = true;
                                Global.diagUsercontrol.subFunctionSeedkey = (byte)Convert.ToInt32(cmdarry[indexCmd + 1].Substring(3, 2), 16);
                            }
                            
                        }
                    }
                    
                    Global.passThruWrapper.TxMsg(Global.diagUsercontrol.ReqIDTextBox_Text, cmd.Trim(), Global.diagUsercontrol.TxRxMsgUpdateDiagDataGridViewCallback);
                }
                else
                {
                    Thread.Sleep(time);
                    preCmdIsSleep = true;
                }
                indexCmd++;
            }
        }

        /* Run script thread */
        private void RunScript(object timeInterval)
        {
            int time = Convert.ToInt32(timeInterval.ToString());

            if(this.ScriptTextBox.Text != "")
            {
                string[] cmdarry = this.ScriptTextBox.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                while(this.LoopCheckBox.Checked)
                {
                    parseScript(cmdarry, time);
                }             
            }
            
        }

        /* Loop script thread */
        private void LoopScript(object timeInterval)
        {
            int time = Convert.ToInt32(timeInterval.ToString());

            if (this.ScriptTextBox.Text != "")
            {
                string[] cmdarry = this.ScriptTextBox.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                while (Convert.ToInt32(this.LoopTextBox.Text) > 0)
                {
                    /* Loop count subtract 1 and update LoopTextBox.Text */
                    this.LoopTextBox.Text = (Convert.ToInt32(this.LoopTextBox.Text) - 1).ToString();

                    parseScript(cmdarry, time);
                }

            }

        }

        /* Click Run button */
        private void RunButton_Click(object sender, EventArgs e)
        {
            /* if not connect device, return */
            if (!Global.passThruWrapper.IsConnectDevice)
                return;

            /* Build a new thread to run script */
            Thread childThread = new Thread(RunScript);
            childThread.Start(Global.setupForm.ScriptTimeIntervalTextBox_Text);
        }

        /* Click Loop button */
        private void LoopButton_Click(object sender, EventArgs e)
        {
            /* if not connect device, return */
            if (!Global.passThruWrapper.IsConnectDevice)
                return;

            /* Build a new thread to run loop script */
            Thread childThread = new Thread(LoopScript);
            childThread.Start(Global.setupForm.ScriptTimeIntervalTextBox_Text);
        }
    }
}
