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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.readDTCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ScriptLabel = new System.Windows.Forms.Label();
            this.SplitlineLabel1 = new System.Windows.Forms.Label();
            this.SplitLineLabel2 = new System.Windows.Forms.Label();
            this.SplitLinLabel3 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Len = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainWinMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxRxDataGridView)).BeginInit();
            this.ContextMenuStripForDiagDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWinMenuStrip
            // 
            this.MainWinMenuStrip.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWinMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainWinMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainWinMenuStrip.Name = "MainWinMenuStrip";
            this.MainWinMenuStrip.Size = new System.Drawing.Size(655, 24);
            this.MainWinMenuStrip.TabIndex = 0;
            this.MainWinMenuStrip.Text = "MainWinMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SettingToolStripMenuItem.Text = "Setting";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readDTCToolStripMenuItem,
            this.hexTooTASCIIToolStripMenuItem,
            this.nRCToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // readDTCToolStripMenuItem
            // 
            this.readDTCToolStripMenuItem.Name = "readDTCToolStripMenuItem";
            this.readDTCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.readDTCToolStripMenuItem.Text = "ReadDTC";
            this.readDTCToolStripMenuItem.Click += new System.EventHandler(this.readDTCToolStripMenuItem_Click);
            // 
            // hexTooTASCIIToolStripMenuItem
            // 
            this.hexTooTASCIIToolStripMenuItem.Name = "hexTooTASCIIToolStripMenuItem";
            this.hexTooTASCIIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hexTooTASCIIToolStripMenuItem.Text = "HexToASCII";
            this.hexTooTASCIIToolStripMenuItem.Click += new System.EventHandler(this.hexTooTASCIIToolStripMenuItem_Click);
            // 
            // nRCToolStripMenuItem
            // 
            this.nRCToolStripMenuItem.Name = "nRCToolStripMenuItem";
            this.nRCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nRCToolStripMenuItem.Text = "NRC Table";
            this.nRCToolStripMenuItem.Click += new System.EventHandler(this.nRCToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // DeviceConnectButton
            // 
            this.DeviceConnectButton.BackColor = System.Drawing.Color.White;
            this.DeviceConnectButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceConnectButton.ForeColor = System.Drawing.Color.White;
            this.DeviceConnectButton.Location = new System.Drawing.Point(165, 36);
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
            this.DeviceSelectComboBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceSelectComboBox.FormattingEnabled = true;
            this.DeviceSelectComboBox.Location = new System.Drawing.Point(20, 37);
            this.DeviceSelectComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeviceSelectComboBox.Name = "DeviceSelectComboBox";
            this.DeviceSelectComboBox.Size = new System.Drawing.Size(140, 20);
            this.DeviceSelectComboBox.TabIndex = 68;
            // 
            // TestPresentTimer
            // 
            this.TestPresentTimer.Interval = 2000;
            this.TestPresentTimer.Tick += new System.EventHandler(this.TestPresentTimer_Tick);
            // 
            // RxMsgTimer
            // 
            this.RxMsgTimer.Interval = 10;
            this.RxMsgTimer.Tick += new System.EventHandler(this.RxMsgTimer_Tick);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(588, 89);
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
            this.ReqIDTextBox.Location = new System.Drawing.Point(253, 36);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TxRxDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.TxRxDataGridView.Location = new System.Drawing.Point(208, 121);
            this.TxRxDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxRxDataGridView.Name = "TxRxDataGridView";
            this.TxRxDataGridView.ReadOnly = true;
            this.TxRxDataGridView.RowHeadersVisible = false;
            this.TxRxDataGridView.RowTemplate.Height = 20;
            this.TxRxDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TxRxDataGridView.Size = new System.Drawing.Size(425, 286);
            this.TxRxDataGridView.TabIndex = 64;
            this.TxRxDataGridView.DoubleClick += new System.EventHandler(this.TxRxDataGridView_DoubleClick);
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
            this.SecurityAccessButton.Location = new System.Drawing.Point(588, 36);
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
            this.TestPresentComboBox.Location = new System.Drawing.Point(439, 37);
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
            this.TestPresentCheckBox.Location = new System.Drawing.Point(417, 36);
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
            this.RxDataTextBox.Location = new System.Drawing.Point(208, 90);
            this.RxDataTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RxDataTextBox.Name = "RxDataTextBox";
            this.RxDataTextBox.Size = new System.Drawing.Size(374, 22);
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
            this.SecurityAccessComboBox.Location = new System.Drawing.Point(527, 37);
            this.SecurityAccessComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SecurityAccessComboBox.Name = "SecurityAccessComboBox";
            this.SecurityAccessComboBox.Size = new System.Drawing.Size(55, 20);
            this.SecurityAccessComboBox.TabIndex = 62;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(588, 61);
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
            this.TxDataTextBox.Location = new System.Drawing.Point(208, 62);
            this.TxDataTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxDataTextBox.Name = "TxDataTextBox";
            this.TxDataTextBox.Size = new System.Drawing.Size(374, 22);
            this.TxDataTextBox.TabIndex = 55;
            this.TxDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReqIDTextBox_EnterKeyPress);
            // 
            // ResIDTextBox
            // 
            this.ResIDTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResIDTextBox.Location = new System.Drawing.Point(345, 36);
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
            this.ReqIDLabel.Location = new System.Drawing.Point(207, 36);
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
            this.ResIDLabel.Location = new System.Drawing.Point(300, 36);
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
            this.LoopTextBox.Location = new System.Drawing.Point(55, 97);
            this.LoopTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoopTextBox.Name = "LoopTextBox";
            this.LoopTextBox.Size = new System.Drawing.Size(25, 19);
            this.LoopTextBox.TabIndex = 74;
            this.LoopTextBox.Text = "1";
            // 
            // LoopButton
            // 
            this.LoopButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopButton.Location = new System.Drawing.Point(17, 97);
            this.LoopButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.Size = new System.Drawing.Size(35, 19);
            this.LoopButton.TabIndex = 73;
            this.LoopButton.Text = "Loop";
            this.LoopButton.UseVisualStyleBackColor = true;
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopCheckBox.Location = new System.Drawing.Point(83, 98);
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
            this.RunButton.Location = new System.Drawing.Point(129, 97);
            this.RunButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(35, 19);
            this.RunButton.TabIndex = 71;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(20, 121);
            this.ScriptTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ScriptTextBox.Multiline = true;
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Size = new System.Drawing.Size(140, 286);
            this.ScriptTextBox.TabIndex = 70;
            this.ScriptTextBox.WordWrap = false;
            // 
            // ScriptLabel
            // 
            this.ScriptLabel.AutoSize = true;
            this.ScriptLabel.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptLabel.Location = new System.Drawing.Point(67, 70);
            this.ScriptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScriptLabel.Name = "ScriptLabel";
            this.ScriptLabel.Size = new System.Drawing.Size(30, 12);
            this.ScriptLabel.TabIndex = 75;
            this.ScriptLabel.Text = "Script";
            // 
            // SplitlineLabel1
            // 
            this.SplitlineLabel1.BackColor = System.Drawing.Color.Silver;
            this.SplitlineLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitlineLabel1.Location = new System.Drawing.Point(20, 75);
            this.SplitlineLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SplitlineLabel1.Name = "SplitlineLabel1";
            this.SplitlineLabel1.Size = new System.Drawing.Size(40, 2);
            this.SplitlineLabel1.TabIndex = 76;
            // 
            // SplitLineLabel2
            // 
            this.SplitLineLabel2.BackColor = System.Drawing.Color.Silver;
            this.SplitLineLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitLineLabel2.Location = new System.Drawing.Point(184, 75);
            this.SplitLineLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SplitLineLabel2.Name = "SplitLineLabel2";
            this.SplitLineLabel2.Size = new System.Drawing.Size(2, 332);
            this.SplitLineLabel2.TabIndex = 77;
            // 
            // SplitLinLabel3
            // 
            this.SplitLinLabel3.BackColor = System.Drawing.Color.Silver;
            this.SplitLinLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitLinLabel3.Location = new System.Drawing.Point(104, 75);
            this.SplitLinLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SplitLinLabel3.Name = "SplitLinLabel3";
            this.SplitLinLabel3.Size = new System.Drawing.Size(80, 2);
            this.SplitLinLabel3.TabIndex = 78;
            this.SplitLinLabel3.Text = "label1";
            // 
            // Num
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.DefaultCellStyle = dataGridViewCellStyle2;
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Num.Width = 30;
            // 
            // Type
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.DefaultCellStyle = dataGridViewCellStyle3;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 30;
            // 
            // ID
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Len
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Len.DefaultCellStyle = dataGridViewCellStyle5;
            this.Len.HeaderText = "Len";
            this.Len.Name = "Len";
            this.Len.ReadOnly = true;
            this.Len.Width = 30;
            // 
            // Data
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 180;
            // 
            // TimeStamp
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStamp.DefaultCellStyle = dataGridViewCellStyle7;
            this.TimeStamp.HeaderText = "TimeStamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            this.TimeStamp.Width = 120;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.SplitLinLabel3);
            this.Controls.Add(this.SplitLineLabel2);
            this.Controls.Add(this.SplitlineLabel1);
            this.Controls.Add(this.ScriptLabel);
            this.Controls.Add(this.LoopTextBox);
            this.Controls.Add(this.LoopButton);
            this.Controls.Add(this.LoopCheckBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.DeviceConnectButton);
            this.Controls.Add(this.DeviceSelectComboBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ReqIDTextBox);
            this.Controls.Add(this.TxRxDataGridView);
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
        private System.Windows.Forms.ToolStripMenuItem readDTCToolStripMenuItem;
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
        private System.Windows.Forms.Label ScriptLabel;
        private System.Windows.Forms.Label SplitlineLabel1;
        private System.Windows.Forms.Label SplitLineLabel2;
        private System.Windows.Forms.Label SplitLinLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Len;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
    }
}

