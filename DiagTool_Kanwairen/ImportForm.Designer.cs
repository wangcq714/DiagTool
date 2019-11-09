namespace DiagTool_Kanwairen
{
    partial class ImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            this.DllPathnameLabel = new System.Windows.Forms.Label();
            this.DllPathnameTextBox = new System.Windows.Forms.TextBox();
            this.DllSelectButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.ConcelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DllPathnameLabel
            // 
            this.DllPathnameLabel.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DllPathnameLabel.Location = new System.Drawing.Point(12, 39);
            this.DllPathnameLabel.Name = "DllPathnameLabel";
            this.DllPathnameLabel.Size = new System.Drawing.Size(49, 23);
            this.DllPathnameLabel.TabIndex = 0;
            this.DllPathnameLabel.Text = "Dll:";
            this.DllPathnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DllPathnameTextBox
            // 
            this.DllPathnameTextBox.Location = new System.Drawing.Point(58, 40);
            this.DllPathnameTextBox.Name = "DllPathnameTextBox";
            this.DllPathnameTextBox.Size = new System.Drawing.Size(358, 21);
            this.DllPathnameTextBox.TabIndex = 1;
            // 
            // DllSelectButton
            // 
            this.DllSelectButton.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DllSelectButton.Image = ((System.Drawing.Image)(resources.GetObject("DllSelectButton.Image")));
            this.DllSelectButton.Location = new System.Drawing.Point(426, 38);
            this.DllSelectButton.Name = "DllSelectButton";
            this.DllSelectButton.Size = new System.Drawing.Size(27, 25);
            this.DllSelectButton.TabIndex = 2;
            this.DllSelectButton.UseVisualStyleBackColor = true;
            this.DllSelectButton.Click += new System.EventHandler(this.DllSelectButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.Location = new System.Drawing.Point(292, 217);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(62, 23);
            this.YesButton.TabIndex = 3;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // ConcelButton
            // 
            this.ConcelButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConcelButton.Location = new System.Drawing.Point(390, 217);
            this.ConcelButton.Name = "ConcelButton";
            this.ConcelButton.Size = new System.Drawing.Size(62, 23);
            this.ConcelButton.TabIndex = 4;
            this.ConcelButton.Text = "Concel";
            this.ConcelButton.UseVisualStyleBackColor = true;
            this.ConcelButton.Click += new System.EventHandler(this.ConcelButton_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.ConcelButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.DllSelectButton);
            this.Controls.Add(this.DllPathnameTextBox);
            this.Controls.Add(this.DllPathnameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportForm";
            this.Text = "Import";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DllPathnameLabel;
        private System.Windows.Forms.TextBox DllPathnameTextBox;
        private System.Windows.Forms.Button DllSelectButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button ConcelButton;
    }
}