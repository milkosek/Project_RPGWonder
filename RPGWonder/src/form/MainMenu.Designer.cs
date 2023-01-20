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
            this.exitButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.manageCharactersButton = new System.Windows.Forms.Button();
            this.manageCampaignsButton = new System.Windows.Forms.Button();
            this.hostSessionButton = new System.Windows.Forms.Button();
            this.joinSessionButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // settingsButton
            // 
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // manageCharactersButton
            // 
            resources.ApplyResources(this.manageCharactersButton, "manageCharactersButton");
            this.manageCharactersButton.Name = "manageCharactersButton";
            this.manageCharactersButton.UseVisualStyleBackColor = true;
            this.manageCharactersButton.Click += new System.EventHandler(this.CrtCharButton_Click);
            // 
            // manageCampaignsButton
            // 
            resources.ApplyResources(this.manageCampaignsButton, "manageCampaignsButton");
            this.manageCampaignsButton.Name = "manageCampaignsButton";
            this.manageCampaignsButton.UseVisualStyleBackColor = true;
            this.manageCampaignsButton.Click += new System.EventHandler(this.CrtCampaignButton_Click);
            // 
            // hostSessionButton
            // 
            resources.ApplyResources(this.hostSessionButton, "hostSessionButton");
            this.hostSessionButton.Name = "hostSessionButton";
            this.hostSessionButton.UseVisualStyleBackColor = true;
            this.hostSessionButton.Click += new System.EventHandler(this.HostButton_Click);
            // 
            // joinSessionButton
            // 
            resources.ApplyResources(this.joinSessionButton, "joinSessionButton");
            this.joinSessionButton.Name = "joinSessionButton";
            this.joinSessionButton.UseVisualStyleBackColor = true;
            this.joinSessionButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.joinSessionButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.manageCharactersButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.hostSessionButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.manageCampaignsButton, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button manageCharactersButton;
        private System.Windows.Forms.Button manageCampaignsButton;
        private System.Windows.Forms.Button hostSessionButton;
        private System.Windows.Forms.Button joinSessionButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

