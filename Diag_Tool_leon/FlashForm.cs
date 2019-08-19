using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;  //hex  using this namespace
using System.Runtime.InteropServices;  //dll using this namespace
using J2534DotNet;
using System.Diagnostics;
using System.Threading;


namespace Diag_Tool_leon
{
    public partial class FlashForm : Form
    {
        public FlashForm()
        {
            InitializeComponent();
        }
        string str1="";
        string FlashRequestID = "";
        string FlashResponseID = "";
        string ISO15765_BS = "";
        string ISO15765_STMIN = "";
        string FuncAddr = "";
        string FLASH_DLL = "";
        string CRC_DLL = "";
        string strDatebyte = "";
        int sum = 0;
        UInt32 Max_Hex_Addr =new UInt32(); 
        DataTable Flash_csv_table = new DataTable();
        J2534 passThru1 = new J2534();
        List<J2534Device> availableJ2534Devices = J2534Detect.ListDevices();
        J2534Err J2534Error;
        private int deviceId = 0;  //设备编号，可选择不同的设备
        private bool OpenADevice=false;   //用于表示是否成功连接一个设备
        int baudRate = 500000;          //波特率 
        int channelId = 0; //选择设备的不同通道
        int filterId = 0;
        int numMsgs = 100;
        string[,] dategridebuff = new string [80,5];
        int RowsTmp = 0;
        int ColumnsTmp = 0;
        int TransTimeout = 0;
        int TansmitBS = 0;
        byte[] key= new byte[4];
        byte[] seed = new byte[4];
        byte[] szBin = new byte [0xfffffff];

        int slep_time = 0;
        int slep_timeTmp = 0;
        string tmpDategrid = "";
        bool SendOk = true;
        int RowReadNow = 0;
        //  int FlachProgress = 0xFF;
        string[] send_receiv = new string[2];
        string FlashAddrBegin = "";
        string FlashBlockSize = "";
        string FlashEachTime = "";
        string Seed_lv = "";
        bool SecurProg = false;
        bool FlashProg = false;
        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts;
        Thread FlashThread;  //leon
        int LOGFLAG=0;
        string LOG_Addr = "";
        byte log_flag = 0;
       // UInt32 ProgBar = 0;

        private void VariableToDefault()
        {
             sum = 0;
             deviceId = 0;  //设备编号，可选择不同的设备
             OpenADevice=false;   //用于表示是否成功连接一个设备
             baudRate = 500000;          //波特率 
             channelId = 0; //选择设备的不同通道
             RowsTmp = 0;
             ColumnsTmp = 0;
             TransTimeout = 0;
             slep_time = 0;
             slep_timeTmp = 0;
             tmpDategrid = "";
             SendOk = true;
             FlashAddrBegin = "";
             FlashBlockSize = "";
             FlashEachTime = "";
             Seed_lv = "";
             SecurProg = false;
             FlashProg = false;
             button1.Enabled = true;
        }

        private void FlashForm_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            Flash_csv_table.Columns.Add("Step", typeof(int));
            // DTCANRxScroll.Columns.Add("delata_Time");
            Flash_csv_table.Columns.Add("ArbID");
            Flash_csv_table.Columns.Add("Content");
            Flash_csv_table.Columns.Add("Time");

            dataGridView1.DataSource=Flash_csv_table;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 600;
            dataGridView1.Columns[3].Width = 200;

            str1 = AppDomain.CurrentDomain.BaseDirectory+@"\Configuration";
            String[] dirs = Directory.GetDirectories(@str1);
            foreach (string Dir in dirs)
            {
                 comboBox1.Items.Add( Dir.Replace(str1+"\\", string.Empty));
                 comboBox1.SelectedIndex=0;
            }

            if (availableJ2534Devices.Count == 0)
            {
                MessageBox.Show("请检查设备驱动哦！");
                return;
            }
            foreach (J2534Device device in availableJ2534Devices)
                FlashDevice.Items.Add(device.Name);
            FlashDevice.SelectedIndex = 0;
        }


        private void deviceDisconnect()
        {
            if (OpenADevice)
            {
                passThru1.StopMsgFilter(channelId, filterId);
                passThru1.Disconnect(channelId);
            }
        }

