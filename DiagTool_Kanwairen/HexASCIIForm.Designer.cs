namespace DiagTool_Kanwairen
{
    partial class HexASCIIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexASCIIForm));
            this.HexTextBox = new System.Windows.Forms.TextBox();
            this.ASCIITextBox = new System.Windows.Forms.TextBox();
            this.ToASCIIButton = new System.Windows.Forms.Button();
            this.ToHexButton = new System.Windows.Forms.Button();
            this.HexLabel = new System.Windows.Forms.Label();
            this.ASCIILabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HexTextBox
            // 
            this.HexTextBox.Location = new System.Drawing.Point(71, 31);
            this.HexTextBox.Name = "HexTextBox";
            this.HexTextBox.Size = new System.Drawing.Size(447, 21);
            this.HexTextBox.TabIndex = 0;
            // 
            // ASCIITextBox
            // 
            this.ASCIITextBox.Location = new System.Drawing.Point(71, 125);
            this.ASCIITextBox.Name = "ASCIITextBox";
            this.ASCIITextBox.Size = new System.Drawing.Size(446, 21);
            this.ASCIITextBox.TabIndex = 1;
            // 
            // ToASCIIButton
            // 
            this.ToASCIIButton.Location = new System.Drawing.Point(217, 69);
            this.ToASCIIButton.Name = "ToASCIIButton";
            this.ToASCIIButton.Size = new System.Drawing.Size(98, 32);
            this.ToASCIIButton.TabIndex = 2;
            this.ToASCIIButton.Text = "ToASCII";
            this.ToASCIIButton.UseVisualStyleBackColor = true;
            this.ToASCIIButton.Click += new System.EventHandler(this.ToASCIIButton_Click);
            // 
            // ToHexButton
            // 
            this.ToHexButton.Location = new System.Drawing.Point(217, 172);
            this.ToHexButton.Name = "ToHexButton";
            this.ToHexButton.Size = new System.Drawing.Size(98, 32);
            this.ToHexButton.TabIndex = 3;
            this.ToHexButton.Text = "ToHex";
            this.ToHexButton.UseVisualStyleBackColor = true;
            this.ToHexButton.Click += new System.EventHandler(this.ToHexButton_Click);
            // 
            // HexLabel
            // 
            this.HexLabel.AutoSize = true;
            this.HexLabel.Location = new System.Drawing.Point(26, 35);
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(29, 12);
            this.HexLabel.TabIndex = 4;
            this.HexLabel.Text = "Hex:";
            // 
            // ASCIILabel
            // 
            this.ASCIILabel.AutoSize = true;
            this.ASCIILabel.Location = new System.Drawing.Point(16, 130);
            this.ASCIILabel.Name = "ASCIILabel";
            this.ASCIILabel.Size = new System.Drawing.Size(41, 12);
            this.ASCIILabel.TabIndex = 5;
            this.ASCIILabel.Text = "ASCII:";
            // 
            // HexASCIIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 229);
            this.Controls.Add(this.ASCIILabel);
            this.Controls.Add(this.HexLabel);
            this.Controls.Add(this.ToHexButton);
            this.Controls.Add(this.ToASCIIButton);
            this.Controls.Add(this.ASCIITextBox);
            this.Controls.Add(this.HexTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HexASCIIForm";
            this.Text = "Hex&&ASCII";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToASCIIFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HexTextBox;
        private System.Windows.Forms.TextBox ASCIITextBox;
        private System.Windows.Forms.Button ToASCIIButton;
        private System.Windows.Forms.Button ToHexButton;
        private System.Windows.Forms.Label HexLabel;
        private System.Windows.Forms.Label ASCIILabel;
    }
}