﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace DiagTool_Luffy
{
    public partial class MainWindow
    {
        int ScriptTimeCount = 0;
    
        private void ParseScript(string ScriptText, int Time)
        {
            string PreCmd = "";
            string[] CmdDataArray = ScriptText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string CmdData in CmdDataArray)
            {
                CmdPushQueue(CmdDataCleaning(CmdData), PreCmd, Time);
                PreCmd = CmdDataCleaning(CmdData);
            }
        }

        private string CmdDataCleaning(string CmdData)
        {
            return string.Join(" ", CmdData.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
        }

        private void CmdPushQueue(string Cmd, string PreCmd, int Time)
        {
            if ("" != Cmd)
            {
                if ((!Regex.IsMatch(Cmd, @"Sleep\([0-9]+\)"))
                 && (!Regex.IsMatch(PreCmd, @"Sleep\([0-9]+\)")))
                {
                    string SleepCmd = "Sleep(" + Convert.ToString(Time) + ")";
                    if(!ScriptCmdQueue.FullFlag)
                    {
                        ScriptCmdQueue.PushQueue(SleepCmd);
                    }
                    
                }

                if (!ScriptCmdQueue.FullFlag)
                {
                    ScriptCmdQueue.PushQueue(Cmd);
                }
            }
        }

        public void ScriptRunmmTimerCBFunc(uint uTimerID, uint uMsg, UIntPtr dwUser, UIntPtr dw1, UIntPtr dw2)
        {
            /* Callback from the MMTimer API that fires the Timer event. Note we are in a different thread here */
            if (ScriptTimeCount >= 100)
            {
                ScriptTimeCount -= 100;
            }
            else
            {
                ScriptTimeCount = 0;
            }

            if (0 == ScriptTimeCount)
            {
                ScriptCmdTx();
            }

            
        }

        private void ScriptCmdTx()
        {
            do
            {
                if (!ScriptCmdQueue.EmptyFlag)
                {
                    object CmdObject = new object();
                    ScriptCmdQueue.PopQueue(ref CmdObject);
                    string Cmd = (string)CmdObject;

                    if (Regex.IsMatch(Cmd, @"Sleep\([0-9]+\)"))
                    {
                        ScriptTimeCount = Convert.ToInt32(Cmd.Substring(6, Cmd.Length - 7));
                        break;
                    }
                    else if (Regex.IsMatch(Cmd, @"^27 [0-9]{2}[' ']*=[' ']*67 [0-9]{2}$"))
                    {
                        break;
                    }
                    else
                    {
                        passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(Cmd), TxRxMsgUpdateUIDataCallback);
                    }
                }
                else
                {
                    break;
                }
            } while (true);
        }

        private void RunScript(object ScriptRunTimeInterval)
        {
            do
            {
                if(ScriptCmdQueue.EmptyFlag)
                {
                    ParseScript(this.ScriptTextBox.Text, (int)ScriptRunTimeInterval);
                }                
            } while (this.LoopCheckBox.Checked);
        }
       
        private void LoopScript(object ScriptRunTimeInterval)
        {
            if (this.ScriptTextBox.Text != "")
            {
                while (Convert.ToInt32(this.LoopTextBox.Text) > 0)
                {
                    if (ScriptCmdQueue.EmptyFlag)
                    {
                        ParseScript(this.ScriptTextBox.Text, (int)ScriptRunTimeInterval);
                        UpdateLoopTextBoxText((Convert.ToInt32(this.LoopTextBox.Text) - 1).ToString());
                    }                    
                }
            }
        }
    }
}
