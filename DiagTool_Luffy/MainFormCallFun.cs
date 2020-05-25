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

using J2534DotNet;
namespace DiagTool_Luffy
{
    public partial class MainWindow
    {
        private void MainWindowInit()
        {
            bool retVal = false;

            if (!licenseManagement.LicenseCheck())
            {
                this.Close();
                return;
            }

            this.TestPresentComboBox.SelectedIndex = 0;
            this.SecurityAccessComboBox.SelectedIndex = 0;
            this.DeviceConnectButton.Image = Image.FromFile("stop.png");

            int index = this.TxRxDataGridView.Rows.Add();
            this.TxRxDataGridView.Rows[index].Cells[0].Value = "1";
            this.TxRxDataGridView.Rows[index].Cells[1].Value = "Tx";
            this.TxRxDataGridView.Rows[index].Cells[2].Value = "734";
            this.TxRxDataGridView.Rows[index].Cells[3].Value = "2";
            this.TxRxDataGridView.Rows[index].Cells[4].Value = "10 02";
            this.TxRxDataGridView.Rows[index].Cells[5].Value = "2020:05:17";

            TxRxDataGridViewAddRow("2", "Rx", "634", "6", "50 02 00 00 00 00", "2020:05:17");

            retVal = Global.passThruWrapper.DeviceConnectInit(DeviceConnectInitCallback);
            if (!retVal)
            {
                MessageBox.Show("-----Please device driver!!!-----");
            }
        }

        public void TxRxDataGridViewAddRow(string num, string type, string id, string len, string data, string ts)
        {
            int index = this.TxRxDataGridView.Rows.Add();

            this.TxRxDataGridView.Rows[index].Cells[0].Value = num;
            this.TxRxDataGridView.Rows[index].Cells[1].Value = type;
            this.TxRxDataGridView.Rows[index].Cells[2].Value = id;
            this.TxRxDataGridView.Rows[index].Cells[3].Value = len;
            this.TxRxDataGridView.Rows[index].Cells[4].Value = data;
            this.TxRxDataGridView.Rows[index].Cells[5].Value = ts;
        }


        private void ConnectDevice()
        {
            BaudRate baudRate = Global.CANBaudRate;

            if (!bDeviceConnectState)
            {
                bDeviceConnectState = Global.passThruWrapper.ConnectDevice(this.DeviceSelectComboBox.SelectedIndex, this.ReqIDTextBox_Text, this.ResIDTextBox_Text, baudRate);
                if (bDeviceConnectState)
                {
                    this.RxMsgTimer.Start();
                    this.TestPresentTimer.Start();
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
                this.RxMsgTimer.Stop();
                this.TestPresentTimer.Stop();
                Global.passThruWrapper.deviceClose();
                this.DeviceConnectButton.Image = Image.FromFile("stop.png");
                bDeviceConnectState = false;
            }
        }

        private void RxCANMessage()
        {
            Global.passThruWrapper.RxMsg(ResIDTextBox, TxRxMsgUpdateDiagDataGridViewCallback, TxRxMsgCallDllCallback, TxRxMsgCallSyncCallback);
        }

        private void TestPresent()
        {
            /* if ReqID is empty, return */
            if (ReqIDTextBox.Text.Trim() == "")
                return;
            /* if enable TetsPresent */
            if (TestPresentCheckBox.Checked)
            {
                /* if "3E 80" is sent, don't display in DiagDataGridView */
                if (TestPresentComboBox.SelectedIndex == 0)
                {
                    Global.passThruWrapper.TxMsg(ReqIDTextBox.Text, TestPresentComboBox.Text, TxRxMsgNotUpdateDiagDataGridViewCallback);
                }
                /* if "3E 00" is sent, display in DiagDataGridView */
                else if (TestPresentComboBox.SelectedIndex == 1)
                {
                    Global.passThruWrapper.TxMsg(ReqIDTextBox.Text, TestPresentComboBox.Text, TxRxMsgUpdateDiagDataGridViewCallback);
                }
            }
        }

        private void TxCANMessage()
        {
            /* if ReqID or Txdata is empty, return */
            if ((ReqIDTextBox.Text.Trim() == "") || (TxDataTextBox.Text.Trim() == ""))
                return;

            //Console.Write("1"); // Debug
            Global.passThruWrapper.TxMsg(ReqIDTextBox.Text, TxDataTextBox.Text, TxRxMsgUpdateDiagDataGridViewCallback);
        }

        private void SecurityAccess()
        {
            string dataStr = "27 ";

            isCallKeyToSeedDll = true;
            subFunctionSeedkey = (byte)Convert.ToInt32(SecurityAccessComboBox.Text.Substring(3, 2), 16);
            dataStr += SecurityAccessComboBox.Text.Substring(3, 2);
            Global.passThruWrapper.TxMsg(ReqIDTextBox.Text, dataStr, TxRxMsgUpdateDiagDataGridViewCallback);
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
}
