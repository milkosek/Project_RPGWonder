
namespace RPGWonder.src.form
{
    partial class Selector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectCampaignComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectCampaignComboBox
            // 
            this.selectCampaignComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectCampaignComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.selectCampaignComboBox.FormattingEnabled = true;
            this.selectCampaignComboBox.Location = new System.Drawing.Point(74, 91);
            this.selectCampaignComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectCampaignComboBox.Name = "selectCampaignComboBox";
            this.selectCampaignComboBox.Size = new System.Drawing.Size(453, 37);
            this.selectCampaignComboBox.TabIndex = 1;
            this.selectCampaignComboBox.SelectedIndexChanged += new System.EventHandler(this.selectCampaignComboBox_SelectedIndexChanged);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(232, 166);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(137, 35);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.selectCampaignComboBox);
            this.Name = "Selector";
            this.Text = "Selector";
            this.Load += new System.EventHandler(this.Selector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectCampaignComboBox;
        private System.Windows.Forms.Button okButton;
    }
}