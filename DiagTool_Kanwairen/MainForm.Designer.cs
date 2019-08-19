namespace DiagTool_Kanwairen
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagLabel = new System.Windows.Forms.Label();
            this.TxRxLabel = new System.Windows.Forms.Label();
            this.FlashLabel = new System.Windows.Forms.Label();
            this.SetupLabel = new System.Windows.Forms.Label();
            this.DiagPanel = new System.Windows.Forms.Panel();
            this.DiagManualPanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ReqIDTextBox = new System.Windows.Forms.TextBox();
            this.DiagDataGridView = new System.Windows.Forms.DataGridView();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripForDiagDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SecurityAccessButton = new System.Windows.Forms.Button();
            this.SecurityAccessComboBox = new System.Windows.Forms.ComboBox();
            this.TestPresentComboBox = new System.Windows.Forms.ComboBox();
            this.TestPresentCheckBox = new System.Windows.Forms.CheckBox();
            this.TxRxPanel = new System.Windows.Forms.Panel();
            this.RxLabel = new System.Windows.Forms.Label();
            this.RxDataTextBox = new System.Windows.Forms.TextBox();
            this.TxLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.TxdataTextBox = new System.Windows.Forms.TextBox();
            this.ResIDTextBox = new System.Windows.Forms.TextBox();
            this.ResIDLabel = new System.Windows.Forms.Label();
            this.ReqIDLabel = new System.Windows.Forms.Label();
            this.AutoLineLabel = new System.Windows.Forms.Label();
            this.ManualLineLabel = new System.Windows.Forms.Label();
            this.AutoLabel = new System.Windows.Forms.Label();
            this.ManualLabel = new System.Windows.Forms.Label();
            this.SetupPanel = new System.Windows.Forms.Panel();
            this.FlashPanel = new System.Windows.Forms.Panel();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.DeviceConnectButton = new System.Windows.Forms.Button();
            this.DeviceSelectComboBox = new System.Windows.Forms.ComboBox();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.RxMsgTimer = new System.Windows.Forms.Timer(this.components);
            this.TestPresentTimer = new System.Windows.Forms.Timer(this.components);
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.DiagPanel.SuspendLayout();
            this.DiagManualPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagDataGridView)).BeginInit();
            this.ContextMenuStripForDiagDataGridView.SuspendLayout();
            this.SetupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1000, 25);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ImportToolStripMenuItem.Text = "Import";
            this.ImportToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 21);
            this.toolStripMenuItem1.Text = "Tool";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // DiagLabel
            // 
            this.DiagLabel.BackColor = System.Drawing.Color.White;
            this.DiagLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DiagLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiagLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DiagLabel.Location = new System.Drawing.Point(0, 24);
            this.DiagLabel.Name = "DiagLabel";
            this.DiagLabel.Size = new System.Drawing.Size(120, 151);
            this.DiagLabel.TabIndex = 5;
            this.DiagLabel.Text = "Diag";
            this.DiagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiagLabel.Click += new System.EventHandler(this.DiagLabel_Click);
            // 
            // TxRxLabel
            // 
            this.TxRxLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TxRxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxRxLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxRxLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxRxLabel.ForeColor = System.Drawing.Color.White;
            this.TxRxLabel.Location = new System.Drawing.Point(0, 175);
            this.TxRxLabel.Name = "TxRxLabel";
            this.TxRxLabel.Size = new System.Drawing.Size(120, 150);
            this.TxRxLabel.TabIndex = 6;
            this.TxRxLabel.Text = "TxRx";
            this.TxRxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TxRxLabel.Click += new System.EventHandler(this.TxRxLabel_Click);
            // 
            // FlashLabel
            // 
            this.FlashLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.FlashLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlashLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlashLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashLabel.ForeColor = System.Drawing.Color.White;
            this.FlashLabel.Location = new System.Drawing.Point(0, 325);
            this.FlashLabel.Name = "FlashLabel";
            this.FlashLabel.Size = new System.Drawing.Size(120, 150);
            this.FlashLabel.TabIndex = 7;
            this.FlashLabel.Text = "Flash";
            this.FlashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FlashLabel.Click += new System.EventHandler(this.FlashLabel_Click);
            // 
            // SetupLabel
            // 
            this.SetupLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.SetupLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SetupLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetupLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupLabel.ForeColor = System.Drawing.Color.White;
            this.SetupLabel.Location = new System.Drawing.Point(0, 475);
            this.SetupLabel.Name = "SetupLabel";
            this.SetupLabel.Size = new System.Drawing.Size(120, 150);
            this.SetupLabel.TabIndex = 8;
            this.SetupLabel.Text = "Setup";
            this.SetupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetupLabel.Click += new System.EventHandler(this.SetupLabel_Click);
            // 
            // DiagPanel
            // 
            this.DiagPanel.Controls.Add(this.DiagManualPanel);
            this.DiagPanel.Controls.Add(this.AutoLineLabel);
            this.DiagPanel.Controls.Add(this.ManualLineLabel);
            this.DiagPanel.Controls.Add(this.AutoLabel);
            this.DiagPanel.Controls.Add(this.ManualLabel);
            this.DiagPanel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagPanel.Location = new System.Drawing.Point(126, 25);
            this.DiagPanel.Name = "DiagPanel";
            this.DiagPanel.Size = new System.Drawing.Size(874, 600);
            this.DiagPanel.TabIndex = 9;
            // 
            // DiagManualPanel
            // 
            this.DiagManualPanel.Controls.Add(this.ClearButton);
            this.DiagManualPanel.Controls.Add(this.ReqIDTextBox);
            this.DiagManualPanel.Controls.Add(this.DiagDataGridView);
            this.DiagManualPanel.Controls.Add(this.SecurityAccessButton);
            this.DiagManualPanel.Controls.Add(this.SecurityAccessComboBox);
            this.DiagManualPanel.Controls.Add(this.TestPresentComboBox);
            this.DiagManualPanel.Controls.Add(this.TestPresentCheckBox);
            this.DiagManualPanel.Controls.Add(this.TxRxPanel);
            this.DiagManualPanel.Controls.Add(this.RxLabel);
            this.DiagManualPanel.Controls.Add(this.RxDataTextBox);
            this.DiagManualPanel.Controls.Add(this.TxLabel);
            this.DiagManualPanel.Controls.Add(this.SendButton);
            this.DiagManualPanel.Controls.Add(this.TxdataTextBox);
            this.DiagManualPanel.Controls.Add(this.ResIDTextBox);
            this.DiagManualPanel.Controls.Add(this.ResIDLabel);
            this.DiagManualPanel.Controls.Add(this.ReqIDLabel);
            this.DiagManualPanel.Location = new System.Drawing.Point(0, 52);
            this.DiagManualPanel.Name = "DiagManualPanel";
            this.DiagManualPanel.Size = new System.Drawing.Size(880, 548);
            this.DiagManualPanel.TabIndex = 20;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(771, 98);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(68, 29);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ReqIDTextBox
            // 
            this.ReqIDTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqIDTextBox.Location = new System.Drawing.Point(116, 15);
            this.ReqIDTextBox.Name = "ReqIDTextBox";
            this.ReqIDTextBox.Size = new System.Drawing.Size(60, 26);
            this.ReqIDTextBox.TabIndex = 30;
            this.ReqIDTextBox.Text = "710";
            // 
            // DiagDataGridView
            // 
            this.DiagDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DiagDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DiagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sum,
            this.Type,
            this.ID,
            this.Length,
            this.Data,
            this.Time});
            this.DiagDataGridView.ContextMenuStrip = this.ContextMenuStripForDiagDataGridView;
            this.DiagDataGridView.Location = new System.Drawing.Point(46, 132);
            this.DiagDataGridView.Name = "DiagDataGridView";
            this.DiagDataGridView.ReadOnly = true;
            this.DiagDataGridView.RowTemplate.Height = 23;
            this.DiagDataGridView.Size = new System.Drawing.Size(793, 404);
            this.DiagDataGridView.TabIndex = 29;
            this.DiagDataGridView.DoubleClick += new System.EventHandler(this.DiagDataGridView_DoubleClick);
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Sum";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 60;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 70;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 320;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 200;
            // 
            // ContextMenuStripForDiagDataGridView
            // 
            this.ContextMenuStripForDiagDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.ContextMenuStripForDiagDataGridView.Name = "ContextMenuStripForDiagDataGridView";
            this.ContextMenuStripForDiagDataGridView.Size = new System.Drawing.Size(107, 48);
            // 
            // SecurityAccessButton
            // 
            this.SecurityAccessButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityAccessButton.Location = new System.Drawing.Point(517, 16);
            this.SecurityAccessButton.Name = "SecurityAccessButton";
            this.SecurityAccessButton.Size = new System.Drawing.Size(91, 30);
            this.SecurityAccessButton.TabIndex = 28;
            this.SecurityAccessButton.Text = "Security";
            this.SecurityAccessButton.UseVisualStyleBackColor = true;
            this.SecurityAccessButton.Click += new System.EventHandler(this.SecurityAccessButton_Click);
            // 
            // SecurityAccessComboBox
            // 
            this.SecurityAccessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecurityAccessComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityAccessComboBox.FormattingEnabled = true;
            this.SecurityAccessComboBox.Items.AddRange(new object[] {
            "27 01/02",
            "27 03/04",
            "27 05/06",
            "27 07/08",
            "27 09/0A",
            "27 11/12",
            "27 13/14"});
            this.SecurityAccessComboBox.Location = new System.Drawing.Point(404, 18);
            this.SecurityAccessComboBox.Name = "SecurityAccessComboBox";
            this.SecurityAccessComboBox.Size = new System.Drawing.Size(100, 27);
            this.SecurityAccessComboBox.TabIndex = 27;
            // 
            // TestPresentComboBox
            // 
            this.TestPresentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestPresentComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPresentComboBox.FormattingEnabled = true;
            this.TestPresentComboBox.Items.AddRange(new object[] {
            "3E 80",
            "3E 00"});
            this.TestPresentComboBox.Location = new System.Drawing.Point(771, 18);
            this.TestPresentComboBox.Name = "TestPresentComboBox";
            this.TestPresentComboBox.Size = new System.Drawing.Size(67, 27);
            this.TestPresentComboBox.TabIndex = 26;
            // 
            // TestPresentCheckBox
            // 
            this.TestPresentCheckBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPresentCheckBox.Location = new System.Drawing.Point(710, 18);
            this.TestPresentCheckBox.Name = "TestPresentCheckBox";
            this.TestPresentCheckBox.Size = new System.Drawing.Size(55, 25);
            this.TestPresentCheckBox.TabIndex = 25;
            this.TestPresentCheckBox.Text = "3E";
            this.TestPresentCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TestPresentCheckBox.UseVisualStyleBackColor = true;
            // 
            // TxRxPanel
            // 
            this.TxRxPanel.Location = new System.Drawing.Point(495, 433);
            this.TxRxPanel.Name = "TxRxPanel";
            this.TxRxPanel.Size = new System.Drawing.Size(796, 58);
            this.TxRxPanel.TabIndex = 10;
            // 
            // RxLabel
            // 
            this.RxLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RxLabel.Location = new System.Drawing.Point(42, 100);
            this.RxLabel.Name = "RxLabel";
            this.RxLabel.Size = new System.Drawing.Size(50, 20);
            this.RxLabel.TabIndex = 24;
            this.RxLabel.Text = "Rx:";
            this.RxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RxDataTextBox
            // 
            this.RxDataTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RxDataTextBox.Location = new System.Drawing.Point(98, 99);
            this.RxDataTextBox.Name = "RxDataTextBox";
            this.RxDataTextBox.Size = new System.Drawing.Size(653, 26);
            this.RxDataTextBox.TabIndex = 23;
            // 
            // TxLabel
            // 
            this.TxLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxLabel.Location = new System.Drawing.Point(42, 63);
            this.TxLabel.Name = "TxLabel";
            this.TxLabel.Size = new System.Drawing.Size(50, 20);
            this.TxLabel.TabIndex = 22;
            this.TxLabel.Text = "Tx:";
            this.TxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(771, 61);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(68, 29);
            this.SendButton.TabIndex = 21;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // TxdataTextBox
            // 
            this.TxdataTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxdataTextBox.Location = new System.Drawing.Point(98, 62);
            this.TxdataTextBox.Name = "TxdataTextBox";
            this.TxdataTextBox.Size = new System.Drawing.Size(653, 26);
            this.TxdataTextBox.TabIndex = 20;
            this.TxdataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReqIDTextBox_EnterKeyPress);
            // 
            // ResIDTextBox
            // 
            this.ResIDTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResIDTextBox.Location = new System.Drawing.Point(282, 15);
            this.ResIDTextBox.Name = "ResIDTextBox";
            this.ResIDTextBox.Size = new System.Drawing.Size(60, 26);
            this.ResIDTextBox.TabIndex = 19;
            this.ResIDTextBox.Text = "718";
            // 
            // ResIDLabel
            // 
            this.ResIDLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResIDLabel.Location = new System.Drawing.Point(211, 18);
            this.ResIDLabel.Name = "ResIDLabel";
            this.ResIDLabel.Size = new System.Drawing.Size(65, 20);
            this.ResIDLabel.TabIndex = 18;
            this.ResIDLabel.Text = "ResID:";
            this.ResIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReqIDLabel
            // 
            this.ReqIDLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqIDLabel.Location = new System.Drawing.Point(49, 18);
            this.ReqIDLabel.Name = "ReqIDLabel";
            this.ReqIDLabel.Size = new System.Drawing.Size(61, 20);
            this.ReqIDLabel.TabIndex = 16;
            this.ReqIDLabel.Text = "ReqID:";
            this.ReqIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoLineLabel
            // 
            this.AutoLineLabel.BackColor = System.Drawing.Color.LightGray;
            this.AutoLineLabel.Location = new System.Drawing.Point(440, 50);
            this.AutoLineLabel.Name = "AutoLineLabel";
            this.AutoLineLabel.Size = new System.Drawing.Size(400, 2);
            this.AutoLineLabel.TabIndex = 19;
            // 
            // ManualLineLabel
            // 
            this.ManualLineLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.ManualLineLabel.Location = new System.Drawing.Point(40, 50);
            this.ManualLineLabel.Name = "ManualLineLabel";
            this.ManualLineLabel.Size = new System.Drawing.Size(400, 2);
            this.ManualLineLabel.TabIndex = 18;
            // 
            // AutoLabel
            // 
            this.AutoLabel.BackColor = System.Drawing.Color.White;
            this.AutoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoLabel.ForeColor = System.Drawing.Color.DimGray;
            this.AutoLabel.Location = new System.Drawing.Point(440, 0);
            this.AutoLabel.Name = "AutoLabel";
            this.AutoLabel.Size = new System.Drawing.Size(440, 50);
            this.AutoLabel.TabIndex = 17;
            this.AutoLabel.Text = "Auto";
            this.AutoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoLabel.Click += new System.EventHandler(this.AutoLabel_Click);
            // 
            // ManualLabel
            // 
            this.ManualLabel.BackColor = System.Drawing.Color.White;
            this.ManualLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManualLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ManualLabel.Location = new System.Drawing.Point(0, 10);
            this.ManualLabel.Name = "ManualLabel";
            this.ManualLabel.Size = new System.Drawing.Size(440, 40);
            this.ManualLabel.TabIndex = 16;
            this.ManualLabel.Text = "Manual";
            this.ManualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManualLabel.Click += new System.EventHandler(this.ManualLabel_Click);
            // 
            // SetupPanel
            // 
            this.SetupPanel.Controls.Add(this.FlashPanel);
            this.SetupPanel.Controls.Add(this.BaudRateComboBox);
            this.SetupPanel.Controls.Add(this.BaudRateLabel);
            this.SetupPanel.Controls.Add(this.DeviceConnectButton);
            this.SetupPanel.Controls.Add(this.DeviceSelectComboBox);
            this.SetupPanel.Controls.Add(this.DeviceLabel);
            this.SetupPanel.Location = new System.Drawing.Point(120, 392);
            this.SetupPanel.Name = "SetupPanel";
            this.SetupPanel.Size = new System.Drawing.Size(880, 233);
            this.SetupPanel.TabIndex = 12;
            // 
            // FlashPanel
            // 
            this.FlashPanel.Location = new System.Drawing.Point(149, 514);
            this.FlashPanel.Name = "FlashPanel";
            this.FlashPanel.Size = new System.Drawing.Size(852, 42);
            this.FlashPanel.TabIndex = 11;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "250k",
            "500k"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(225, 153);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(254, 27);
            this.BaudRateComboBox.TabIndex = 4;
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateLabel.Location = new System.Drawing.Point(127, 153);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(92, 23);
            this.BaudRateLabel.TabIndex = 3;
            this.BaudRateLabel.Text = "BaudRate:";
            this.BaudRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeviceConnectButton
            // 
            this.DeviceConnectButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceConnectButton.Location = new System.Drawing.Point(498, 72);
            this.DeviceConnectButton.Name = "DeviceConnectButton";
            this.DeviceConnectButton.Size = new System.Drawing.Size(64, 31);
            this.DeviceConnectButton.TabIndex = 2;
            this.DeviceConnectButton.UseVisualStyleBackColor = true;
            this.DeviceConnectButton.Click += new System.EventHandler(this.DeviceConnectButton_Click);
            // 
            // DeviceSelectComboBox
            // 
            this.DeviceSelectComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceSelectComboBox.FormattingEnabled = true;
            this.DeviceSelectComboBox.Location = new System.Drawing.Point(225, 75);
            this.DeviceSelectComboBox.Name = "DeviceSelectComboBox";
            this.DeviceSelectComboBox.Size = new System.Drawing.Size(254, 27);
            this.DeviceSelectComboBox.TabIndex = 1;
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceLabel.Location = new System.Drawing.Point(123, 75);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(76, 23);
            this.DeviceLabel.TabIndex = 0;
            this.DeviceLabel.Text = "Device:";
            this.DeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RxMsgTimer
            // 
            this.RxMsgTimer.Interval = 1;
            this.RxMsgTimer.Tick += new System.EventHandler(this.RxMsgTimer_Tick);
            // 
            // TestPresentTimer
            // 
            this.TestPresentTimer.Interval = 2000;
            this.TestPresentTimer.Tick += new System.EventHandler(this.TestPresentTimer_Tick);
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
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.SetupPanel);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.DiagPanel);
            this.Controls.Add(this.SetupLabel);
            this.Controls.Add(this.FlashLabel);
            this.Controls.Add(this.TxRxLabel);
            this.Controls.Add(this.DiagLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Leon";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.DiagPanel.ResumeLayout(false);
            this.DiagManualPanel.ResumeLayout(false);
            this.DiagManualPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagDataGridView)).EndInit();
            this.ContextMenuStripForDiagDataGridView.ResumeLayout(false);
            this.SetupPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label DiagLabel;
        private System.Windows.Forms.Label TxRxLabel;
        private System.Windows.Forms.Label FlashLabel;
        private System.Windows.Forms.Label SetupLabel;
        private System.Windows.Forms.Panel DiagPanel;
        private System.Windows.Forms.Panel TxRxPanel;
        private System.Windows.Forms.Panel SetupPanel;
        private System.Windows.Forms.Label AutoLabel;
        private System.Windows.Forms.Label ManualLabel;
        private System.Windows.Forms.Label AutoLineLabel;
        private System.Windows.Forms.Label ManualLineLabel;
        private System.Windows.Forms.Panel DiagManualPanel;
        private System.Windows.Forms.DataGridView DiagDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button SecurityAccessButton;
        private System.Windows.Forms.ComboBox SecurityAccessComboBox;
        private System.Windows.Forms.ComboBox TestPresentComboBox;
        private System.Windows.Forms.CheckBox TestPresentCheckBox;
        private System.Windows.Forms.Label RxLabel;
        private System.Windows.Forms.TextBox RxDataTextBox;
        private System.Windows.Forms.Label TxLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox TxdataTextBox;
        private System.Windows.Forms.TextBox ResIDTextBox;
        private System.Windows.Forms.Label ResIDLabel;
        private System.Windows.Forms.Label ReqIDLabel;
        private System.Windows.Forms.ComboBox DeviceSelectComboBox;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.Button DeviceConnectButton;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.TextBox ReqIDTextBox;
        private System.Windows.Forms.Panel FlashPanel;
        private System.Windows.Forms.Timer RxMsgTimer;
        private System.Windows.Forms.Timer TestPresentTimer;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripForDiagDataGridView;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
    }
}

