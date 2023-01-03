namespace RPGWonder
{
    partial class ManageCampaigns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Open a popup window asking for the name of the campaign.
        /// </summary>
        /// <param name="sender">reference to the object that triggered the event</param>
        /// <param name="e">event arguments</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCampaigns));
            this.CrtNewCampaignButton = new System.Windows.Forms.Button();
            this.manageCampaignsListBox = new System.Windows.Forms.ListBox();
            this.LoadCampaignButton = new System.Windows.Forms.Button();
            this.editCampaignButton = new System.Windows.Forms.Button();
            this.deleteCampaignButton = new System.Windows.Forms.Button();
            this.createCampaignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrtNewCampaignButton
            // 
            this.CrtNewCampaignButton.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.CrtNewCampaignButton, "CrtNewCampaignButton");
            this.CrtNewCampaignButton.Name = "CrtNewCampaignButton";
            this.CrtNewCampaignButton.UseVisualStyleBackColor = false;
            this.CrtNewCampaignButton.Click += new System.EventHandler(this.CrtNewCampaignButton_Click);
            // 
            // manageCampaignsListBox
            // 
            resources.ApplyResources(this.manageCampaignsListBox, "manageCampaignsListBox");
            this.manageCampaignsListBox.FormattingEnabled = true;
            this.manageCampaignsListBox.Name = "manageCampaignsListBox";
            this.manageCampaignsListBox.SelectedIndexChanged += new System.EventHandler(this.manageCampaignsListBox_SelectedIndexChanged);
            // 
            // LoadCampaignButton
            // 
            this.LoadCampaignButton.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.LoadCampaignButton, "LoadCampaignButton");
            this.LoadCampaignButton.Name = "LoadCampaignButton";
            this.LoadCampaignButton.UseVisualStyleBackColor = false;
            this.LoadCampaignButton.Click += new System.EventHandler(this.LoadCampaignButton_Click);
            // 
            // editCampaignButton
            // 
            this.editCampaignButton.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.editCampaignButton, "editCampaignButton");
            this.editCampaignButton.Name = "editCampaignButton";
            this.editCampaignButton.UseVisualStyleBackColor = false;
            this.editCampaignButton.Click += new System.EventHandler(this.editCampaignButton_Click);
            // 
            // deleteCampaignButton
            // 
            this.deleteCampaignButton.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.deleteCampaignButton, "deleteCampaignButton");
            this.deleteCampaignButton.Name = "deleteCampaignButton";
            this.deleteCampaignButton.UseVisualStyleBackColor = false;
            this.deleteCampaignButton.Click += new System.EventHandler(this.deleteCampaignButton_Click);
            // 
            // createCampaignButton
            // 
            this.createCampaignButton.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.createCampaignButton, "createCampaignButton");
            this.createCampaignButton.Name = "createCampaignButton";
            this.createCampaignButton.UseVisualStyleBackColor = false;
            this.createCampaignButton.Click += new System.EventHandler(this.createCampaignButton_Click);
            // 
            // ManageCampaigns
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createCampaignButton);
            this.Controls.Add(this.deleteCampaignButton);
            this.Controls.Add(this.editCampaignButton);
            this.Controls.Add(this.LoadCampaignButton);
            this.Controls.Add(this.CrtNewCampaignButton);
            this.Controls.Add(this.manageCampaignsListBox);
            this.Name = "ManageCampaigns";
            this.Load += new System.EventHandler(this.ManageCampaigns_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrtNewCampaignButton;
        private System.Windows.Forms.ListBox manageCampaignsListBox;
        private System.Windows.Forms.Button LoadCampaignButton;
        private System.Windows.Forms.Button editCampaignButton;
        private System.Windows.Forms.Button deleteCampaignButton;
        private System.Windows.Forms.Button createCampaignButton;
    }
}