namespace RPGWonder
{
    partial class ShowCharacter
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
            this.skillsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.abilitiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.flawsLabel = new System.Windows.Forms.Label();
            this.bondsLabel = new System.Windows.Forms.Label();
            this.personalityTraitsLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.alignmentLabel = new System.Windows.Forms.Label();
            this.idealsLabel = new System.Windows.Forms.Label();
            this.basicInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flawTextBox = new System.Windows.Forms.TextBox();
            this.bondTextBox = new System.Windows.Forms.TextBox();
            this.idealTextBox = new System.Windows.Forms.TextBox();
            this.personalityTextBox = new System.Windows.Forms.TextBox();
            this.alignmentTextBox = new System.Windows.Forms.TextBox();
            this.backgroundTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.basicInfoTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // skillsTableLayoutPanel
            // 
            this.skillsTableLayoutPanel.ColumnCount = 1;
            this.skillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillsTableLayoutPanel.Location = new System.Drawing.Point(289, 54);
            this.skillsTableLayoutPanel.Name = "skillsTableLayoutPanel";
            this.skillsTableLayoutPanel.RowCount = 1;
            this.skillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.skillsTableLayoutPanel.Size = new System.Drawing.Size(188, 603);
            this.skillsTableLayoutPanel.TabIndex = 30;
            // 
            // abilitiesTableLayoutPanel
            // 
            this.abilitiesTableLayoutPanel.ColumnCount = 3;
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.33929F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.66071F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.abilitiesTableLayoutPanel.Location = new System.Drawing.Point(12, 54);
            this.abilitiesTableLayoutPanel.Name = "abilitiesTableLayoutPanel";
            this.abilitiesTableLayoutPanel.RowCount = 1;
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.abilitiesTableLayoutPanel.Size = new System.Drawing.Size(271, 603);
            this.abilitiesTableLayoutPanel.TabIndex = 28;
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.characterNameLabel.Location = new System.Drawing.Point(423, 4);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(213, 31);
            this.characterNameLabel.TabIndex = 27;
            this.characterNameLabel.Text = "Character Name";
            this.characterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flawsLabel
            // 
            this.flawsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flawsLabel.AutoSize = true;
            this.flawsLabel.Location = new System.Drawing.Point(369, 300);
            this.flawsLabel.Name = "flawsLabel";
            this.flawsLabel.Size = new System.Drawing.Size(35, 16);
            this.flawsLabel.TabIndex = 18;
            this.flawsLabel.Text = "Flaw";
            // 
            // bondsLabel
            // 
            this.bondsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bondsLabel.AutoSize = true;
            this.bondsLabel.Location = new System.Drawing.Point(52, 300);
            this.bondsLabel.Name = "bondsLabel";
            this.bondsLabel.Size = new System.Drawing.Size(39, 16);
            this.bondsLabel.TabIndex = 18;
            this.bondsLabel.Text = "Bond";
            // 
            // personalityTraitsLabel
            // 
            this.personalityTraitsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personalityTraitsLabel.AutoSize = true;
            this.personalityTraitsLabel.Location = new System.Drawing.Point(14, 222);
            this.personalityTraitsLabel.Name = "personalityTraitsLabel";
            this.personalityTraitsLabel.Size = new System.Drawing.Size(77, 32);
            this.personalityTraitsLabel.TabIndex = 18;
            this.personalityTraitsLabel.Text = "Personality Traits";
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(364, 94);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(40, 16);
            this.levelLabel.TabIndex = 17;
            this.levelLabel.Text = "Level";
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(352, 26);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(52, 16);
            this.genderLabel.TabIndex = 17;
            this.genderLabel.Text = "Gender";
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(11, 162);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(80, 16);
            this.backgroundLabel.TabIndex = 17;
            this.backgroundLabel.Text = "Background";
            // 
            // classLabel
            // 
            this.classLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(50, 94);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(41, 16);
            this.classLabel.TabIndex = 17;
            this.classLabel.Text = "Class";
            this.classLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // raceLabel
            // 
            this.raceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(51, 26);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(40, 16);
            this.raceLabel.TabIndex = 16;
            this.raceLabel.Text = "Race";
            // 
            // alignmentLabel
            // 
            this.alignmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.alignmentLabel.AutoSize = true;
            this.alignmentLabel.Location = new System.Drawing.Point(338, 162);
            this.alignmentLabel.Name = "alignmentLabel";
            this.alignmentLabel.Size = new System.Drawing.Size(66, 16);
            this.alignmentLabel.TabIndex = 17;
            this.alignmentLabel.Text = "Alignment";
            // 
            // idealsLabel
            // 
            this.idealsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.idealsLabel.AutoSize = true;
            this.idealsLabel.Location = new System.Drawing.Point(367, 230);
            this.idealsLabel.Name = "idealsLabel";
            this.idealsLabel.Size = new System.Drawing.Size(37, 16);
            this.idealsLabel.TabIndex = 18;
            this.idealsLabel.Text = "Ideal";
            // 
            // basicInfoTableLayout
            // 
            this.basicInfoTableLayout.ColumnCount = 4;
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.basicInfoTableLayout.Controls.Add(this.flawTextBox, 3, 4);
            this.basicInfoTableLayout.Controls.Add(this.bondTextBox, 1, 4);
            this.basicInfoTableLayout.Controls.Add(this.idealTextBox, 3, 3);
            this.basicInfoTableLayout.Controls.Add(this.personalityTextBox, 1, 3);
            this.basicInfoTableLayout.Controls.Add(this.alignmentTextBox, 3, 2);
            this.basicInfoTableLayout.Controls.Add(this.backgroundTextBox, 1, 2);
            this.basicInfoTableLayout.Controls.Add(this.levelTextBox, 3, 1);
            this.basicInfoTableLayout.Controls.Add(this.classTextBox, 1, 1);
            this.basicInfoTableLayout.Controls.Add(this.genderTextBox, 3, 0);
            this.basicInfoTableLayout.Controls.Add(this.raceTextBox, 1, 0);
            this.basicInfoTableLayout.Controls.Add(this.flawsLabel, 2, 4);
            this.basicInfoTableLayout.Controls.Add(this.bondsLabel, 0, 4);
            this.basicInfoTableLayout.Controls.Add(this.personalityTraitsLabel, 0, 3);
            this.basicInfoTableLayout.Controls.Add(this.levelLabel, 2, 1);
            this.basicInfoTableLayout.Controls.Add(this.genderLabel, 2, 0);
            this.basicInfoTableLayout.Controls.Add(this.backgroundLabel, 0, 2);
            this.basicInfoTableLayout.Controls.Add(this.classLabel, 0, 1);
            this.basicInfoTableLayout.Controls.Add(this.raceLabel, 0, 0);
            this.basicInfoTableLayout.Controls.Add(this.alignmentLabel, 2, 2);
            this.basicInfoTableLayout.Controls.Add(this.idealsLabel, 2, 3);
            this.basicInfoTableLayout.Location = new System.Drawing.Point(483, 54);
            this.basicInfoTableLayout.Name = "basicInfoTableLayout";
            this.basicInfoTableLayout.RowCount = 5;
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.Size = new System.Drawing.Size(628, 344);
            this.basicInfoTableLayout.TabIndex = 25;
            // 
            // flawTextBox
            // 
            this.flawTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flawTextBox.Location = new System.Drawing.Point(411, 297);
            this.flawTextBox.Name = "flawTextBox";
            this.flawTextBox.ReadOnly = true;
            this.flawTextBox.Size = new System.Drawing.Size(213, 22);
            this.flawTextBox.TabIndex = 40;
            // 
            // bondTextBox
            // 
            this.bondTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bondTextBox.Location = new System.Drawing.Point(97, 297);
            this.bondTextBox.Name = "bondTextBox";
            this.bondTextBox.ReadOnly = true;
            this.bondTextBox.Size = new System.Drawing.Size(213, 22);
            this.bondTextBox.TabIndex = 39;
            // 
            // idealTextBox
            // 
            this.idealTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idealTextBox.Location = new System.Drawing.Point(411, 227);
            this.idealTextBox.Name = "idealTextBox";
            this.idealTextBox.ReadOnly = true;
            this.idealTextBox.Size = new System.Drawing.Size(213, 22);
            this.idealTextBox.TabIndex = 38;
            // 
            // personalityTextBox
            // 
            this.personalityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.personalityTextBox.Location = new System.Drawing.Point(97, 227);
            this.personalityTextBox.Name = "personalityTextBox";
            this.personalityTextBox.ReadOnly = true;
            this.personalityTextBox.Size = new System.Drawing.Size(213, 22);
            this.personalityTextBox.TabIndex = 37;
            // 
            // alignmentTextBox
            // 
            this.alignmentTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alignmentTextBox.Location = new System.Drawing.Point(411, 159);
            this.alignmentTextBox.Name = "alignmentTextBox";
            this.alignmentTextBox.ReadOnly = true;
            this.alignmentTextBox.Size = new System.Drawing.Size(213, 22);
            this.alignmentTextBox.TabIndex = 36;
            // 
            // backgroundTextBox
            // 
            this.backgroundTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backgroundTextBox.Location = new System.Drawing.Point(97, 159);
            this.backgroundTextBox.Name = "backgroundTextBox";
            this.backgroundTextBox.ReadOnly = true;
            this.backgroundTextBox.Size = new System.Drawing.Size(213, 22);
            this.backgroundTextBox.TabIndex = 35;
            // 
            // levelTextBox
            // 
            this.levelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelTextBox.Location = new System.Drawing.Point(411, 91);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.ReadOnly = true;
            this.levelTextBox.Size = new System.Drawing.Size(213, 22);
            this.levelTextBox.TabIndex = 34;
            // 
            // classTextBox
            // 
            this.classTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classTextBox.Location = new System.Drawing.Point(97, 91);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.ReadOnly = true;
            this.classTextBox.Size = new System.Drawing.Size(213, 22);
            this.classTextBox.TabIndex = 33;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderTextBox.Location = new System.Drawing.Point(411, 23);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(213, 22);
            this.genderTextBox.TabIndex = 32;
            // 
            // raceTextBox
            // 
            this.raceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.raceTextBox.Location = new System.Drawing.Point(97, 23);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.ReadOnly = true;
            this.raceTextBox.Size = new System.Drawing.Size(213, 22);
            this.raceTextBox.TabIndex = 31;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(483, 402);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(628, 253);
            this.descriptionTextBox.TabIndex = 31;
            // 
            // ShowCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 667);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.skillsTableLayoutPanel);
            this.Controls.Add(this.abilitiesTableLayoutPanel);
            this.Controls.Add(this.characterNameLabel);
            this.Controls.Add(this.basicInfoTableLayout);
            this.Name = "ShowCharacter";
            this.Text = "ShowCharacter";
            this.Load += new System.EventHandler(this.ShowCharacter_Load);
            this.basicInfoTableLayout.ResumeLayout(false);
            this.basicInfoTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel skillsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel abilitiesTableLayoutPanel;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.Label flawsLabel;
        private System.Windows.Forms.Label bondsLabel;
        private System.Windows.Forms.Label personalityTraitsLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label alignmentLabel;
        private System.Windows.Forms.Label idealsLabel;
        private System.Windows.Forms.TableLayoutPanel basicInfoTableLayout;
        private System.Windows.Forms.TextBox flawTextBox;
        private System.Windows.Forms.TextBox bondTextBox;
        private System.Windows.Forms.TextBox idealTextBox;
        private System.Windows.Forms.TextBox personalityTextBox;
        private System.Windows.Forms.TextBox alignmentTextBox;
        private System.Windows.Forms.TextBox backgroundTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}