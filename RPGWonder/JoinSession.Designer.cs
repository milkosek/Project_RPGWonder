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
            this.JoinGameButton = new System.Windows.Forms.Button();
            this.ipAddrInput = new System.Windows.Forms.TextBox();
            this.ipAddrLabel = new System.Windows.Forms.Label();
            this.charactersComboBox = new System.Windows.Forms.ComboBox();
            this.charactersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JoinGameButton
            // 
            this.JoinGameButton.Location = new System.Drawing.Point(331, 339);
            this.JoinGameButton.Name = "JoinGameButton";
            this.JoinGameButton.Size = new System.Drawing.Size(121, 77);
            this.JoinGameButton.TabIndex = 0;
            this.JoinGameButton.Text = "Join!";
            this.JoinGameButton.UseVisualStyleBackColor = true;
            this.JoinGameButton.Click += new System.EventHandler(this.JoinGameButton_Click);
            // 
            // ipAddrInput
            // 
            this.ipAddrInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddrInput.Location = new System.Drawing.Point(205, 233);
            this.ipAddrInput.Name = "ipAddrInput";
            this.ipAddrInput.Size = new System.Drawing.Size(367, 49);
            this.ipAddrInput.TabIndex = 1;
            // 
            // ipAddrLabel
            // 
            this.ipAddrLabel.AutoSize = true;
            this.ipAddrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddrLabel.Location = new System.Drawing.Point(199, 194);
            this.ipAddrLabel.Name = "ipAddrLabel";
            this.ipAddrLabel.Size = new System.Drawing.Size(309, 36);
            this.ipAddrLabel.TabIndex = 2;
            this.ipAddrLabel.Text = "Enter host IP address:";
            // 
            // charactersComboBox
            // 
            this.charactersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charactersComboBox.FormattingEnabled = true;
            this.charactersComboBox.Location = new System.Drawing.Point(205, 109);
            this.charactersComboBox.Name = "charactersComboBox";
            this.charactersComboBox.Size = new System.Drawing.Size(367, 50);
            this.charactersComboBox.TabIndex = 3;
            // 
            // charactersLabel
            // 
            this.charactersLabel.AutoSize = true;
            this.charactersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charactersLabel.Location = new System.Drawing.Point(199, 70);
            this.charactersLabel.Name = "charactersLabel";
            this.charactersLabel.Size = new System.Drawing.Size(324, 36);
            this.charactersLabel.TabIndex = 4;
            this.charactersLabel.Text = "Choose your character:";
            // 
            // JoinSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charactersLabel);
            this.Controls.Add(this.charactersComboBox);
            this.Controls.Add(this.ipAddrLabel);
            this.Controls.Add(this.ipAddrInput);
            this.Controls.Add(this.JoinGameButton);
            this.Name = "JoinSession";
            this.Text = "JoinSession";
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