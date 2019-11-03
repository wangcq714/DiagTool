using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;



namespace DiagTool_Kanwairen
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime; //seemingly it has no effect at all.
        }

        /*Run before display*/
        private void MainWindowLoad(object sender, EventArgs e)
        {
            Global.diagUsercontrol.Show();
            MainGroupBox.Controls.Clear();
            MainGroupBox.Controls.Add(Global.diagUsercontrol);
        }

        /*DiagWin Display*/
        private void DiagLabel_Click(object sender, EventArgs e)
        {
            this.DiagLabel.BackColor = System.Drawing.Color.White;
            this.FlashLabel.BackColor = System.Drawing.Color.DodgerBlue;

            this.DiagLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FlashLabel.ForeColor = System.Drawing.Color.White;

            Global.diagUsercontrol.Show();
            MainGroupBox.Controls.Clear();
            MainGroupBox.Controls.Add(Global.diagUsercontrol);
        }

        /*FlashWin Display*/
        private void FlashLabel_Click(object sender, EventArgs e)
        {
            this.DiagLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.FlashLabel.BackColor = System.Drawing.Color.White;

            this.DiagLabel.ForeColor = System.Drawing.Color.White;
            this.FlashLabel.ForeColor = System.Drawing.Color.DodgerBlue;

            Global.flashUsercontrol.Show();
            MainGroupBox.Controls.Clear();
            MainGroupBox.Controls.Add(Global.flashUsercontrol);
        }


        /*Click File->Import*/
        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //importForm.ShowDialog();         /* MainWindow can't be operated. */
            Global.importForm.Show();          /* MainWindow can be operated. */ 
        }

        /*Click Network->TxPanel*/
        private void TxPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Global.txPanelForm.ShowDialog();  /* MainWindow can't be operated. */
            Global.txPanelForm.Show();          /* MainWindow can be operated. */
        }

        /*Click Setup->Hardware*/
        private void HardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.setupForm.ShowDialog();  /* MainWindow can't be operated. */
            //Global.hardwareForm.Show();          /* MainWindow can be operated. */
        }

        /* Close main window, exit app */
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Click Tool->ToASCII*/
        private void ToASCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.hexAsciiForm.Show();          /* MainWindow can be operated. */
        }

        /* Click Tool->NRCTable*/
        private void nRCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.nrcTableForm.Show();          /* MainWindow can be operated. */
        }

        /* Click Auto->Script */
        private void scriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.scriptForm.Show();          /* MainWindow can be operated. */
        }

        /* Click Networks->DTC */
        private void dTCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.dtcTestForm.Show();          /* MainWindow can be operated. */
        }

        private void readDTCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.readDTCForm.Show();          /* MainWindow can be operated. */
        }
    }
}
