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
            this.SuspendLayout();
            // 
            // selectCampaignComboBox
            // 
            resources.ApplyResources(this.selectCampaignComboBox, "selectCampaignComboBox");
            this.selectCampaignComboBox.FormattingEnabled = true;
            this.selectCampaignComboBox.Name = "selectCampaignComboBox";
            // 
            // selectCampaignLabel
            // 
            resources.ApplyResources(this.selectCampaignLabel, "selectCampaignLabel");
            this.selectCampaignLabel.Name = "selectCampaignLabel";
            // 
            // hostSessionButton
            // 
            resources.ApplyResources(this.hostSessionButton, "hostSessionButton");
            this.hostSessionButton.Name = "hostSessionButton";
            this.hostSessionButton.UseVisualStyleBackColor = true;
            this.hostSessionButton.Click += new System.EventHandler(this.hostSessionButton_Click);
            // 
            // HostSession
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hostSessionButton);
            this.Controls.Add(this.selectCampaignLabel);
            this.Controls.Add(this.selectCampaignComboBox);
            this.Name = "HostSession";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectCampaignComboBox;
        private System.Windows.Forms.Label selectCampaignLabel;
        private System.Windows.Forms.Button hostSessionButton;
    }
}