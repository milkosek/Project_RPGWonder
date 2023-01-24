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
            this.addAsset = new System.Windows.Forms.Button();
            this.removeAsset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(12, 298);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(772, 44);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CampaignNameTextBox
            // 
            this.CampaignNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.CampaignNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.CampaignNameTextBox.Name = "CampaignNameTextBox";
            this.CampaignNameTextBox.Size = new System.Drawing.Size(295, 38);
            this.CampaignNameTextBox.TabIndex = 2;
            // 
            // listBox
            // 
            this.listBox.Enabled = false;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 29;
            this.listBox.Location = new System.Drawing.Point(12, 56);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(691, 236);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(709, 56);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 75);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(709, 218);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 75);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.Control;
            this.createButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createButton.Location = new System.Drawing.Point(313, 12);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(95, 38);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(709, 137);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 75);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addAsset
            // 
            this.addAsset.Location = new System.Drawing.Point(646, 12);
            this.addAsset.Name = "addAsset";
            this.addAsset.Size = new System.Drawing.Size(138, 38);
            this.addAsset.TabIndex = 9;
            this.addAsset.Text = "Add Asset";
            this.addAsset.UseVisualStyleBackColor = true;
            this.addAsset.Click += new System.EventHandler(this.addAsset_Click);
            // 
            // removeAsset
            // 
            this.removeAsset.Location = new System.Drawing.Point(487, 12);
            this.removeAsset.Name = "removeAsset";
            this.removeAsset.Size = new System.Drawing.Size(153, 37);
            this.removeAsset.TabIndex = 10;
            this.removeAsset.Text = "Remove Asset";
            this.removeAsset.UseVisualStyleBackColor = true;
            this.removeAsset.Click += new System.EventHandler(this.removeAsset_Click);
            // 
            // CreateOrEditCampaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 351);
            this.Controls.Add(this.removeAsset);
            this.Controls.Add(this.addAsset);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.CampaignNameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button addAsset;
        private System.Windows.Forms.Button removeAsset;
    }
}