using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using J2534DotNet;

namespace DiagTool_Kanwairen
{
    class Setup
    {

        public retstate SetupInit(List<J2534Device> availableJ2534Devices, Action<List<J2534Device>> Callback)
        {
            retstate ret = retstate.NOT_OK;

            if (availableJ2534Devices.Count != 0)
            {
                Callback(availableJ2534Devices);
                ret = retstate.OK;
            }

            return ret;
        }
    }
}
