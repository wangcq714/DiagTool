using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using J2534DotNet;

namespace DiagTool_Luffy
{
    class Global
    {     
        public static BaudRate CANBaudRate = BaudRate.ISO15765_500000;
        public static int ScriptRunTimeInterval = 100;
        public static string SecurityAccessDllPathname = "";
    }
}
