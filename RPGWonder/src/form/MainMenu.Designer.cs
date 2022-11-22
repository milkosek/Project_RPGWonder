using System.Collections.Generic;
using System.Windows.Forms;

namespace RPGWonder
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ExitButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ManageCharsButton = new System.Windows.Forms.Button();
            this.ManageCampaignsButton = new System.Windows.Forms.Button();
            this.HostButton = new System.Windows.Forms.Button();
            this.JoinButton = new System.Windows.Forms.Button();
            this.TempDiceRollMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SettingsButton
            // 
            resources.ApplyResources(this.SettingsButton, "SettingsButton");
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ManageCharsButton
            // 
            resources.ApplyResources(this.ManageCharsButton, "ManageCharsButton");
            this.ManageCharsButton.Name = "ManageCharsButton";
            this.ManageCharsButton.UseVisualStyleBackColor = true;
            this.ManageCharsButton.Click += new System.EventHandler(this.CrtCharButton_Click);
            // 
            // ManageCampaignsButton
            // 
            resources.ApplyResources(this.ManageCampaignsButton, "ManageCampaignsButton");
            this.ManageCampaignsButton.Name = "ManageCampaignsButton";
            this.ManageCampaignsButton.UseVisualStyleBackColor = true;
            this.ManageCampaignsButton.Click += new System.EventHandler(this.CrtCampaignButton_Click);
            // 
            // HostButton
            // 
            resources.ApplyResources(this.HostButton, "HostButton");
            this.HostButton.Name = "HostButton";
            this.HostButton.UseVisualStyleBackColor = true;
            this.HostButton.Click += new System.EventHandler(this.HostButton_Click);
            // 
            // JoinButton
            // 
            resources.ApplyResources(this.JoinButton, "JoinButton");
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.UseVisualStyleBackColor = true;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // TempDiceRollMenu
            // 
            resources.ApplyResources(this.TempDiceRollMenu, "TempDiceRollMenu");
            this.TempDiceRollMenu.Name = "TempDiceRollMenu";
            this.TempDiceRollMenu.UseVisualStyleBackColor = true;
            this.TempDiceRollMenu.Click += new System.EventHandler(this.TempDiceRollMenu_Click);
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TempDiceRollMenu);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.HostButton);
            this.Controls.Add(this.ManageCampaignsButton);
            this.Controls.Add(this.ManageCharsButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ManageCharsButton;
        private System.Windows.Forms.Button ManageCampaignsButton;
        private System.Windows.Forms.Button HostButton;
        private System.Windows.Forms.Button JoinButton;
        private Button TempDiceRollMenu;
    }
}

