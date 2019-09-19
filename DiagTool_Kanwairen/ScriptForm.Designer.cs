namespace DiagTool_Kanwairen
{
    partial class ScriptForm
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
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(27, 21);
            this.ScriptTextBox.Multiline = true;
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ScriptTextBox.Size = new System.Drawing.Size(525, 374);
            this.ScriptTextBox.TabIndex = 0;
            this.ScriptTextBox.WordWrap = false;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(372, 413);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(83, 36);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ScriptTextBox);
            this.Name = "ScriptForm";
            this.Text = "Script";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScriptFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.Button RunButton;
    }
}