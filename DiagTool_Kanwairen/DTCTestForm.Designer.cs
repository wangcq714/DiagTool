namespace DiagTool_Kanwairen
{
    partial class DTCTestForm
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
            this.DTCTestTextBox = new System.Windows.Forms.TextBox();
            this.DTCTestComboBox = new System.Windows.Forms.ComboBox();
            this.ReadDTCButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTCTestTextBox
            // 
            this.DTCTestTextBox.Location = new System.Drawing.Point(16, 13);
            this.DTCTestTextBox.Multiline = true;
            this.DTCTestTextBox.Name = "DTCTestTextBox";
            this.DTCTestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DTCTestTextBox.Size = new System.Drawing.Size(184, 532);
            this.DTCTestTextBox.TabIndex = 0;
            this.DTCTestTextBox.WordWrap = false;
            // 
            // DTCTestComboBox
            // 
            this.DTCTestComboBox.FormattingEnabled = true;
            this.DTCTestComboBox.Items.AddRange(new object[] {
            "19 01",
            "19 02",
            "19 04",
            "19 06",
            "19 0A"});
            this.DTCTestComboBox.Location = new System.Drawing.Point(236, 43);
            this.DTCTestComboBox.Name = "DTCTestComboBox";
            this.DTCTestComboBox.Size = new System.Drawing.Size(109, 20);
            this.DTCTestComboBox.TabIndex = 1;
            // 
            // ReadDTCButton
            // 
            this.ReadDTCButton.Location = new System.Drawing.Point(236, 81);
            this.ReadDTCButton.Name = "ReadDTCButton";
            this.ReadDTCButton.Size = new System.Drawing.Size(109, 24);
            this.ReadDTCButton.TabIndex = 2;
            this.ReadDTCButton.Text = "Read";
            this.ReadDTCButton.UseVisualStyleBackColor = true;
            this.ReadDTCButton.Click += new System.EventHandler(this.ReadDTCButton_Click);
            // 
            // DTCTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.ReadDTCButton);
            this.Controls.Add(this.DTCTestComboBox);
            this.Controls.Add(this.DTCTestTextBox);
            this.Name = "DTCTestForm";
            this.Text = "DTCTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DTCTestFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DTCTestTextBox;
        private System.Windows.Forms.ComboBox DTCTestComboBox;
        private System.Windows.Forms.Button ReadDTCButton;
    }
}