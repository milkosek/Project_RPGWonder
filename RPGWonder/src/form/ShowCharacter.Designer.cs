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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCharacter));
            this.skillsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.abilitiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.DescriptionLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.textTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.equipmentTextBox = new System.Windows.Forms.TextBox();
            this.specialsTextBox = new System.Windows.Forms.TextBox();
            this.equipmentLabel = new System.Windows.Forms.Label();
            this.specialRulesLabel = new System.Windows.Forms.Label();
            this.basicInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.alignmentTextBox = new System.Windows.Forms.TextBox();
            this.backgroundTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.alignmentLabel = new System.Windows.Forms.Label();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.othersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.passivePerceptionTextBox = new System.Windows.Forms.TextBox();
            this.hitDiceTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.initiativeModifierTextBox = new System.Windows.Forms.TextBox();
            this.armorClassTextBox = new System.Windows.Forms.TextBox();
            this.proficiencyBonusTextBox = new System.Windows.Forms.TextBox();
            this.HPtextBox = new System.Windows.Forms.TextBox();
            this.passivePerceptionLabel = new System.Windows.Forms.Label();
            this.hitDiceLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.HPLabel = new System.Windows.Forms.Label();
            this.proficiencyBonusLabel = new System.Windows.Forms.Label();
            this.armorClassLabel = new System.Windows.Forms.Label();
            this.initiativeModifierLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.DescriptionLayoutPanel.SuspendLayout();
            this.textTableLayoutPanel.SuspendLayout();
            this.basicInfoTableLayout.SuspendLayout();
            this.othersTableLayoutPanel.SuspendLayout();
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
            this.skillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.skillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.skillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.skillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.skillsTableLayoutPanel.Size = new System.Drawing.Size(188, 603);
            this.skillsTableLayoutPanel.TabIndex = 30;
            // 
            // abilitiesTableLayoutPanel
            // 
            this.abilitiesTableLayoutPanel.ColumnCount = 3;
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.33929F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.66071F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
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
            this.characterNameLabel.Location = new System.Drawing.Point(12, 9);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(213, 31);
            this.characterNameLabel.TabIndex = 27;
            this.characterNameLabel.Text = "Character Name";
            this.characterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLayoutPanel
            // 
            this.DescriptionLayoutPanel.ColumnCount = 1;
            this.DescriptionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DescriptionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DescriptionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DescriptionLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.DescriptionLayoutPanel.Controls.Add(this.descriptionTextBox, 0, 1);
            this.DescriptionLayoutPanel.Location = new System.Drawing.Point(486, 211);
            this.DescriptionLayoutPanel.Name = "DescriptionLayoutPanel";
            this.DescriptionLayoutPanel.RowCount = 2;
            this.DescriptionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.561753F));
            this.DescriptionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.43825F));
            this.DescriptionLayoutPanel.Size = new System.Drawing.Size(682, 189);
            this.DescriptionLayoutPanel.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(254, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Character Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 21);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(676, 165);
            this.descriptionTextBox.TabIndex = 31;
            // 
            // textTableLayoutPanel
            // 
            this.textTableLayoutPanel.ColumnCount = 2;
            this.textTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.textTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.textTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.textTableLayoutPanel.Controls.Add(this.equipmentTextBox, 0, 1);
            this.textTableLayoutPanel.Controls.Add(this.specialsTextBox, 0, 1);
            this.textTableLayoutPanel.Controls.Add(this.equipmentLabel, 0, 0);
            this.textTableLayoutPanel.Controls.Add(this.specialRulesLabel, 1, 0);
            this.textTableLayoutPanel.Location = new System.Drawing.Point(483, 406);
            this.textTableLayoutPanel.Name = "textTableLayoutPanel";
            this.textTableLayoutPanel.RowCount = 2;
            this.textTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.561753F));
            this.textTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.43825F));
            this.textTableLayoutPanel.Size = new System.Drawing.Size(682, 251);
            this.textTableLayoutPanel.TabIndex = 45;
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.Location = new System.Drawing.Point(3, 27);
            this.equipmentTextBox.Multiline = true;
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.ReadOnly = true;
            this.equipmentTextBox.Size = new System.Drawing.Size(403, 221);
            this.equipmentTextBox.TabIndex = 40;
            // 
            // specialsTextBox
            // 
            this.specialsTextBox.Location = new System.Drawing.Point(412, 27);
            this.specialsTextBox.Multiline = true;
            this.specialsTextBox.Name = "specialsTextBox";
            this.specialsTextBox.ReadOnly = true;
            this.specialsTextBox.Size = new System.Drawing.Size(267, 221);
            this.specialsTextBox.TabIndex = 39;
            // 
            // equipmentLabel
            // 
            this.equipmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.equipmentLabel.AutoSize = true;
            this.equipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.equipmentLabel.Location = new System.Drawing.Point(160, 4);
            this.equipmentLabel.Name = "equipmentLabel";
            this.equipmentLabel.Size = new System.Drawing.Size(88, 20);
            this.equipmentLabel.TabIndex = 36;
            this.equipmentLabel.Text = "Equipment";
            // 
            // specialRulesLabel
            // 
            this.specialRulesLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.specialRulesLabel.AutoSize = true;
            this.specialRulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.specialRulesLabel.Location = new System.Drawing.Point(513, 4);
            this.specialRulesLabel.Name = "specialRulesLabel";
            this.specialRulesLabel.Size = new System.Drawing.Size(64, 20);
            this.specialRulesLabel.TabIndex = 35;
            this.specialRulesLabel.Text = "Special";
            // 
            // basicInfoTableLayout
            // 
            this.basicInfoTableLayout.ColumnCount = 4;
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.3764F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.02392F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.05582F));
            this.basicInfoTableLayout.Controls.Add(this.alignmentTextBox, 3, 2);
            this.basicInfoTableLayout.Controls.Add(this.backgroundTextBox, 1, 2);
            this.basicInfoTableLayout.Controls.Add(this.levelTextBox, 3, 1);
            this.basicInfoTableLayout.Controls.Add(this.classTextBox, 1, 1);
            this.basicInfoTableLayout.Controls.Add(this.genderTextBox, 3, 0);
            this.basicInfoTableLayout.Controls.Add(this.levelLabel, 2, 1);
            this.basicInfoTableLayout.Controls.Add(this.genderLabel, 2, 0);
            this.basicInfoTableLayout.Controls.Add(this.backgroundLabel, 0, 2);
            this.basicInfoTableLayout.Controls.Add(this.classLabel, 0, 1);
            this.basicInfoTableLayout.Controls.Add(this.raceLabel, 0, 0);
            this.basicInfoTableLayout.Controls.Add(this.alignmentLabel, 2, 2);
            this.basicInfoTableLayout.Controls.Add(this.raceTextBox, 1, 0);
            this.basicInfoTableLayout.Location = new System.Drawing.Point(483, 54);
            this.basicInfoTableLayout.Name = "basicInfoTableLayout";
            this.basicInfoTableLayout.RowCount = 3;
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.basicInfoTableLayout.Size = new System.Drawing.Size(685, 151);
            this.basicInfoTableLayout.TabIndex = 43;
            // 
            // alignmentTextBox
            // 
            this.alignmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.alignmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alignmentTextBox.Location = new System.Drawing.Point(446, 112);
            this.alignmentTextBox.Name = "alignmentTextBox";
            this.alignmentTextBox.ReadOnly = true;
            this.alignmentTextBox.Size = new System.Drawing.Size(236, 26);
            this.alignmentTextBox.TabIndex = 23;
            // 
            // backgroundTextBox
            // 
            this.backgroundTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backgroundTextBox.Location = new System.Drawing.Point(123, 112);
            this.backgroundTextBox.Name = "backgroundTextBox";
            this.backgroundTextBox.ReadOnly = true;
            this.backgroundTextBox.Size = new System.Drawing.Size(215, 26);
            this.backgroundTextBox.TabIndex = 22;
            // 
            // levelTextBox
            // 
            this.levelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.levelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelTextBox.Location = new System.Drawing.Point(446, 62);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.ReadOnly = true;
            this.levelTextBox.Size = new System.Drawing.Size(236, 26);
            this.levelTextBox.TabIndex = 21;
            // 
            // classTextBox
            // 
            this.classTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.classTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classTextBox.Location = new System.Drawing.Point(123, 62);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.ReadOnly = true;
            this.classTextBox.Size = new System.Drawing.Size(215, 26);
            this.classTextBox.TabIndex = 20;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genderTextBox.Location = new System.Drawing.Point(446, 12);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(236, 26);
            this.genderTextBox.TabIndex = 19;
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.levelLabel.Location = new System.Drawing.Point(391, 65);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(49, 20);
            this.levelLabel.TabIndex = 17;
            this.levelLabel.Text = "Level";
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.genderLabel.Location = new System.Drawing.Point(376, 15);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(64, 20);
            this.genderLabel.TabIndex = 17;
            this.genderLabel.Text = "Gender";
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backgroundLabel.Location = new System.Drawing.Point(19, 115);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(98, 20);
            this.backgroundLabel.TabIndex = 17;
            this.backgroundLabel.Text = "Background";
            // 
            // classLabel
            // 
            this.classLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classLabel.Location = new System.Drawing.Point(65, 65);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(52, 20);
            this.classLabel.TabIndex = 17;
            this.classLabel.Text = "Class";
            this.classLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // raceLabel
            // 
            this.raceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.raceLabel.AutoSize = true;
            this.raceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.raceLabel.Location = new System.Drawing.Point(69, 15);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(48, 20);
            this.raceLabel.TabIndex = 16;
            this.raceLabel.Text = "Race";
            // 
            // alignmentLabel
            // 
            this.alignmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.alignmentLabel.AutoSize = true;
            this.alignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alignmentLabel.Location = new System.Drawing.Point(357, 115);
            this.alignmentLabel.Name = "alignmentLabel";
            this.alignmentLabel.Size = new System.Drawing.Size(83, 20);
            this.alignmentLabel.TabIndex = 17;
            this.alignmentLabel.Text = "Alignment";
            // 
            // raceTextBox
            // 
            this.raceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.raceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.raceTextBox.Location = new System.Drawing.Point(123, 12);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.ReadOnly = true;
            this.raceTextBox.Size = new System.Drawing.Size(215, 26);
            this.raceTextBox.TabIndex = 18;
            // 
            // othersTableLayoutPanel
            // 
            this.othersTableLayoutPanel.ColumnCount = 2;
            this.othersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.othersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.othersTableLayoutPanel.Controls.Add(this.passivePerceptionTextBox, 1, 7);
            this.othersTableLayoutPanel.Controls.Add(this.hitDiceTextBox, 1, 6);
            this.othersTableLayoutPanel.Controls.Add(this.sizeTextBox, 1, 5);
            this.othersTableLayoutPanel.Controls.Add(this.speedTextBox, 1, 4);
            this.othersTableLayoutPanel.Controls.Add(this.initiativeModifierTextBox, 1, 3);
            this.othersTableLayoutPanel.Controls.Add(this.armorClassTextBox, 1, 2);
            this.othersTableLayoutPanel.Controls.Add(this.proficiencyBonusTextBox, 1, 1);
            this.othersTableLayoutPanel.Controls.Add(this.HPtextBox, 1, 0);
            this.othersTableLayoutPanel.Controls.Add(this.passivePerceptionLabel, 0, 7);
            this.othersTableLayoutPanel.Controls.Add(this.hitDiceLabel, 0, 6);
            this.othersTableLayoutPanel.Controls.Add(this.sizeLabel, 0, 5);
            this.othersTableLayoutPanel.Controls.Add(this.speedLabel, 0, 4);
            this.othersTableLayoutPanel.Controls.Add(this.HPLabel, 0, 0);
            this.othersTableLayoutPanel.Controls.Add(this.proficiencyBonusLabel, 0, 1);
            this.othersTableLayoutPanel.Controls.Add(this.armorClassLabel, 0, 2);
            this.othersTableLayoutPanel.Controls.Add(this.initiativeModifierLabel, 0, 3);
            this.othersTableLayoutPanel.Location = new System.Drawing.Point(1174, 54);
            this.othersTableLayoutPanel.Name = "othersTableLayoutPanel";
            this.othersTableLayoutPanel.RowCount = 8;
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.Size = new System.Drawing.Size(227, 601);
            this.othersTableLayoutPanel.TabIndex = 44;
            // 
            // passivePerceptionTextBox
            // 
            this.passivePerceptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passivePerceptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passivePerceptionTextBox.Location = new System.Drawing.Point(116, 550);
            this.passivePerceptionTextBox.Name = "passivePerceptionTextBox";
            this.passivePerceptionTextBox.ReadOnly = true;
            this.passivePerceptionTextBox.Size = new System.Drawing.Size(108, 26);
            this.passivePerceptionTextBox.TabIndex = 43;
            // 
            // hitDiceTextBox
            // 
            this.hitDiceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hitDiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hitDiceTextBox.Location = new System.Drawing.Point(116, 474);
            this.hitDiceTextBox.Name = "hitDiceTextBox";
            this.hitDiceTextBox.ReadOnly = true;
            this.hitDiceTextBox.Size = new System.Drawing.Size(108, 26);
            this.hitDiceTextBox.TabIndex = 43;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sizeTextBox.Location = new System.Drawing.Point(116, 399);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.ReadOnly = true;
            this.sizeTextBox.Size = new System.Drawing.Size(108, 26);
            this.sizeTextBox.TabIndex = 43;
            // 
            // speedTextBox
            // 
            this.speedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.speedTextBox.Location = new System.Drawing.Point(116, 324);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.ReadOnly = true;
            this.speedTextBox.Size = new System.Drawing.Size(108, 26);
            this.speedTextBox.TabIndex = 43;
            // 
            // initiativeModifierTextBox
            // 
            this.initiativeModifierTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initiativeModifierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.initiativeModifierTextBox.Location = new System.Drawing.Point(116, 249);
            this.initiativeModifierTextBox.Name = "initiativeModifierTextBox";
            this.initiativeModifierTextBox.ReadOnly = true;
            this.initiativeModifierTextBox.Size = new System.Drawing.Size(108, 26);
            this.initiativeModifierTextBox.TabIndex = 43;
            // 
            // armorClassTextBox
            // 
            this.armorClassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.armorClassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.armorClassTextBox.Location = new System.Drawing.Point(116, 174);
            this.armorClassTextBox.Name = "armorClassTextBox";
            this.armorClassTextBox.ReadOnly = true;
            this.armorClassTextBox.Size = new System.Drawing.Size(108, 26);
            this.armorClassTextBox.TabIndex = 42;
            // 
            // proficiencyBonusTextBox
            // 
            this.proficiencyBonusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proficiencyBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.proficiencyBonusTextBox.Location = new System.Drawing.Point(116, 99);
            this.proficiencyBonusTextBox.Name = "proficiencyBonusTextBox";
            this.proficiencyBonusTextBox.ReadOnly = true;
            this.proficiencyBonusTextBox.Size = new System.Drawing.Size(108, 26);
            this.proficiencyBonusTextBox.TabIndex = 41;
            // 
            // HPtextBox
            // 
            this.HPtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HPtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HPtextBox.Location = new System.Drawing.Point(116, 24);
            this.HPtextBox.Name = "HPtextBox";
            this.HPtextBox.ReadOnly = true;
            this.HPtextBox.Size = new System.Drawing.Size(108, 26);
            this.HPtextBox.TabIndex = 33;
            // 
            // passivePerceptionLabel
            // 
            this.passivePerceptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passivePerceptionLabel.AutoSize = true;
            this.passivePerceptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passivePerceptionLabel.Location = new System.Drawing.Point(21, 543);
            this.passivePerceptionLabel.Name = "passivePerceptionLabel";
            this.passivePerceptionLabel.Size = new System.Drawing.Size(89, 40);
            this.passivePerceptionLabel.TabIndex = 40;
            this.passivePerceptionLabel.Text = "Passive Perception";
            // 
            // hitDiceLabel
            // 
            this.hitDiceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hitDiceLabel.AutoSize = true;
            this.hitDiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hitDiceLabel.Location = new System.Drawing.Point(39, 477);
            this.hitDiceLabel.Name = "hitDiceLabel";
            this.hitDiceLabel.Size = new System.Drawing.Size(71, 20);
            this.hitDiceLabel.TabIndex = 39;
            this.hitDiceLabel.Text = "Hit Dice";
            // 
            // sizeLabel
            // 
            this.sizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sizeLabel.Location = new System.Drawing.Point(68, 402);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(42, 20);
            this.sizeLabel.TabIndex = 38;
            this.sizeLabel.Text = "Size";
            // 
            // speedLabel
            // 
            this.speedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.speedLabel.Location = new System.Drawing.Point(54, 327);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(56, 20);
            this.speedLabel.TabIndex = 37;
            this.speedLabel.Text = "Speed";
            // 
            // HPLabel
            // 
            this.HPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HPLabel.AutoSize = true;
            this.HPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HPLabel.Location = new System.Drawing.Point(77, 27);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(33, 20);
            this.HPLabel.TabIndex = 33;
            this.HPLabel.Text = "HP";
            // 
            // proficiencyBonusLabel
            // 
            this.proficiencyBonusLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.proficiencyBonusLabel.AutoSize = true;
            this.proficiencyBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.proficiencyBonusLabel.Location = new System.Drawing.Point(13, 92);
            this.proficiencyBonusLabel.Name = "proficiencyBonusLabel";
            this.proficiencyBonusLabel.Size = new System.Drawing.Size(97, 40);
            this.proficiencyBonusLabel.TabIndex = 34;
            this.proficiencyBonusLabel.Text = "Proficiency Bonus";
            // 
            // armorClassLabel
            // 
            this.armorClassLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.armorClassLabel.AutoSize = true;
            this.armorClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.armorClassLabel.Location = new System.Drawing.Point(7, 177);
            this.armorClassLabel.Name = "armorClassLabel";
            this.armorClassLabel.Size = new System.Drawing.Size(103, 20);
            this.armorClassLabel.TabIndex = 35;
            this.armorClassLabel.Text = "Armor Class";
            // 
            // initiativeModifierLabel
            // 
            this.initiativeModifierLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.initiativeModifierLabel.AutoSize = true;
            this.initiativeModifierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.initiativeModifierLabel.Location = new System.Drawing.Point(35, 242);
            this.initiativeModifierLabel.Name = "initiativeModifierLabel";
            this.initiativeModifierLabel.Size = new System.Drawing.Size(75, 40);
            this.initiativeModifierLabel.TabIndex = 36;
            this.initiativeModifierLabel.Text = "Initiative Modifier";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(12, 663);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(1332, 44);
            this.saveButton.TabIndex = 42;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            // 
            // ShowCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 667);
            this.Controls.Add(this.DescriptionLayoutPanel);
            this.Controls.Add(this.textTableLayoutPanel);
            this.Controls.Add(this.basicInfoTableLayout);
            this.Controls.Add(this.othersTableLayoutPanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.skillsTableLayoutPanel);
            this.Controls.Add(this.abilitiesTableLayoutPanel);
            this.Controls.Add(this.characterNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowCharacter";
            this.Text = "Character";
            this.Load += new System.EventHandler(this.ShowCharacter_Load);
            this.DescriptionLayoutPanel.ResumeLayout(false);
            this.DescriptionLayoutPanel.PerformLayout();
            this.textTableLayoutPanel.ResumeLayout(false);
            this.textTableLayoutPanel.PerformLayout();
            this.basicInfoTableLayout.ResumeLayout(false);
            this.basicInfoTableLayout.PerformLayout();
            this.othersTableLayoutPanel.ResumeLayout(false);
            this.othersTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel skillsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel abilitiesTableLayoutPanel;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.TableLayoutPanel DescriptionLayoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TableLayoutPanel textTableLayoutPanel;
        private System.Windows.Forms.TextBox specialsTextBox;
        private System.Windows.Forms.Label equipmentLabel;
        private System.Windows.Forms.Label specialRulesLabel;
        private System.Windows.Forms.TableLayoutPanel basicInfoTableLayout;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label alignmentLabel;
        private System.Windows.Forms.TableLayoutPanel othersTableLayoutPanel;
        private System.Windows.Forms.TextBox passivePerceptionTextBox;
        private System.Windows.Forms.TextBox hitDiceTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox initiativeModifierTextBox;
        private System.Windows.Forms.TextBox armorClassTextBox;
        private System.Windows.Forms.TextBox proficiencyBonusTextBox;
        private System.Windows.Forms.TextBox HPtextBox;
        private System.Windows.Forms.Label passivePerceptionLabel;
        private System.Windows.Forms.Label hitDiceLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label HPLabel;
        private System.Windows.Forms.Label proficiencyBonusLabel;
        private System.Windows.Forms.Label armorClassLabel;
        private System.Windows.Forms.Label initiativeModifierLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox alignmentTextBox;
        private System.Windows.Forms.TextBox backgroundTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.TextBox equipmentTextBox;
    }
}