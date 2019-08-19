using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DiagTool_Kanwairen
{
    public partial class MainWindow : Form
    {
        retstate retVal;
        DataTable DTCANRxScroll = new DataTable();

        PassThruWrapper passThruWrapper = new PassThruWrapper();
        Setup setup = new Setup();
        Diag diag = new Diag();

        public MainWindow()
        {
            InitializeComponent();

            this.TestPresentComboBox.SelectedIndex = 0;
            this.SecurityAccessComboBox.SelectedIndex = 0;
            this.BaudRateComboBox.SelectedIndex = 1;

            this.DiagPanel.Visible = true;
            this.TxRxPanel.Visible = false;
            this.FlashPanel.Visible = false;
            this.SetupPanel.Visible = false;

            this.DeviceConnectButton.Image = Image.FromFile("stop.png");

            this.DiagDataGridView.DataSource = DTCANRxScroll;

            retVal = setup.SetupInit(passThruWrapper.availableJ2534Devices, this.SetupInitCallback);
            if (retVal == retstate.NOT_OK)
            {
                MessageBox.Show("请检查设备驱动哦！");
            }
            //Console.WriteLine("{0}", TestPresentComboBox.Text);  //test
        }

        private void DiagLabel_Click(object sender, EventArgs e)
        {
            this.DiagLabel.BackColor = System.Drawing.Color.White;
            this.TxRxLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.FlashLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.SetupLabel.BackColor = System.Drawing.Color.DodgerBlue;

            this.DiagLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxRxLabel.ForeColor = System.Drawing.Color.White;
            this.FlashLabel.ForeColor = System.Drawing.Color.White;
            this.SetupLabel.ForeColor = System.Drawing.Color.White;

            this.DiagPanel.Visible = true;
            this.TxRxPanel.Visible = false;
            this.FlashPanel.Visible = false;
            this.SetupPanel.Visible = false;
        }

        private void TxRxLabel_Click(object sender, EventArgs e)
        {
            this.DiagLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TxRxLabel.BackColor = System.Drawing.Color.White;
            this.FlashLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.SetupLabel.BackColor = System.Drawing.Color.DodgerBlue;

            this.DiagLabel.ForeColor = System.Drawing.Color.White;
            this.TxRxLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FlashLabel.ForeColor = System.Drawing.Color.White;
            this.SetupLabel.ForeColor = System.Drawing.Color.White;

            this.DiagPanel.Visible = false;
            this.TxRxPanel.Visible = true;
            this.FlashPanel.Visible = false;
            this.SetupPanel.Visible = false;
        }

        private void FlashLabel_Click(object sender, EventArgs e)
        {
            this.DiagLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TxRxLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.FlashLabel.BackColor = System.Drawing.Color.White;
            this.SetupLabel.BackColor = System.Drawing.Color.DodgerBlue;

            this.DiagLabel.ForeColor = System.Drawing.Color.White;
            this.TxRxLabel.ForeColor = System.Drawing.Color.White;
            this.FlashLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SetupLabel.ForeColor = System.Drawing.Color.White;

            this.DiagPanel.Visible = false;
            this.TxRxPanel.Visible = false;
            this.FlashPanel.Visible = true;
            this.SetupPanel.Visible = false;
        }

        private void SetupLabel_Click(object sender, EventArgs e)
        {
            this.DiagLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TxRxLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.FlashLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.SetupLabel.BackColor = System.Drawing.Color.White;

            this.DiagLabel.ForeColor = System.Drawing.Color.White;
            this.TxRxLabel.ForeColor = System.Drawing.Color.White;
            this.FlashLabel.ForeColor = System.Drawing.Color.White;
            this.SetupLabel.ForeColor = System.Drawing.Color.DodgerBlue;

            this.DiagPanel.Visible = false;
            this.TxRxPanel.Visible = false;
            this.FlashPanel.Visible = false;
            this.SetupPanel.Visible = true;
        }

        private void ManualLabel_Click(object sender, EventArgs e)
        {
            this.ManualLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AutoLabel.ForeColor = System.Drawing.Color.DimGray;

            this.ManualLineLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.AutoLineLabel.BackColor = System.Drawing.Color.LightGray;

            this.DiagManualPanel.Visible = true;
        }

        private void AutoLabel_Click(object sender, EventArgs e)
        {
            this.ManualLabel.ForeColor = System.Drawing.Color.DimGray;
            this.AutoLabel.ForeColor = System.Drawing.Color.DodgerBlue;

            this.ManualLineLabel.BackColor = System.Drawing.Color.LightGray;
            this.AutoLineLabel.BackColor = System.Drawing.Color.DodgerBlue;

            this.DiagManualPanel.Visible = false;
        }

        /*Click DeviceConnectButton*/
        private void DeviceConnectButton_Click(object sender, EventArgs e)
        {
            retstate retVal = retstate.NOT_OK;
            if (!passThruWrapper.IsConnectDevice)
            {
                retVal = passThruWrapper.connectToDevice(this.DeviceSelectComboBox, this.ReqIDTextBox.Text, this.ResIDTextBox.Text);
                if (retVal == retstate.NOT_OK)
                {
                    MessageBox.Show("请检查设备连接！", "Error");
                }
                else if (retVal == retstate.OK)
                {
                    this.RxMsgTimer.Enabled = true;
                    this.TestPresentTimer.Enabled = true;
                    this.DeviceConnectButton.Image = Image.FromFile("run.png");
                }
            }
            else
            {
                this.RxMsgTimer.Enabled = false;
                this.TestPresentTimer.Enabled = false;
                passThruWrapper.deviceClose();
                this.DeviceConnectButton.Image = Image.FromFile("stop.png");
            }
        }

        /*Trigger RxMsgTimer for Rx Msg*/
        private void RxMsgTimer_Tick(object sender, EventArgs e)
        {
            passThruWrapper.RxMsg(ResIDTextBox, TxRxMsgUpdateDiagDataGridViewCallback, TxRxMsgCallDllCallback);
        }

        /*Trigger TestPresentTimer for Tx TestPresent Msg periodically */
        private void TestPresentTimer_Tick(object sender, EventArgs e)
        {
            /* if not connect device, return */
            if (!passThruWrapper.IsConnectDevice)
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
                    passThruWrapper.TxMsg(ReqIDTextBox.Text, TestPresentComboBox.Text, TxRxMsgNotUpdateDiagDataGridViewCallback);
                }
                /* if "3E 00" is sent, display in DiagDataGridView */
                else if (TestPresentComboBox.SelectedIndex == 1)
                {
                    passThruWrapper.TxMsg(ReqIDTextBox.Text, TestPresentComboBox.Text, TxRxMsgUpdateDiagDataGridViewCallback);
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
            if (!passThruWrapper.IsConnectDevice)
                return;
            /* if ReqID or Txdata is empty, return */
            if ((ReqIDTextBox.Text.Trim() == "") || (TxdataTextBox.Text.Trim() == ""))
                return;

            passThruWrapper.TxMsg(ReqIDTextBox.Text, TxdataTextBox.Text, TxRxMsgUpdateDiagDataGridViewCallback);
            
        }

        /*Click File->Import*/
        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog();
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
            if (!passThruWrapper.IsConnectDevice)
                return;

            dataStr += " " + SecurityAccessComboBox.Text.Substring(3, 2);
            passThruWrapper.TxMsg(ReqIDTextBox.Text, dataStr, TxRxMsgUpdateDiagDataGridViewCallback);
        }

        /*DiagDataGridView DoubleClick for copy data to TxDataText*/
        private void DiagDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (DiagDataGridView.CurrentCell.Value != null)
            {
                TxdataTextBox.Text = DiagDataGridView.CurrentCell.Value.ToString();
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DTCANRxScroll.Clear();
        }
    }
}
