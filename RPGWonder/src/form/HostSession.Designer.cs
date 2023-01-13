namespace RPGWonder
{
    partial class HostSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostSession));
            this.selectCampaignComboBox = new System.Windows.Forms.ComboBox();
            this.selectCampaignLabel = new System.Windows.Forms.Label();
            this.hostSessionButton = new System.Windows.Forms.Button();
            this.myIPTextBox = new System.Windows.Forms.TextBox();
            this.myIPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectCampaignComboBox
            // 
            resources.ApplyResources(this.selectCampaignComboBox, "selectCampaignComboBox");
            this.selectCampaignComboBox.FormattingEnabled = true;
            this.selectCampaignComboBox.Name = "selectCampaignComboBox";
            this.selectCampaignComboBox.SelectedIndexChanged += new System.EventHandler(this.selectCampaignComboBox_SelectedIndexChanged);
            // 
            // selectCampaignLabel
            // 
            resources.ApplyResources(this.selectCampaignLabel, "selectCampaignLabel");
            this.selectCampaignLabel.Name = "selectCampaignLabel";
            // 
            // hostSessionButton
            // 
            this.hostSessionButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.hostSessionButton, "hostSessionButton");
            this.hostSessionButton.Name = "hostSessionButton";
            this.hostSessionButton.UseVisualStyleBackColor = false;
            this.hostSessionButton.Click += new System.EventHandler(this.hostSessionButton_Click);
            // 
            // myIPTextBox
            // 
            resources.ApplyResources(this.myIPTextBox, "myIPTextBox");
            this.myIPTextBox.Name = "myIPTextBox";
            this.myIPTextBox.ReadOnly = true;
            // 
            // myIPLabel
            // 
            resources.ApplyResources(this.myIPLabel, "myIPLabel");
            this.myIPLabel.Name = "myIPLabel";
            // 
            // HostSession
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myIPLabel);
            this.Controls.Add(this.myIPTextBox);
            this.Controls.Add(this.hostSessionButton);
            this.Controls.Add(this.selectCampaignLabel);
            this.Controls.Add(this.selectCampaignComboBox);
            this.Name = "HostSession";
            this.Load += new System.EventHandler(this.HostSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectCampaignComboBox;
        private System.Windows.Forms.Label selectCampaignLabel;
        private System.Windows.Forms.Button hostSessionButton;
        private System.Windows.Forms.TextBox myIPTextBox;
        private System.Windows.Forms.Label myIPLabel;
    }
}