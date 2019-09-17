using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagTool_Kanwairen
{
    public partial class ToASCIIForm : Form
    {
        public ToASCIIForm()
        {
            InitializeComponent();
        }

        private void ToASCIIButton_Click(object sender, EventArgs e)
        {
            HexToAsciiFunc(HexTextBox.Text);
        }

        private void HexToAsciiFunc(string HexValue)
        {
            UInt16 HEXVALUE;
            ASCIITextBox.Text = "";
            string[] HEX1 = HexValue.Trim().Split(' ');

            foreach (string HexHexIndex in HEX1)
            {
                HEXVALUE = Convert.ToUInt16(HexHexIndex, 16);
                ASCIITextBox.Text += ((char)HEXVALUE).ToString();
            }
        }

        /*Redefine FormClosing action*/
        private void ToASCIIFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
