namespace RPGWonder
{
    partial class RollDie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollDie));
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Location = new System.Drawing.Point(94, 74);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(226, 28);
            this.difficultyComboBox.TabIndex = 7;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(90, 20);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Rolling for:";
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bonusTextBox.Location = new System.Drawing.Point(94, 41);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(226, 26);
            this.bonusTextBox.TabIndex = 5;
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rollButton.Location = new System.Drawing.Point(326, 35);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 75);
            this.rollButton.TabIndex = 4;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bonusLabel.Location = new System.Drawing.Point(12, 44);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(57, 20);
            this.bonusLabel.TabIndex = 8;
            this.bonusLabel.Text = "Bonus";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.difficultyLabel.Location = new System.Drawing.Point(12, 76);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(75, 20);
            this.difficultyLabel.TabIndex = 9;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // RollDie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 122);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.bonusLabel);
            this.Controls.Add(this.difficultyComboBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.rollButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RollDie";
            this.Text = "Roll Die";
            this.Load += new System.EventHandler(this.RollDie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox difficultyComboBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Label difficultyLabel;
    }
}