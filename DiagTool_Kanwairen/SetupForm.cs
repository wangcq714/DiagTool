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
            this.BaudRateComboBox.SelectedIndex = 2;
        }

        /*Run before display*/
        private void SetupWindowLoad(object sender, EventArgs e)
        {
            //this.BaudRateComboBox.SelectedIndex = 1;
            //this.DeviceConnectButton.Image = Image.FromFile("stop.png");
        }

        /*Redefine Formclosing*/
        private void SetupFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        /*Define external access port for this.BaudRateComboBox.Text*/
        public string BaudRateComboBox_Text
        {
            get { return this.BaudRateComboBox.Text; }
            set { this.BaudRateComboBox.Text = value; }
        }

        /*Define external access port for this.ScriptTimeIntervalTextBox.Text*/
        public string ScriptTimeIntervalTextBox_Text
        {
            get { return this.ScriptTimeIntervalTextBox.Text; }
            set { this.ScriptTimeIntervalTextBox.Text = value; }
        }
    }
}
