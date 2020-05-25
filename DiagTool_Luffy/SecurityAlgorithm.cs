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
        //        System.Reflection命名空间
        //(1)   AppDomain:应用程序域，可以将其理解为一组程序集的逻辑容器
        //(2)   Assembly:程序集类
        //(3)   Module:模块类
        //(4)   Type:使用反射得到类型信息的最核心的类
        //他们之间是一种从属关系，也就是说，一个AppDomain可以包含N个Assembly,一个Assembly可以包含N个Module,而一个Module可以包含N个Type.


        //在要使用dll的文件中先定一个委托

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void doDllFunction(ref byte seed_value, ref byte key_value);

        public string Security_DLL(byte[] DataReceive, string pathname)
        {
            byte[] key = new byte[4];
            byte[] seed = new byte[4];
            string strDatebyte = "";

            for (int i = 0; i < 4; i++)
            {
                seed[i] = DataReceive[6 + i];
            }

            if (pathname != "")
            {
                Dll dllinvoke = new Dll(pathname);   //实例化 或者satatic方法
                doDllFunction show = (doDllFunction)dllinvoke.Invoke("CalcKeys1", typeof(doDllFunction));//InitFunction为需要执行的函数名
                show(ref seed[0], ref key[0]);

                strDatebyte += "27 " + string.Format("{0:X2}", (DataReceive[5] + 1));
                for (int i = 0; i < 4; i++)
                {
                    strDatebyte += " " + string.Format("{0:X2}", key[i]);
                }                  
            }
            return strDatebyte;
        }
    }
}
