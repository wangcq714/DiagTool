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
    public partial class MainWindow : Form
    {
        private SecurityAlgorithm securityAlgorithm = new SecurityAlgorithm();
        //private LicenseManagement licenseManagement = new LicenseManagement();
        private PassThruWrapper passThruWrapper = new PassThruWrapper();
        MMTimer mmTimer = new MMTimer();

        private static DiagDataGridViewRowData[] DiagDataGridViewRowDatas = new DiagDataGridViewRowData[32];
        private static DiagDataGridViewRowDataQueue diagDataGridViewRowDataQueue = new DiagDataGridViewRowDataQueue(DiagDataGridViewRowDatas);

        static object DiagDataGridViewAddRowLocker = new object();

        private bool bDeviceConnectState = false;

        public bool isCallKeyToSeedDll = false;
        public byte subFunctionSeedkey = 0;
        public DataTable DTCANRxScroll = new DataTable();

        



        public MainWindow()
        {
            InitializeComponent();
        }

        /*Run before display*/
        private void MainWindowLoad(object sender, EventArgs e)
        {
            MainWindowInit();
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


        /*Click DeviceConnectButton*/
        private void DeviceConnectButton_Click(object sender, EventArgs e)
        {
            ConnectDevice();
        }

        /*Trigger RxMsgTimer for Rx Msg*/
        private void RxMsgTimer_Tick(object sender, EventArgs e)
        {
            RxCANMessage();
        }

        /*Trigger TestPresentTimer for Tx TestPresent Msg periodically */
        private void TestPresentTimer_Tick(object sender, EventArgs e)
        {
            TestPresent();
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
            TxCANMessage();
        }

        /*Click ClearButton*/
        private void ClearButton_Click(object sender, EventArgs e)
        {
            RxDataTextBox.Text = "";
        }

        /*Click SecurityAccessButton*/
        private void SecurityAccessButton_Click(object sender, EventArgs e)
        {
            SecurityAccess();
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
            this.TxRxDataGridView.Rows.Clear();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTxRxData();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            //importForm.ShowDialog();         /* MainWindow can't be operated. */
            importForm.Show();          /* MainWindow can be operated. */
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            //importForm.ShowDialog();         /* MainWindow can't be operated. */
            settingForm.Show();          /* MainWindow can be operated. */
        }

        private void nRCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NRCTableForm nRCTableForm = new NRCTableForm();
            //importForm.ShowDialog();         /* MainWindow can't be operated. */
            nRCTableForm.Show();          /* MainWindow can be operated. */
        }

        private void hexTooTASCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HexASCIIForm hexASCIIForm = new HexASCIIForm();
            hexASCIIForm.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //licenseManagement.Register();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();

            aboutForm.Show();
        }

        private void LoopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
