namespace DiagTool_Luffy
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.ScriptTimeIntervalLabel = new System.Windows.Forms.Label();
            this.ScriptTimeIntervalTextBox = new System.Windows.Forms.TextBox();
            this.ScriptTimeUnitLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "125k",
            "250k",
            "500k"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(80, 16);
            this.BaudRateComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(56, 20);
            this.BaudRateComboBox.TabIndex = 9;
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateLabel.Location = new System.Drawing.Point(19, 15);
            this.BaudRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(56, 23);
            this.BaudRateLabel.TabIndex = 8;
            this.BaudRateLabel.Text = "BaudRate:";
            this.BaudRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScriptTimeIntervalLabel
            // 
            this.ScriptTimeIntervalLabel.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptTimeIntervalLabel.Location = new System.Drawing.Point(19, 61);
            this.ScriptTimeIntervalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScriptTimeIntervalLabel.Name = "ScriptTimeIntervalLabel";
            this.ScriptTimeIntervalLabel.Size = new System.Drawing.Size(56, 15);
            this.ScriptTimeIntervalLabel.TabIndex = 10;
            this.ScriptTimeIntervalLabel.Text = "ScriptTime:";
            this.ScriptTimeIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScriptTimeIntervalTextBox
            // 
            this.ScriptTimeIntervalTextBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptTimeIntervalTextBox.Location = new System.Drawing.Point(80, 59);
            this.ScriptTimeIntervalTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ScriptTimeIntervalTextBox.Name = "ScriptTimeIntervalTextBox";
            this.ScriptTimeIntervalTextBox.Size = new System.Drawing.Size(56, 19);
            this.ScriptTimeIntervalTextBox.TabIndex = 11;
            this.ScriptTimeIntervalTextBox.Text = "100";
            // 
            // ScriptTimeUnitLabel
            // 
            this.ScriptTimeUnitLabel.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptTimeUnitLabel.Location = new System.Drawing.Point(143, 58);
            this.ScriptTimeUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScriptTimeUnitLabel.Name = "ScriptTimeUnitLabel";
            this.ScriptTimeUnitLabel.Size = new System.Drawing.Size(22, 21);
            this.ScriptTimeUnitLabel.TabIndex = 12;
            this.ScriptTimeUnitLabel.Text = "ms";
            this.ScriptTimeUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(42, 106);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(44, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(116, 106);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(44, 23);
            this.ReturnButton.TabIndex = 14;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 162);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ScriptTimeUnitLabel);
            this.Controls.Add(this.ScriptTimeIntervalTextBox);
            this.Controls.Add(this.ScriptTimeIntervalLabel);
            this.Controls.Add(this.BaudRateComboBox);
            this.Controls.Add(this.BaudRateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingWindowLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Label ScriptTimeIntervalLabel;
        private System.Windows.Forms.TextBox ScriptTimeIntervalTextBox;
        private System.Windows.Forms.Label ScriptTimeUnitLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}