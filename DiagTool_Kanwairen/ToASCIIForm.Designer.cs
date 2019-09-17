namespace DiagTool_Kanwairen
{
    partial class ToASCIIForm
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
            this.HexTextBox = new System.Windows.Forms.TextBox();
            this.ASCIITextBox = new System.Windows.Forms.TextBox();
            this.ToASCIIButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HexTextBox
            // 
            this.HexTextBox.Location = new System.Drawing.Point(63, 39);
            this.HexTextBox.Name = "HexTextBox";
            this.HexTextBox.Size = new System.Drawing.Size(447, 21);
            this.HexTextBox.TabIndex = 0;
            // 
            // ASCIITextBox
            // 
            this.ASCIITextBox.Location = new System.Drawing.Point(63, 163);
            this.ASCIITextBox.Name = "ASCIITextBox";
            this.ASCIITextBox.Size = new System.Drawing.Size(446, 21);
            this.ASCIITextBox.TabIndex = 1;
            // 
            // ToASCIIButton
            // 
            this.ToASCIIButton.Location = new System.Drawing.Point(209, 90);
            this.ToASCIIButton.Name = "ToASCIIButton";
            this.ToASCIIButton.Size = new System.Drawing.Size(125, 32);
            this.ToASCIIButton.TabIndex = 2;
            this.ToASCIIButton.Text = "ToASCII";
            this.ToASCIIButton.UseVisualStyleBackColor = true;
            this.ToASCIIButton.Click += new System.EventHandler(this.ToASCIIButton_Click);
            // 
            // ToASCIIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.ToASCIIButton);
            this.Controls.Add(this.ASCIITextBox);
            this.Controls.Add(this.HexTextBox);
            this.Name = "ToASCIIForm";
            this.Text = "ToASCIIForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToASCIIFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HexTextBox;
        private System.Windows.Forms.TextBox ASCIITextBox;
        private System.Windows.Forms.Button ToASCIIButton;
    }
}