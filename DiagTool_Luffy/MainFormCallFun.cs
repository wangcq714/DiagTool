using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using J2534DotNet;
namespace DiagTool_Luffy
{
    public partial class MainWindow
    {
        private void MainWindowInit()
        {
            bool Result = false;
            /* This will result in progrom carsh
            if (!licenseManagement.LicenseCheck())
            {
                this.Close();
                return;
            }
            */
            this.TestPresentComboBox.SelectedIndex = 0;
            this.SecurityAccessComboBox.SelectedIndex = 0;
            this.ReadDTCComboBox.SelectedIndex = 1;
            this.DeviceConnectButton.Image = Image.FromFile("stop.png");

            Result = passThruWrapper.DeviceConnectInit(DeviceConnectInitCallback);
            DiagDataGridViewRowDataQueue.QueueInit();
            ScriptCmdQueue.QueueInit();
            if (!Result)
            {
                MessageBox.Show("-----Please device driver!!!-----");
            }
        }

        public void TxRxDataGridViewAddRow(string num, string type, string id, string len, string data, string ts)
        {
            int index = this.TxRxDataGridView.Rows.Add();

            this.TxRxDataGridView.Rows[index].Cells[0].Value = index;
            this.TxRxDataGridView.Rows[index].Cells[1].Value = type;
            this.TxRxDataGridView.Rows[index].Cells[2].Value = id;
            this.TxRxDataGridView.Rows[index].Cells[3].Value = len;
            this.TxRxDataGridView.Rows[index].Cells[4].Value = data;
            this.TxRxDataGridView.Rows[index].Cells[5].Value = ts;

            this.TxRxDataGridView.Refresh();
        }


        private void ConnectDevice()
        {
            BaudRate baudRate = Global.CANBaudRate;

            if (!bDeviceConnectState)
            {
                bDeviceConnectState = passThruWrapper.ConnectDevice(this.DeviceSelectComboBox.SelectedIndex, this.ReqIDTextBox_Text, this.ResIDTextBox_Text, baudRate);
                if (bDeviceConnectState)
                {
                    DisableFormComponent();
                    StartTimer();
                    this.DeviceConnectButton.Image = Image.FromFile("run.png");
                    bDeviceConnectState = true;
                }
                else
                {
                    MessageBox.Show("Please Connect Device!!!", "Error");
                }
            }
            else
            {
                EnableFormComponent();
                StopTimer();
                passThruWrapper.deviceClose();
                this.DeviceConnectButton.Image = Image.FromFile("stop.png");
                bDeviceConnectState = false;
            }
        }

        private void DisableFormComponent()
        {
            this.ReqIDTextBox.Enabled = false;
            this.ResIDTextBox.Enabled = false;
            this.DeviceSelectComboBox.Enabled = false;
            this.TestPresentComboBox.Enabled = false;
            this.SecurityAccessComboBox.Enabled = false;
        }

        private void EnableFormComponent()
        {
            this.ReqIDTextBox.Enabled = true;
            this.ResIDTextBox.Enabled = true;
            this.DeviceSelectComboBox.Enabled = true;
            this.TestPresentComboBox.Enabled = true;
            this.SecurityAccessComboBox.Enabled = true;
        }

        private void StartTimer()
        {
            this.RxMsgTimer.Start();
            this.TestPresentTimer.Start();
            RxMsgmmTimer.Start(10, true, RxMsgmmTimerCBFunc);
            ScriptRunmmTimer.Start(100, true, ScriptRunmmTimerCBFunc);
        }

        private void StopTimer()
        {
            this.RxMsgTimer.Stop();
            this.TestPresentTimer.Stop();
            RxMsgmmTimer.Stop();
            ScriptRunmmTimer.Stop();
        }

        public void RxMsgmmTimerCBFunc(uint uTimerID, uint uMsg, UIntPtr dwUser, UIntPtr dw1, UIntPtr dw2)
        {
            /* Callback from the MMTimer API that fires the Timer event. Note we are in a different thread here */
            passThruWrapper.RxMsg(TxRxMsgUpdateUIDataCallback, TxRxMsgCallDllCallback, TxRxMsgCallSyncCallback);
            //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff:ffffff"));
        }

        private void RxCANMessage()
        {
            //passThruWrapper.RxMsg(TxRxMsgUpdateDiagDataGridViewCallback, TxRxMsgCallDllCallback, TxRxMsgCallSyncCallback);
            UpdateMainWindowUI();
        }

        private void UpdateMainWindowUI()
        {
            if (!DiagDataGridViewRowDataQueue.EmptyFlag)
            {
                //DiagDataGridViewRowData RowData = new DiagDataGridViewRowData();
                object RowDataObject = new object();
                DiagDataGridViewRowDataQueue.PopQueue(ref RowDataObject);
                DiagDataGridViewRowData RowData = RowDataObject as DiagDataGridViewRowData;
                /* Regardless of Tx or Rx, clear RxDataTextBox. */
                UpdateRxDataTextBoxText("");
                /* if Recieve Msg， update RxDataTextBox. */
                if (RowData.type == "Rx")
                {
                    UpdateRxDataTextBoxText(RowData.data);
                }

                UpdateTxRxMsgUpdateDiagDataGridView(RowData.type, RowData.id, RowData.len, RowData.data, RowData.ts);
            }
        }

