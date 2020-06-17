using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

using J2534DotNet;

namespace DiagTool_Luffy
{
    class SecurityAlgorithm
    {



        //在要使用dll的文件中先定一个委托
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void doDllFunction(ref byte seed_value, ref byte key_value, byte len);


        public string SecurityAccessSeedToKey(string SeedStr, string pathname)
        {
            string Result = "";

            byte[] seed = ConvertSeedToByte(SeedStr);
            byte[] key = new byte[seed.Length];
                       
            if (pathname != "")
            {
                Dll dllinvoke = new Dll(pathname);   //实例化 或者satatic方法
                doDllFunction CalculateKeyBySeed = (doDllFunction)dllinvoke.Invoke("CalcKeys", typeof(doDllFunction));//InitFunction为需要执行的函数名
                CalculateKeyBySeed(ref seed[0], ref key[0], (byte)seed.Length);

                for (int i = 0; i < key.Length; i++)
                {
                    Result += string.Format("{0:X2}", key[i]) + " ";
                }
            }
            else
            {
                MessageBox.Show("Please Import Dll !!!", "Error");
            }
            return Result.Trim();
        }


        private byte[] ConvertSeedToByte(string SeedStr)
        {
            string[] msgDataStr = SeedStr.Trim().ToUpper().Split(' ');
            byte[] Result = new byte[msgDataStr.Length];
            for (int i = 0; i < msgDataStr.Length; i++)
            {
                Result[i] = Convert.ToByte(msgDataStr[i], 16);
            }

            return Result;
        }
    }
}
