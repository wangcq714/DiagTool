namespace Diag_Tool_leon
{
    partial class importDiag
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ImportDll = new System.Windows.Forms.Button();
            this.Comfirm = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(22, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 44);
            this.textBox1.TabIndex = 0;
            // 
            // ImportDll
            // 
            this.ImportDll.Location = new System.Drawing.Point(125, 75);
            this.ImportDll.Name = "ImportDll";
            this.ImportDll.Size = new System.Drawing.Size(75, 33);
            this.ImportDll.TabIndex = 1;
            this.ImportDll.Text = "选择文件";
            this.ImportDll.UseVisualStyleBackColor = true;
            this.ImportDll.Click += new System.EventHandler(this.ImportDll_Click);
            // 
            // Comfirm
            // 
            this.Comfirm.Location = new System.Drawing.Point(22, 108);
            this.Comfirm.Name = "Comfirm";
            this.Comfirm.Size = new System.Drawing.Size(75, 32);
            this.Comfirm.TabIndex = 2;
            this.Comfirm.Text = "确认";
            this.Comfirm.UseVisualStyleBackColor = true;
            this.Comfirm.Click += new System.EventHandler(this.Comfirm_Click);
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(247, 108);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(75, 32);
            this.Cancle.TabIndex = 3;
            this.Cancle.Text = "取消";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // importDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 167);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.Comfirm);
            this.Controls.Add(this.ImportDll);
            this.Controls.Add(this.textBox1);
            this.Name = "importDiag";
            this.Text = "importDiag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ImportDll;
        private System.Windows.Forms.Button Comfirm;
        private System.Windows.Forms.Button Cancle;

    }
}