namespace DiagTool_Kanwairen
{
    partial class TxPanelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TxPanelForm));
            this.TxPanelDataGridView = new System.Windows.Forms.DataGridView();
            this.Tx = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Auto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxPanelDGVContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxMsgTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxPanelDataGridView)).BeginInit();
            this.TxPanelDGVContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxPanelDataGridView
            // 
            this.TxPanelDataGridView.AllowUserToAddRows = false;
            this.TxPanelDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TxPanelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxPanelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TxPanelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tx,
            this.Auto,
            this.Period,
            this.AbrID,
            this.DLC,
            this.B0,
            this.B1,
            this.B2,
            this.B3,
            this.B4,
            this.B5,
            this.B6,
            this.B7});
            this.TxPanelDataGridView.ContextMenuStrip = this.TxPanelDGVContextMenuStrip;
            this.TxPanelDataGridView.Location = new System.Drawing.Point(12, 12);
            this.TxPanelDataGridView.Name = "TxPanelDataGridView";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TxPanelDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.TxPanelDataGridView.RowTemplate.Height = 23;
            this.TxPanelDataGridView.Size = new System.Drawing.Size(490, 238);
            this.TxPanelDataGridView.TabIndex = 11;
            // 
            // Tx
            // 
            this.Tx.HeaderText = "Tx";
            this.Tx.Name = "Tx";
            this.Tx.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tx.Width = 25;
            // 
            // Auto
            // 
            this.Auto.HeaderText = "At";
            this.Auto.Name = "Auto";
            this.Auto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Auto.Width = 25;
            // 
            // Period
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Period.DefaultCellStyle = dataGridViewCellStyle13;
            this.Period.HeaderText = "Period(ms)";
            this.Period.Name = "Period";
            this.Period.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Period.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Period.Width = 70;
            // 
            // AbrID
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AbrID.DefaultCellStyle = dataGridViewCellStyle14;
            this.AbrID.HeaderText = "AbrID";
            this.AbrID.MaxInputLength = 3;
            this.AbrID.Name = "AbrID";
            this.AbrID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AbrID.Width = 50;
            // 
            // DLC
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DLC.DefaultCellStyle = dataGridViewCellStyle15;
            this.DLC.HeaderText = "DLC";
            this.DLC.MaxInputLength = 1;
            this.DLC.Name = "DLC";
            this.DLC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DLC.Width = 30;
            // 
            // B0
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.B0.DefaultCellStyle = dataGridViewCellStyle16;
            this.B0.HeaderText = "B0";
            this.B0.MaxInputLength = 4;
            this.B0.Name = "B0";
            this.B0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B0.Width = 30;
            // 
            // B1
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.B1.DefaultCellStyle = dataGridViewCellStyle17;
            this.B1.HeaderText = "B1";
            this.B1.MaxInputLength = 4;
            this.B1.Name = "B1";
            this.B1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B1.Width = 30;
            // 
            // B2
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.B2.DefaultCellStyle = dataGridViewCellStyle18;
            this.B2.HeaderText = "B2";
            this.B2.MaxInputLength = 4;
            this.B2.Name = "B2";
            this.B2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B2.Width = 30;
            // 
            // B3
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.B3.DefaultCellStyle = dataGridViewCellStyle19;
            this.B3.HeaderText = "B3";
            this.B3.MaxInputLength = 4;
            this.B3.Name = "B3";
            this.B3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B3.Width = 30;
            // 
            // B4
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.B4.DefaultCellStyle = dataGridViewCellStyle20;
            this.B4.HeaderText = "B4";
            this.B4.MaxInputLength = 4;
            this.B4.Name = "B4";
            this.B4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B4.Width = 30;
            // 
            // B5
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.B5.DefaultCellStyle = dataGridViewCellStyle21;
            this.B5.HeaderText = "B5";
            this.B5.MaxInputLength = 4;
            this.B5.Name = "B5";
            this.B5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B5.Width = 30;
            // 
            // B6
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.B6.DefaultCellStyle = dataGridViewCellStyle22;
            this.B6.HeaderText = "B6";
            this.B6.MaxInputLength = 4;
            this.B6.Name = "B6";
            this.B6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B6.Width = 30;
            // 
            // B7
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.B7.DefaultCellStyle = dataGridViewCellStyle23;
            this.B7.HeaderText = "B7";
            this.B7.MaxInputLength = 4;
            this.B7.Name = "B7";
            this.B7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B7.Width = 30;
            // 
            // TxPanelDGVContextMenuStrip
            // 
            this.TxPanelDGVContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMessageToolStripMenuItem});
            this.TxPanelDGVContextMenuStrip.Name = "TxPanelDGVContextMenuStrip";
            this.TxPanelDGVContextMenuStrip.Size = new System.Drawing.Size(157, 26);
            // 
            // AddMessageToolStripMenuItem
            // 
            this.AddMessageToolStripMenuItem.Name = "AddMessageToolStripMenuItem";
            this.AddMessageToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.AddMessageToolStripMenuItem.Text = "Add message";
            this.AddMessageToolStripMenuItem.Click += new System.EventHandler(this.AddMessageToolStripMenuItem_Click);
            // 
            // TxMsgTimer
            // 
            this.TxMsgTimer.Interval = 100;
            this.TxMsgTimer.Tick += new System.EventHandler(this.TxMsgTimer_Tick);
            // 
            // TxPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 262);
            this.Controls.Add(this.TxPanelDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TxPanelForm";
            this.Text = "TxPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TxPanelFormClosing);
            this.Load += new System.EventHandler(this.TxPanelWindowLoad);
            ((System.ComponentModel.ISupportInitialize)(this.TxPanelDataGridView)).EndInit();
            this.TxPanelDGVContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TxPanelDataGridView;
        private System.Windows.Forms.ContextMenuStrip TxPanelDGVContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddMessageToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn Tx;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Auto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DLC;
        private System.Windows.Forms.DataGridViewTextBoxColumn B0;
        private System.Windows.Forms.DataGridViewTextBoxColumn B1;
        private System.Windows.Forms.DataGridViewTextBoxColumn B2;
        private System.Windows.Forms.DataGridViewTextBoxColumn B3;
        private System.Windows.Forms.DataGridViewTextBoxColumn B4;
        private System.Windows.Forms.DataGridViewTextBoxColumn B5;
        private System.Windows.Forms.DataGridViewTextBoxColumn B6;
        private System.Windows.Forms.DataGridViewTextBoxColumn B7;
        private System.Windows.Forms.Timer TxMsgTimer;
    }
}