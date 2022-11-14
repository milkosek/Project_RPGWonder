namespace RPGWonder
{
    partial class ManageCampaigns
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

        /// <summary>
        /// Open a popup window asking for the name of the campaign.
        /// </summary>
        /// <param name="sender">reference to the object that triggered the event</param>
        /// <param name="e">event arguments</param>
        private void HandleCreateCampaign(object sender, System.EventArgs e)
        {
            CreateCampaignPopup createCampaignPopup = new CreateCampaignPopup();
            createCampaignPopup.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCampaigns));
            this.CrtNewCampaignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrtNewCampaignButton
            // 
            resources.ApplyResources(this.CrtNewCampaignButton, "CrtNewCampaignButton");
            this.CrtNewCampaignButton.Name = "CrtNewCampaignButton";
            this.CrtNewCampaignButton.UseVisualStyleBackColor = true;
            this.CrtNewCampaignButton.Click += new System.EventHandler(this.HandleCreateCampaign);
            // 
            // ManageCampaigns
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CrtNewCampaignButton);
            this.Name = "ManageCampaigns";
            this.Load += new System.EventHandler(this.ManageCampaigns_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrtNewCampaignButton;
    }
}