namespace DiagTool_Kanwairen
{
    partial class NRCTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NRCTableForm));
            this.NRCDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NRCDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NRCDataGridView
            // 
            this.NRCDataGridView.AllowUserToAddRows = false;
            this.NRCDataGridView.AllowUserToResizeColumns = false;
            this.NRCDataGridView.AllowUserToResizeRows = false;
            this.NRCDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.NRCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NRCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.NRC,
            this.Description});
            this.NRCDataGridView.Location = new System.Drawing.Point(3, 1);
            this.NRCDataGridView.Name = "NRCDataGridView";
            this.NRCDataGridView.RowHeadersVisible = false;
            this.NRCDataGridView.RowTemplate.Height = 23;
            this.NRCDataGridView.Size = new System.Drawing.Size(580, 558);
            this.NRCDataGridView.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "No.";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 50;
            // 
            // NRC
            // 
            this.NRC.HeaderText = "NRC";
            this.NRC.Name = "NRC";
            this.NRC.ReadOnly = true;
            this.NRC.Width = 60;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 450;
            // 
            // NRCTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.NRCDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NRCTableForm";
            this.Text = "NRCTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NRCTableFormClosing);
            this.Load += new System.EventHandler(this.NRCTableLoad);
            ((System.ComponentModel.ISupportInitialize)(this.NRCDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NRCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}