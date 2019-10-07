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
    public partial class HexASCIIForm : Form
    {
        public HexASCIIForm()
        {
            InitializeComponent();
        }

        /*Redefine FormClosing action*/
        private void ToASCIIFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        /* Hex to Ascii */
        private string HexToAsciiFunc(string HexStr)
        {
            UInt16 HexValue;
            string retAsciiStr = "";        
            string[] HexStrArr = HexStr.Trim().Split(' ');

            foreach(string hex in HexStrArr)
            {
                HexValue = Convert.ToUInt16(hex, 16);
                retAsciiStr += ((char)HexValue).ToString();              
            }

            return retAsciiStr;
        }

        /* Ascii to Hex */
        private string AsciiToHexFunc(string AsciiStr)
        {
            string retHexStr = "";
            char[] AsciiStrArr = AsciiStr.ToCharArray();

            foreach (char ascii in AsciiStrArr)
            {
                retHexStr += ((int)ascii).ToString("X2") + " ";
            }

            return retHexStr;
        }

        /* Click ToASCII */
        private void ToASCIIButton_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIITextBox.Text = "";
                ASCIITextBox.Text = HexToAsciiFunc(HexTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please input legal content！");
            }          
        }

        /* Click ToHex */
        private void ToHexButton_Click(object sender, EventArgs e)
        {
            try
            {
                HexTextBox.Text = "";
                HexTextBox.Text = AsciiToHexFunc(ASCIITextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please input legal content！");
            }
}
    }
}
