namespace RPGWonder
{
    partial class JoinSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinSession));
            this.JoinGameButton = new System.Windows.Forms.Button();
            this.ipAddrInput = new System.Windows.Forms.TextBox();
            this.ipAddrLabel = new System.Windows.Forms.Label();
            this.charactersComboBox = new System.Windows.Forms.ComboBox();
            this.charactersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JoinGameButton
            // 
            resources.ApplyResources(this.JoinGameButton, "JoinGameButton");
            this.JoinGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.JoinGameButton.Name = "JoinGameButton";
            this.JoinGameButton.UseVisualStyleBackColor = false;
            this.JoinGameButton.Click += new System.EventHandler(this.JoinGameButton_Click);
            // 
            // ipAddrInput
            // 
            resources.ApplyResources(this.ipAddrInput, "ipAddrInput");
            this.ipAddrInput.Name = "ipAddrInput";
            // 
            // ipAddrLabel
            // 
            resources.ApplyResources(this.ipAddrLabel, "ipAddrLabel");
            this.ipAddrLabel.Name = "ipAddrLabel";
            // 
            // charactersComboBox
            // 
            resources.ApplyResources(this.charactersComboBox, "charactersComboBox");
            this.charactersComboBox.FormattingEnabled = true;
            this.charactersComboBox.Name = "charactersComboBox";
            this.charactersComboBox.SelectedIndexChanged += new System.EventHandler(this.charactersComboBox_SelectedIndexChanged);
            // 
            // charactersLabel
            // 
            resources.ApplyResources(this.charactersLabel, "charactersLabel");
            this.charactersLabel.Name = "charactersLabel";
            // 
            // JoinSession
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.charactersLabel);
            this.Controls.Add(this.charactersComboBox);
            this.Controls.Add(this.ipAddrLabel);
            this.Controls.Add(this.ipAddrInput);
            this.Controls.Add(this.JoinGameButton);
            this.Name = "JoinSession";
            this.Load += new System.EventHandler(this.JoinSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JoinGameButton;
        private System.Windows.Forms.TextBox ipAddrInput;
        private System.Windows.Forms.Label ipAddrLabel;
        private System.Windows.Forms.ComboBox charactersComboBox;
        private System.Windows.Forms.Label charactersLabel;
    }
}