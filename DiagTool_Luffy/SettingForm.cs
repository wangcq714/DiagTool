using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using J2534DotNet;

namespace DiagTool_Luffy
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        /*Run before display*/
        private void SettingWindowLoad(object sender, EventArgs e)
        {
            LoadBaudRateComboBox();

            LoadScriptTimeIntervalTextBox();
        }

        private void LoadBaudRateComboBox()
        {
            switch (Global.CANBaudRate)
            {
                case BaudRate.ISO15765_125000:
                    this.BaudRateComboBox.SelectedIndex = 0;
                    break;
                case BaudRate.ISO15765_250000:
                    this.BaudRateComboBox.SelectedIndex = 1;
                    break;
                case BaudRate.ISO15765_500000:
                    this.BaudRateComboBox.SelectedIndex = 2;
                    break;
                default:
                    this.BaudRateComboBox.SelectedIndex = 2;
                    break;
            }
        }

        private void LoadScriptTimeIntervalTextBox()
        {
            this.ScriptTimeIntervalTextBox.Text = Convert.ToString(Global.ScriptRunTimeInterval);
        }

        /*Redefine Formclosing*/
        private void SettingFormClosing(object sender, FormClosingEventArgs e)
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UpdateBaudrateData();
            UpdateScriptRunTimeIntervalData();

            this.Close();
        }

        private void UpdateBaudrateData()
        {
            switch (this.BaudRateComboBox.SelectedIndex)
            {
                case 0:
                    Global.CANBaudRate = BaudRate.ISO15765_125000;
                    break;
                case 1:
                    Global.CANBaudRate = BaudRate.ISO15765_250000;
                    break;
                case 2:
                    Global.CANBaudRate = BaudRate.ISO15765_500000;
                    break;
                default:
                    Global.CANBaudRate = BaudRate.ISO15765_500000;
                    break;
            }
        }

        private void UpdateScriptRunTimeIntervalData()
        {
            Global.ScriptRunTimeInterval = Convert.ToInt32(this.ScriptTimeIntervalTextBox.Text.ToString().Trim());
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
