using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DiagTool_Luffy
{
    class LicenseManagement
    {
        private string encryptComputer = string.Empty;

        public bool LicenseCheck()
        {
            string computerInfo = ComputerInfo.GetComputerInfo();
            encryptComputer = new Encryption().EncryptString(computerInfo);
            if (CheckRegist() == false)
            {
                RegistFile.WriteComputerInfoFile(encryptComputer);
                MessageBox.Show("Sorry, No license!!!");               
                return false;
            }

            return true;
        }

        private bool CheckRegist()
        {
            Encryption helper = new Encryption();
            string md5key = helper.GetMD5String(encryptComputer);
            return CheckRegistData(md5key);
        }
        private bool CheckRegistData(string key)
        {
            if (RegistFile.ExistRegistInfofile() == false)
            {
                return false;
            }
            else
            {
                string info = RegistFile.ReadRegistFile();
                var helper = new Encryption(EncryptionKeyEnum.KeyB);
                string registData = helper.DecryptString(info);
                if (key == registData)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Register()
        {
            if (CheckRegist() == true)
            {
                MessageBox.Show("     Registered");
                return;
            }
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
                RegistFile.RegistInfofile);
            if (fileName != localFileName)
                File.Copy(fileName, localFileName, true);

            if (CheckRegist() == true)
            {
                MessageBox.Show("Register Success");
            }
        }

    }
}
