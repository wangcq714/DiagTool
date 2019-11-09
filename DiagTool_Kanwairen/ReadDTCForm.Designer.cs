namespace DiagTool_Kanwairen
{
    partial class ReadDTCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadDTCForm));
            this.DTCDisplayTextBox = new System.Windows.Forms.TextBox();
            this.ReadDTCButton = new System.Windows.Forms.Button();
            this.ReadDTCComboBox = new System.Windows.Forms.ComboBox();
            this.DTCHighByteTextBox = new System.Windows.Forms.TextBox();
            this.DTCLowByteTextBox = new System.Windows.Forms.TextBox();
            this.DTCFaultTypeTextBox = new System.Windows.Forms.TextBox();
            this.RecordNumberTextBox = new System.Windows.Forms.TextBox();
            this.TestFailedCheckBox = new System.Windows.Forms.CheckBox();
            this.TestFailedThisMonitoringCycleCheckBox = new System.Windows.Forms.CheckBox();
            this.PendingDTCCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmedDTCCheckBox = new System.Windows.Forms.CheckBox();
            this.TestNotCompletedSinceLastClearCheckBox = new System.Windows.Forms.CheckBox();
            this.TestFailedSinceLastClearCheckBox = new System.Windows.Forms.CheckBox();
            this.TestNotCompletedThisMonitoringCycleCheckBox = new System.Windows.Forms.CheckBox();
            this.WarningIndicatorRequestedCheckBox = new System.Windows.Forms.CheckBox();
            this.DTCMasklabel = new System.Windows.Forms.Label();
            this.Bit0Label = new System.Windows.Forms.Label();
            this.Bit1Label = new System.Windows.Forms.Label();
            this.Bit2Label = new System.Windows.Forms.Label();
            this.Bit3Label = new System.Windows.Forms.Label();
            this.Bit4Label = new System.Windows.Forms.Label();
            this.Bit5Label = new System.Windows.Forms.Label();
            this.Bit6Label = new System.Windows.Forms.Label();
            this.Bit7Label = new System.Windows.Forms.Label();
            this.DTCListLabel = new System.Windows.Forms.Label();
            this.HighByteLabel = new System.Windows.Forms.Label();
            this.LowByteLabel = new System.Windows.Forms.Label();
            this.FaultTypeLabel = new System.Windows.Forms.Label();
            this.RecordNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTCDisplayTextBox
            // 
            this.DTCDisplayTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DTCDisplayTextBox.Location = new System.Drawing.Point(24, 41);
            this.DTCDisplayTextBox.Multiline = true;
            this.DTCDisplayTextBox.Name = "DTCDisplayTextBox";
            this.DTCDisplayTextBox.ReadOnly = true;
            this.DTCDisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DTCDisplayTextBox.Size = new System.Drawing.Size(130, 351);
            this.DTCDisplayTextBox.TabIndex = 0;
            this.DTCDisplayTextBox.WordWrap = false;
            // 
            // ReadDTCButton
            // 
            this.ReadDTCButton.Location = new System.Drawing.Point(215, 86);
            this.ReadDTCButton.Name = "ReadDTCButton";
            this.ReadDTCButton.Size = new System.Drawing.Size(214, 31);
            this.ReadDTCButton.TabIndex = 1;
            this.ReadDTCButton.Text = "Read";
            this.ReadDTCButton.UseVisualStyleBackColor = true;
            this.ReadDTCButton.Click += new System.EventHandler(this.ReadDTCButton_Click);
            // 
            // ReadDTCComboBox
            // 
            this.ReadDTCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReadDTCComboBox.FormattingEnabled = true;
            this.ReadDTCComboBox.Items.AddRange(new object[] {
            "19 01",
            "19 02",
            "19 04",
            "19 06",
            "19 0A"});
            this.ReadDTCComboBox.Location = new System.Drawing.Point(215, 41);
            this.ReadDTCComboBox.Name = "ReadDTCComboBox";
            this.ReadDTCComboBox.Size = new System.Drawing.Size(67, 20);
            this.ReadDTCComboBox.TabIndex = 2;
            this.ReadDTCComboBox.SelectedIndexChanged += new System.EventHandler(this.ReadDTCComboBox_SelectedIndexChanged);
            // 
            // DTCHighByteTextBox
            // 
            this.DTCHighByteTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DTCHighByteTextBox.Location = new System.Drawing.Point(297, 40);
            this.DTCHighByteTextBox.Name = "DTCHighByteTextBox";
            this.DTCHighByteTextBox.Size = new System.Drawing.Size(27, 21);
            this.DTCHighByteTextBox.TabIndex = 3;
            this.DTCHighByteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTCLowByteTextBox
            // 
            this.DTCLowByteTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DTCLowByteTextBox.Location = new System.Drawing.Point(332, 40);
            this.DTCLowByteTextBox.Name = "DTCLowByteTextBox";
            this.DTCLowByteTextBox.Size = new System.Drawing.Size(27, 21);
            this.DTCLowByteTextBox.TabIndex = 4;
            this.DTCLowByteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTCFaultTypeTextBox
            // 
            this.DTCFaultTypeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DTCFaultTypeTextBox.Location = new System.Drawing.Point(367, 40);
            this.DTCFaultTypeTextBox.Name = "DTCFaultTypeTextBox";
            this.DTCFaultTypeTextBox.Size = new System.Drawing.Size(27, 21);
            this.DTCFaultTypeTextBox.TabIndex = 5;
            this.DTCFaultTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RecordNumberTextBox
            // 
            this.RecordNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.RecordNumberTextBox.Location = new System.Drawing.Point(402, 40);
            this.RecordNumberTextBox.Name = "RecordNumberTextBox";
            this.RecordNumberTextBox.Size = new System.Drawing.Size(27, 21);
            this.RecordNumberTextBox.TabIndex = 6;
            this.RecordNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TestFailedCheckBox
            // 
            this.TestFailedCheckBox.AutoSize = true;
            this.TestFailedCheckBox.Checked = true;
            this.TestFailedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TestFailedCheckBox.Location = new System.Drawing.Point(215, 194);
            this.TestFailedCheckBox.Name = "TestFailedCheckBox";
            this.TestFailedCheckBox.Size = new System.Drawing.Size(90, 16);
            this.TestFailedCheckBox.TabIndex = 7;
            this.TestFailedCheckBox.Text = "Test failed";
            this.TestFailedCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestFailedThisMonitoringCycleCheckBox
            // 
            this.TestFailedThisMonitoringCycleCheckBox.AutoSize = true;
            this.TestFailedThisMonitoringCycleCheckBox.Checked = true;
            this.TestFailedThisMonitoringCycleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TestFailedThisMonitoringCycleCheckBox.Location = new System.Drawing.Point(215, 218);
            this.TestFailedThisMonitoringCycleCheckBox.Name = "TestFailedThisMonitoringCycleCheckBox";
            this.TestFailedThisMonitoringCycleCheckBox.Size = new System.Drawing.Size(222, 16);
            this.TestFailedThisMonitoringCycleCheckBox.TabIndex = 8;
            this.TestFailedThisMonitoringCycleCheckBox.Text = "Test failed this monitoring cycle";
            this.TestFailedThisMonitoringCycleCheckBox.UseVisualStyleBackColor = true;
            // 
            // PendingDTCCheckBox
            // 
            this.PendingDTCCheckBox.AutoSize = true;
            this.PendingDTCCheckBox.Checked = true;
            this.PendingDTCCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PendingDTCCheckBox.Location = new System.Drawing.Point(215, 242);
            this.PendingDTCCheckBox.Name = "PendingDTCCheckBox";
            this.PendingDTCCheckBox.Size = new System.Drawing.Size(90, 16);
            this.PendingDTCCheckBox.TabIndex = 9;
            this.PendingDTCCheckBox.Text = "Pending DTC";
            this.PendingDTCCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmedDTCCheckBox
            // 
            this.ConfirmedDTCCheckBox.AutoSize = true;
            this.ConfirmedDTCCheckBox.Checked = true;
            this.ConfirmedDTCCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConfirmedDTCCheckBox.Location = new System.Drawing.Point(215, 266);
            this.ConfirmedDTCCheckBox.Name = "ConfirmedDTCCheckBox";
            this.ConfirmedDTCCheckBox.Size = new System.Drawing.Size(102, 16);
            this.ConfirmedDTCCheckBox.TabIndex = 10;
            this.ConfirmedDTCCheckBox.Text = "Confirmed DTC";
            this.ConfirmedDTCCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestNotCompletedSinceLastClearCheckBox
            // 
            this.TestNotCompletedSinceLastClearCheckBox.AutoSize = true;
            this.TestNotCompletedSinceLastClearCheckBox.Location = new System.Drawing.Point(215, 290);
            this.TestNotCompletedSinceLastClearCheckBox.Name = "TestNotCompletedSinceLastClearCheckBox";
            this.TestNotCompletedSinceLastClearCheckBox.Size = new System.Drawing.Size(234, 16);
            this.TestNotCompletedSinceLastClearCheckBox.TabIndex = 11;
            this.TestNotCompletedSinceLastClearCheckBox.Text = "Test not completed since last clear";
            this.TestNotCompletedSinceLastClearCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestFailedSinceLastClearCheckBox
            // 
            this.TestFailedSinceLastClearCheckBox.AutoSize = true;
            this.TestFailedSinceLastClearCheckBox.Checked = true;
            this.TestFailedSinceLastClearCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TestFailedSinceLastClearCheckBox.Location = new System.Drawing.Point(215, 314);
            this.TestFailedSinceLastClearCheckBox.Name = "TestFailedSinceLastClearCheckBox";
            this.TestFailedSinceLastClearCheckBox.Size = new System.Drawing.Size(192, 16);
            this.TestFailedSinceLastClearCheckBox.TabIndex = 12;
            this.TestFailedSinceLastClearCheckBox.Text = "Test failed since last clear";
            this.TestFailedSinceLastClearCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestNotCompletedThisMonitoringCycleCheckBox
            // 
            this.TestNotCompletedThisMonitoringCycleCheckBox.AutoSize = true;
            this.TestNotCompletedThisMonitoringCycleCheckBox.Location = new System.Drawing.Point(215, 338);
            this.TestNotCompletedThisMonitoringCycleCheckBox.Name = "TestNotCompletedThisMonitoringCycleCheckBox";
            this.TestNotCompletedThisMonitoringCycleCheckBox.Size = new System.Drawing.Size(264, 16);
            this.TestNotCompletedThisMonitoringCycleCheckBox.TabIndex = 13;
            this.TestNotCompletedThisMonitoringCycleCheckBox.Text = "Test not completed this monitoring cycle";
            this.TestNotCompletedThisMonitoringCycleCheckBox.UseVisualStyleBackColor = true;
            // 
            // WarningIndicatorRequestedCheckBox
            // 
            this.WarningIndicatorRequestedCheckBox.AutoSize = true;
            this.WarningIndicatorRequestedCheckBox.Location = new System.Drawing.Point(215, 362);
            this.WarningIndicatorRequestedCheckBox.Name = "WarningIndicatorRequestedCheckBox";
            this.WarningIndicatorRequestedCheckBox.Size = new System.Drawing.Size(186, 16);
            this.WarningIndicatorRequestedCheckBox.TabIndex = 14;
            this.WarningIndicatorRequestedCheckBox.Text = "Warning indicator requested";
            this.WarningIndicatorRequestedCheckBox.UseVisualStyleBackColor = true;
            // 
            // DTCMasklabel
            // 
            this.DTCMasklabel.AutoSize = true;
            this.DTCMasklabel.Location = new System.Drawing.Point(175, 168);
            this.DTCMasklabel.Name = "DTCMasklabel";
            this.DTCMasklabel.Size = new System.Drawing.Size(35, 12);
            this.DTCMasklabel.TabIndex = 15;
            this.DTCMasklabel.Text = "Mask:";
            // 
            // Bit0Label
            // 
            this.Bit0Label.AutoSize = true;
            this.Bit0Label.Location = new System.Drawing.Point(174, 196);
            this.Bit0Label.Name = "Bit0Label";
            this.Bit0Label.Size = new System.Drawing.Size(35, 12);
            this.Bit0Label.TabIndex = 16;
            this.Bit0Label.Text = "Bit0:";
            // 
            // Bit1Label
            // 
            this.Bit1Label.AutoSize = true;
            this.Bit1Label.Location = new System.Drawing.Point(174, 220);
            this.Bit1Label.Name = "Bit1Label";
            this.Bit1Label.Size = new System.Drawing.Size(35, 12);
            this.Bit1Label.TabIndex = 17;
            this.Bit1Label.Text = "Bit1:";
            // 
            // Bit2Label
            // 
            this.Bit2Label.AutoSize = true;
            this.Bit2Label.Location = new System.Drawing.Point(174, 244);
            this.Bit2Label.Name = "Bit2Label";
            this.Bit2Label.Size = new System.Drawing.Size(35, 12);
            this.Bit2Label.TabIndex = 18;
            this.Bit2Label.Text = "Bit2:";
            // 
            // Bit3Label
            // 
            this.Bit3Label.AutoSize = true;
            this.Bit3Label.Location = new System.Drawing.Point(174, 268);
            this.Bit3Label.Name = "Bit3Label";
            this.Bit3Label.Size = new System.Drawing.Size(35, 12);
            this.Bit3Label.TabIndex = 19;
            this.Bit3Label.Text = "Bit3:";
            // 
            // Bit4Label
            // 
            this.Bit4Label.AutoSize = true;
            this.Bit4Label.Location = new System.Drawing.Point(174, 292);
            this.Bit4Label.Name = "Bit4Label";
            this.Bit4Label.Size = new System.Drawing.Size(35, 12);
            this.Bit4Label.TabIndex = 20;
            this.Bit4Label.Text = "Bit4:";
            // 
            // Bit5Label
            // 
            this.Bit5Label.AutoSize = true;
            this.Bit5Label.Location = new System.Drawing.Point(174, 316);
            this.Bit5Label.Name = "Bit5Label";
            this.Bit5Label.Size = new System.Drawing.Size(35, 12);
            this.Bit5Label.TabIndex = 21;
            this.Bit5Label.Text = "Bit5:";
            // 
            // Bit6Label
            // 
            this.Bit6Label.AutoSize = true;
            this.Bit6Label.Location = new System.Drawing.Point(174, 340);
            this.Bit6Label.Name = "Bit6Label";
            this.Bit6Label.Size = new System.Drawing.Size(35, 12);
            this.Bit6Label.TabIndex = 22;
            this.Bit6Label.Text = "Bit6:";
            // 
            // Bit7Label
            // 
            this.Bit7Label.AutoSize = true;
            this.Bit7Label.Location = new System.Drawing.Point(174, 364);
            this.Bit7Label.Name = "Bit7Label";
            this.Bit7Label.Size = new System.Drawing.Size(35, 12);
            this.Bit7Label.TabIndex = 23;
            this.Bit7Label.Text = "Bit7:";
            // 
            // DTCListLabel
            // 
            this.DTCListLabel.AutoSize = true;
            this.DTCListLabel.Location = new System.Drawing.Point(23, 22);
            this.DTCListLabel.Name = "DTCListLabel";
            this.DTCListLabel.Size = new System.Drawing.Size(53, 12);
            this.DTCListLabel.TabIndex = 24;
            this.DTCListLabel.Text = "DTCList:";
            // 
            // HighByteLabel
            // 
            this.HighByteLabel.AutoSize = true;
            this.HighByteLabel.Location = new System.Drawing.Point(299, 22);
            this.HighByteLabel.Name = "HighByteLabel";
            this.HighByteLabel.Size = new System.Drawing.Size(23, 12);
            this.HighByteLabel.TabIndex = 25;
            this.HighByteLabel.Text = "HB:";
            // 
            // LowByteLabel
            // 
            this.LowByteLabel.AutoSize = true;
            this.LowByteLabel.Location = new System.Drawing.Point(334, 22);
            this.LowByteLabel.Name = "LowByteLabel";
            this.LowByteLabel.Size = new System.Drawing.Size(23, 12);
            this.LowByteLabel.TabIndex = 26;
            this.LowByteLabel.Text = "LB:";
            // 
            // FaultTypeLabel
            // 
            this.FaultTypeLabel.AutoSize = true;
            this.FaultTypeLabel.Location = new System.Drawing.Point(369, 22);
            this.FaultTypeLabel.Name = "FaultTypeLabel";
            this.FaultTypeLabel.Size = new System.Drawing.Size(23, 12);
            this.FaultTypeLabel.TabIndex = 27;
            this.FaultTypeLabel.Text = "FT:";
            // 
            // RecordNumberLabel
            // 
            this.RecordNumberLabel.AutoSize = true;
            this.RecordNumberLabel.Location = new System.Drawing.Point(404, 22);
            this.RecordNumberLabel.Name = "RecordNumberLabel";
            this.RecordNumberLabel.Size = new System.Drawing.Size(23, 12);
            this.RecordNumberLabel.TabIndex = 28;
            this.RecordNumberLabel.Text = "RN:";
            // 
            // ReadDTCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 406);
            this.Controls.Add(this.RecordNumberLabel);
            this.Controls.Add(this.FaultTypeLabel);
            this.Controls.Add(this.LowByteLabel);
            this.Controls.Add(this.HighByteLabel);
            this.Controls.Add(this.DTCListLabel);
            this.Controls.Add(this.Bit7Label);
            this.Controls.Add(this.Bit6Label);
            this.Controls.Add(this.Bit5Label);
            this.Controls.Add(this.Bit4Label);
            this.Controls.Add(this.Bit3Label);
            this.Controls.Add(this.Bit2Label);
            this.Controls.Add(this.Bit1Label);
            this.Controls.Add(this.Bit0Label);
            this.Controls.Add(this.DTCMasklabel);
            this.Controls.Add(this.WarningIndicatorRequestedCheckBox);
            this.Controls.Add(this.TestNotCompletedThisMonitoringCycleCheckBox);
            this.Controls.Add(this.TestFailedSinceLastClearCheckBox);
            this.Controls.Add(this.TestNotCompletedSinceLastClearCheckBox);
            this.Controls.Add(this.ConfirmedDTCCheckBox);
            this.Controls.Add(this.PendingDTCCheckBox);
            this.Controls.Add(this.TestFailedThisMonitoringCycleCheckBox);
            this.Controls.Add(this.TestFailedCheckBox);
            this.Controls.Add(this.RecordNumberTextBox);
            this.Controls.Add(this.DTCFaultTypeTextBox);
            this.Controls.Add(this.DTCLowByteTextBox);
            this.Controls.Add(this.DTCHighByteTextBox);
            this.Controls.Add(this.ReadDTCComboBox);
            this.Controls.Add(this.ReadDTCButton);
            this.Controls.Add(this.DTCDisplayTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReadDTCForm";
            this.Text = "ReadDTC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadDTCFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DTCDisplayTextBox;
        private System.Windows.Forms.Button ReadDTCButton;
        private System.Windows.Forms.ComboBox ReadDTCComboBox;
        private System.Windows.Forms.TextBox DTCHighByteTextBox;
        private System.Windows.Forms.TextBox DTCLowByteTextBox;
        private System.Windows.Forms.TextBox DTCFaultTypeTextBox;
        private System.Windows.Forms.TextBox RecordNumberTextBox;
        private System.Windows.Forms.CheckBox TestFailedCheckBox;
        private System.Windows.Forms.CheckBox TestFailedThisMonitoringCycleCheckBox;
        private System.Windows.Forms.CheckBox PendingDTCCheckBox;
        private System.Windows.Forms.CheckBox ConfirmedDTCCheckBox;
        private System.Windows.Forms.CheckBox TestNotCompletedSinceLastClearCheckBox;
        private System.Windows.Forms.CheckBox TestFailedSinceLastClearCheckBox;
        private System.Windows.Forms.CheckBox TestNotCompletedThisMonitoringCycleCheckBox;
        private System.Windows.Forms.CheckBox WarningIndicatorRequestedCheckBox;
        private System.Windows.Forms.Label DTCMasklabel;
        private System.Windows.Forms.Label Bit0Label;
        private System.Windows.Forms.Label Bit1Label;
        private System.Windows.Forms.Label Bit2Label;
        private System.Windows.Forms.Label Bit3Label;
        private System.Windows.Forms.Label Bit4Label;
        private System.Windows.Forms.Label Bit5Label;
        private System.Windows.Forms.Label Bit6Label;
        private System.Windows.Forms.Label Bit7Label;
        private System.Windows.Forms.Label DTCListLabel;
        private System.Windows.Forms.Label HighByteLabel;
        private System.Windows.Forms.Label LowByteLabel;
        private System.Windows.Forms.Label FaultTypeLabel;
        private System.Windows.Forms.Label RecordNumberLabel;
    }
}