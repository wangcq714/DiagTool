using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using J2534DotNet;

namespace DiagTool_Kanwairen
{
    public partial class DiagUserControl : UserControl
    {
        public bool isCallKeyToSeedDll = false;
        public byte subFunctionSeedkey = 0;
        private retstate retVal;
        public DataTable DTCANRxScroll = new DataTable();

        public DiagUserControl()
        {
            InitializeComponent();
        }

        /*Run before display*/
        private void DiagUserControlLoad(object sender, EventArgs e)
        {
            this.TestPresentComboBox.SelectedIndex = 0;
            this.SecurityAccessComboBox.SelectedIndex = 0;
            this.DeviceConnectButton.Image = Image.FromFile("stop.png");

            DTCANRxScroll.Columns.Add("Sum", typeof(int));
            DTCANRxScroll.Columns.Add("Type");
            DTCANRxScroll.Columns.Add("ArbID");
            DTCANRxScroll.Columns.Add("Length", typeof(int));
            DTCANRxScroll.Columns.Add("Data");
            DTCANRxScroll.Columns.Add("TimeStamp");
            this.TxRxDataGridView.DataSource = DTCANRxScroll;
            this.TxRxDataGridView.Columns[0].Width = 50;
            this.TxRxDataGridView.Columns[1].Width = 40;
            this.TxRxDataGridView.Columns[2].Width = 50;
            this.TxRxDataGridView.Columns[3].Width = 50;
            this.TxRxDataGridView.Columns[4].Width = 400;
            this.TxRxDataGridView.Columns[5].Width = 200;
            this.TxRxDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.TxRxDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // ALL
            this.TxRxDataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.TxRxDataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.TxRxDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.TxRxDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            retVal = DeviceConnectInit(Global.passThruWrapper.availableJ2534Devices, DeviceConnectInitCallback);
            if (retVal == retstate.NOT_OK)
            {
                MessageBox.Show("请检查设备驱动哦！");
            }
        }

        /*Define external access port for this.ReqIDTextBox.Text*/
        public string ReqIDTextBox_Text
        {
            get { return this.ReqIDTextBox.Text; }
            set { this.ReqIDTextBox.Text = value; }
        }

        /*Define external access port for this.ResIDTextBox.Text*/
        public string ResIDTextBox_Text
        {
            get { return this.ResIDTextBox.Text; }
            set { this.ResIDTextBox.Text = value; }
        }

        /*Define external access port for this.RxDataTextBox.Text*/
        public string RxDataTextBox_Text
        {
            get { return this.RxDataTextBox.Text; }
            set { this.RxDataTextBox.Text = value; }
        }

        /*DeviceConnectInit init*/
        public retstate DeviceConnectInit(List<J2534Device> availableJ2534Devices, Action<List<J2534Device>> Callback)
        {
            retstate ret = retstate.NOT_OK;

            if (availableJ2534Devices.Count != 0)
            {
                Callback(availableJ2534Devices);
                ret = retstate.OK;
            }

            return ret;
        }

        /*Click DeviceConnectButton*/
        private void DeviceConnectButton_Click(object sender, EventArgs e)
        {
            retstate retVal = retstate.NOT_OK;
            BaudRate baudRate = BaudRate.ISO15765_500000;

            if (!Global.passThruWrapper.IsConnectDevice)
            {
                /* Use selected baudrate in setup */
                switch (Convert.ToInt32(Global.setupForm.BaudRateComboBox_Text.Substring(0, 3)))
                {
                    case 125:
                        baudRate = BaudRate.ISO15765_125000;
                        break;
                    case 250:
                        baudRate = BaudRate.ISO15765_250000;
                        break;
                    case 500:
                        baudRate = BaudRate.ISO15765_500000;
                        break;
                    default :
                        baudRate = BaudRate.ISO15765_500000;
                        break;

                }
                retVal = Global.passThruWrapper.connectToDevice(this.DeviceSelectComboBox.SelectedIndex, Global.diagUsercontrol.ReqIDTextBox_Text, Global.diagUsercontrol.ResIDTextBox_Text, baudRate);
                if (retVal == retstate.NOT_OK)
                {
                    MessageBox.Show("请检查设备连接！", "Error");
                }
                else if (retVal == retstate.OK)
                {
                    this.RxMsgTimer.Start();
                    this.TestPresentTimer.Start();
                    Global.mmTimer.Start(2, true); // TxPanel timer.
                    this.DeviceConnectButton.Image = Image.FromFile("run.png");
                }
            }
            else
            {
                this.RxMsgTimer.Stop();
                this.TestPresentTimer.Stop();
                Global.mmTimer.Stop();          // TxPanel timer.
                Global.passThruWrapper.deviceClose();
                this.DeviceConnectButton.Image = Image.FromFile("stop.png");
            }
        }

