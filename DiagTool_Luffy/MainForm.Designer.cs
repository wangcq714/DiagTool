namespace DiagTool_Luffy
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainWinMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexTooTASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nRCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceConnectButton = new System.Windows.Forms.Button();
            this.DeviceSelectComboBox = new System.Windows.Forms.ComboBox();
            this.TestPresentTimer = new System.Windows.Forms.Timer(this.components);
            this.RxMsgTimer = new System.Windows.Forms.Timer(this.components);
            this.ClearButton = new System.Windows.Forms.Button();
            this.ReqIDTextBox = new System.Windows.Forms.TextBox();
            this.TxRxDataGridView = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Len = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripForDiagDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecurityAccessButton = new System.Windows.Forms.Button();
            this.TestPresentComboBox = new System.Windows.Forms.ComboBox();
            this.TestPresentCheckBox = new System.Windows.Forms.CheckBox();
            this.RxDataTextBox = new System.Windows.Forms.TextBox();
            this.SecurityAccessComboBox = new System.Windows.Forms.ComboBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.TxDataTextBox = new System.Windows.Forms.TextBox();
            this.ResIDTextBox = new System.Windows.Forms.TextBox();
            this.ReqIDLabel = new System.Windows.Forms.Label();
            this.ResIDLabel = new System.Windows.Forms.Label();
            this.LoopTextBox = new System.Windows.Forms.TextBox();
            this.LoopButton = new System.Windows.Forms.Button();
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MainWinTabControl = new System.Windows.Forms.TabControl();
            this.LogTabPage = new System.Windows.Forms.TabPage();
            this.DTCTabPage = new System.Windows.Forms.TabPage();
            this.RecordNumberLabel = new System.Windows.Forms.Label();
            this.FaultTypeLabel = new System.Windows.Forms.Label();
            this.LowByteLabel = new System.Windows.Forms.Label();
            this.HighByteLabel = new System.Windows.Forms.Label();
            this.DTCListLabel = new System.Windows.Forms.Label();
            this.Bit7Label = new System.Windows.Forms.Label();
            this.Bit6Label = new System.Windows.Forms.Label();
            this.Bit5Label = new System.Windows.Forms.Label();
            this.Bit4Label = new System.Windows.Forms.Label();
            this.Bit3Label = new System.Windows.Forms.Label();
            this.Bit2Label = new System.Windows.Forms.Label();
            this.Bit1Label = new System.Windows.Forms.Label();
            this.Bit0Label = new System.Windows.Forms.Label();
            this.DTCMasklabel = new System.Windows.Forms.Label();
            this.WarningIndicatorRequestedCheckBox = new System.Windows.Forms.CheckBox();
            this.TestNotCompletedThisMonitoringCycleCheckBox = new System.Windows.Forms.CheckBox();
            this.TestFailedSinceLastClearCheckBox = new System.Windows.Forms.CheckBox();
            this.TestNotCompletedSinceLastClearCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmedDTCCheckBox = new System.Windows.Forms.CheckBox();
            this.PendingDTCCheckBox = new System.Windows.Forms.CheckBox();
            this.TestFailedThisMonitoringCycleCheckBox = new System.Windows.Forms.CheckBox();
            this.TestFailedCheckBox = new System.Windows.Forms.CheckBox();
            this.RecordNumberTextBox = new System.Windows.Forms.TextBox();
            this.DTCFaultTypeTextBox = new System.Windows.Forms.TextBox();
            this.DTCLowByteTextBox = new System.Windows.Forms.TextBox();
            this.DTCHighByteTextBox = new System.Windows.Forms.TextBox();
            this.ReadDTCComboBox = new System.Windows.Forms.ComboBox();
            this.ReadDTCButton = new System.Windows.Forms.Button();
            this.DTCDisplayTextBox = new System.Windows.Forms.TextBox();
            this.MainWinMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxRxDataGridView)).BeginInit();
            this.ContextMenuStripForDiagDataGridView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MainWinTabControl.SuspendLayout();
            this.LogTabPage.SuspendLayout();
            this.DTCTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWinMenuStrip
            // 
            this.MainWinMenuStrip.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWinMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainWinMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainWinMenuStrip.Name = "MainWinMenuStrip";
            this.MainWinMenuStrip.Size = new System.Drawing.Size(734, 24);
            this.MainWinMenuStrip.TabIndex = 0;
            this.MainWinMenuStrip.Text = "MainWinMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.SettingToolStripMenuItem.Text = "Setting";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexTooTASCIIToolStripMenuItem,
            this.nRCToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // hexTooTASCIIToolStripMenuItem
            // 
            this.hexTooTASCIIToolStripMenuItem.Name = "hexTooTASCIIToolStripMenuItem";
            this.hexTooTASCIIToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.hexTooTASCIIToolStripMenuItem.Text = "HexToASCII";
            this.hexTooTASCIIToolStripMenuItem.Click += new System.EventHandler(this.hexTooTASCIIToolStripMenuItem_Click);
            // 
            // nRCToolStripMenuItem
            // 
            this.nRCToolStripMenuItem.Name = "nRCToolStripMenuItem";
            this.nRCToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nRCToolStripMenuItem.Text = "NRC Table";
            this.nRCToolStripMenuItem.Click += new System.EventHandler(this.nRCToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // DeviceConnectButton
            // 
            this.DeviceConnectButton.BackColor = System.Drawing.Color.White;
            this.DeviceConnectButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceConnectButton.ForeColor = System.Drawing.Color.White;
            this.DeviceConnectButton.Location = new System.Drawing.Point(199, 37);
            this.DeviceConnectButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeviceConnectButton.Name = "DeviceConnectButton";
            this.DeviceConnectButton.Size = new System.Drawing.Size(22, 22);
            this.DeviceConnectButton.TabIndex = 69;
            this.DeviceConnectButton.UseVisualStyleBackColor = false;
            this.DeviceConnectButton.Click += new System.EventHandler(this.DeviceConnectButton_Click);
            // 
            // DeviceSelectComboBox
            // 
            this.DeviceSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceSelectComboBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceSelectComboBox.FormattingEnabled = true;
            this.DeviceSelectComboBox.Location = new System.Drawing.Point(19, 37);
            this.DeviceSelectComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeviceSelectComboBox.Name = "DeviceSelectComboBox";
            this.DeviceSelectComboBox.Size = new System.Drawing.Size(178, 22);
            this.DeviceSelectComboBox.TabIndex = 68;
            // 
            // TestPresentTimer
            // 
            this.TestPresentTimer.Interval = 2000;
            this.TestPresentTimer.Tick += new System.EventHandler(this.TestPresentTimer_Tick);
            // 
            // RxMsgTimer
            // 
            this.RxMsgTimer.Interval = 100;
            this.RxMsgTimer.Tick += new System.EventHandler(this.RxMsgTimer_Tick);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(664, 90);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(45, 22);
            this.ClearButton.TabIndex = 66;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ReqIDTextBox
            // 
            this.ReqIDTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqIDTextBox.Location = new System.Drawing.Point(271, 37);
            this.ReqIDTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReqIDTextBox.Name = "ReqIDTextBox";
            this.ReqIDTextBox.Size = new System.Drawing.Size(35, 22);
            this.ReqIDTextBox.TabIndex = 65;
            this.ReqIDTextBox.Text = "710";
            this.ReqIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxRxDataGridView
            // 
            this.TxRxDataGridView.AllowUserToAddRows = false;
            this.TxRxDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TxRxDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TxRxDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TxRxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TxRxDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Type,
            this.ID,
            this.Len,
            this.Data,
            this.TimeStamp});
            this.TxRxDataGridView.ContextMenuStrip = this.ContextMenuStripForDiagDataGridView;
            this.TxRxDataGridView.Location = new System.Drawing.Point(0, 5);
            this.TxRxDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxRxDataGridView.Name = "TxRxDataGridView";
            this.TxRxDataGridView.ReadOnly = true;
            this.TxRxDataGridView.RowHeadersVisible = false;
            this.TxRxDataGridView.RowTemplate.Height = 20;
            this.TxRxDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TxRxDataGridView.Size = new System.Drawing.Size(478, 289);
            this.TxRxDataGridView.TabIndex = 64;
            this.TxRxDataGridView.DoubleClick += new System.EventHandler(this.TxRxDataGridView_DoubleClick);
            // 
            // Num
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.DefaultCellStyle = dataGridViewCellStyle2;
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Num.Width = 40;
            // 
            // Type
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.DefaultCellStyle = dataGridViewCellStyle3;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 35;
            // 
            // ID
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // Len
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Len.DefaultCellStyle = dataGridViewCellStyle5;
            this.Len.HeaderText = "Len";
            this.Len.Name = "Len";
            this.Len.ReadOnly = true;
            this.Len.Width = 35;
            // 
            // Data
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 180;
            // 
            // TimeStamp
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStamp.DefaultCellStyle = dataGridViewCellStyle7;
            this.TimeStamp.HeaderText = "TimeStamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            this.TimeStamp.Width = 130;
            // 
            // ContextMenuStripForDiagDataGridView
            // 
            this.ContextMenuStripForDiagDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.ContextMenuStripForDiagDataGridView.Name = "ContextMenuStripForDiagDataGridView";
            this.ContextMenuStripForDiagDataGridView.Size = new System.Drawing.Size(107, 48);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SecurityAccessButton
            // 
            this.SecurityAccessButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityAccessButton.Location = new System.Drawing.Point(664, 37);
            this.SecurityAccessButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SecurityAccessButton.Name = "SecurityAccessButton";
            this.SecurityAccessButton.Size = new System.Drawing.Size(45, 22);
            this.SecurityAccessButton.TabIndex = 63;
            this.SecurityAccessButton.Text = "Secu";
            this.SecurityAccessButton.UseVisualStyleBackColor = true;
            this.SecurityAccessButton.Click += new System.EventHandler(this.SecurityAccessButton_Click);
            // 
            // TestPresentComboBox
            // 
            this.TestPresentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestPresentComboBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPresentComboBox.FormattingEnabled = true;
            this.TestPresentComboBox.Items.AddRange(new object[] {
            "3E 80",
            "3E 00"});
            this.TestPresentComboBox.Location = new System.Drawing.Point(531, 38);
            this.TestPresentComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestPresentComboBox.Name = "TestPresentComboBox";
            this.TestPresentComboBox.Size = new System.Drawing.Size(50, 20);
            this.TestPresentComboBox.TabIndex = 61;
            // 
            // TestPresentCheckBox
            // 
            this.TestPresentCheckBox.Checked = true;
            this.TestPresentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TestPresentCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPresentCheckBox.Location = new System.Drawing.Point(509, 37);
            this.TestPresentCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestPresentCheckBox.Name = "TestPresentCheckBox";
            this.TestPresentCheckBox.Size = new System.Drawing.Size(22, 22);
            this.TestPresentCheckBox.TabIndex = 60;
            this.TestPresentCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TestPresentCheckBox.UseVisualStyleBackColor = true;
            // 
            // RxDataTextBox
            // 
            this.RxDataTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RxDataTextBox.Location = new System.Drawing.Point(223, 91);
            this.RxDataTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RxDataTextBox.Name = "RxDataTextBox";
            this.RxDataTextBox.Size = new System.Drawing.Size(437, 22);
            this.RxDataTextBox.TabIndex = 58;
            // 
            // SecurityAccessComboBox
            // 
            this.SecurityAccessComboBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityAccessComboBox.FormattingEnabled = true;
            this.SecurityAccessComboBox.Items.AddRange(new object[] {
            "01/02",
            "03/04",
            "05/06",
            "07/08",
            "09/0A",
            "11/12",
            "13/14"});
            this.SecurityAccessComboBox.Location = new System.Drawing.Point(605, 38);
            this.SecurityAccessComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SecurityAccessComboBox.Name = "SecurityAccessComboBox";
            this.SecurityAccessComboBox.Size = new System.Drawing.Size(55, 20);
            this.SecurityAccessComboBox.TabIndex = 62;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(664, 62);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(45, 22);
            this.SendButton.TabIndex = 56;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // TxDataTextBox
            // 
            this.TxDataTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDataTextBox.Location = new System.Drawing.Point(223, 63);
            this.TxDataTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxDataTextBox.Name = "TxDataTextBox";
            this.TxDataTextBox.Size = new System.Drawing.Size(437, 22);
            this.TxDataTextBox.TabIndex = 55;
            this.TxDataTextBox.Text = "10 03";
            this.TxDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReqIDTextBox_EnterKeyPress);
            // 
            // ResIDTextBox
            // 
            this.ResIDTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResIDTextBox.Location = new System.Drawing.Point(363, 37);
            this.ResIDTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResIDTextBox.Name = "ResIDTextBox";
            this.ResIDTextBox.Size = new System.Drawing.Size(35, 22);
            this.ResIDTextBox.TabIndex = 54;
            this.ResIDTextBox.Text = "718";
            this.ResIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReqIDLabel
            // 
            this.ReqIDLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqIDLabel.Location = new System.Drawing.Point(225, 37);
            this.ReqIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReqIDLabel.Name = "ReqIDLabel";
            this.ReqIDLabel.Size = new System.Drawing.Size(40, 22);
            this.ReqIDLabel.TabIndex = 52;
            this.ReqIDLabel.Text = "ReqID";
            this.ReqIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResIDLabel
            // 
            this.ResIDLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResIDLabel.Location = new System.Drawing.Point(318, 37);
            this.ResIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResIDLabel.Name = "ResIDLabel";
            this.ResIDLabel.Size = new System.Drawing.Size(40, 22);
            this.ResIDLabel.TabIndex = 53;
            this.ResIDLabel.Text = "ResID";
            this.ResIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoopTextBox
            // 
            this.LoopTextBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopTextBox.Location = new System.Drawing.Point(54, 24);
            this.LoopTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoopTextBox.Name = "LoopTextBox";
            this.LoopTextBox.Size = new System.Drawing.Size(25, 19);
            this.LoopTextBox.TabIndex = 74;
            this.LoopTextBox.Text = "1";
            // 
            // LoopButton
            // 
            this.LoopButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopButton.Location = new System.Drawing.Point(11, 24);
            this.LoopButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.Size = new System.Drawing.Size(35, 19);
            this.LoopButton.TabIndex = 73;
            this.LoopButton.Text = "Loop";
            this.LoopButton.UseVisualStyleBackColor = true;
            this.LoopButton.Click += new System.EventHandler(this.LoopButton_Click);
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopCheckBox.Location = new System.Drawing.Point(86, 25);
            this.LoopCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(45, 16);
            this.LoopCheckBox.TabIndex = 72;
            this.LoopCheckBox.Text = "Loop";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(130, 24);
            this.RunButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(35, 19);
            this.RunButton.TabIndex = 71;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(11, 54);
            this.ScriptTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ScriptTextBox.Multiline = true;
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Size = new System.Drawing.Size(154, 307);
            this.ScriptTextBox.TabIndex = 70;
            this.ScriptTextBox.Text = "10 03\r\n27 01\r\n27 02=67 02";
            this.ScriptTextBox.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoopTextBox);
            this.groupBox1.Controls.Add(this.LoopButton);
            this.groupBox1.Controls.Add(this.LoopCheckBox);
            this.groupBox1.Controls.Add(this.RunButton);
            this.groupBox1.Controls.Add(this.ScriptTextBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 367);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script";
            // 
            // MainWinTabControl
            // 
            this.MainWinTabControl.Controls.Add(this.LogTabPage);
            this.MainWinTabControl.Controls.Add(this.DTCTabPage);
            this.MainWinTabControl.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWinTabControl.Location = new System.Drawing.Point(223, 122);
            this.MainWinTabControl.Name = "MainWinTabControl";
            this.MainWinTabControl.SelectedIndex = 0;
            this.MainWinTabControl.Size = new System.Drawing.Size(490, 327);
            this.MainWinTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainWinTabControl.TabIndex = 80;
            // 
            // LogTabPage
            // 
            this.LogTabPage.Controls.Add(this.TxRxDataGridView);
            this.LogTabPage.Location = new System.Drawing.Point(4, 23);
            this.LogTabPage.Name = "LogTabPage";
            this.LogTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogTabPage.Size = new System.Drawing.Size(482, 300);
            this.LogTabPage.TabIndex = 0;
            this.LogTabPage.Text = "Log";
            this.LogTabPage.UseVisualStyleBackColor = true;
            // 
            // DTCTabPage
            // 
            this.DTCTabPage.Controls.Add(this.RecordNumberLabel);
            this.DTCTabPage.Controls.Add(this.FaultTypeLabel);
            this.DTCTabPage.Controls.Add(this.LowByteLabel);
            this.DTCTabPage.Controls.Add(this.HighByteLabel);
            this.DTCTabPage.Controls.Add(this.DTCListLabel);
            this.DTCTabPage.Controls.Add(this.Bit7Label);
            this.DTCTabPage.Controls.Add(this.Bit6Label);
            this.DTCTabPage.Controls.Add(this.Bit5Label);
            this.DTCTabPage.Controls.Add(this.Bit4Label);
            this.DTCTabPage.Controls.Add(this.Bit3Label);
            this.DTCTabPage.Controls.Add(this.Bit2Label);
            this.DTCTabPage.Controls.Add(this.Bit1Label);
            this.DTCTabPage.Controls.Add(this.Bit0Label);
            this.DTCTabPage.Controls.Add(this.DTCMasklabel);
            this.DTCTabPage.Controls.Add(this.WarningIndicatorRequestedCheckBox);
            this.DTCTabPage.Controls.Add(this.TestNotCompletedThisMonitoringCycleCheckBox);
            this.DTCTabPage.Controls.Add(this.TestFailedSinceLastClearCheckBox);
            this.DTCTabPage.Controls.Add(this.TestNotCompletedSinceLastClearCheckBox);
            this.DTCTabPage.Controls.Add(this.ConfirmedDTCCheckBox);
            this.DTCTabPage.Controls.Add(this.PendingDTCCheckBox);
            this.DTCTabPage.Controls.Add(this.TestFailedThisMonitoringCycleCheckBox);
            this.DTCTabPage.Controls.Add(this.TestFailedCheckBox);
            this.DTCTabPage.Controls.Add(this.RecordNumberTextBox);
            this.DTCTabPage.Controls.Add(this.DTCFaultTypeTextBox);
            this.DTCTabPage.Controls.Add(this.DTCLowByteTextBox);
            this.DTCTabPage.Controls.Add(this.DTCHighByteTextBox);
            this.DTCTabPage.Controls.Add(this.ReadDTCComboBox);
            this.DTCTabPage.Controls.Add(this.ReadDTCButton);
            this.DTCTabPage.Controls.Add(this.DTCDisplayTextBox);
            this.DTCTabPage.Location = new System.Drawing.Point(4, 23);
            this.DTCTabPage.Name = "DTCTabPage";
            this.DTCTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DTCTabPage.Size = new System.Drawing.Size(482, 300);
            this.DTCTabPage.TabIndex = 1;
            this.DTCTabPage.Text = "DTC";
            this.DTCTabPage.UseVisualStyleBackColor = true;
            // 
            // RecordNumberLabel
            // 
            this.RecordNumberLabel.AutoSize = true;
            this.RecordNumberLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordNumberLabel.Location = new System.Drawing.Point(313, 12);
            this.RecordNumberLabel.Name = "RecordNumberLabel";
            this.RecordNumberLabel.Size = new System.Drawing.Size(22, 14);
            this.RecordNumberLabel.TabIndex = 57;
            this.RecordNumberLabel.Text = "RN";
            // 
            // FaultTypeLabel
            // 
            this.FaultTypeLabel.AutoSize = true;
            this.FaultTypeLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaultTypeLabel.Location = new System.Drawing.Point(285, 12);
            this.FaultTypeLabel.Name = "FaultTypeLabel";
            this.FaultTypeLabel.Size = new System.Drawing.Size(20, 14);
            this.FaultTypeLabel.TabIndex = 56;
            this.FaultTypeLabel.Text = "FT";
            // 
            // LowByteLabel
            // 
            this.LowByteLabel.AutoSize = true;
            this.LowByteLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowByteLabel.Location = new System.Drawing.Point(257, 12);
            this.LowByteLabel.Name = "LowByteLabel";
            this.LowByteLabel.Size = new System.Drawing.Size(20, 14);
            this.LowByteLabel.TabIndex = 55;
            this.LowByteLabel.Text = "LB";
            // 
            // HighByteLabel
            // 
            this.HighByteLabel.AutoSize = true;
            this.HighByteLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighByteLabel.Location = new System.Drawing.Point(226, 12);
            this.HighByteLabel.Name = "HighByteLabel";
            this.HighByteLabel.Size = new System.Drawing.Size(22, 14);
            this.HighByteLabel.TabIndex = 54;
            this.HighByteLabel.Text = "HB";
            // 
            // DTCListLabel
            // 
            this.DTCListLabel.AutoSize = true;
            this.DTCListLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTCListLabel.Location = new System.Drawing.Point(21, 12);
            this.DTCListLabel.Name = "DTCListLabel";
            this.DTCListLabel.Size = new System.Drawing.Size(50, 14);
            this.DTCListLabel.TabIndex = 53;
            this.DTCListLabel.Text = "DTCList:";
            // 
            // Bit7Label
            // 
            this.Bit7Label.AutoSize = true;
            this.Bit7Label.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit7Label.Location = new System.Drawing.Point(151, 239);
            this.Bit7Label.Name = "Bit7Label";
            this.Bit7Label.Size = new System.Drawing.Size(31, 14);
            this.Bit7Label.TabIndex = 52;
            this.Bit7Label.Text = "Bit7:";
            // 
            // Bit6Label
            // 
            this.Bit6Label.AutoSize = true;
            this.Bit6Label.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit6Label.Location = new System.Drawing.Point(151, 222);
            this.Bit6Label.Name = "Bit6Label";
            this.Bit6Label.Size = new System.Drawing.Size(31, 14);
            this.Bit6Label.TabIndex = 51;
            this.Bit6Label.Text = "Bit6:";
            // 
            // Bit5Label
            // 
            this.Bit5Label.AutoSize = true;
            this.Bit5Label.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit5Label.Location = new System.Drawing.Point(151, 205);
            this.Bit5Label.Name = "Bit5Label";
            this.Bit5Label.Size = new System.Drawing.Size(31, 14);
            this.Bit5Label.TabIndex = 50;
            this.Bit5Label.Text = "Bit5:";
            // 
            // Bit4Label
            // 
            this.Bit4Label.AutoSize = true;
            this.Bit4Label.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit4Label.Location = new System.Drawing.Point(151, 188);
            this.Bit4Label.Name = "Bit4Label";
            this.Bit4Label.Size = new System.Drawing.Size(31, 14);
            this.Bit4Label.TabIndex = 49;
            this.Bit4Label.Text = "Bit4:";
            // 
            // Bit3Label
            // 
            this.Bit3Label.AutoSize = true;
            this.Bit3Label.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit3Label.Location = new System.Drawing.Point(151, 171);
            this.Bit3Label.Name = "Bit3Label";
            this.Bit3Label.Size = new System.Drawing.Size(31, 14);
            this.Bit3Label.TabIndex = 48;
            this.Bit3Label.Text = "Bit3:";
            // 
            // Bit2Label
            // 
            this.Bit2Label.AutoSize = true;
            this.Bit2Label.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit2Label.Location = new System.Drawing.Point(151, 154);
            this.Bit2Label.Name = "Bit2Label";
            this.Bit2Label.Size = new System.Drawing.Size(31, 14);
            this.Bit2Label.TabIndex = 47;
            this.Bit2Label.Text = "Bit2:";
            // 
            // Bit1Label
            // 
            this.Bit1Label.AutoSize = true;
            this.Bit1Label.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit1Label.Location = new System.Drawing.Point(151, 137);
            this.Bit1Label.Name = "Bit1Label";
            this.Bit1Label.Size = new System.Drawing.Size(31, 14);
            this.Bit1Label.TabIndex = 46;
            this.Bit1Label.Text = "Bit1:";
            // 
            // Bit0Label
            // 
            this.Bit0Label.AutoSize = true;
            this.Bit0Label.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit0Label.Location = new System.Drawing.Point(151, 120);
            this.Bit0Label.Name = "Bit0Label";
            this.Bit0Label.Size = new System.Drawing.Size(31, 14);
            this.Bit0Label.TabIndex = 45;
            this.Bit0Label.Text = "Bit0:";
            // 
            // DTCMasklabel
            // 
            this.DTCMasklabel.AutoSize = true;
            this.DTCMasklabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTCMasklabel.Location = new System.Drawing.Point(151, 103);
            this.DTCMasklabel.Name = "DTCMasklabel";
            this.DTCMasklabel.Size = new System.Drawing.Size(37, 14);
            this.DTCMasklabel.TabIndex = 44;
            this.DTCMasklabel.Text = "Mask:";
            // 
            // WarningIndicatorRequestedCheckBox
            // 
            this.WarningIndicatorRequestedCheckBox.AutoSize = true;
            this.WarningIndicatorRequestedCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningIndicatorRequestedCheckBox.Location = new System.Drawing.Point(192, 239);
            this.WarningIndicatorRequestedCheckBox.Name = "WarningIndicatorRequestedCheckBox";
            this.WarningIndicatorRequestedCheckBox.Size = new System.Drawing.Size(175, 18);
            this.WarningIndicatorRequestedCheckBox.TabIndex = 43;
            this.WarningIndicatorRequestedCheckBox.Text = "Warning indicator requested";
            this.WarningIndicatorRequestedCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestNotCompletedThisMonitoringCycleCheckBox
            // 
            this.TestNotCompletedThisMonitoringCycleCheckBox.AutoSize = true;
            this.TestNotCompletedThisMonitoringCycleCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNotCompletedThisMonitoringCycleCheckBox.Location = new System.Drawing.Point(192, 222);
            this.TestNotCompletedThisMonitoringCycleCheckBox.Name = "TestNotCompletedThisMonitoringCycleCheckBox";
            this.TestNotCompletedThisMonitoringCycleCheckBox.Size = new System.Drawing.Size(234, 18);
            this.TestNotCompletedThisMonitoringCycleCheckBox.TabIndex = 42;
            this.TestNotCompletedThisMonitoringCycleCheckBox.Text = "Test not completed this monitoring cycle";
            this.TestNotCompletedThisMonitoringCycleCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestFailedSinceLastClearCheckBox
            // 
            this.TestFailedSinceLastClearCheckBox.AutoSize = true;
            this.TestFailedSinceLastClearCheckBox.Checked = true;
            this.TestFailedSinceLastClearCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TestFailedSinceLastClearCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestFailedSinceLastClearCheckBox.Location = new System.Drawing.Point(192, 205);
            this.TestFailedSinceLastClearCheckBox.Name = "TestFailedSinceLastClearCheckBox";
            this.TestFailedSinceLastClearCheckBox.Size = new System.Drawing.Size(157, 18);
            this.TestFailedSinceLastClearCheckBox.TabIndex = 41;
            this.TestFailedSinceLastClearCheckBox.Text = "Test failed since last clear";
            this.TestFailedSinceLastClearCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestNotCompletedSinceLastClearCheckBox
            // 
            this.TestNotCompletedSinceLastClearCheckBox.AutoSize = true;
            this.TestNotCompletedSinceLastClearCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNotCompletedSinceLastClearCheckBox.Location = new System.Drawing.Point(192, 188);
            this.TestNotCompletedSinceLastClearCheckBox.Name = "TestNotCompletedSinceLastClearCheckBox";
            this.TestNotCompletedSinceLastClearCheckBox.Size = new System.Drawing.Size(202, 18);
            this.TestNotCompletedSinceLastClearCheckBox.TabIndex = 40;
            this.TestNotCompletedSinceLastClearCheckBox.Text = "Test not completed since last clear";
            this.TestNotCompletedSinceLastClearCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmedDTCCheckBox
            // 
            this.ConfirmedDTCCheckBox.AutoSize = true;
            this.ConfirmedDTCCheckBox.Checked = true;
            this.ConfirmedDTCCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConfirmedDTCCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmedDTCCheckBox.Location = new System.Drawing.Point(192, 171);
            this.ConfirmedDTCCheckBox.Name = "ConfirmedDTCCheckBox";
            this.ConfirmedDTCCheckBox.Size = new System.Drawing.Size(106, 18);
            this.ConfirmedDTCCheckBox.TabIndex = 39;
            this.ConfirmedDTCCheckBox.Text = "Confirmed DTC";
            this.ConfirmedDTCCheckBox.UseVisualStyleBackColor = true;
            // 
            // PendingDTCCheckBox
            // 
            this.PendingDTCCheckBox.AutoSize = true;
            this.PendingDTCCheckBox.Checked = true;
            this.PendingDTCCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PendingDTCCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingDTCCheckBox.Location = new System.Drawing.Point(192, 154);
            this.PendingDTCCheckBox.Name = "PendingDTCCheckBox";
            this.PendingDTCCheckBox.Size = new System.Drawing.Size(94, 18);
            this.PendingDTCCheckBox.TabIndex = 38;
            this.PendingDTCCheckBox.Text = "Pending DTC";
            this.PendingDTCCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestFailedThisMonitoringCycleCheckBox
            // 
            this.TestFailedThisMonitoringCycleCheckBox.AutoSize = true;
            this.TestFailedThisMonitoringCycleCheckBox.Checked = true;
            this.TestFailedThisMonitoringCycleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TestFailedThisMonitoringCycleCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestFailedThisMonitoringCycleCheckBox.Location = new System.Drawing.Point(192, 137);
            this.TestFailedThisMonitoringCycleCheckBox.Name = "TestFailedThisMonitoringCycleCheckBox";
            this.TestFailedThisMonitoringCycleCheckBox.Size = new System.Drawing.Size(189, 18);
            this.TestFailedThisMonitoringCycleCheckBox.TabIndex = 37;
            this.TestFailedThisMonitoringCycleCheckBox.Text = "Test failed this monitoring cycle";
            this.TestFailedThisMonitoringCycleCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestFailedCheckBox
            // 
            this.TestFailedCheckBox.AutoSize = true;
            this.TestFailedCheckBox.Checked = true;
            this.TestFailedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TestFailedCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestFailedCheckBox.Location = new System.Drawing.Point(192, 120);
            this.TestFailedCheckBox.Name = "TestFailedCheckBox";
            this.TestFailedCheckBox.Size = new System.Drawing.Size(79, 18);
            this.TestFailedCheckBox.TabIndex = 36;
            this.TestFailedCheckBox.Text = "Test failed";
            this.TestFailedCheckBox.UseVisualStyleBackColor = true;
            // 
            // RecordNumberTextBox
            // 
            this.RecordNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.RecordNumberTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordNumberTextBox.Location = new System.Drawing.Point(311, 27);
            this.RecordNumberTextBox.Name = "RecordNumberTextBox";
            this.RecordNumberTextBox.Size = new System.Drawing.Size(22, 22);
            this.RecordNumberTextBox.TabIndex = 35;
            this.RecordNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTCFaultTypeTextBox
            // 
            this.DTCFaultTypeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DTCFaultTypeTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTCFaultTypeTextBox.Location = new System.Drawing.Point(280, 27);
            this.DTCFaultTypeTextBox.Name = "DTCFaultTypeTextBox";
            this.DTCFaultTypeTextBox.Size = new System.Drawing.Size(22, 22);
            this.DTCFaultTypeTextBox.TabIndex = 34;
            this.DTCFaultTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTCLowByteTextBox
            // 
            this.DTCLowByteTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DTCLowByteTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTCLowByteTextBox.Location = new System.Drawing.Point(249, 27);
            this.DTCLowByteTextBox.Name = "DTCLowByteTextBox";
            this.DTCLowByteTextBox.Size = new System.Drawing.Size(22, 22);
            this.DTCLowByteTextBox.TabIndex = 33;
            this.DTCLowByteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTCHighByteTextBox
            // 
            this.DTCHighByteTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DTCHighByteTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTCHighByteTextBox.Location = new System.Drawing.Point(218, 27);
            this.DTCHighByteTextBox.Name = "DTCHighByteTextBox";
            this.DTCHighByteTextBox.Size = new System.Drawing.Size(22, 22);
            this.DTCHighByteTextBox.TabIndex = 32;
            this.DTCHighByteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReadDTCComboBox
            // 
            this.ReadDTCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReadDTCComboBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadDTCComboBox.FormattingEnabled = true;
            this.ReadDTCComboBox.Items.AddRange(new object[] {
            "19 01",
            "19 02",
            "19 04",
            "19 06",
            "19 0A"});
            this.ReadDTCComboBox.Location = new System.Drawing.Point(154, 27);
            this.ReadDTCComboBox.Name = "ReadDTCComboBox";
            this.ReadDTCComboBox.Size = new System.Drawing.Size(55, 22);
            this.ReadDTCComboBox.TabIndex = 31;
            // 
            // ReadDTCButton
            // 
            this.ReadDTCButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadDTCButton.Location = new System.Drawing.Point(154, 57);
            this.ReadDTCButton.Name = "ReadDTCButton";
            this.ReadDTCButton.Size = new System.Drawing.Size(181, 28);
            this.ReadDTCButton.TabIndex = 30;
            this.ReadDTCButton.Text = "Read";
            this.ReadDTCButton.UseVisualStyleBackColor = true;
            // 
            // DTCDisplayTextBox
            // 
            this.DTCDisplayTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DTCDisplayTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTCDisplayTextBox.Location = new System.Drawing.Point(21, 27);
            this.DTCDisplayTextBox.Multiline = true;
            this.DTCDisplayTextBox.Name = "DTCDisplayTextBox";
            this.DTCDisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DTCDisplayTextBox.Size = new System.Drawing.Size(105, 234);
            this.DTCDisplayTextBox.TabIndex = 29;
            this.DTCDisplayTextBox.WordWrap = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(734, 466);
            this.Controls.Add(this.MainWinTabControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeviceConnectButton);
            this.Controls.Add(this.DeviceSelectComboBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ReqIDTextBox);
            this.Controls.Add(this.SecurityAccessButton);
            this.Controls.Add(this.TestPresentComboBox);
            this.Controls.Add(this.TestPresentCheckBox);
            this.Controls.Add(this.RxDataTextBox);
            this.Controls.Add(this.SecurityAccessComboBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.TxDataTextBox);
            this.Controls.Add(this.ResIDTextBox);
            this.Controls.Add(this.ReqIDLabel);
            this.Controls.Add(this.ResIDLabel);
            this.Controls.Add(this.MainWinMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainWinMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luffy";
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.MainWinMenuStrip.ResumeLayout(false);
            this.MainWinMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxRxDataGridView)).EndInit();
            this.ContextMenuStripForDiagDataGridView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MainWinTabControl.ResumeLayout(false);
            this.LogTabPage.ResumeLayout(false);
            this.DTCTabPage.ResumeLayout(false);
            this.DTCTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainWinMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexTooTASCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nRCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.Button DeviceConnectButton;
        private System.Windows.Forms.ComboBox DeviceSelectComboBox;
        private System.Windows.Forms.Timer TestPresentTimer;
        private System.Windows.Forms.Timer RxMsgTimer;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox ReqIDTextBox;
        private System.Windows.Forms.DataGridView TxRxDataGridView;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripForDiagDataGridView;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.Button SecurityAccessButton;
        private System.Windows.Forms.ComboBox TestPresentComboBox;
        private System.Windows.Forms.CheckBox TestPresentCheckBox;
        private System.Windows.Forms.TextBox RxDataTextBox;
        private System.Windows.Forms.ComboBox SecurityAccessComboBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox TxDataTextBox;
        private System.Windows.Forms.TextBox ResIDTextBox;
        private System.Windows.Forms.Label ReqIDLabel;
        private System.Windows.Forms.Label ResIDLabel;
        private System.Windows.Forms.TextBox LoopTextBox;
        private System.Windows.Forms.Button LoopButton;
        private System.Windows.Forms.CheckBox LoopCheckBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl MainWinTabControl;
        private System.Windows.Forms.TabPage LogTabPage;
        private System.Windows.Forms.TabPage DTCTabPage;
        private System.Windows.Forms.Label RecordNumberLabel;
        private System.Windows.Forms.Label FaultTypeLabel;
        private System.Windows.Forms.Label LowByteLabel;
        private System.Windows.Forms.Label HighByteLabel;
        private System.Windows.Forms.Label DTCListLabel;
        private System.Windows.Forms.Label Bit7Label;
        private System.Windows.Forms.Label Bit6Label;
        private System.Windows.Forms.Label Bit5Label;
        private System.Windows.Forms.Label Bit4Label;
        private System.Windows.Forms.Label Bit3Label;
        private System.Windows.Forms.Label Bit2Label;
        private System.Windows.Forms.Label Bit1Label;
        private System.Windows.Forms.Label Bit0Label;
        private System.Windows.Forms.Label DTCMasklabel;
        private System.Windows.Forms.CheckBox WarningIndicatorRequestedCheckBox;
        private System.Windows.Forms.CheckBox TestNotCompletedThisMonitoringCycleCheckBox;
        private System.Windows.Forms.CheckBox TestFailedSinceLastClearCheckBox;
        private System.Windows.Forms.CheckBox TestNotCompletedSinceLastClearCheckBox;
        private System.Windows.Forms.CheckBox ConfirmedDTCCheckBox;
        private System.Windows.Forms.CheckBox PendingDTCCheckBox;
        private System.Windows.Forms.CheckBox TestFailedThisMonitoringCycleCheckBox;
        private System.Windows.Forms.CheckBox TestFailedCheckBox;
        private System.Windows.Forms.TextBox RecordNumberTextBox;
        private System.Windows.Forms.TextBox DTCFaultTypeTextBox;
        private System.Windows.Forms.TextBox DTCLowByteTextBox;
        private System.Windows.Forms.TextBox DTCHighByteTextBox;
        private System.Windows.Forms.ComboBox ReadDTCComboBox;
        private System.Windows.Forms.Button ReadDTCButton;
        private System.Windows.Forms.TextBox DTCDisplayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Len;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
    }
}

