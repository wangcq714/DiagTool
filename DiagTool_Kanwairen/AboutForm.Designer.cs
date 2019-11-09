namespace DiagTool_Kanwairen
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(65, 56);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(77, 12);
            this.AuthorLabel.TabIndex = 0;
            this.AuthorLabel.Text = "Author: Leon";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(60, 100);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(95, 12);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Version: v1.0.0";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(245, 172);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.AuthorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label VersionLabel;
    }
}