namespace Diag_Tool_leon
{
    partial class Leon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leon));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvCANRx = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除本行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text1 = new System.Windows.Forms.Label();
            this.AllDevice = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResponseID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Diag_Function = new System.Windows.Forms.ComboBox();
            this.File_path = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Require_cont = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入dllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入测试表格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能简介ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简介1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HexToAscii = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCANRx)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvCANRx
            // 
            this.dgvCANRx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCANRx.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCANRx.Location = new System.Drawing.Point(17, 161);
            this.dgvCANRx.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCANRx.Name = "dgvCANRx";
            this.dgvCANRx.RowTemplate.Height = 23;
            this.dgvCANRx.Size = new System.Drawing.Size(952, 436);
            this.dgvCANRx.TabIndex = 0;
            this.dgvCANRx.DoubleClick += new System.EventHandler(this.dgvCANRx_DoubleClick);
            this.dgvCANRx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCANRx_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除本行ToolStripMenuItem,
            this.清除所有ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // 删除本行ToolStripMenuItem
            // 
            this.删除本行ToolStripMenuItem.Name = "删除本行ToolStripMenuItem";
            this.删除本行ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除本行ToolStripMenuItem.Text = "删除本行";
            this.删除本行ToolStripMenuItem.Click += new System.EventHandler(this.删除本行ToolStripMenuItem_Click);
            // 
            // 清除所有ToolStripMenuItem
            // 
            this.清除所有ToolStripMenuItem.Name = "清除所有ToolStripMenuItem";
            this.清除所有ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清除所有ToolStripMenuItem.Text = "清除所有";
            this.清除所有ToolStripMenuItem.Click += new System.EventHandler(this.清除所有ToolStripMenuItem_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(13, 93);
            this.text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(70, 23);
            this.text1.TabIndex = 1;
            this.text1.Text = "设备：";
            // 
            // AllDevice
            // 
            this.AllDevice.FormattingEnabled = true;
            this.AllDevice.Location = new System.Drawing.Point(91, 90);
            this.AllDevice.Margin = new System.Windows.Forms.Padding(4);
            this.AllDevice.Name = "AllDevice";
            this.AllDevice.Size = new System.Drawing.Size(130, 27);
            this.AllDevice.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(255, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "请求ID：";
            // 
            // RequestID
            // 
            this.RequestID.Location = new System.Drawing.Point(489, 84);
            this.RequestID.Name = "RequestID";
            this.RequestID.Size = new System.Drawing.Size(55, 27);
            this.RequestID.TabIndex = 5;
            this.RequestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(821, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "响应ID:";
            // 
            // ResponseID
            // 
            this.ResponseID.Location = new System.Drawing.Point(900, 83);
            this.ResponseID.Name = "ResponseID";
            this.ResponseID.Size = new System.Drawing.Size(55, 27);
            this.ResponseID.TabIndex = 7;
            this.ResponseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "功能:";
            // 
            // Diag_Function
            // 
            this.Diag_Function.FormattingEnabled = true;
            this.Diag_Function.Location = new System.Drawing.Point(93, 41);
            this.Diag_Function.Margin = new System.Windows.Forms.Padding(4);
            this.Diag_Function.Name = "Diag_Function";
            this.Diag_Function.Size = new System.Drawing.Size(128, 27);
            this.Diag_Function.TabIndex = 9;
            // 
            // File_path
            // 
            this.File_path.Location = new System.Drawing.Point(386, 41);
            this.File_path.Name = "File_path";
            this.File_path.Size = new System.Drawing.Size(437, 27);
            this.File_path.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(255, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "选择文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Require_cont
            // 
            this.Require_cont.BackColor = System.Drawing.Color.Plum;
            this.Require_cont.Location = new System.Drawing.Point(561, 83);
            this.Require_cont.Name = "Require_cont";
            this.Require_cont.Size = new System.Drawing.Size(189, 27);
            this.Require_cont.TabIndex = 13;
            this.Require_cont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Require_cont_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(862, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "刷新";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(765, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 27);
            this.button4.TabIndex = 16;
            this.button4.Text = "发送";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "NOK";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.功能简介ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 25);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入dllToolStripMenuItem,
            this.导入测试表格ToolStripMenuItem});
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.导入ToolStripMenuItem.Text = "文件选项";
            // 
            // 导入dllToolStripMenuItem
            // 
            this.导入dllToolStripMenuItem.Name = "导入dllToolStripMenuItem";
            this.导入dllToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.导入dllToolStripMenuItem.Text = "导入dll";
            this.导入dllToolStripMenuItem.Click += new System.EventHandler(this.导入dllToolStripMenuItem_Click);
            // 
            // 导入测试表格ToolStripMenuItem
            // 
            this.导入测试表格ToolStripMenuItem.Name = "导入测试表格ToolStripMenuItem";
            this.导入测试表格ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.导入测试表格ToolStripMenuItem.Text = "导入测试表格";
            // 
            // 功能简介ToolStripMenuItem
            // 
            this.功能简介ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简介1ToolStripMenuItem});
            this.功能简介ToolStripMenuItem.Name = "功能简介ToolStripMenuItem";
            this.功能简介ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.功能简介ToolStripMenuItem.Text = "功能简介";
            // 
            // 简介1ToolStripMenuItem
            // 
            this.简介1ToolStripMenuItem.Name = "简介1ToolStripMenuItem";
            this.简介1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.简介1ToolStripMenuItem.Text = "简介1";
            this.简介1ToolStripMenuItem.Click += new System.EventHandler(this.简介1ToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(596, 126);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 27);
            this.comboBox1.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(685, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 27);
            this.button5.TabIndex = 20;
            this.button5.Text = "安全认证";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(828, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 27);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "3E";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(877, 123);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 27);
            this.comboBox2.TabIndex = 22;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 27);
            this.textBox1.TabIndex = 23;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // HexToAscii
            // 
            this.HexToAscii.AutoSize = true;
            this.HexToAscii.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexToAscii.Location = new System.Drawing.Point(13, 127);
            this.HexToAscii.Name = "HexToAscii";
            this.HexToAscii.Size = new System.Drawing.Size(46, 23);
            this.HexToAscii.TabIndex = 24;
            this.HexToAscii.Text = "HEX:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(431, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 27);
            this.textBox2.TabIndex = 25;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(329, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 30);
            this.button6.TabIndex = 26;
            this.button6.Text = "转ASCII:";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(329, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 28);
            this.button7.TabIndex = 27;
            this.button7.Text = "EE_INI";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Leon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 621);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.HexToAscii);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Require_cont);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.File_path);
            this.Controls.Add(this.Diag_Function);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResponseID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RequestID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllDevice);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.dgvCANRx);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Leon";
            this.Text = "Leon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCANRx)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvCANRx;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.ComboBox AllDevice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RequestID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResponseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Diag_Function;
        private System.Windows.Forms.TextBox File_path;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Require_cont;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除本行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除所有ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入dllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入测试表格ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label HexToAscii;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem 功能简介ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简介1ToolStripMenuItem;
    }
}

