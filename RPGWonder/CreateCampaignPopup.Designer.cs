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
            this.CreateCapaignPopupAcceptButton = new System.Windows.Forms.Button();
            this.CreateCampaignPopupTextBox = new System.Windows.Forms.TextBox();
            this.CreateCapaignPopupCancelButton = new System.Windows.Forms.Button();
            this.CreateCampaignPopupNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateCapaignPopupAcceptButton
            // 
            this.CreateCapaignPopupAcceptButton.Location = new System.Drawing.Point(79, 97);
            this.CreateCapaignPopupAcceptButton.Name = "CreateCapaignPopupAcceptButton";
            this.CreateCapaignPopupAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCapaignPopupAcceptButton.TabIndex = 1;
            this.CreateCapaignPopupAcceptButton.Text = "Ok";
            this.CreateCapaignPopupAcceptButton.UseVisualStyleBackColor = true;
            this.CreateCapaignPopupAcceptButton.Click += new System.EventHandler(this.CreateCapaignPopupAcceptButton_Click);
            // 
            // CreateCampaignPopupTextBox
            // 
            this.CreateCampaignPopupTextBox.Location = new System.Drawing.Point(160, 38);
            this.CreateCampaignPopupTextBox.Name = "CreateCampaignPopupTextBox";
            this.CreateCampaignPopupTextBox.Size = new System.Drawing.Size(137, 22);
            this.CreateCampaignPopupTextBox.TabIndex = 0;
            this.CreateCampaignPopupTextBox.TextChanged += new System.EventHandler(this.CreateCampaignPopupTextBox_TextChanged);
            // 
            // CreateCapaignPopupCancelButton
            // 
            this.CreateCapaignPopupCancelButton.Location = new System.Drawing.Point(160, 97);
            this.CreateCapaignPopupCancelButton.Name = "CreateCapaignPopupCancelButton";
            this.CreateCapaignPopupCancelButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCapaignPopupCancelButton.TabIndex = 3;
            this.CreateCapaignPopupCancelButton.Text = "Cancel";
            this.CreateCapaignPopupCancelButton.UseVisualStyleBackColor = true;
            this.CreateCapaignPopupCancelButton.Click += new System.EventHandler(this.CreateCapaignPopupCancelButton_Click);
            // 
            // CreateCampaignPopupNameLabel
            // 
            this.CreateCampaignPopupNameLabel.AutoSize = true;
            this.CreateCampaignPopupNameLabel.Location = new System.Drawing.Point(45, 41);
            this.CreateCampaignPopupNameLabel.Name = "CreateCampaignPopupNameLabel";
            this.CreateCampaignPopupNameLabel.Size = new System.Drawing.Size(109, 16);
            this.CreateCampaignPopupNameLabel.TabIndex = 2;
            this.CreateCampaignPopupNameLabel.Text = "Campaign name:";
            // 
            // CreateCampaignPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 163);
            this.Controls.Add(this.CreateCapaignPopupCancelButton);
            this.Controls.Add(this.CreateCampaignPopupNameLabel);
            this.Controls.Add(this.CreateCapaignPopupAcceptButton);
            this.Controls.Add(this.CreateCampaignPopupTextBox);
            this.Name = "CreateCampaignPopup";
            this.Text = "CreateCampaignPopup";
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