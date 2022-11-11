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
            this.CrtNewCampaignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrtNewCampaignButton
            // 
            this.CrtNewCampaignButton.Location = new System.Drawing.Point(433, 226);
            this.CrtNewCampaignButton.Name = "CrtNewCampaignButton";
            this.CrtNewCampaignButton.Size = new System.Drawing.Size(218, 30);
            this.CrtNewCampaignButton.TabIndex = 0;
            this.CrtNewCampaignButton.Text = "Create New Campaign";
            this.CrtNewCampaignButton.UseVisualStyleBackColor = true;
            this.CrtNewCampaignButton.Click += new System.EventHandler(this.HandleCreateCampaign);
            // 
            // ManageCampaigns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CrtNewCampaignButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageCampaigns";
            this.Text = "RPGWonder";
            this.Load += new System.EventHandler(this.ManageCampaigns_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrtNewCampaignButton;
    }
}