namespace RPGWonder
{
    partial class CreateOrEditCharacter
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
            this.saveButton = new System.Windows.Forms.Button();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.initiativeModifierTextBox = new System.Windows.Forms.TextBox();
            this.armorClassTextBox = new System.Windows.Forms.TextBox();
            this.proficiencyBonusTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.hitDiceLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.HPLabel = new System.Windows.Forms.Label();
            this.proficiencyBonusLabel = new System.Windows.Forms.Label();
            this.armorClassLabel = new System.Windows.Forms.Label();
            this.initiativeModifierLabel = new System.Windows.Forms.Label();
            this.textTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.specialTextBox = new System.Windows.Forms.TextBox();
            this.equipmentLabel = new System.Windows.Forms.Label();
            this.specialRulesLabel = new System.Windows.Forms.Label();
            this.passivePerceptionLabel = new System.Windows.Forms.Label();
            this.skillsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.abilitiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rerollAbilitiesButton = new System.Windows.Forms.Button();
            this.levelLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.hitDiceTextBox = new System.Windows.Forms.TextBox();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.alignmentLabel = new System.Windows.Forms.Label();
            this.basicInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.alignmentComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundComboBox = new System.Windows.Forms.ComboBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.othersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HPTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rollHPComboBox = new System.Windows.Forms.ComboBox();
            this.rollHPButton = new System.Windows.Forms.Button();
            this.HPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.passivePerceptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.equipmentTextBox = new System.Windows.Forms.TextBox();
            this.textTableLayoutPanel.SuspendLayout();
            this.abilitiesTableLayoutPanel.SuspendLayout();
            this.basicInfoTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).BeginInit();
            this.othersTableLayoutPanel.SuspendLayout();
            this.HPTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPNumericUpDown)).BeginInit();
            this.DescriptionLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(6, 776);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(1496, 44);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sizeTextBox.Location = new System.Drawing.Point(117, 471);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.ReadOnly = true;
            this.sizeTextBox.Size = new System.Drawing.Size(121, 26);
            this.sizeTextBox.TabIndex = 43;
            // 
            // initiativeModifierTextBox
            // 
            this.initiativeModifierTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initiativeModifierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.initiativeModifierTextBox.Location = new System.Drawing.Point(117, 296);
            this.initiativeModifierTextBox.Name = "initiativeModifierTextBox";
            this.initiativeModifierTextBox.ReadOnly = true;
            this.initiativeModifierTextBox.Size = new System.Drawing.Size(121, 26);
            this.initiativeModifierTextBox.TabIndex = 43;
            // 
            // armorClassTextBox
            // 
            this.armorClassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.armorClassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.armorClassTextBox.Location = new System.Drawing.Point(117, 207);
            this.armorClassTextBox.Name = "armorClassTextBox";
            this.armorClassTextBox.ReadOnly = true;
            this.armorClassTextBox.Size = new System.Drawing.Size(121, 26);
            this.armorClassTextBox.TabIndex = 42;
            // 
            // proficiencyBonusTextBox
            // 
            this.proficiencyBonusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proficiencyBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.proficiencyBonusTextBox.Location = new System.Drawing.Point(117, 119);
            this.proficiencyBonusTextBox.Name = "proficiencyBonusTextBox";
            this.proficiencyBonusTextBox.ReadOnly = true;
            this.proficiencyBonusTextBox.Size = new System.Drawing.Size(121, 26);
            this.proficiencyBonusTextBox.TabIndex = 41;
            // 
            // speedTextBox
            // 
            this.speedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.speedTextBox.Location = new System.Drawing.Point(117, 384);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.ReadOnly = true;
            this.speedTextBox.Size = new System.Drawing.Size(121, 26);
            this.speedTextBox.TabIndex = 43;
            // 
            // hitDiceLabel
            // 
            this.hitDiceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hitDiceLabel.AutoSize = true;
            this.hitDiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hitDiceLabel.Location = new System.Drawing.Point(40, 562);
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
            this.sizeLabel.Location = new System.Drawing.Point(69, 474);
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
            this.speedLabel.Location = new System.Drawing.Point(55, 387);
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
            this.HPLabel.Location = new System.Drawing.Point(78, 34);
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
            this.proficiencyBonusLabel.Location = new System.Drawing.Point(14, 112);
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
            this.armorClassLabel.Location = new System.Drawing.Point(8, 210);
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
            this.initiativeModifierLabel.Location = new System.Drawing.Point(36, 289);
            this.initiativeModifierLabel.Name = "initiativeModifierLabel";
            this.initiativeModifierLabel.Size = new System.Drawing.Size(75, 40);
            this.initiativeModifierLabel.TabIndex = 36;
            this.initiativeModifierLabel.Text = "Initiative Modifier";
            // 
            // textTableLayoutPanel
            // 
            this.textTableLayoutPanel.ColumnCount = 2;
            this.textTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.textTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.textTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.textTableLayoutPanel.Controls.Add(this.equipmentTextBox, 0, 1);
            this.textTableLayoutPanel.Controls.Add(this.specialTextBox, 0, 1);
            this.textTableLayoutPanel.Controls.Add(this.equipmentLabel, 0, 0);
            this.textTableLayoutPanel.Controls.Add(this.specialRulesLabel, 1, 0);
            this.textTableLayoutPanel.Location = new System.Drawing.Point(480, 443);
            this.textTableLayoutPanel.Name = "textTableLayoutPanel";
            this.textTableLayoutPanel.RowCount = 2;
            this.textTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.561753F));
            this.textTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.43825F));
            this.textTableLayoutPanel.Size = new System.Drawing.Size(679, 327);
            this.textTableLayoutPanel.TabIndex = 39;
            // 
            // specialTextBox
            // 
            this.specialTextBox.Location = new System.Drawing.Point(410, 34);
            this.specialTextBox.Multiline = true;
            this.specialTextBox.Name = "specialTextBox";
            this.specialTextBox.Size = new System.Drawing.Size(266, 290);
            this.specialTextBox.TabIndex = 39;
            // 
            // equipmentLabel
            // 
            this.equipmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.equipmentLabel.AutoSize = true;
            this.equipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.equipmentLabel.Location = new System.Drawing.Point(159, 11);
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
            this.specialRulesLabel.Location = new System.Drawing.Point(511, 11);
            this.specialRulesLabel.Name = "specialRulesLabel";
            this.specialRulesLabel.Size = new System.Drawing.Size(64, 20);
            this.specialRulesLabel.TabIndex = 35;
            this.specialRulesLabel.Text = "Special";
            // 
            // passivePerceptionLabel
            // 
            this.passivePerceptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passivePerceptionLabel.AutoSize = true;
            this.passivePerceptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passivePerceptionLabel.Location = new System.Drawing.Point(22, 643);
            this.passivePerceptionLabel.Name = "passivePerceptionLabel";
            this.passivePerceptionLabel.Size = new System.Drawing.Size(89, 40);
            this.passivePerceptionLabel.TabIndex = 40;
            this.passivePerceptionLabel.Text = "Passive Perception";
            // 
            // skillsTableLayoutPanel
            // 
            this.skillsTableLayoutPanel.ColumnCount = 1;
            this.skillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillsTableLayoutPanel.Location = new System.Drawing.Point(283, 59);
            this.skillsTableLayoutPanel.Name = "skillsTableLayoutPanel";
            this.skillsTableLayoutPanel.RowCount = 1;
            this.skillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.skillsTableLayoutPanel.Size = new System.Drawing.Size(188, 711);
            this.skillsTableLayoutPanel.TabIndex = 37;
            // 
            // abilitiesTableLayoutPanel
            // 
            this.abilitiesTableLayoutPanel.ColumnCount = 3;
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.33929F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.66071F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.abilitiesTableLayoutPanel.Controls.Add(this.rerollAbilitiesButton, 2, 0);
            this.abilitiesTableLayoutPanel.Location = new System.Drawing.Point(6, 59);
            this.abilitiesTableLayoutPanel.Name = "abilitiesTableLayoutPanel";
            this.abilitiesTableLayoutPanel.RowCount = 1;
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.abilitiesTableLayoutPanel.Size = new System.Drawing.Size(271, 711);
            this.abilitiesTableLayoutPanel.TabIndex = 36;
            // 
            // rerollAbilitiesButton
            // 
            this.rerollAbilitiesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rerollAbilitiesButton.Enabled = false;
            this.rerollAbilitiesButton.Image = global::RPGWonder.Properties.Resources.Die;
            this.rerollAbilitiesButton.Location = new System.Drawing.Point(212, 335);
            this.rerollAbilitiesButton.Name = "rerollAbilitiesButton";
            this.rerollAbilitiesButton.Size = new System.Drawing.Size(40, 40);
            this.rerollAbilitiesButton.TabIndex = 0;
            this.rerollAbilitiesButton.UseVisualStyleBackColor = true;
            this.rerollAbilitiesButton.Click += new System.EventHandler(this.rerollAbilitiesButton_Click);
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
            // hitDiceTextBox
            // 
            this.hitDiceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hitDiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hitDiceTextBox.Location = new System.Drawing.Point(117, 559);
            this.hitDiceTextBox.Name = "hitDiceTextBox";
            this.hitDiceTextBox.ReadOnly = true;
            this.hitDiceTextBox.Size = new System.Drawing.Size(121, 26);
            this.hitDiceTextBox.TabIndex = 43;
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
            // basicInfoTableLayout
            // 
            this.basicInfoTableLayout.ColumnCount = 4;
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.3764F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.02392F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.05582F));
            this.basicInfoTableLayout.Controls.Add(this.alignmentComboBox, 3, 2);
            this.basicInfoTableLayout.Controls.Add(this.genderComboBox, 3, 0);
            this.basicInfoTableLayout.Controls.Add(this.backgroundComboBox, 1, 2);
            this.basicInfoTableLayout.Controls.Add(this.classComboBox, 1, 1);
            this.basicInfoTableLayout.Controls.Add(this.raceComboBox, 1, 0);
            this.basicInfoTableLayout.Controls.Add(this.levelLabel, 2, 1);
            this.basicInfoTableLayout.Controls.Add(this.genderLabel, 2, 0);
            this.basicInfoTableLayout.Controls.Add(this.backgroundLabel, 0, 2);
            this.basicInfoTableLayout.Controls.Add(this.classLabel, 0, 1);
            this.basicInfoTableLayout.Controls.Add(this.raceLabel, 0, 0);
            this.basicInfoTableLayout.Controls.Add(this.alignmentLabel, 2, 2);
            this.basicInfoTableLayout.Controls.Add(this.levelNumericUpDown, 3, 1);
            this.basicInfoTableLayout.Location = new System.Drawing.Point(477, 59);
            this.basicInfoTableLayout.Name = "basicInfoTableLayout";
            this.basicInfoTableLayout.RowCount = 3;
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.basicInfoTableLayout.Size = new System.Drawing.Size(685, 151);
            this.basicInfoTableLayout.TabIndex = 34;
            // 
            // alignmentComboBox
            // 
            this.alignmentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.alignmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alignmentComboBox.FormattingEnabled = true;
            this.alignmentComboBox.Location = new System.Drawing.Point(446, 111);
            this.alignmentComboBox.Name = "alignmentComboBox";
            this.alignmentComboBox.Size = new System.Drawing.Size(236, 28);
            this.alignmentComboBox.TabIndex = 46;
            this.alignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.alignmentComboBox_SelectedIndexChanged);
            this.alignmentComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alignmentComboBox_KeyPress);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(446, 11);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(236, 28);
            this.genderComboBox.TabIndex = 44;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            this.genderComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderComboBox_KeyPress);
            // 
            // backgroundComboBox
            // 
            this.backgroundComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backgroundComboBox.FormattingEnabled = true;
            this.backgroundComboBox.Location = new System.Drawing.Point(123, 111);
            this.backgroundComboBox.Name = "backgroundComboBox";
            this.backgroundComboBox.Size = new System.Drawing.Size(215, 28);
            this.backgroundComboBox.TabIndex = 43;
            this.backgroundComboBox.SelectedIndexChanged += new System.EventHandler(this.backgroundComboBox_SelectedIndexChanged);
            this.backgroundComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.backgroundComboBox_KeyPress);
            // 
            // classComboBox
            // 
            this.classComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.classComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(123, 61);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(215, 28);
            this.classComboBox.TabIndex = 42;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            this.classComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.classComboBox_KeyPress);
            // 
            // raceComboBox
            // 
            this.raceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.raceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(123, 11);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(215, 28);
            this.raceComboBox.TabIndex = 41;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceCcomboBox_SelectedIndexChanged);
            this.raceComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.raceComboBox_KeyPress);
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
            // levelNumericUpDown
            // 
            this.levelNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.levelNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.levelNumericUpDown.Location = new System.Drawing.Point(446, 62);
            this.levelNumericUpDown.Name = "levelNumericUpDown";
            this.levelNumericUpDown.Size = new System.Drawing.Size(236, 26);
            this.levelNumericUpDown.TabIndex = 47;
            this.levelNumericUpDown.ValueChanged += new System.EventHandler(this.levelBox_ValueChanged);
            // 
            // othersTableLayoutPanel
            // 
            this.othersTableLayoutPanel.ColumnCount = 3;
            this.othersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.44109F));
            this.othersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.36858F));
            this.othersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.88822F));
            this.othersTableLayoutPanel.Controls.Add(this.HPTableLayoutPanel, 2, 0);
            this.othersTableLayoutPanel.Controls.Add(this.HPNumericUpDown, 1, 0);
            this.othersTableLayoutPanel.Controls.Add(this.passivePerceptionTextBox, 1, 7);
            this.othersTableLayoutPanel.Controls.Add(this.hitDiceTextBox, 1, 6);
            this.othersTableLayoutPanel.Controls.Add(this.sizeTextBox, 1, 5);
            this.othersTableLayoutPanel.Controls.Add(this.speedTextBox, 1, 4);
            this.othersTableLayoutPanel.Controls.Add(this.initiativeModifierTextBox, 1, 3);
            this.othersTableLayoutPanel.Controls.Add(this.armorClassTextBox, 1, 2);
            this.othersTableLayoutPanel.Controls.Add(this.proficiencyBonusTextBox, 1, 1);
            this.othersTableLayoutPanel.Controls.Add(this.passivePerceptionLabel, 0, 7);
            this.othersTableLayoutPanel.Controls.Add(this.hitDiceLabel, 0, 6);
            this.othersTableLayoutPanel.Controls.Add(this.sizeLabel, 0, 5);
            this.othersTableLayoutPanel.Controls.Add(this.speedLabel, 0, 4);
            this.othersTableLayoutPanel.Controls.Add(this.HPLabel, 0, 0);
            this.othersTableLayoutPanel.Controls.Add(this.proficiencyBonusLabel, 0, 1);
            this.othersTableLayoutPanel.Controls.Add(this.armorClassLabel, 0, 2);
            this.othersTableLayoutPanel.Controls.Add(this.initiativeModifierLabel, 0, 3);
            this.othersTableLayoutPanel.Location = new System.Drawing.Point(1168, 59);
            this.othersTableLayoutPanel.Name = "othersTableLayoutPanel";
            this.othersTableLayoutPanel.RowCount = 8;
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75917F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.othersTableLayoutPanel.Size = new System.Drawing.Size(331, 711);
            this.othersTableLayoutPanel.TabIndex = 38;
            // 
            // HPTableLayoutPanel
            // 
            this.HPTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HPTableLayoutPanel.ColumnCount = 1;
            this.HPTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HPTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HPTableLayoutPanel.Controls.Add(this.rollHPComboBox, 0, 1);
            this.HPTableLayoutPanel.Controls.Add(this.rollHPButton, 0, 0);
            this.HPTableLayoutPanel.Location = new System.Drawing.Point(244, 3);
            this.HPTableLayoutPanel.Name = "HPTableLayoutPanel";
            this.HPTableLayoutPanel.RowCount = 2;
            this.HPTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HPTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HPTableLayoutPanel.Size = new System.Drawing.Size(84, 82);
            this.HPTableLayoutPanel.TabIndex = 43;
            this.HPTableLayoutPanel.Visible = false;
            // 
            // rollHPComboBox
            // 
            this.rollHPComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rollHPComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rollHPComboBox.FormattingEnabled = true;
            this.rollHPComboBox.Items.AddRange(new object[] {
            "avg",
            "roll"});
            this.rollHPComboBox.Location = new System.Drawing.Point(3, 47);
            this.rollHPComboBox.Name = "rollHPComboBox";
            this.rollHPComboBox.Size = new System.Drawing.Size(78, 28);
            this.rollHPComboBox.TabIndex = 43;
            this.rollHPComboBox.Text = "avg";
            this.rollHPComboBox.SelectedIndexChanged += new System.EventHandler(this.rollHPComboBox_SelectedIndexChanged);
            this.rollHPComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rollHPComboBox_KeyPress);
            // 
            // rollHPButton
            // 
            this.rollHPButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollHPButton.Enabled = false;
            this.rollHPButton.Image = global::RPGWonder.Properties.Resources.Die;
            this.rollHPButton.Location = new System.Drawing.Point(3, 3);
            this.rollHPButton.Name = "rollHPButton";
            this.rollHPButton.Size = new System.Drawing.Size(78, 35);
            this.rollHPButton.TabIndex = 42;
            this.rollHPButton.UseVisualStyleBackColor = true;
            this.rollHPButton.Click += new System.EventHandler(this.rollHPButton_Click);
            // 
            // HPNumericUpDown
            // 
            this.HPNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HPNumericUpDown.Enabled = false;
            this.HPNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HPNumericUpDown.Location = new System.Drawing.Point(117, 31);
            this.HPNumericUpDown.Name = "HPNumericUpDown";
            this.HPNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.HPNumericUpDown.TabIndex = 48;
            // 
            // passivePerceptionTextBox
            // 
            this.passivePerceptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passivePerceptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passivePerceptionTextBox.Location = new System.Drawing.Point(117, 650);
            this.passivePerceptionTextBox.Name = "passivePerceptionTextBox";
            this.passivePerceptionTextBox.ReadOnly = true;
            this.passivePerceptionTextBox.Size = new System.Drawing.Size(121, 26);
            this.passivePerceptionTextBox.TabIndex = 43;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameTextBox.Location = new System.Drawing.Point(6, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(465, 38);
            this.nameTextBox.TabIndex = 40;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // DescriptionLayoutPanel
            // 
            this.DescriptionLayoutPanel.ColumnCount = 1;
            this.DescriptionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DescriptionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DescriptionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DescriptionLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.DescriptionLayoutPanel.Controls.Add(this.descriptionTextBox, 0, 1);
            this.DescriptionLayoutPanel.Location = new System.Drawing.Point(480, 216);
            this.DescriptionLayoutPanel.Name = "DescriptionLayoutPanel";
            this.DescriptionLayoutPanel.RowCount = 2;
            this.DescriptionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.561753F));
            this.DescriptionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.43825F));
            this.DescriptionLayoutPanel.Size = new System.Drawing.Size(682, 224);
            this.DescriptionLayoutPanel.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(254, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Character Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 24);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(676, 197);
            this.descriptionTextBox.TabIndex = 31;
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.Location = new System.Drawing.Point(3, 34);
            this.equipmentTextBox.Multiline = true;
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(401, 290);
            this.equipmentTextBox.TabIndex = 40;
            // 
            // CreateOrEditCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 826);
            this.Controls.Add(this.DescriptionLayoutPanel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.textTableLayoutPanel);
            this.Controls.Add(this.skillsTableLayoutPanel);
            this.Controls.Add(this.abilitiesTableLayoutPanel);
            this.Controls.Add(this.basicInfoTableLayout);
            this.Controls.Add(this.othersTableLayoutPanel);
            this.Controls.Add(this.saveButton);
            this.Name = "CreateOrEditCharacter";
            this.Text = "CreateOrEditCharacter";
            this.Load += new System.EventHandler(this.CreateOrEditCharacter_Load);
            this.textTableLayoutPanel.ResumeLayout(false);
            this.textTableLayoutPanel.PerformLayout();
            this.abilitiesTableLayoutPanel.ResumeLayout(false);
            this.basicInfoTableLayout.ResumeLayout(false);
            this.basicInfoTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).EndInit();
            this.othersTableLayoutPanel.ResumeLayout(false);
            this.othersTableLayoutPanel.PerformLayout();
            this.HPTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HPNumericUpDown)).EndInit();
            this.DescriptionLayoutPanel.ResumeLayout(false);
            this.DescriptionLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox initiativeModifierTextBox;
        private System.Windows.Forms.TextBox armorClassTextBox;
        private System.Windows.Forms.TextBox proficiencyBonusTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label hitDiceLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label HPLabel;
        private System.Windows.Forms.Label proficiencyBonusLabel;
        private System.Windows.Forms.Label armorClassLabel;
        private System.Windows.Forms.Label initiativeModifierLabel;
        private System.Windows.Forms.TableLayoutPanel textTableLayoutPanel;
        private System.Windows.Forms.Label equipmentLabel;
        private System.Windows.Forms.Label specialRulesLabel;
        private System.Windows.Forms.Label passivePerceptionLabel;
        private System.Windows.Forms.TableLayoutPanel skillsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel abilitiesTableLayoutPanel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox hitDiceTextBox;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label alignmentLabel;
        private System.Windows.Forms.TableLayoutPanel basicInfoTableLayout;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TableLayoutPanel othersTableLayoutPanel;
        private System.Windows.Forms.TextBox passivePerceptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox alignmentComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox backgroundComboBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.NumericUpDown levelNumericUpDown;
        private System.Windows.Forms.TextBox specialTextBox;
        private System.Windows.Forms.TableLayoutPanel DescriptionLayoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button rerollAbilitiesButton;
        private System.Windows.Forms.NumericUpDown HPNumericUpDown;
        private System.Windows.Forms.Button rollHPButton;
        private System.Windows.Forms.TableLayoutPanel HPTableLayoutPanel;
        private System.Windows.Forms.ComboBox rollHPComboBox;
        private System.Windows.Forms.TextBox equipmentTextBox;
    }
}