        private void deviceClose()
        {
            deviceDisconnect();
            if (OpenADevice)
            {
                passThru1.Close(deviceId);
                passThru1.FreeLibrary();
                OpenADevice = false;
            }
        }

//在要使用dll的文件中先定一个委托
[UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
public delegate void doDllFunction1(ref byte seed_value, ref byte key_value);

[UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
delegate UInt32 CalcChecksum(ref byte pBuffer, UInt32 u32Size);

        private void button1_Click(object sender, EventArgs e)
        {
            int FlashSelected = comboBox1.SelectedIndex;
            bool HexFlag = false;
            RowReadNow = 0;
            int i=0,j=0;
            deviceClose();
            //连接设备
            ConnectDevice();

            if (!OpenADevice)
            {
                MessageBox.Show("请链接对应设备");
                return;
            }

            //解析配置文件
            if (comboBox1.Text != "")
            {
                Flash_csv_table.Clear();
                sum = 0;
                //解析刷新配置文件ini
                Read_Ini_File(str1 + @"\" + comboBox1.Text + @"\install.ini");

                //解析刷新配置文件csv
                Read_Csv_File(str1 + @"\" + comboBox1.Text + @"\Flash\flash.csv");
                //解析刷新配置文件csv
                LOG_Addr = str1 + @"\" + comboBox1.Text + @"\data.log";
            }
            //IOCONTROL
            SetFlashparam();

            button1.Enabled = false;

            //解析hex
            HexFlag=ReadHexFile(Leon.Flash_File_path);

            ////test
            //MessageBox.Show("请链接对应设备1");

            FLASH_DLL = str1 + "\\"+comboBox1.Text + @"\Security\SecurityKeys.dll";
            CRC_DLL = str1 + "\\" + comboBox1.Text + @"\Security\Checksum.dll";

            RowsTmp=dataGridView1.Rows.Count-1;

            progressBar1.Maximum = RowsTmp;
            progressBar1.Minimum = 0;
            //progressBar1.Step = 1;

            ColumnsTmp = dataGridView1.Columns.Count;

            for (i = 0; i < RowsTmp; i++)
                for (j = 0; j < ColumnsTmp; j++)
                    dategridebuff[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                     //CLEAR DATAGRIDEVOEW
            Flash_csv_table.Clear();
            sum = 0;
            //刷新
            if (HexFlag)
            {
                //FlashThread = new Thread(FlashHandle);  //leon
               // FlashThread.Start();

                DoFlash();
                stopwatch.Start();
                log_flag = 0;
                if (checkBox1.Checked) LOGFLAG = 1;
                else LOGFLAG = 0;
            }

        }
        //解析刷新配置文件ini
        private void Read_Ini_File(string Filename)
        {
            if (File.Exists(@Filename))
            {
                Read_ini myIni = new Read_ini(Filename);
                FlashRequestID = myIni.ReadString("15765", "RequestID", "");
                FlashResponseID = myIni.ReadString("15765", "ResponseID", "");
                FuncAddr = myIni.ReadString("15765", "FunRequestID", "");
                ISO15765_BS = myIni.ReadString("15765", "ISO15765_BS", "");
                ISO15765_STMIN = myIni.ReadString("15765", "ISO15765_STMIN", "");

                TransTimeout = Int32.Parse(ISO15765_STMIN,System.Globalization.NumberStyles.HexNumber);
                TansmitBS = Int32.Parse(ISO15765_BS, System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                MessageBox.Show("缺少ini配置文件");
            }
            
        }

        //解析刷新配置文件csv
        private void Read_Csv_File(string filepath)
        {
            if (File.Exists(filepath))
            {
                string strpath = filepath; //csv文件的路径
                try
                {
                    string strID="";
                    int Line_index = 0;
                
                    string strline=""; 


                    StreamReader mysr = new StreamReader(strpath,System.Text.Encoding.Default);
                    while (Line_index < 80)
                    {
                        Line_index++;   //up row index is 80.
                        if (((strline = mysr.ReadLine()) != null))
                        {
                            if ((strline.Length>1) && (strline.Substring(0, 2) != "//"))
                            {
                               // aryline = strline.Split(new char[] { ';' });
                                strline=strline.ToLower().Trim();
                                strID = FlashRequestID;  //DEFAULT
                                //111
                                if (strline.IndexOf("setchecksum") == 0)
                                {
                                    //若为检测checksum的命令服务，在最后加上初始checksum DD DD DD DD
                                    if (strline.Contains(" ;"))
                                    {
                                        strline = strline.Insert(strline.IndexOf(";"), "DD DD DD DD");
                                    }
                                    else
                                    {
                                        strline = strline.Insert(strline.IndexOf(";"), " DD DD DD DD");
                                    }
                                    strline = strline.Substring(strline.IndexOf(")") + 1);
                                }
                                //222
                                if (strline.IndexOf("sendchecksum") == 0)
                                {
                                    if (strline.Contains(" ;"))
                                    {
                                        strline = strline.Insert(strline.IndexOf(";"), "EE EE EE EE");
                                    }
                                    else
                                    {
                                        strline = strline.Insert(strline.IndexOf(";"), " EE EE EE EE");
                                    }
                                    strline = strline.Substring(strline.IndexOf(")")+1);
                                }
                                //333
                                if (strline.IndexOf("sleep") == 0)
                                {
                                    if (strline.Contains(";"))
                                        strline = strline.Replace(";", "");
                                   // goto ReadLineCSV;
                                }

                                //444
                                if (strline.IndexOf("setsenddataparameter") == 0)
                                {
                                    if (strline.Contains(")"))
                                    {
                                        string Addr1 = "";
                                        string Addr2 = "";
                                        strline = strline.Split(')')[0] + ")";
                                        strline = strline.Replace("setsenddataparameter", "36");
                                        Addr1 = strline.Substring(strline.IndexOf("(")+1, strline.IndexOf(",") - strline.IndexOf("(")-1);
                                        Addr2 = strline.Substring(strline.IndexOf(",") + 1, strline.IndexOf(",", strline.IndexOf(",") + 1)- strline.IndexOf(",")-1);
                                        Max_Hex_Addr = Convert.ToUInt32(Addr1, 16) + Convert.ToUInt32(Addr2, 16);
                                   //     goto ReadLineCSV;
                                    }
                                    else
                                    {
                                        MessageBox.Show("请检查脚本语法");
                                        return;
                                    }

                                }
                                //555
                                if(strline.Contains(","))
                                {
                          //          strline = strline.Replace(",","");
                                }
                                //666
                                if (strline.Contains(";"))
                                {
                                    strline = strline.Replace(";", "=");
                                }
                                //777
                                if (strline.IndexOf("getchecksum") == 0)
                                {
                                    strline = strline.Replace("getchecksum","");
                                }
                                //888
                                if (strline.IndexOf("until") == 0)
                                {
                                    strline = strline.Substring(strline.IndexOf(" "));
                                }
                                //999
                                if (strline.IndexOf("config14230baudrate") == 0)
                                {
                                    strline = strline.Replace("config14230baudrate","");
                                }

                                //AAA
                                if (strline.Contains(")"))
                                {
                               //     strline = strline.Substring(strline.LastIndexOf(")")).Replace(")","");
                                }
                                //BBB
                                if (strline.Contains("="))
                                {
                                    if( strline.Substring(strline.LastIndexOf("=")).Replace("=", "").Trim()=="")
                                        strline=strline.Replace("=","");
                                    if(strline.Contains("= "))
                                        strline = strline.Replace("= ", "=");
                                }

                                if (strline.IndexOf("funreq") == 0)
                                {
                                    strID = FuncAddr;
                                    strline = strline.Replace("funreq", "");
                                }
                                if (strline.IndexOf("checksoftwareversion") == 0)
                                {

                                }

                                if ((strline.IndexOf("seedandkey") == 0) && (strline.IndexOf("seedandkeypara")<0))
                                {
                                    continue;
                                }

                                if (strline.IndexOf("getseedandkeypara") == 0)
                                { 
                                
                                }
                                if (strline.IndexOf("seedandkeypara") == 0)
                                {
                                
                                }

                                if (strline.IndexOf("setkeys") == 0)
                                {
                                    strline = strline.Substring(strline.LastIndexOf("27"));                            
                                }

                                if (strline.IndexOf("fromecuchecksum") == 0)
                                {

                                }

                               // ReadLineCSV: strline = strline.Trim();
                                if (strline.Trim() != "")
                                {
                                    DataRow CommandRow;
                                    CommandRow = Flash_csv_table.NewRow();

                                    CommandRow[0] = ++sum;
                                    CommandRow[1] = strID.ToUpper().Trim();
                                    CommandRow[2] = strline.ToUpper().Trim();
                                    Flash_csv_table.Rows.Add(CommandRow);
                                }
                            }
                        }
                    }
                   // return true;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("缺少csv配置文件");
            }
        }

         private void SetFlashparam()
         {
             //SConfig_List config;
             //config.NumOfParams = 1;
             //config.ConfigPtr = new SConfig[3];
             //config.ConfigPtr[0].Parameter = (int)ConfigPara.ISO15765_STMIN;
             //config.ConfigPtr[0].Value = TransTimeout;
             //config.ConfigPtr[1].Parameter = (int)ConfigPara.ISO15765_BS;
             //config.ConfigPtr[1].Value = TansmitBS;
             //config.ConfigPtr[2].Parameter = (int)ConfigPara.DATA_RATE;
             //config.ConfigPtr[2].Value = 500000;

             //J2534Error = passThru1.SetConfig(channelId, config);
             J2534Error = passThru1.SetConfig(channelId, (int)ConfigPara.STMIN_TX, TransTimeout);
             J2534Error = passThru1.SetConfig(channelId, (int)ConfigPara.BS_TX, TansmitBS);

         }
        //解析hex
        public bool ReadHexFile(string fileName)
        {
            if (fileName == null || fileName.Trim() == "")  //文件存在
            {
                return false;
            }

            for (UInt32 kk = 0; kk < 0x1ffffff; kk++) szBin[kk] = 0xFF;

            using (FileStream fs = new FileStream(fileName, FileMode.Open))  //open file
            {
                 StreamReader HexReader = new StreamReader(fs);    //读取数据流
                string szLine = "";
              //  string szHex = "";
                int segAddr = 0;
                byte i = 0;
                byte j = 0;
                //byte[] szBin = new byte[Max_Hex_Addr];   //buff of the hex to Flash
                HexReader.BaseStream.Seek(0,SeekOrigin.Begin);//返回文件开头
                HexReader.DiscardBufferedData();   //正确返回开头
                while (true)
                {
                    szLine = HexReader.ReadLine();      //读取Hex中一行

                    if (szLine == null) { break; }          //读取完毕，退出
                    if (szLine.Substring(0, 1) == ":")    //判断首字符是”:”
                    {
                        if (szLine.Substring(1, 8) == "00000001") { break; }  //文件结束标识

                        if (szLine.Substring(7, 2) == "02")
                        {
                            segAddr = Int32.Parse(szLine.Substring(9, 4), System.Globalization.NumberStyles.HexNumber);
                            segAddr *= 16;
                        }
                        else if (szLine.Substring(7, 2) == "04")
                        {
                            segAddr = Int32.Parse(szLine.Substring(9, 4), System.Globalization.NumberStyles.HexNumber);
                            segAddr *= 65536;
                        }
                        else if (szLine.Substring(7, 2) == "00")
                        {
                            Int32 tmpAddr = Int32.Parse(szLine.Substring(3, 4), System.Globalization.NumberStyles.HexNumber);
                            int num = UInt16.Parse(szLine.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                            tmpAddr += segAddr;
                            j = 0;
                            for (i = 0; i < num; i++)
                            {
                                szBin[tmpAddr++] = (byte)Int16.Parse(szLine.Substring(j + 9, 2), System.Globalization.NumberStyles.HexNumber);
                                j += 2;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hex格式错误，请检查!","Error");
                        return false;
                    }
                }

                HexReader.Close();
            }
            return true;
        }
        //csv changed
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text !="")
            {
                Flash_csv_table.Clear();
                sum = 0;
                //解析刷新配置文件ini
                Read_Ini_File(str1 + @"\" + comboBox1.Text + @"\install.ini");

                //解析刷新配置文件csv
                Read_Csv_File(str1 +@"\" + comboBox1.Text + @"\Flash\flash.csv");
            }
        }
        private void DoFlash()
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void ConnectDevice()
        {

            passThru1.LoadLibrary(availableJ2534Devices[FlashDevice.SelectedIndex]);
            J2534Error = passThru1.Open(ref deviceId);

            if ((J2534Error == J2534Err.STATUS_NOERROR))
            {
                OpenADevice = ConnectIso15765(FlashRequestID, FlashResponseID);
                if (OpenADevice)
                {
                    //    timer1.Start();
                }
                else
                {
                    
                    MessageBox.Show("请检查设备连接！", "Error");
                }
            }
            else
            {
              //  OpenADevice = false;
                MessageBox.Show("请检查设备连接！", "Error");
            }
        }

        public bool ConnectIso15765(string RequestID, string ResponseID)
        {
            List<byte> value = new List<byte>();

            J2534Error = passThru1.Connect(deviceId, ProtocolID.ISO15765, ConnectFlag.NONE, BaudRate.ISO15765, ref channelId);
            if (J2534Err.STATUS_NOERROR != J2534Error)
            {
                return false;
            }

            PassThruMsg maskMsg = new PassThruMsg();
            PassThruMsg patternMsg = new PassThruMsg();
            PassThruMsg flowControlMsg = new PassThruMsg();

            byte i;
            for (i = 0; i < 1; i++)
            {
                maskMsg.ProtocolID = ProtocolID.ISO15765;
                maskMsg.TxFlags = TxFlag.ISO15765_FRAME_PAD;
                maskMsg.Data = new byte[] { 0xff, 0xff, 0xff, 0xff };  //4 "FF" for stand ID,5 "FF" for extend ID

                byte ReqID_1 = (byte)Convert.ToUInt16(RequestID.Trim().ToUpper().Substring(0, 1), 16);
                byte ReqID_2 = (byte)Convert.ToUInt16(RequestID.Trim().ToUpper().Substring(1, 2), 16);

                byte RespID_1 = (byte)Convert.ToUInt16(ResponseID.Trim().ToUpper().Substring(0, 1), 16);
                byte RespID_2 = (byte)Convert.ToUInt16(ResponseID.Trim().ToUpper().Substring(1, 2), 16);

                patternMsg.ProtocolID = ProtocolID.ISO15765;
                patternMsg.TxFlags = TxFlag.ISO15765_FRAME_PAD;
                patternMsg.Data = new byte[] { 0x00, 0x00, RespID_1, RespID_2 };

                flowControlMsg.ProtocolID = ProtocolID.ISO15765;
                flowControlMsg.TxFlags = TxFlag.ISO15765_FRAME_PAD;
                flowControlMsg.Data = new byte[] { 0x00, 0x00, ReqID_1, ReqID_2 };

                J2534Error = passThru1.StartMsgFilter(channelId, FilterType.FLOW_CONTROL_FILTER, ref maskMsg, ref patternMsg, ref flowControlMsg, ref filterId);
                if (J2534Err.STATUS_NOERROR != J2534Error)
                {
                    passThru1.Disconnect(channelId);
                    return false;
                }
            }
            return true;
        }

        public void Transmit_Message(string DID_REAL, string MessageToSend)
        {
            int DID = Convert.ToInt32(DID_REAL.Trim(), 16);
            string[] dataStr = MessageToSend.Trim().Split(' ');
            int[] byteStr = new int[dataStr.Length + 4];
            byteStr[0] = 0;
            byteStr[1] = 0;
            byteStr[2] = (byte)((int)DID / 256);
            byteStr[3] = (byte)((int)DID % 256);

            strDatebyte = "";
            for (int i = 0; i < dataStr.Length; i++)
            {
                byteStr[i + 4] = Convert.ToInt32(dataStr[i], 16);
            }

            PassThruMsg TxMsg = new PassThruMsg();
            TxMsg.ProtocolID = ProtocolID.ISO15765;   //SEND
            TxMsg.TxFlags = TxFlag.ISO15765_FRAME_PAD;

            TxMsg.Data = new byte[byteStr.Length];
            for (int i = 0; i < byteStr.Length; i++)
            {
                TxMsg.Data[i] = (byte)byteStr[i];
            }
            for (int i = 0; i < (TxMsg.Data.Length - 4); i++)
                strDatebyte += string.Format("{0:X2}", TxMsg.Data[i + 4]) + " ";

            passThru1.ClearRxBuffer(channelId);
            int numMsgs = 1;    //to be tested later
            J2534Error = (J2534Err)0x09;  //noerror in default.
            while (J2534Error == (J2534Err)0x09)  //ERR_TIMEOUT
            {
                J2534Error = passThru1.WriteMsgs(channelId, ref TxMsg, ref numMsgs, 0);  //transmit timout   TransTimeout
            }

            //test code
            if (J2534Error != 0 )
            {
                sum = 0;
            }
            sum= Flash_csv_table.Rows.Count;

            DataRow canRow;
            canRow = Flash_csv_table.NewRow();
            canRow[0] = ++sum;
            
            canRow[1] = DID_REAL.Trim();
            if (dataStr[0] == "36")
            {
                canRow[2] = MessageToSend.Substring(0,15)+"...";
            }
            else
                canRow[2] = MessageToSend;
            canRow[3] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Flash_csv_table.Rows.Add(canRow);

            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            if (LOGFLAG ==1 )    Write_To_log(canRow, "TX", MessageToSend);
        }

        private void Write_To_log(DataRow dataTable, string TxRxFlag, string message)
        {
            if (log_flag==0)
            {
                log_flag = 1;
                FileStream fs = new FileStream(LOG_Addr, FileMode.Create, FileAccess.Write, FileShare.Read);
                StreamWriter writer0 = new StreamWriter(fs, Encoding.UTF8);
                writer0.WriteLine("Step:     Dir:      ID:       Data:                    Time:");
                writer0.Flush(); // 使得所有缓冲的数据都写入到文件中
                fs.Close(); // 方法关闭当前文件流
            }

            try
            {
                using (FileStream stream = new FileStream(LOG_Addr, FileMode.Append, FileAccess.Write, FileShare.Read))
                {
                    string str1 = dataTable[0].ToString().PadRight(10,' ');
                    str1 += TxRxFlag.PadRight(10, ' ');
                    str1 += dataTable[1].ToString().PadRight(10, ' ');
                    int tmpLen;
                    StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
                    tmpLen = message.Trim().Length;
                    if (message.Trim().Length > 20)
                    {
                        str1 += message.Substring(0, 20).ToString().PadRight(25, ' ');
                        str1 += dataTable[3].ToString().PadRight(25, ' ');
                        writer.WriteLine(str1+"\n");
                        while (tmpLen > 0)
                        {
                            if (tmpLen > 20)
                            {
                                tmpLen -= 21;
                                str1 = string.Empty.PadLeft(30, ' ') + message.Substring(message.Trim().Length - tmpLen, 20).ToString().PadRight(25, ' ');
                            }
                            else
                            {
                                str1 = string.Empty.PadLeft(30, ' ') + message.Substring(message.Trim().Length - tmpLen, tmpLen).ToString().PadRight(25, ' ');
                                tmpLen = 0;//watch out here!
                            }
                            writer.WriteLine(str1);
                            writer.Flush();//!!!
                        }
                    }
                    else
                    {
                        str1 += message.PadRight(25, ' ');
                        str1 += dataTable[3].ToString().PadRight(25, ' ');
                        writer.WriteLine(str1);
                        writer.Flush();
                    }
                }
            }
            catch
            {
            }


        }

        UInt32 CRCInitRem = 0xFFFFFFFF;

        static UInt32[] CRC32_Table_2 = new UInt32[256]{
        0x00000000,0x77073096,0xee0e612c,0x990951ba,0x76dc419,0x706af48f,0xe963a535,0x9e6495a3,
        0xedb8832,0x79dcb8a4,0xe0d5e91e,0x97d2d988,0x9b64c2b,0x7eb17cbd,0xe7b82d07,0x90bf1d91,
        0x1db71064,0x6ab020f2,0xf3b97148,0x84be41de,0x1adad47d,0x6ddde4eb,0xf4d4b551,0x83d385c7,
        0x136c9856,0x646ba8c0,0xfd62f97a,0x8a65c9ec,0x14015c4f,0x63066cd9,0xfa0f3d63,0x8d080df5,
        0x3b6e20c8,0x4c69105e,0xd56041e4,0xa2677172,0x3c03e4d1,0x4b04d447,0xd20d85fd,0xa50ab56b,
        0x35b5a8fa,0x42b2986c,0xdbbbc9d6,0xacbcf940,0x32d86ce3,0x45df5c75,0xdcd60dcf,0xabd13d59,
        0x26d930ac,0x51de003a,0xc8d75180,0xbfd06116,0x21b4f4b5,0x56b3c423,0xcfba9599,0xb8bda50f,
        0x2802b89e,0x5f058808,0xc60cd9b2,0xb10be924,0x2f6f7c87,0x58684c11,0xc1611dab,0xb6662d3d,
        0x76dc4190,0x1db7106,0x98d220bc,0xefd5102a,0x71b18589,0x6b6b51f,0x9fbfe4a5,0xe8b8d433,
        0x7807c9a2,0xf00f934,0x9609a88e,0xe10e9818,0x7f6a0dbb,0x86d3d2d,0x91646c97,0xe6635c01,
        0x6b6b51f4,0x1c6c6162,0x856530d8,0xf262004e,0x6c0695ed,0x1b01a57b,0x8208f4c1,0xf50fc457,
        0x65b0d9c6,0x12b7e950,0x8bbeb8ea,0xfcb9887c,0x62dd1ddf,0x15da2d49,0x8cd37cf3,0xfbd44c65,
        0x4db26158,0x3ab551ce,0xa3bc0074,0xd4bb30e2,0x4adfa541,0x3dd895d7,0xa4d1c46d,0xd3d6f4fb,
        0x4369e96a,0x346ed9fc,0xad678846,0xda60b8d0,0x44042d73,0x33031de5,0xaa0a4c5f,0xdd0d7cc9,
        0x5005713c,0x270241aa,0xbe0b1010,0xc90c2086,0x5768b525,0x206f85b3,0xb966d409,0xce61e49f,
        0x5edef90e,0x29d9c998,0xb0d09822,0xc7d7a8b4,0x59b33d17,0x2eb40d81,0xb7bd5c3b,0xc0ba6cad,
        0xedb88320,0x9abfb3b6,0x3b6e20c,0x74b1d29a,0xead54739,0x9dd277af,0x4db2615,0x73dc1683,
        0xe3630b12,0x94643b84,0xd6d6a3e,0x7a6a5aa8,0xe40ecf0b,0x9309ff9d,0xa00ae27,0x7d079eb1,
        0xf00f9344,0x8708a3d2,0x1e01f268,0x6906c2fe,0xf762575d,0x806567cb,0x196c3671,0x6e6b06e7,
        0xfed41b76,0x89d32be0,0x10da7a5a,0x67dd4acc,0xf9b9df6f,0x8ebeeff9,0x17b7be43,0x60b08ed5,
        0xd6d6a3e8,0xa1d1937e,0x38d8c2c4,0x4fdff252,0xd1bb67f1,0xa6bc5767,0x3fb506dd,0x48b2364b,
        0xd80d2bda,0xaf0a1b4c,0x36034af6,0x41047a60,0xdf60efc3,0xa867df55,0x316e8eef,0x4669be79,
        0xcb61b38c,0xbc66831a,0x256fd2a0,0x5268e236,0xcc0c7795,0xbb0b4703,0x220216b9,0x5505262f,
        0xc5ba3bbe,0xb2bd0b28,0x2bb45a92,0x5cb36a04,0xc2d7ffa7,0xb5d0cf31,0x2cd99e8b,0x5bdeae1d,
        0x9b64c2b0,0xec63f226,0x756aa39c,0x26d930a,0x9c0906a9,0xeb0e363f,0x72076785,0x5005713,
        0x95bf4a82,0xe2b87a14,0x7bb12bae,0xcb61b38,0x92d28e9b,0xe5d5be0d,0x7cdcefb7,0xbdbdf21,
        0x86d3d2d4,0xf1d4e242,0x68ddb3f8,0x1fda836e,0x81be16cd,0xf6b9265b,0x6fb077e1,0x18b74777,
        0x88085ae6,0xff0f6a70,0x66063bca,0x11010b5c,0x8f659eff,0xf862ae69,0x616bffd3,0x166ccf45,
        0xa00ae278,0xd70dd2ee,0x4e048354,0x3903b3c2,0xa7672661,0xd06016f7,0x4969474d,0x3e6e77db,
        0xaed16a4a,0xd9d65adc,0x40df0b66,0x37d83bf0,0xa9bcae53,0xdebb9ec5,0x47b2cf7f,0x30b5ffe9,
        0xbdbdf21c,0xcabac28a,0x53b39330,0x24b4a3a6,0xbad03605,0xcdd70693,0x54de5729,0x23d967bf,
        0xb3667a2e,0xc4614ab8,0x5d681b02,0x2a6f2b94,0xb40bbe37,0xc30c8ea1,0x5a05df1b,0x2d02ef8d
        };

        private UInt32 GetCheckSum(UInt32 StartAddr, UInt32 StopAddr, byte type)
        {
              // UInt32 result;
               if (type == 0)
               {
                   for (UInt32 i = StartAddr; i <= StopAddr; i++)
                   {
                       UInt32 temp = (CRCInitRem ^ szBin[i]) & 0x000000FF;
                       CRCInitRem = ((CRCInitRem >> 8) & 0x00FFFFFF) ^ CRC32_Table_2[temp];
                   }
                   return CRCInitRem ^ 0xFFFFFFFF;
               }
               else if (type == 1)
               {
                   DllTest dllinvoke2 = new DllTest(CRC_DLL);   //实例化 或者satatic方法
                   CalcChecksum show2 = (CalcChecksum)dllinvoke2.Invoke("CalcChecksum", typeof(CalcChecksum));//InitFunction为需要执行的函数名
                   CRCInitRem = show2(ref szBin[StartAddr], StopAddr);
                   return ((UInt32)CRCInitRem);
               }
               else if (type == 2)
               {
                   UInt32 AddrTmp=StartAddr;
                   while (AddrTmp <= StopAddr)
                   {
                       CRCInitRem = CRCInitRem ^ (UInt32)(szBin[AddrTmp]);

                        for(byte i = 0; i < 8; i++)
                        {
                            if ((CRCInitRem & 1) >0)
                            {
                                CRCInitRem >>= 1;
                                CRCInitRem = CRCInitRem ^ (UInt32)0xEDB88320u;
                            }
                            else
                            {
                                CRCInitRem >>= 1;
                            }
                        }
                        AddrTmp++;
                   }
                   if (StartAddr == 0xc4ff80)
                   {
                       CRCInitRem = CRCInitRem ^ 0xffffffff;
                   }

                   if (StartAddr == 0xc0f000)
                   {
                       CRCInitRem = CRCInitRem ^ 0xffffffff;
                   }

                    return (~CRCInitRem);
                   
               }
               else
               {
                   return 0;
               }
        }
        bool sleepFlag = false;

        private void FlashHandle()
        {
            if (SendOk)
            {
                if (RowReadNow <= RowsTmp - 1)
                {
                    tmpDategrid = dategridebuff[RowReadNow, 2].Trim();

                    if (tmpDategrid.Contains("="))
                    {
                        send_receiv = tmpDategrid.Split('=');
                        if (send_receiv[0].IndexOf("27") == 0)
                        {
                            if (!SecurProg)
                            {
                                SendOk = true;
                                RowReadNow++;
                            }
                            else
                            {
                                SendOk = false;
                            }
                        }
                        else if (tmpDategrid.Contains("DD DD DD DD"))
                        {
                            string CRCBeginAddr = "";
                            string CRCEndAddr = "";
                            UInt32 CRC32 = 0;

                            if (send_receiv[0].Length > 36)   //SGMW  GW1.2
                            {
                                 CRCBeginAddr = send_receiv[0].Split(' ')[4] + send_receiv[0].Split(' ')[5] + send_receiv[0].Split(' ')[6] + send_receiv[0].Split(' ')[7];
                                 CRCEndAddr = send_receiv[0].Split(' ')[8] + send_receiv[0].Split(' ')[9] + send_receiv[0].Split(' ')[10] + send_receiv[0].Split(' ')[11];
                                 CRC32 = GetCheckSum(Convert.ToUInt32(CRCBeginAddr, 16), (Convert.ToUInt32(CRCEndAddr, 16)), 0);
                            }
                            else    //SGMW GW3.0
                            {
                                CRCBeginAddr = FlashAddrBegin;
                                CRCEndAddr = String.Format("{0:X}", (Convert.ToUInt32(CRCBeginAddr, 16) + Convert.ToUInt32(FlashBlockSize, 16)-1));
                                CRC32 = GetCheckSum(Convert.ToUInt32(CRCBeginAddr, 16), (Convert.ToUInt32(CRCEndAddr, 16)), 0);
                            }

                            string ss = Convert.ToString(CRC32, 16);
                            if (ss.Length < 8)
                            {
                                for (byte index1 = 0; index1 < 8 - ss.Length; index1++)
                                {
                                    ss = '0' + ss;
                                }
                            }
                            ss = ss.Insert(6, " ");
                            ss = ss.Insert(4, " ");
                            ss = ss.Insert(2, " ");
                            CRCInitRem = 0xFFFFFFFF;

                            // ss=ss.
                            Transmit_Message(dategridebuff[RowReadNow, 1], send_receiv[0].Replace("DD DD DD DD", ss.ToUpper()));
                            SendOk = false;
                        }
                        else if (tmpDategrid.Contains("EE EE EE EE"))
                        {
                            string CRCBeginAddr = FlashAddrBegin;
                            UInt32 CRC32 = GetCheckSum(Convert.ToUInt32(CRCBeginAddr, 16), (Convert.ToUInt32(FlashBlockSize, 16) - 1), 1);
                            string ss = Convert.ToString(CRC32, 16);
                            ss = ss.Insert(6, " ");
                            ss = ss.Insert(4, " ");
                            ss = ss.Insert(2, " ");
                            CRCInitRem = 0xFFFFFFFF;
                            // ss=ss.
                            Transmit_Message(dategridebuff[RowReadNow, 1], send_receiv[0].Replace("EE EE EE EE", ss.ToUpper()));
                            SendOk = false;
                        }
                        else
                        {
                            Transmit_Message(dategridebuff[RowReadNow, 1], send_receiv[0]);

                            SendOk = false;
                        }
                    }
                    else if (tmpDategrid.Contains("SLEEP"))
                    {
                        slep_time = Convert.ToInt16(tmpDategrid.Substring(tmpDategrid.IndexOf("(") + 1, tmpDategrid.IndexOf(")") - tmpDategrid.IndexOf("(") - 1), 10);
                        SendOk = false;
                        sleepFlag = true;
                        slep_timeTmp = 0;
                        RowReadNow++;
                    }
                    else if (tmpDategrid.IndexOf("27") == 0)
                    {
                        Transmit_Message(dategridebuff[RowReadNow, 1], tmpDategrid);
                        Seed_lv = tmpDategrid.Substring(3, 2);
                        SendOk = false;
                        RowReadNow++;
                    }
                    else if (tmpDategrid.IndexOf("36") == 0)
                    {
                        SendOk = false;
                        FlashProg = true;
                        FlashBlockIndex = 0;
                        tmpDategrid.Substring(tmpDategrid.IndexOf('(') + 1, tmpDategrid.IndexOf(',') - tmpDategrid.IndexOf('(') - 1);
                        FlashAddrBegin = tmpDategrid.Substring(tmpDategrid.IndexOf("(") + 1, tmpDategrid.IndexOf(",") - tmpDategrid.IndexOf("(") - 1);
                        FlashBlockSize = tmpDategrid.Substring(tmpDategrid.IndexOf(",") + 1, tmpDategrid.IndexOf(",", tmpDategrid.IndexOf(",") + 1) - tmpDategrid.IndexOf(",") - 1);
                        FlashEachTime = tmpDategrid.Substring(tmpDategrid.LastIndexOf(',') + 1, tmpDategrid.IndexOf(')') - tmpDategrid.LastIndexOf(',') - 1);

                        Flash36(FlashAddrBegin, FlashBlockSize, FlashEachTime);

                        RowReadNow++;
                    }
                    else if (tmpDategrid.Contains("EE EE EE EE"))
                    {

                        string CRCBeginAddr = FlashAddrBegin;
                        UInt32 CRC32 = GetCheckSum(Convert.ToUInt32(CRCBeginAddr, 16), (Convert.ToUInt32(CRCBeginAddr, 16)+Convert.ToUInt32(FlashBlockSize, 16) - 1), 2);
                        string ss = Convert.ToString(CRC32, 16);
                        ss = ss.Insert(6, " ");
                        ss = ss.Insert(4, " ");
                        ss = ss.Insert(2, " ");

                        // ss=ss.
                        Transmit_Message(dategridebuff[RowReadNow, 1], dategridebuff[RowReadNow,2].Replace("EE EE EE EE", ss.ToUpper()));
                        SendOk = false;
                        RowReadNow++;
                    }
                    else
                    {
                        SendOk = false;
                        Transmit_Message(dategridebuff[RowReadNow, 1], tmpDategrid);
                        RowReadNow++;
                    }

                }
                else
                {

                    //   OpenADevice = false;
                }
            }
            else
            {
                //receive
                if (sleepFlag && (slep_timeTmp < slep_time))
                {
                   // slep_timeTmp += timer1.Interval;
                    SendOk = false;
                }
                else
                {
                    if (sleepFlag)
                    {
                        sleepFlag = false;
                        SendOk = true;
                    }
                }
                List<PassThruMsg> rxMsgs = new List<PassThruMsg>();
                J2534Err status = J2534Err.STATUS_NOERROR;
                numMsgs = 10;//test line
                status = passThru1.ReadMsgs(channelId, ref rxMsgs, ref numMsgs, 0);
                int count = rxMsgs.Count;
                for (int k = 0; k < count; k++)
                {
                    string strDataID = "";
                    strDatebyte = "";
                    if (rxMsgs[k].Data.Length > 4)   //前四个字节是地址  //长帧回的第一帧猜测只是ID的4个字节
                    {
                        for (int i = 0; i < 4; i++)
                            strDataID += string.Format("{0:X2}", rxMsgs[k].Data[i]);   //转2个16进制表示的数字
                        if (strDataID.TrimStart('0') == FlashResponseID.ToUpper())
                        {
                            for (int i = 0; i < (rxMsgs[k].Data.Length - 4); i++)
                                strDatebyte += string.Format("{0:X2}", rxMsgs[k].Data[i + 4]) + " ";
                            if (status == J2534Err.STATUS_NOERROR)    //maybe no use
                            {

                                if (strDatebyte.Substring(0, 2) != "76")
                                {
                                    //   TimeSpan ts = new TimeSpan(DateTime.Now.Ticks);

                                    int rowindex = Flash_csv_table.Rows.Count;
                                    DataRow canRow;
                                    canRow = Flash_csv_table.NewRow();
                                    canRow[0] = rowindex + 1;
                                    canRow[1] = strDataID.TrimStart('0');
                                    canRow[2] = strDatebyte;
                                    canRow[3] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                                    Flash_csv_table.Rows.Add(canRow);
                                    Flash_csv_table.AcceptChanges();

                                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                                    if (LOGFLAG == 1) Write_To_log(canRow, "RX", strDatebyte);
                                }
                                if ((strDatebyte.Substring(0, 2) == "7F") && (strDatebyte.Substring(6, 2) != "78"))
                                {
                                    deviceClose();
                                    timer1.Enabled = false;
                                    timer2.Enabled = false;

                                    mstimer.Text = stopwatch.Elapsed.ToString();
                                    stopwatch.Reset();
                              //      FlashThread.Abort();

                                    VariableToDefault();
                                    SecurProg = false;
                                }
                                else if ((strDatebyte.Substring(0, 2) == "7F") && (strDatebyte.Substring(6, 2) == "78"))
                                {
                                    //SendOk = false;
                                }
                                else if (tmpDategrid.Contains("="))
                                {
                                    if (strDatebyte.IndexOf(send_receiv[1].Trim()) == 0)
                                    {
                                        RowReadNow++;
                                        SendOk = true;
                                    }
                                    else
                                    {
                                        deviceClose();
                                        timer1.Enabled = false;
                                        timer2.Enabled = false;
                                        VariableToDefault();
                                        SecurProg = false;
                                    }
                                }
                                else if ((strDatebyte.Substring(0, 2) == "67") && (Convert.ToInt16(strDatebyte.Substring(3, 2), 16) == (Convert.ToInt16(Seed_lv, 16))))
                                {
                                    Security_DLL(rxMsgs[k].Data);
                                    SecurProg = true;
                                }
                                else if ((strDatebyte.Substring(0, 2) == "67") && (Convert.ToInt16(strDatebyte.Substring(3, 2), 16) == (Convert.ToInt16(Seed_lv, 16) + 1)))
                                {
                                    RowReadNow++;
                                    SecurProg = false;
                                    SendOk = true;
                                }
                                else if (strDatebyte.Substring(0, 2) == "76")
                                {
                                    //using (FileStream stream = new FileStream(LOG_Addr, FileMode.Append, FileAccess.Write, FileShare.Read))
                                    //{
                                    //    int rowindex = Flash_csv_table.Rows.Count+1;

                                    //    string str1 = rowindex.ToString().PadRight(10, ' ');
                                    //    str1 += "RX".PadRight(10, ' ');
                                    //    str1 += strDataID.TrimStart('0').ToString().PadRight(10, ' ');
                                    //    StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);

                                    //    str1 += strDatebyte.PadRight(25, ' ');
                                    //    str1 += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff").PadRight(25, ' ');
                                    //    writer.WriteLine(str1);
                                    //    writer.Flush();
                                    //}

                                    Flash36(FlashAddrBegin, FlashBlockSize, FlashEachTime);
                                }
                                else
                                {
                                    SendOk = true;
                                }

                                //append this
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //send
            //ts = stopwatch.Elapsed;
            //label4.Text = string.Format("{0}:{1}:{2}:{3:D3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            FlashHandle();
            if (sleepFlag && (slep_timeTmp < slep_time))
            {
                slep_timeTmp += (timer1.Interval*10);
               // SendOk = false;
            }

                //label4.Text = timer1.Interval.ToString();
            //ts = stopwatch.Elapsed;
            //label5.Text = string.Format("{0}:{1}:{2}:{3:D3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        int FlashBlockIndex =0;

        private void Flash36( string FlashAddrBegin, string FlashBlockSize1,string FlashEachTime)
        {
            int FlashAddrBeginInt=Convert.ToInt32(FlashAddrBegin, 16);
            int FlashBlockSize1Int=Convert.ToInt32(FlashBlockSize1, 16);
            int FlashEachTimeInt=Convert.ToInt32(FlashEachTime, 16);
            strDatebyte = "";

            if ((FlashEachTimeInt * FlashBlockIndex) < FlashBlockSize1Int)
            {
                FlashBlockIndex++;
                strDatebyte += "36 " + string.Format("{0:X2}", FlashBlockIndex % 0x100)+" ";
                //       FlashBlockSize-=FlashEachTime;
                for (int i = 0; i < FlashEachTimeInt; i++)
                    strDatebyte += string.Format("{0:X2}", szBin[FlashAddrBeginInt + (FlashBlockIndex - 1) * FlashEachTimeInt + i]) + " ";
                Transmit_Message(dategridebuff[RowReadNow, 1], strDatebyte);
            }
            else if ((FlashEachTimeInt * FlashBlockIndex) >= FlashBlockSize1Int)
            { 
                //to be added
                FlashBlockIndex = 0;
                FlashProg = false;
                SendOk = true;
               // timer2.Enabled = false;
            }

        }
        private void Security_DLL(byte[] DataReceive)
        {
            byte[] key = new byte[4];
            byte[] seed = new byte[4];
            strDatebyte = "";

            for (int i = 0; i < 4; i++)
            {
                seed[i] = DataReceive[6 + i];
            }

            if (FLASH_DLL != "")
            {
                DllTest dllinvoke1 = new DllTest(FLASH_DLL);   //实例化 或者satatic方法
                doDllFunction1 show1;
                if(comboBox1.Text.Contains("517"))
                     show1 = (doDllFunction1)dllinvoke1.Invoke("CalcKeys1", typeof(doDllFunction1));//InitFunction为需要执行的函数名
                else 
                     show1 = (doDllFunction1)dllinvoke1.Invoke("CalcKeys", typeof(doDllFunction1));//InitFunction为需要执行的函数名
                show1(ref seed[0], ref key[0]);

                if(DataReceive[5] == (byte)(Convert.ToInt16(Seed_lv, 16)))
                {
                    strDatebyte += "27 ";
                    strDatebyte += string.Format("{0:X2}", Convert.ToInt16(Seed_lv, 16)+1)+" ";
                }

                for (int i = 0; i < 4; i++)
                    strDatebyte += string.Format("{0:X2}", key[i]) + " ";

                Transmit_Message(dategridebuff[RowReadNow, 1], strDatebyte);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ts=stopwatch.Elapsed;
            mstimer.Text = string.Format("{0}:{1}:{2}:{3:D3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            progressBar1.Value = RowReadNow;
            if (RowReadNow > RowsTmp - 1)
            {
                DataRow canRow;
                canRow = Flash_csv_table.NewRow();
                canRow[0] = 66666;
                canRow[1] = "";
                canRow[2] = "Bravo!!!";
                canRow[3] = "";
                Flash_csv_table.Rows.Add(canRow);

                timer2.Enabled = false;
                timer1.Enabled = false;
              //  FlashThread.Abort(); 
                stopwatch.Reset();
                deviceClose();
                VariableToDefault();
            }
         //   int beginIndex = dataGridView1.RowCount;
            //if (beginIndex < 10)
            //{

            //}
            //else
            //{
            //    dataGridView1.FirstDisplayedScrollingRowIndex = beginIndex-10;
            //}
            //Flash36(FlashAddrBegin, FlashBlockSize, FlashEachTime);
        }

        private void FlashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
            deviceClose();
            VariableToDefault();
        }
    }
}
