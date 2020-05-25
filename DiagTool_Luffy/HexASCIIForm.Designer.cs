namespace DiagTool_Luffy
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
            this.HexTextBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexTextBox.Location = new System.Drawing.Point(57, 35);
            this.HexTextBox.Name = "HexTextBox";
            this.HexTextBox.Size = new System.Drawing.Size(244, 19);
            this.HexTextBox.TabIndex = 0;
            // 
            // ASCIITextBox
            // 
            this.ASCIITextBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASCIITextBox.Location = new System.Drawing.Point(57, 86);
            this.ASCIITextBox.Name = "ASCIITextBox";
            this.ASCIITextBox.Size = new System.Drawing.Size(244, 19);
            this.ASCIITextBox.TabIndex = 1;
            // 
            // ToASCIIButton
            // 
            this.ToASCIIButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToASCIIButton.Location = new System.Drawing.Point(88, 60);
            this.ToASCIIButton.Name = "ToASCIIButton";
            this.ToASCIIButton.Size = new System.Drawing.Size(50, 20);
            this.ToASCIIButton.TabIndex = 2;
            this.ToASCIIButton.Text = "ToAscii";
            this.ToASCIIButton.UseVisualStyleBackColor = true;
            this.ToASCIIButton.Click += new System.EventHandler(this.ToASCIIButton_Click);
            // 
            // ToHexButton
            // 
            this.ToHexButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToHexButton.Location = new System.Drawing.Point(209, 60);
            this.ToHexButton.Name = "ToHexButton";
            this.ToHexButton.Size = new System.Drawing.Size(50, 20);
            this.ToHexButton.TabIndex = 3;
            this.ToHexButton.Text = "ToHex";
            this.ToHexButton.UseVisualStyleBackColor = true;
            this.ToHexButton.Click += new System.EventHandler(this.ToHexButton_Click);
            // 
            // HexLabel
            // 
            this.HexLabel.AutoSize = true;
            this.HexLabel.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexLabel.Location = new System.Drawing.Point(21, 35);
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(25, 12);
            this.HexLabel.TabIndex = 4;
            this.HexLabel.Text = "Hex:";
            // 
            // ASCIILabel
            // 
            this.ASCIILabel.AutoSize = true;
            this.ASCIILabel.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASCIILabel.Location = new System.Drawing.Point(18, 89);
            this.ASCIILabel.Name = "ASCIILabel";
            this.ASCIILabel.Size = new System.Drawing.Size(28, 12);
            this.ASCIILabel.TabIndex = 5;
            this.ASCIILabel.Text = "Ascii:";
            // 
            // HexASCIIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 152);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hex&&ASCII";
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