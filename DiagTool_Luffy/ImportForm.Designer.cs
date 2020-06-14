namespace DiagTool_Luffy
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
            this.SADllPathnameLabel = new System.Windows.Forms.Label();
            this.DllPathnameTextBox = new System.Windows.Forms.TextBox();
            this.DllSelectButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SADllPathnameLabel
            // 
            this.SADllPathnameLabel.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SADllPathnameLabel.Location = new System.Drawing.Point(12, 26);
            this.SADllPathnameLabel.Name = "SADllPathnameLabel";
            this.SADllPathnameLabel.Size = new System.Drawing.Size(40, 19);
            this.SADllPathnameLabel.TabIndex = 0;
            this.SADllPathnameLabel.Text = "SA dll:";
            this.SADllPathnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DllPathnameTextBox
            // 
            this.DllPathnameTextBox.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DllPathnameTextBox.Location = new System.Drawing.Point(17, 48);
            this.DllPathnameTextBox.Name = "DllPathnameTextBox";
            this.DllPathnameTextBox.Size = new System.Drawing.Size(270, 19);
            this.DllPathnameTextBox.TabIndex = 1;
            // 
            // DllSelectButton
            // 
            this.DllSelectButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DllSelectButton.Image = ((System.Drawing.Image)(resources.GetObject("DllSelectButton.Image")));
            this.DllSelectButton.Location = new System.Drawing.Point(295, 44);
            this.DllSelectButton.Name = "DllSelectButton";
            this.DllSelectButton.Size = new System.Drawing.Size(27, 25);
            this.DllSelectButton.TabIndex = 2;
            this.DllSelectButton.UseVisualStyleBackColor = true;
            this.DllSelectButton.Click += new System.EventHandler(this.DllSelectButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.Location = new System.Drawing.Point(81, 114);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(45, 23);
            this.YesButton.TabIndex = 3;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.Location = new System.Drawing.Point(181, 114);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(45, 23);
            this.NoButton.TabIndex = 4;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.ConcelButton_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 188);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.DllSelectButton);
            this.Controls.Add(this.DllPathnameTextBox);
            this.Controls.Add(this.SADllPathnameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.Load += new System.EventHandler(this.ImportWindowLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SADllPathnameLabel;
        private System.Windows.Forms.TextBox DllPathnameTextBox;
        private System.Windows.Forms.Button DllSelectButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
    }
}