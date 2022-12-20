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
            this.EditCharacterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrtNewCharacterButton
            // 
            resources.ApplyResources(this.CrtNewCharacterButton, "CrtNewCharacterButton");
            this.CrtNewCharacterButton.Name = "CrtNewCharacterButton";
            this.CrtNewCharacterButton.UseVisualStyleBackColor = true;
            this.CrtNewCharacterButton.Click += new System.EventHandler(this.CrtNewCharacterButton_Click);
            // 
            // EditCharacterButton
            // 
            resources.ApplyResources(this.EditCharacterButton, "EditCharacterButton");
            this.EditCharacterButton.Name = "EditCharacterButton";
            this.EditCharacterButton.UseVisualStyleBackColor = true;
            // 
            // ManageCharacters
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditCharacterButton);
            this.Controls.Add(this.CrtNewCharacterButton);
            this.Name = "ManageCharacters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrtNewCharacterButton;
        private System.Windows.Forms.Button EditCharacterButton;
    }
}