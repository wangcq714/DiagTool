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
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.LoopButton = new System.Windows.Forms.Button();
            this.LoopTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(20, 20);
            this.ScriptTextBox.Multiline = true;
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ScriptTextBox.Size = new System.Drawing.Size(207, 319);
            this.ScriptTextBox.TabIndex = 0;
            this.ScriptTextBox.WordWrap = false;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(184, 359);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(43, 24);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Location = new System.Drawing.Point(134, 362);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(48, 16);
            this.LoopCheckBox.TabIndex = 2;
            this.LoopCheckBox.Text = "Loop";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoopButton
            // 
            this.LoopButton.Location = new System.Drawing.Point(20, 358);
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.Size = new System.Drawing.Size(43, 24);
            this.LoopButton.TabIndex = 3;
            this.LoopButton.Text = "Loop";
            this.LoopButton.UseVisualStyleBackColor = true;
            this.LoopButton.Click += new System.EventHandler(this.LoopButton_Click);
            // 
            // LoopTextBox
            // 
            this.LoopTextBox.Location = new System.Drawing.Point(69, 360);
            this.LoopTextBox.Name = "LoopTextBox";
            this.LoopTextBox.Size = new System.Drawing.Size(50, 21);
            this.LoopTextBox.TabIndex = 4;
            this.LoopTextBox.Text = "1";
            // 
            // ScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 395);
            this.Controls.Add(this.LoopTextBox);
            this.Controls.Add(this.LoopButton);
            this.Controls.Add(this.LoopCheckBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ScriptTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScriptForm";
            this.Text = "Script";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScriptFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.CheckBox LoopCheckBox;
        private System.Windows.Forms.Button LoopButton;
        private System.Windows.Forms.TextBox LoopTextBox;
    }
}