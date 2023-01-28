namespace RPGWonder
{
    partial class CreateOrEditCampaign
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
            _instance = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrEditCampaign));
            this.SaveButton = new System.Windows.Forms.Button();
            this.CampaignNameTextBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addAssetButton = new System.Windows.Forms.Button();
            this.removeAssetButton = new System.Windows.Forms.Button();
            this.codexButton = new System.Windows.Forms.Button();
            this.mapsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(11, 291);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(579, 36);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CampaignNameTextBox
            // 
            this.CampaignNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.CampaignNameTextBox.Location = new System.Drawing.Point(9, 10);
            this.CampaignNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CampaignNameTextBox.Name = "CampaignNameTextBox";
            this.CampaignNameTextBox.Size = new System.Drawing.Size(385, 32);
            this.CampaignNameTextBox.TabIndex = 2;
            // 
            // listBox
            // 
            this.listBox.Enabled = false;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(9, 83);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(519, 204);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(532, 96);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(56, 61);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(532, 226);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(56, 61);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.Control;
            this.createButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createButton.Location = new System.Drawing.Point(398, 11);
            this.createButton.Margin = new System.Windows.Forms.Padding(2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(71, 30);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(532, 161);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(56, 61);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addAsset
            // 
            this.addAssetButton.Enabled = false;
            this.addAssetButton.Location = new System.Drawing.Point(473, 10);
            this.addAssetButton.Margin = new System.Windows.Forms.Padding(2);
            this.addAssetButton.Name = "addAsset";
            this.addAssetButton.Size = new System.Drawing.Size(115, 31);
            this.addAssetButton.TabIndex = 9;
            this.addAssetButton.Text = "Add Asset";
            this.addAssetButton.UseVisualStyleBackColor = true;
            this.addAssetButton.Click += new System.EventHandler(this.addAsset_Click);
            // 
            // removeAsset
            // 
            this.removeAssetButton.Enabled = false;
            this.removeAssetButton.Location = new System.Drawing.Point(473, 45);
            this.removeAssetButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeAssetButton.Name = "removeAsset";
            this.removeAssetButton.Size = new System.Drawing.Size(115, 30);
            this.removeAssetButton.TabIndex = 10;
            this.removeAssetButton.Text = "Remove Asset";
            this.removeAssetButton.UseVisualStyleBackColor = true;
            this.removeAssetButton.Click += new System.EventHandler(this.removeAsset_Click);
            // 
            // codexButton
            // 
            this.codexButton.Enabled = false;
            this.codexButton.Location = new System.Drawing.Point(9, 48);
            this.codexButton.Margin = new System.Windows.Forms.Padding(2);
            this.codexButton.Name = "codexButton";
            this.codexButton.Size = new System.Drawing.Size(104, 31);
            this.codexButton.TabIndex = 11;
            this.codexButton.Text = "Codex";
            this.codexButton.UseVisualStyleBackColor = true;
            this.codexButton.Click += new System.EventHandler(this.codexButton_Click);
            // 
            // mapsButton
            // 
            this.mapsButton.Enabled = false;
            this.mapsButton.Location = new System.Drawing.Point(117, 48);
            this.mapsButton.Margin = new System.Windows.Forms.Padding(2);
            this.mapsButton.Name = "mapsButton";
            this.mapsButton.Size = new System.Drawing.Size(104, 31);
            this.mapsButton.TabIndex = 12;
            this.mapsButton.Text = "Maps";
            this.mapsButton.UseVisualStyleBackColor = true;
            this.mapsButton.Click += new System.EventHandler(this.mapsButton_Click);
            // 
            // CreateOrEditCampaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 333);
            this.Controls.Add(this.mapsButton);
            this.Controls.Add(this.codexButton);
            this.Controls.Add(this.removeAssetButton);
            this.Controls.Add(this.addAssetButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.CampaignNameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateOrEditCampaign";
            this.Text = "Campaign";
            this.Load += new System.EventHandler(this.CreateOrEditCampaign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CampaignNameTextBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addAssetButton;
        private System.Windows.Forms.Button removeAssetButton;
        private System.Windows.Forms.Button codexButton;
        private System.Windows.Forms.Button mapsButton;
    }
}