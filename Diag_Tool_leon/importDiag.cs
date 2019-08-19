using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diag_Tool_leon
{
    public partial class importDiag : Form
    {
        public importDiag()
        {
            InitializeComponent();
        }
        static public string Dll_Path = "";

        private void ImportDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Dll Files (*.dll)|*.dll|All files (*.*)|*.*";
            OpenFileDialog.RestoreDirectory = true;
            OpenFileDialog.FilterIndex = 1;
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = OpenFileDialog.FileName;
            }
        }

        private void Comfirm_Click(object sender, EventArgs e)
        {

            Dll_Path = textBox1.Text;
            this.Close();
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
