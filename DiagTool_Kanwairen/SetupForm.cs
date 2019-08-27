using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using J2534DotNet;

namespace DiagTool_Kanwairen
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
            this.BaudRateComboBox.SelectedIndex = 1;
        }

        /*Run before display*/
        private void HardwareWindowLoad(object sender, EventArgs e)
        {
            //this.BaudRateComboBox.SelectedIndex = 1;
            //this.DeviceConnectButton.Image = Image.FromFile("stop.png");
        }

        /*Redefine Formclosing*/
        private void HardwareFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
