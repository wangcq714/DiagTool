using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using J2534DotNet;

namespace DiagTool_Kanwairen
{
    public partial class DiagUserControl : UserControl
    {
        retstate retVal;
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
            if (!Global.passThruWrapper.IsConnectDevice)
            {
                retVal = Global.passThruWrapper.connectToDevice(this.DeviceSelectComboBox.SelectedIndex, Global.diagUsercontrol.ReqIDTextBox_Text, Global.diagUsercontrol.ResIDTextBox_Text);
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
            string dataStr = "27";

            /* if not connect device, return */
            if (!Global.passThruWrapper.IsConnectDevice)
                return;

            dataStr += " " + SecurityAccessComboBox.Text.Substring(3, 2);
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
    }
}
