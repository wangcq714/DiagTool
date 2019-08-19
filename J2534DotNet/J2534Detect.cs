using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace J2534DotNet
{
    static public class J2534Detect
    {
        private const string PASSTHRU_REGISTRY_PATH = "Software\\PassThruSupport.04.04";
        private const string PASSTHRU_REGISTRY_PATH_6432 = "Software\\Wow6432Node\\PassThruSupport.04.04";

        static public List<J2534Device> ListDevices()
        {
            List<J2534Device> j2534Devices = new List<J2534Device>();
            RegistryKey myKey = Registry.LocalMachine.OpenSubKey(PASSTHRU_REGISTRY_PATH, false);
            if (myKey == null)
            {
                myKey = Registry.LocalMachine.OpenSubKey(PASSTHRU_REGISTRY_PATH_6432, false);
                if (myKey == null)
                    return j2534Devices;
            }
            string[] devices = myKey.GetSubKeyNames();
            foreach (string device in devices)
            {
                J2534Device tempDevice = new J2534Device();
                RegistryKey deviceKey = myKey.OpenSubKey(device);
                if (deviceKey == null)
                    continue;
                tempDevice.Vendor = (string)deviceKey.GetValue("Vendor", "");
                tempDevice.Name = (string)deviceKey.GetValue("Name", "");
                tempDevice.ConfigApplication = (string)deviceKey.GetValue("ConfigApplication", "");
                tempDevice.FunctionLibrary = (string)deviceKey.GetValue("FunctionLibrary", "");

                tempDevice.CANChannels = (int)deviceKey.GetValue("CAN", 0);
                tempDevice.ISO15765Channels = (int)deviceKey.GetValue("ISO15765", 0);
                tempDevice.J1850PWMChannels = (int)deviceKey.GetValue("J1850PWM", 0);
                tempDevice.J1850VPWChannels = (int)deviceKey.GetValue("J1850VPW", 0);
                tempDevice.ISO9141Channels = (int)deviceKey.GetValue("ISO9141", 0);
                tempDevice.ISO14230Channels = (int)deviceKey.GetValue("ISO14230", 0);
                tempDevice.SCI_A_ENGINEChannels = (int)deviceKey.GetValue("SCI_A_ENGINE", 0);
                tempDevice.SCI_A_TRANSChannels = (int)deviceKey.GetValue("SCI_A_TRANS", 0);
                tempDevice.SCI_B_ENGINEChannels = (int)deviceKey.GetValue("SCI_B_ENGINE", 0);
                tempDevice.SCI_B_TRANSChannels = (int)deviceKey.GetValue("SCI_B_TRANS", 0);

                j2534Devices.Add(tempDevice);
            }

            return j2534Devices;
        }
    }
}
