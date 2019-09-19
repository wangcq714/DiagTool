namespace DiagTool_Kanwairen
{
    partial class DiagUserControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ReqIDTextBox = new System.Windows.Forms.TextBox();
            this.TxRxDataGridView = new System.Windows.Forms.DataGridView();
            this.ContextMenuStripForDiagDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecurityAccessButton = new System.Windows.Forms.Button();
            this.SecurityAccessComboBox = new System.Windows.Forms.ComboBox();
            this.TestPresentComboBox = new System.Windows.Forms.ComboBox();
            this.TestPresentCheckBox = new System.Windows.Forms.CheckBox();
            this.RxDataLabel = new System.Windows.Forms.Label();
            this.RxDataTextBox = new System.Windows.Forms.TextBox();
            this.TxDataLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.TxDataTextBox = new System.Windows.Forms.TextBox();
            this.ResIDTextBox = new System.Windows.Forms.TextBox();
            this.ResIDLabel = new System.Windows.Forms.Label();
            this.ReqIDLabel = new System.Windows.Forms.Label();
            this.RxMsgTimer = new System.Windows.Forms.Timer(this.components);
            this.TestPresentTimer = new System.Windows.Forms.Timer(this.components);
            this.DeviceConnectButton = new System.Windows.Forms.Button();
            this.DeviceSelectComboBox = new System.Windows.Forms.ComboBox();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.FilterAppMsgCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterAppMsgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxRxDataGridView)).BeginInit();
            this.ContextMenuStripForDiagDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(775, 94);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(68, 29);
            this.ClearButton.TabIndex = 46;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ReqIDTextBox
            // 
            this.ReqIDTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqIDTextBox.Location = new System.Drawing.Point(544, 23);
            this.ReqIDTextBox.Name = "ReqIDTextBox";
            this.ReqIDTextBox.Size = new System.Drawing.Size(60, 26);
            this.ReqIDTextBox.TabIndex = 45;
            this.ReqIDTextBox.Text = "710";
            // 
            // TxRxDataGridView
            // 
            this.TxRxDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TxRxDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxRxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TxRxDataGridView.ContextMenuStrip = this.ContextMenuStripForDiagDataGridView;
            this.TxRxDataGridView.Location = new System.Drawing.Point(49, 180);
            this.TxRxDataGridView.Name = "TxRxDataGridView";
            this.TxRxDataGridView.ReadOnly = true;
            this.TxRxDataGridView.RowHeadersVisible = false;
            this.TxRxDataGridView.RowTemplate.Height = 23;
            this.TxRxDataGridView.Size = new System.Drawing.Size(793, 404);
            this.TxRxDataGridView.TabIndex = 44;
            this.TxRxDataGridView.DoubleClick += new System.EventHandler(this.TxRxDataGridView_DoubleClick);
            // 
            // ContextMenuStripForDiagDataGridView
            // 
            this.ContextMenuStripForDiagDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.ContextMenuStripForDiagDataGridView.Name = "ContextMenuStripForDiagDataGridView";
            this.ContextMenuStripForDiagDataGridView.Size = new System.Drawing.Size(153, 70);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SecurityAccessButton
            // 
            this.SecurityAccessButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityAccessButton.Location = new System.Drawing.Point(473, 133);
            this.SecurityAccessButton.Name = "SecurityAccessButton";
            this.SecurityAccessButton.Size = new System.Drawing.Size(91, 30);
            this.SecurityAccessButton.TabIndex = 43;
            this.SecurityAccessButton.Text = "Security";
            this.SecurityAccessButton.UseVisualStyleBackColor = true;
            this.SecurityAccessButton.Click += new System.EventHandler(this.SecurityAccessButton_Click);
            // 
            // SecurityAccessComboBox
            // 
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
            this.SecurityAccessComboBox.Location = new System.Drawing.Point(360, 135);
            this.SecurityAccessComboBox.Name = "SecurityAccessComboBox";
            this.SecurityAccessComboBox.Size = new System.Drawing.Size(100, 27);
            this.SecurityAccessComboBox.TabIndex = 42;
            // 
            // TestPresentComboBox
            // 
            this.TestPresentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestPresentComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPresentComboBox.FormattingEnabled = true;
            this.TestPresentComboBox.Items.AddRange(new object[] {
            "3E 80",
            "3E 00"});
            this.TestPresentComboBox.Location = new System.Drawing.Point(775, 135);
            this.TestPresentComboBox.Name = "TestPresentComboBox";
            this.TestPresentComboBox.Size = new System.Drawing.Size(67, 27);
            this.TestPresentComboBox.TabIndex = 41;
            // 
            // TestPresentCheckBox
            // 
            this.TestPresentCheckBox.Checked = true;
            this.TestPresentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TestPresentCheckBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPresentCheckBox.Location = new System.Drawing.Point(714, 136);
            this.TestPresentCheckBox.Name = "TestPresentCheckBox";
            this.TestPresentCheckBox.Size = new System.Drawing.Size(55, 25);
            this.TestPresentCheckBox.TabIndex = 40;
            this.TestPresentCheckBox.Text = "3E";
            this.TestPresentCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TestPresentCheckBox.UseVisualStyleBackColor = true;
            // 
            // RxDataLabel
            // 
            this.RxDataLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RxDataLabel.Location = new System.Drawing.Point(35, 96);
            this.RxDataLabel.Name = "RxDataLabel";
            this.RxDataLabel.Size = new System.Drawing.Size(47, 20);
            this.RxDataLabel.TabIndex = 39;
            this.RxDataLabel.Text = "Rx:";
            this.RxDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RxDataTextBox
            // 
            this.RxDataTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RxDataTextBox.Location = new System.Drawing.Point(87, 95);
            this.RxDataTextBox.Name = "RxDataTextBox";
            this.RxDataTextBox.Size = new System.Drawing.Size(668, 26);
            this.RxDataTextBox.TabIndex = 38;
            // 
            // TxDataLabel
            // 
            this.TxDataLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDataLabel.Location = new System.Drawing.Point(35, 59);
            this.TxDataLabel.Name = "TxDataLabel";
            this.TxDataLabel.Size = new System.Drawing.Size(47, 20);
            this.TxDataLabel.TabIndex = 37;
            this.TxDataLabel.Text = "Tx:";
            this.TxDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(775, 57);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(68, 29);
            this.SendButton.TabIndex = 36;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // TxDataTextBox
            // 
            this.TxDataTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDataTextBox.Location = new System.Drawing.Point(87, 58);
            this.TxDataTextBox.Name = "TxDataTextBox";
            this.TxDataTextBox.Size = new System.Drawing.Size(668, 26);
            this.TxDataTextBox.TabIndex = 35;
            this.TxDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReqIDTextBox_EnterKeyPress);
            // 
            // ResIDTextBox
            // 
            this.ResIDTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResIDTextBox.Location = new System.Drawing.Point(695, 23);
            this.ResIDTextBox.Name = "ResIDTextBox";
            this.ResIDTextBox.Size = new System.Drawing.Size(60, 26);
            this.ResIDTextBox.TabIndex = 34;
            this.ResIDTextBox.Text = "718";
            // 
            // ResIDLabel
            // 
            this.ResIDLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResIDLabel.Location = new System.Drawing.Point(624, 26);
            this.ResIDLabel.Name = "ResIDLabel";
            this.ResIDLabel.Size = new System.Drawing.Size(65, 20);
            this.ResIDLabel.TabIndex = 33;
            this.ResIDLabel.Text = "ResID:";
            this.ResIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReqIDLabel
            // 
            this.ReqIDLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqIDLabel.Location = new System.Drawing.Point(477, 26);
            this.ReqIDLabel.Name = "ReqIDLabel";
            this.ReqIDLabel.Size = new System.Drawing.Size(61, 20);
            this.ReqIDLabel.TabIndex = 32;
            this.ReqIDLabel.Text = "ReqID:";
            this.ReqIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RxMsgTimer
            // 
            this.RxMsgTimer.Interval = 10;
            this.RxMsgTimer.Tick += new System.EventHandler(this.RxMsgTimer_Tick);
            // 
            // TestPresentTimer
            // 
            this.TestPresentTimer.Interval = 2000;
            this.TestPresentTimer.Tick += new System.EventHandler(this.TestPresentTimer_Tick);
            // 
            // DeviceConnectButton
            // 
            this.DeviceConnectButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceConnectButton.Location = new System.Drawing.Point(361, 21);
            this.DeviceConnectButton.Name = "DeviceConnectButton";
            this.DeviceConnectButton.Size = new System.Drawing.Size(32, 32);
            this.DeviceConnectButton.TabIndex = 49;
            this.DeviceConnectButton.UseVisualStyleBackColor = true;
            this.DeviceConnectButton.Click += new System.EventHandler(this.DeviceConnectButton_Click);
            // 
            // DeviceSelectComboBox
            // 
            this.DeviceSelectComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceSelectComboBox.FormattingEnabled = true;
            this.DeviceSelectComboBox.Location = new System.Drawing.Point(88, 24);
            this.DeviceSelectComboBox.Name = "DeviceSelectComboBox";
            this.DeviceSelectComboBox.Size = new System.Drawing.Size(254, 27);
            this.DeviceSelectComboBox.TabIndex = 48;
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceLabel.Location = new System.Drawing.Point(35, 26);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(47, 23);
            this.DeviceLabel.TabIndex = 47;
            this.DeviceLabel.Text = "Dv:";
            this.DeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterAppMsgCheckBox
            // 
            this.FilterAppMsgCheckBox.AutoSize = true;
            this.FilterAppMsgCheckBox.Checked = true;
            this.FilterAppMsgCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterAppMsgCheckBox.Location = new System.Drawing.Point(131, 142);
            this.FilterAppMsgCheckBox.Name = "FilterAppMsgCheckBox";
            this.FilterAppMsgCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FilterAppMsgCheckBox.TabIndex = 50;
            this.FilterAppMsgCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterAppMsgLabel
            // 
            this.FilterAppMsgLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterAppMsgLabel.Location = new System.Drawing.Point(39, 138);
            this.FilterAppMsgLabel.Name = "FilterAppMsgLabel";
            this.FilterAppMsgLabel.Size = new System.Drawing.Size(91, 20);
            this.FilterAppMsgLabel.TabIndex = 51;
            this.FilterAppMsgLabel.Text = "DiagFilter:";
            this.FilterAppMsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiagUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilterAppMsgLabel);
            this.Controls.Add(this.FilterAppMsgCheckBox);
            this.Controls.Add(this.DeviceConnectButton);
            this.Controls.Add(this.DeviceSelectComboBox);
            this.Controls.Add(this.DeviceLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ReqIDTextBox);
            this.Controls.Add(this.TxRxDataGridView);
            this.Controls.Add(this.SecurityAccessButton);
            this.Controls.Add(this.SecurityAccessComboBox);
            this.Controls.Add(this.TestPresentComboBox);
            this.Controls.Add(this.TestPresentCheckBox);
            this.Controls.Add(this.RxDataLabel);
            this.Controls.Add(this.RxDataTextBox);
            this.Controls.Add(this.TxDataLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.TxDataTextBox);
            this.Controls.Add(this.ResIDTextBox);
            this.Controls.Add(this.ResIDLabel);
            this.Controls.Add(this.ReqIDLabel);
            this.Name = "DiagUserControl";
            this.Size = new System.Drawing.Size(880, 600);
            this.Load += new System.EventHandler(this.DiagUserControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.TxRxDataGridView)).EndInit();
            this.ContextMenuStripForDiagDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox ReqIDTextBox;
        private System.Windows.Forms.DataGridView TxRxDataGridView;
        private System.Windows.Forms.Button SecurityAccessButton;
        private System.Windows.Forms.ComboBox SecurityAccessComboBox;
        private System.Windows.Forms.ComboBox TestPresentComboBox;
        private System.Windows.Forms.CheckBox TestPresentCheckBox;
        private System.Windows.Forms.Label RxDataLabel;
        private System.Windows.Forms.TextBox RxDataTextBox;
        private System.Windows.Forms.Label TxDataLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox TxDataTextBox;
        private System.Windows.Forms.TextBox ResIDTextBox;
        private System.Windows.Forms.Label ResIDLabel;
        private System.Windows.Forms.Label ReqIDLabel;
        private System.Windows.Forms.Timer RxMsgTimer;
        private System.Windows.Forms.Timer TestPresentTimer;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripForDiagDataGridView;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.Button DeviceConnectButton;
        private System.Windows.Forms.ComboBox DeviceSelectComboBox;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.CheckBox FilterAppMsgCheckBox;
        private System.Windows.Forms.Label FilterAppMsgLabel;
    }
}