        private void TestPresent()
        {
            if (this.ReqIDTextBox.Text.Trim() != "")
            {
                /* if enable TetsPresent */
                if (TestPresentCheckBox.Checked)
                {
                    /* if "3E 80" is sent, don't display in DiagDataGridView */
                    if (TestPresentComboBox.SelectedIndex == 0)
                    {
                        passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(TestPresentComboBox.Text), TxRxMsgNotUpdateUIDataCallback);
                    }
                    /* if "3E 00" is sent, display in DiagDataGridView */
                    else if (TestPresentComboBox.SelectedIndex == 1)
                    {
                        passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(TestPresentComboBox.Text), TxRxMsgUpdateUIDataCallback);
                    }
            }
            }
            
        }

        private void TxCANMessage()
        {
            if (!bDeviceConnectState)
                return;

            if ((this.ReqIDTextBox.Text.Trim() != "") && (this.TxDataTextBox.Text.Trim() != ""))
            {
                passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(this.TxDataTextBox.Text), TxRxMsgUpdateUIDataCallback);
            }         
        }

        private UInt32 GetReqID()
        {
            return Convert.ToUInt32(this.ReqIDTextBox.Text.Trim(' ').ToUpper(), 16);
        }

        private byte[] ConvertTxDataToByte(string TxDataStr)
        {
            string[] msgDataStr = TxDataStr.Trim().ToUpper().Split(' ');
            byte[] Result = new byte[msgDataStr.Length];
            for (int i = 0; i < msgDataStr.Length; i++)
            {
                Result[i] = Convert.ToByte(msgDataStr[i], 16);
            }

            return Result;
        }

        private void SecurityAccess()
        {
            string dataStr = "27 ";

            isCallKeyToSeedDll = true;
            SecuritAccessReqSeedSubFunction = (byte)Convert.ToInt32(SecurityAccessComboBox.Text.Substring(3, 2), 16);
            dataStr += SecurityAccessComboBox.Text.Substring(3, 2);
            passThruWrapper.TxMsg(GetReqID(), ConvertTxDataToByte(dataStr), TxRxMsgUpdateUIDataCallback);
        }


        private void ScriptRun()
        {
            /* Build a new thread to run script */
            Thread childThread = new Thread(RunScript);
            childThread.Start(Global.ScriptRunTimeInterval);
        }

        private void ScriptLoop()
        {
            /* Build a new thread to run loop script */
            Thread childThread = new Thread(LoopScript);
            childThread.Start(Global.ScriptRunTimeInterval);
        }


        private void SaveTxRxData()
        {
            string data = "";

            foreach (DataGridViewRow dataRow in this.TxRxDataGridView.Rows)
            {
                data += dataRow.Cells[0].Value.ToString().PadLeft(4) + " : ";
                data += dataRow.Cells[1].Value.ToString().PadRight(4);
                data += dataRow.Cells[2].Value.ToString().PadRight(5);
                data += dataRow.Cells[3].Value.ToString().PadRight(3);
                data += dataRow.Cells[4].Value.ToString().PadRight(50);
                data += dataRow.Cells[5].Value.ToString().PadLeft(20);
                data += "\r\n";
            }
            SaveFile(data);
        }

        /* This fun come from "https://www.cnblogs.com/liao290161655/p/8047344.html" */
        private void SaveFile(string data)
        {
            string localFilePath = "", fileNameExt = "", newFileName = "", FilePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //设置文件类型
            //书写规则例如：txt files(*.txt)|*.txt
            saveFileDialog.Filter = "txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|All files(*.*)|*.*";
            //设置默认文件名（可以不设置）
            saveFileDialog.FileName = "data";
            //主设置默认文件extension（可以不设置）
            saveFileDialog.DefaultExt = "xml";
            //获取或设置一个值，该值指示如果用户省略扩展名，文件对话框是否自动在文件名中添加扩展名。（可以不设置）
            saveFileDialog.AddExtension = true;
            //设置默认文件类型显示顺序（可以不设置）
            saveFileDialog.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录
            saveFileDialog.RestoreDirectory = true;

            // Show save file dialog box
            DialogResult result = saveFileDialog.ShowDialog();
            //点了保存按钮进入
            if (result == DialogResult.OK)
            {
                //获得文件路径
                localFilePath = saveFileDialog.FileName.ToString();
                //获取文件名，不带路径
                fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
                //获取文件路径，不带文件名
                FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));
                //给文件名前加上时间
                //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt;
                //在文件名里加字符
                //saveFileDialog.FileName.Insert(1,"dameng");
                //为用户使用 SaveFileDialog 选定的文件名创建读/写文件流。
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();//输出文件
                                                                                          //fs可以用于其他要写入的操作

                StreamWriter writer0 = new StreamWriter(fs, Encoding.UTF8);
                writer0.WriteLine(data);
                writer0.Flush(); // 使得所有缓冲的数据都写入到文件中
                fs.Close(); // 方法关闭当前文件流
            }
        }
    }

    class DiagDataGridViewRowData
    {
        public string type = String.Empty;
        public string id = String.Empty;
        public string len = String.Empty;
        public string data = String.Empty;
        public string ts = String.Empty;
    }
}
