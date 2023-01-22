namespace RPGWonder
{
    partial class ManageCharacters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCharacters));
            this.CrtNewCharacterButton = new System.Windows.Forms.Button();
            this.LoadCharacterButton = new System.Windows.Forms.Button();
            this.manageCharactersListBox = new System.Windows.Forms.ListBox();
            this.createCharacterButton = new System.Windows.Forms.Button();
            this.deleteCharacterButton = new System.Windows.Forms.Button();
            this.editCharacterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrtNewCharacterButton
            // 
            resources.ApplyResources(this.CrtNewCharacterButton, "CrtNewCharacterButton");
            this.CrtNewCharacterButton.Name = "CrtNewCharacterButton";
            this.CrtNewCharacterButton.UseVisualStyleBackColor = true;
            this.CrtNewCharacterButton.Click += new System.EventHandler(this.CrtNewCharacterButton_Click);
            // 
            // LoadCharacterButton
            // 
            resources.ApplyResources(this.LoadCharacterButton, "LoadCharacterButton");
            this.LoadCharacterButton.Name = "LoadCharacterButton";
            this.LoadCharacterButton.UseVisualStyleBackColor = true;
            this.LoadCharacterButton.Click += new System.EventHandler(this.EditCharacterButton_Click);
            // 
            // manageCharactersListBox
            // 
            resources.ApplyResources(this.manageCharactersListBox, "manageCharactersListBox");
            this.manageCharactersListBox.FormattingEnabled = true;
            this.manageCharactersListBox.Name = "manageCharactersListBox";
            this.manageCharactersListBox.SelectedIndexChanged += new System.EventHandler(this.manageCharactersListBox_SelectedIndexChanged);
            // 
            // createCharacterButton
            // 
            this.createCharacterButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.createCharacterButton, "createCharacterButton");
            this.createCharacterButton.Name = "createCharacterButton";
            this.createCharacterButton.UseVisualStyleBackColor = false;
            this.createCharacterButton.Click += new System.EventHandler(this.createCharacterButton_Click);
            // 
            // deleteCharacterButton
            // 
            this.deleteCharacterButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.deleteCharacterButton, "deleteCharacterButton");
            this.deleteCharacterButton.Name = "deleteCharacterButton";
            this.deleteCharacterButton.UseVisualStyleBackColor = false;
            this.deleteCharacterButton.Click += new System.EventHandler(this.deleteCharacterButton_Click);
            // 
            // editCharacterButton
            // 
            this.editCharacterButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.editCharacterButton, "editCharacterButton");
            this.editCharacterButton.Name = "editCharacterButton";
            this.editCharacterButton.UseVisualStyleBackColor = false;
            this.editCharacterButton.Click += new System.EventHandler(this.editCharacterButton_Click);
            // 
            // ManageCharacters
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createCharacterButton);
            this.Controls.Add(this.deleteCharacterButton);
            this.Controls.Add(this.editCharacterButton);
            this.Controls.Add(this.LoadCharacterButton);
            this.Controls.Add(this.CrtNewCharacterButton);
            this.Controls.Add(this.manageCharactersListBox);
            this.Name = "ManageCharacters";
            this.Load += new System.EventHandler(this.ManageCharacters_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrtNewCharacterButton;
        private System.Windows.Forms.Button LoadCharacterButton;
        private System.Windows.Forms.ListBox manageCharactersListBox;
        private System.Windows.Forms.Button createCharacterButton;
        private System.Windows.Forms.Button deleteCharacterButton;
        private System.Windows.Forms.Button editCharacterButton;
    }
}