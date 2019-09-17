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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NetworksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagLabel = new System.Windows.Forms.Label();
            this.FlashLabel = new System.Windows.Forms.Label();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.toASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.NetworksToolStripMenuItem,
            this.AutoToolStripMenuItem,
            this.OptionToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1000, 25);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ImportToolStripMenuItem.Text = "Import";
            this.ImportToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // NetworksToolStripMenuItem
            // 
            this.NetworksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxPanelToolStripMenuItem});
            this.NetworksToolStripMenuItem.Name = "NetworksToolStripMenuItem";
            this.NetworksToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.NetworksToolStripMenuItem.Text = "Networks";
            // 
            // TxPanelToolStripMenuItem
            // 
            this.TxPanelToolStripMenuItem.Name = "TxPanelToolStripMenuItem";
            this.TxPanelToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.TxPanelToolStripMenuItem.Text = "TxPanel";
            this.TxPanelToolStripMenuItem.Click += new System.EventHandler(this.TxPanelToolStripMenuItem_Click);
            // 
            // AutoToolStripMenuItem
            // 
            this.AutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptToolStripMenuItem});
            this.AutoToolStripMenuItem.Name = "AutoToolStripMenuItem";
            this.AutoToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.AutoToolStripMenuItem.Text = "Auto";
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.scriptToolStripMenuItem.Text = "Script";
            // 
            // OptionToolStripMenuItem
            // 
            this.OptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HardwareToolStripMenuItem});
            this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
            this.OptionToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.OptionToolStripMenuItem.Text = "Option";
            // 
            // HardwareToolStripMenuItem
            // 
            this.HardwareToolStripMenuItem.Name = "HardwareToolStripMenuItem";
            this.HardwareToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.HardwareToolStripMenuItem.Text = "Setup";
            this.HardwareToolStripMenuItem.Click += new System.EventHandler(this.HardwareToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toASCIIToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.HelpToolStripMenuItem.Text = "Help";
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
            this.DiagLabel.Size = new System.Drawing.Size(120, 300);
            this.DiagLabel.TabIndex = 5;
            this.DiagLabel.Text = "Diag";
            this.DiagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiagLabel.Click += new System.EventHandler(this.DiagLabel_Click);
            // 
            // FlashLabel
            // 
            this.FlashLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.FlashLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlashLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlashLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashLabel.ForeColor = System.Drawing.Color.White;
            this.FlashLabel.Location = new System.Drawing.Point(0, 324);
            this.FlashLabel.Name = "FlashLabel";
            this.FlashLabel.Size = new System.Drawing.Size(120, 300);
            this.FlashLabel.TabIndex = 7;
            this.FlashLabel.Text = "Flash";
            this.FlashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FlashLabel.Click += new System.EventHandler(this.FlashLabel_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Location = new System.Drawing.Point(120, 25);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(880, 600);
            this.MainGroupBox.TabIndex = 13;
            this.MainGroupBox.TabStop = false;
            // 
            // toASCIIToolStripMenuItem
            // 
            this.toASCIIToolStripMenuItem.Name = "toASCIIToolStripMenuItem";
            this.toASCIIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toASCIIToolStripMenuItem.Text = "ToASCII";
            this.toASCIIToolStripMenuItem.Click += new System.EventHandler(this.ToASCIIToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 622);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.FlashLabel);
            this.Controls.Add(this.DiagLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Leon";
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.Label DiagLabel;
        private System.Windows.Forms.Label FlashLabel;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.ToolStripMenuItem AutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NetworksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TxPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toASCIIToolStripMenuItem;
    }
}

