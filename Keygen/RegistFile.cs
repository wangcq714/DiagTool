using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Keygen
{
    class RegistFile
    {
        public static string ComputerInfofile = "License\\ComputerInfo.key";
        public static string RegistInfofile = "License\\RegistInfo.key";
        public static void WriteRegistFile(string info)
        {
            WriteFile(info, RegistInfofile);
        }
        public static void WriteComputerInfoFile(string info)
        {
            if (Directory.Exists("License") == false)//if no "License" directory, then create it
            {
                Directory.CreateDirectory("License");
            }
            WriteFile(info, ComputerInfofile);
        }
        public static string ReadRegistFile()
        {
            return ReadFile(RegistInfofile);
        }
        public static string ReadComputerInfoFile()
        {
            return ReadFile(ComputerInfofile);
        }
        public static bool ExistComputerInfofile()
        {
            return File.Exists(ComputerInfofile);
        }
        public static bool ExistRegistInfofile()
        {
            return File.Exists(RegistInfofile);
        }
        private static void WriteFile(string info, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, false))
                {
                    sw.Write(info);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private static string ReadFile(string fileName)
        {
            string info = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    info = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
            }
            return info;
        }

    }
}
