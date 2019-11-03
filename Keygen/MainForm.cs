using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keygen
{
    public partial class KeygenForm : Form
    {
        public KeygenForm()
        {
            InitializeComponent();
        }

        private void GenerateLicenseButton_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }
            else
            {
                return;
            }
            string localFileName = string.Concat(
                Environment.CurrentDirectory,
                Path.DirectorySeparatorChar,
                RegistFile.ComputerInfofile);

            if (Directory.Exists("License") == false)//if no "License" directory, then create it
            {
                Directory.CreateDirectory("License");
            }
            if (fileName != localFileName)
                File.Copy(fileName, localFileName, true);
            string computer = RegistFile.ReadComputerInfoFile();
            Encryption help = new Encryption(EncryptionKeyEnum.KeyB);
            string md5String = help.GetMD5String(computer);
            string registInfo = help.EncryptString(md5String);
            RegistFile.WriteRegistFile(registInfo);
            MessageBox.Show("注册码已生成");
        }
    }
}