        /*Trigger RxMsgTimer for Rx Msg*/
        private void RxMsgTimer_Tick(object sender, EventArgs e)
        {
            Global.passThruWrapper.RxMsg(ResIDTextBox, TxRxMsgUpdateDiagDataGridViewCallback, TxRxMsgCallDllCallback);
        }

        /*Trigger TestPresentTimer for Tx TestPresent Msg periodically */
        private void TestPresentTimer_Tick(object sender, EventArgs e)
        {
            /* if not connect device, return */
            if (!Global.passThruWrapper.IsConnectDevice)
                return;
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

        /*ReqIDTextBox: Press Entry key for send  */
        private void ReqIDTextBox_EnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))   //Enter  
            {
                this.SendButton.PerformClick();
            }
        }

        /*Click SendButton*/
        private void SendButton_Click(object sender, EventArgs e)
        {
            /* if not connect device, return */
            if (!Global.passThruWrapper.IsConnectDevice)
                return;
            /* if ReqID or Txdata is empty, return */
            if ((ReqIDTextBox.Text.Trim() == "") || (TxDataTextBox.Text.Trim() == ""))
                return;

            //Console.Write("1"); // Debug
            Global.passThruWrapper.TxMsg(ReqIDTextBox.Text, TxDataTextBox.Text, TxRxMsgUpdateDiagDataGridViewCallback);

        }

        /*Click ClearButton*/
        private void ClearButton_Click(object sender, EventArgs e)
        {
            RxDataTextBox.Text = "";
        }

        /*Click SecurityAccessButton*/
        private void SecurityAccessButton_Click(object sender, EventArgs e)
        {
            string dataStr = "27 ";

            /* if not connect device, return */
            if (!Global.passThruWrapper.IsConnectDevice)
                return;

            isCallKeyToSeedDll = true;
            subFunctionSeedkey = (byte)Convert.ToInt32(SecurityAccessComboBox.Text.Substring(3, 2), 16);
            dataStr += SecurityAccessComboBox.Text.Substring(3, 2);
            Global.passThruWrapper.TxMsg(ReqIDTextBox.Text, dataStr, TxRxMsgUpdateDiagDataGridViewCallback);
        }

        /*TxRxDataGridView DoubleClick for copy data to TxDataText*/
        private void TxRxDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (TxRxDataGridView.CurrentCell.Value != null)
            {
                TxDataTextBox.Text = TxRxDataGridView.CurrentCell.Value.ToString().Trim();
            }
        }

        /*Clear display*/
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.diagUsercontrol.DTCANRxScroll.Clear();
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

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = "";

            foreach (DataRow dataRow in DTCANRxScroll.Rows)
            {
                data += dataRow[0].ToString() + " : ";
                data += dataRow[1].ToString() + "     ";
                data += dataRow[2].ToString() + "     ";
                data += dataRow[3].ToString() + "     ";
                data += dataRow[4].ToString() + "     ";
                data += dataRow[5].ToString() + "     ";
                data += "\r\n\r\n";
            }
            SaveFile(data);

        }
    }
}
