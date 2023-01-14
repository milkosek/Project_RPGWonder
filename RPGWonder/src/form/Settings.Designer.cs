namespace RPGWonder
{
    partial class Settings
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
            instance = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.systemComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pathLabel = new System.Windows.Forms.Label();
            this.systemLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemComboBox
            // 
            resources.ApplyResources(this.systemComboBox, "systemComboBox");
            this.systemComboBox.FormattingEnabled = true;
            this.systemComboBox.Name = "systemComboBox";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.pathLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.systemComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.systemLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pathTextBox, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pathLabel
            // 
            resources.ApplyResources(this.pathLabel, "pathLabel");
            this.pathLabel.Name = "pathLabel";
            // 
            // systemLabel
            // 
            resources.ApplyResources(this.systemLabel, "systemLabel");
            this.systemLabel.Name = "systemLabel";
            // 
            // pathTextBox
            // 
            resources.ApplyResources(this.pathTextBox, "pathTextBox");
            this.pathTextBox.Name = "pathTextBox";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox systemComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label systemLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}