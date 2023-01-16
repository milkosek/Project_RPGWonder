namespace RPGWonder
{
    partial class CreateOrEditCodexEntry
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
            instance = null;
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
            this.codexEntryTextTextBox = new System.Windows.Forms.TextBox();
            this.codexEntryTextLabel = new System.Windows.Forms.Label();
            this.codexEntryTitleLabel = new System.Windows.Forms.Label();
            this.codexEntryTitleTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codexEntryTextTextBox
            // 
            this.codexEntryTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.codexEntryTextTextBox.Location = new System.Drawing.Point(15, 93);
            this.codexEntryTextTextBox.Multiline = true;
            this.codexEntryTextTextBox.Name = "codexEntryTextTextBox";
            this.codexEntryTextTextBox.Size = new System.Drawing.Size(771, 289);
            this.codexEntryTextTextBox.TabIndex = 7;
            // 
            // codexEntryTextLabel
            // 
            this.codexEntryTextLabel.AutoSize = true;
            this.codexEntryTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.codexEntryTextLabel.Location = new System.Drawing.Point(12, 50);
            this.codexEntryTextLabel.Name = "codexEntryTextLabel";
            this.codexEntryTextLabel.Size = new System.Drawing.Size(69, 32);
            this.codexEntryTextLabel.TabIndex = 6;
            this.codexEntryTextLabel.Text = "Text";
            this.codexEntryTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // codexEntryTitleLabel
            // 
            this.codexEntryTitleLabel.AutoSize = true;
            this.codexEntryTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.codexEntryTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.codexEntryTitleLabel.Name = "codexEntryTitleLabel";
            this.codexEntryTitleLabel.Size = new System.Drawing.Size(69, 32);
            this.codexEntryTitleLabel.TabIndex = 5;
            this.codexEntryTitleLabel.Text = "Title";
            // 
            // codexEntryTitleTextBox
            // 
            this.codexEntryTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.codexEntryTitleTextBox.Location = new System.Drawing.Point(87, 6);
            this.codexEntryTitleTextBox.Name = "codexEntryTitleTextBox";
            this.codexEntryTitleTextBox.Size = new System.Drawing.Size(699, 38);
            this.codexEntryTitleTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(14, 388);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(772, 44);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CreateOrEditCodexEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.codexEntryTextTextBox);
            this.Controls.Add(this.codexEntryTextLabel);
            this.Controls.Add(this.codexEntryTitleLabel);
            this.Controls.Add(this.codexEntryTitleTextBox);
            this.Name = "CreateOrEditCodexEntry";
            this.Text = "CreateOrEditCodexEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codexEntryTextTextBox;
        private System.Windows.Forms.Label codexEntryTextLabel;
        private System.Windows.Forms.Label codexEntryTitleLabel;
        private System.Windows.Forms.TextBox codexEntryTitleTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}