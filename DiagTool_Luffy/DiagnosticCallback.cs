﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using J2534DotNet;

namespace DiagTool_Luffy
{
    public partial class MainWindow
    {
        /*DeviceConnectInit init callback*/
        public void DeviceConnectInitCallback(List<J2534Device> availableJ2534Devices)
        {
            foreach (J2534Device device in availableJ2534Devices)
            {
                this.DeviceSelectComboBox.Items.Add(device.Name);
            }
            this.DeviceSelectComboBox.SelectedIndex = 0;
        }

        /*TxRxMsg callback*/
        public void TxRxMsgUpdateUIDataCallback(string msgIdStr, string dataLenStr, string dataStr, string typeStr, string timeStampStr)
        {
            DataGridViewRowDataPushQueue(msgIdStr, dataLenStr, dataStr, typeStr, timeStampStr);
        }

        

        /*TxRxMsg callback*/
        public void TxRxMsgNotUpdateUIDataCallback(string strDataID, string strDateLen, string strDatebyte, string type, string timeStampStr)
        {
            /* Do nothing */
        }

        /*TxRxMsg callback*/
        public void SecurityAccessCallDllCallback(byte[] Data)
        {
            string dataStr = "";

            if (!bDeviceConnectState)
                return;

            if (Data[4] == 0x67 && Data[5] == SecuritAccessReqSeedSubFunction)
            {
                SecuritAccessReqSeedSubFunction = 0;
                dataStr = securityAlgorithm.Security_DLL(Data, Global.SecurityAccessDllPathname);
                if(dataStr != "")
                {
                    SecuritAccessKey = dataStr.Substring(6);
                } 
                else
                {
                    SecuritAccessKey = "";
                    isCallKeyToSeedDll = false;
                    return;
                }

                /* if "isCallKeyToSeedDll==true", that need to do security verification automaticaly */
                if (isCallKeyToSeedDll)
                {
                    Diagnostic_Send(dataStr);
                    isCallKeyToSeedDll = false;
                }
            }           
        }


        public void SyncUIComponentCallback(byte[] Data)
        {
            if (Data[4] == 0x59)
            {
                UpdateDTCDisplayTextBox_Text(Data);
            }
        }      
    }
}
