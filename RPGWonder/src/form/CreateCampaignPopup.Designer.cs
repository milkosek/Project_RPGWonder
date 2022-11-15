using System;

namespace RPGWonder
{
    partial class CreateCampaignPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCampaignPopup));
            this.CreateCapaignPopupAcceptButton = new System.Windows.Forms.Button();
            this.CreateCampaignPopupTextBox = new System.Windows.Forms.TextBox();
            this.CreateCapaignPopupCancelButton = new System.Windows.Forms.Button();
            this.CreateCampaignPopupNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateCapaignPopupAcceptButton
            // 
            resources.ApplyResources(this.CreateCapaignPopupAcceptButton, "CreateCapaignPopupAcceptButton");
            this.CreateCapaignPopupAcceptButton.Name = "CreateCapaignPopupAcceptButton";
            this.CreateCapaignPopupAcceptButton.UseVisualStyleBackColor = true;
            this.CreateCapaignPopupAcceptButton.Click += new System.EventHandler(this.CreateCapaignPopupAcceptButton_Click);
            // 
            // CreateCampaignPopupTextBox
            // 
            resources.ApplyResources(this.CreateCampaignPopupTextBox, "CreateCampaignPopupTextBox");
            this.CreateCampaignPopupTextBox.Name = "CreateCampaignPopupTextBox";
            this.CreateCampaignPopupTextBox.TextChanged += new System.EventHandler(this.CreateCampaignPopupTextBox_TextChanged);
            // 
            // CreateCapaignPopupCancelButton
            // 
            resources.ApplyResources(this.CreateCapaignPopupCancelButton, "CreateCapaignPopupCancelButton");
            this.CreateCapaignPopupCancelButton.Name = "CreateCapaignPopupCancelButton";
            this.CreateCapaignPopupCancelButton.UseVisualStyleBackColor = true;
            this.CreateCapaignPopupCancelButton.Click += new System.EventHandler(this.CreateCapaignPopupCancelButton_Click);
            // 
            // CreateCampaignPopupNameLabel
            // 
            resources.ApplyResources(this.CreateCampaignPopupNameLabel, "CreateCampaignPopupNameLabel");
            this.CreateCampaignPopupNameLabel.Name = "CreateCampaignPopupNameLabel";
            // 
            // CreateCampaignPopup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreateCapaignPopupCancelButton);
            this.Controls.Add(this.CreateCampaignPopupNameLabel);
            this.Controls.Add(this.CreateCapaignPopupAcceptButton);
            this.Controls.Add(this.CreateCampaignPopupTextBox);
            this.Name = "CreateCampaignPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCapaignPopupAcceptButton;
        private System.Windows.Forms.TextBox CreateCampaignPopupTextBox;
        private System.Windows.Forms.Button CreateCapaignPopupCancelButton;
        private System.Windows.Forms.Label CreateCampaignPopupNameLabel;
        private EventHandler label1_Click;

        public EventHandler CreateCampaignPopup_Load { get; private set; }
    }
}