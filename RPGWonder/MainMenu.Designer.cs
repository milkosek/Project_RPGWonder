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
            this.ExitButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.CrtCharButton = new System.Windows.Forms.Button();
            this.CrtCampaignButton = new System.Windows.Forms.Button();
            this.HostButton = new System.Windows.Forms.Button();
            this.JoinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(220, 288);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(166, 31);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(220, 239);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(166, 31);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // CrtCharButton
            // 
            this.CrtCharButton.Location = new System.Drawing.Point(220, 189);
            this.CrtCharButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CrtCharButton.Name = "CrtCharButton";
            this.CrtCharButton.Size = new System.Drawing.Size(166, 31);
            this.CrtCharButton.TabIndex = 2;
            this.CrtCharButton.Text = "Create Character";
            this.CrtCharButton.UseVisualStyleBackColor = true;
            // 
            // CrtCampaignButton
            // 
            this.CrtCampaignButton.Location = new System.Drawing.Point(220, 139);
            this.CrtCampaignButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CrtCampaignButton.Name = "CrtCampaignButton";
            this.CrtCampaignButton.Size = new System.Drawing.Size(166, 31);
            this.CrtCampaignButton.TabIndex = 3;
            this.CrtCampaignButton.Text = "Create Campaign";
            this.CrtCampaignButton.UseVisualStyleBackColor = true;
            // 
            // HostButton
            // 
            this.HostButton.Location = new System.Drawing.Point(220, 88);
            this.HostButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HostButton.Name = "HostButton";
            this.HostButton.Size = new System.Drawing.Size(166, 31);
            this.HostButton.TabIndex = 4;
            this.HostButton.Text = "Host Session";
            this.HostButton.UseVisualStyleBackColor = true;
            // 
            // JoinButton
            // 
            this.JoinButton.Location = new System.Drawing.Point(220, 36);
            this.JoinButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(166, 31);
            this.JoinButton.TabIndex = 5;
            this.JoinButton.Text = "Join Session";
            this.JoinButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.HostButton);
            this.Controls.Add(this.CrtCampaignButton);
            this.Controls.Add(this.CrtCharButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ExitButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "RPGWonder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button CrtCharButton;
        private System.Windows.Forms.Button CrtCampaignButton;
        private System.Windows.Forms.Button HostButton;
        private System.Windows.Forms.Button JoinButton;
    }
}

