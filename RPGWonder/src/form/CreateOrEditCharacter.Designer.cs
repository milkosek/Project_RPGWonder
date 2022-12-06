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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrEditCharacter));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.raceCcomboBox = new System.Windows.Forms.ComboBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.alignmentComboBox = new System.Windows.Forms.ComboBox();
            this.basicInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flawsLabel = new System.Windows.Forms.Label();
            this.bondsLabel = new System.Windows.Forms.Label();
            this.personalityTraitsLabel = new System.Windows.Forms.Label();
            this.bondsTextBox = new System.Windows.Forms.TextBox();
            this.flawsTextBox = new System.Windows.Forms.TextBox();
            this.ideaslTextBox = new System.Windows.Forms.TextBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.NumericUpDown();
            this.alignmentLabel = new System.Windows.Forms.Label();
            this.personalityTraitsTextBox = new System.Windows.Forms.TextBox();
            this.idealsLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.statsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rerollButton = new System.Windows.Forms.Button();
            this.skillsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.basicInfoTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(176, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(401, 38);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(366, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // raceCcomboBox
            // 
            this.raceCcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.raceCcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raceCcomboBox.FormattingEnabled = true;
            this.raceCcomboBox.Location = new System.Drawing.Point(97, 33);
            this.raceCcomboBox.Name = "raceCcomboBox";
            this.raceCcomboBox.Size = new System.Drawing.Size(213, 24);
            this.raceCcomboBox.TabIndex = 10;
            this.raceCcomboBox.SelectedIndexChanged += new System.EventHandler(this.raceCcomboBox_SelectedIndexChanged);
            // 
            // classComboBox
            // 
            this.classComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(97, 123);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(213, 24);
            this.classComboBox.TabIndex = 11;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // backgroundComboBox
            // 
            this.backgroundComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backgroundComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backgroundComboBox.FormattingEnabled = true;
            this.backgroundComboBox.Location = new System.Drawing.Point(97, 213);
            this.backgroundComboBox.Name = "backgroundComboBox";
            this.backgroundComboBox.Size = new System.Drawing.Size(213, 24);
            this.backgroundComboBox.TabIndex = 12;
            this.backgroundComboBox.SelectedIndexChanged += new System.EventHandler(this.backgroundComboBox_SelectedIndexChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(410, 33);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(215, 24);
            this.genderComboBox.TabIndex = 13;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // alignmentComboBox
            // 
            this.alignmentComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.alignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alignmentComboBox.FormattingEnabled = true;
            this.alignmentComboBox.Location = new System.Drawing.Point(410, 213);
            this.alignmentComboBox.Name = "alignmentComboBox";
            this.alignmentComboBox.Size = new System.Drawing.Size(215, 24);
            this.alignmentComboBox.TabIndex = 14;
            this.alignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.alignmentComboBox_SelectedIndexChanged);
            // 
            // basicInfoTableLayout
            // 
            this.basicInfoTableLayout.ColumnCount = 4;
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.basicInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.basicInfoTableLayout.Controls.Add(this.flawsLabel, 2, 4);
            this.basicInfoTableLayout.Controls.Add(this.bondsLabel, 0, 4);
            this.basicInfoTableLayout.Controls.Add(this.personalityTraitsLabel, 0, 3);
            this.basicInfoTableLayout.Controls.Add(this.bondsTextBox, 1, 4);
            this.basicInfoTableLayout.Controls.Add(this.flawsTextBox, 3, 4);
            this.basicInfoTableLayout.Controls.Add(this.ideaslTextBox, 3, 3);
            this.basicInfoTableLayout.Controls.Add(this.levelLabel, 2, 1);
            this.basicInfoTableLayout.Controls.Add(this.genderLabel, 2, 0);
            this.basicInfoTableLayout.Controls.Add(this.backgroundLabel, 0, 2);
            this.basicInfoTableLayout.Controls.Add(this.classLabel, 0, 1);
            this.basicInfoTableLayout.Controls.Add(this.raceLabel, 0, 0);
            this.basicInfoTableLayout.Controls.Add(this.raceCcomboBox, 1, 0);
            this.basicInfoTableLayout.Controls.Add(this.alignmentComboBox, 3, 2);
            this.basicInfoTableLayout.Controls.Add(this.classComboBox, 1, 1);
            this.basicInfoTableLayout.Controls.Add(this.genderComboBox, 3, 0);
            this.basicInfoTableLayout.Controls.Add(this.levelBox, 3, 1);
            this.basicInfoTableLayout.Controls.Add(this.alignmentLabel, 2, 2);
            this.basicInfoTableLayout.Controls.Add(this.backgroundComboBox, 1, 2);
            this.basicInfoTableLayout.Controls.Add(this.personalityTraitsTextBox, 1, 3);
            this.basicInfoTableLayout.Controls.Add(this.idealsLabel, 2, 3);
            this.basicInfoTableLayout.Location = new System.Drawing.Point(79, 107);
            this.basicInfoTableLayout.Name = "basicInfoTableLayout";
            this.basicInfoTableLayout.RowCount = 5;
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basicInfoTableLayout.Size = new System.Drawing.Size(628, 452);
            this.basicInfoTableLayout.TabIndex = 15;
            // 
            // flawsLabel
            // 
            this.flawsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flawsLabel.AutoSize = true;
            this.flawsLabel.Location = new System.Drawing.Point(369, 398);
            this.flawsLabel.Name = "flawsLabel";
            this.flawsLabel.Size = new System.Drawing.Size(35, 16);
            this.flawsLabel.TabIndex = 18;
            this.flawsLabel.Text = "Flaw";
            // 
            // bondsLabel
            // 
            this.bondsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bondsLabel.AutoSize = true;
            this.bondsLabel.Location = new System.Drawing.Point(52, 398);
            this.bondsLabel.Name = "bondsLabel";
            this.bondsLabel.Size = new System.Drawing.Size(39, 16);
            this.bondsLabel.TabIndex = 18;
            this.bondsLabel.Text = "Bond";
            // 
            // personalityTraitsLabel
            // 
            this.personalityTraitsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personalityTraitsLabel.AutoSize = true;
            this.personalityTraitsLabel.Location = new System.Drawing.Point(14, 299);
            this.personalityTraitsLabel.Name = "personalityTraitsLabel";
            this.personalityTraitsLabel.Size = new System.Drawing.Size(77, 32);
            this.personalityTraitsLabel.TabIndex = 18;
            this.personalityTraitsLabel.Text = "Personality Traits";
            // 
            // bondsTextBox
            // 
            this.bondsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bondsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bondsTextBox.Location = new System.Drawing.Point(97, 392);
            this.bondsTextBox.Name = "bondsTextBox";
            this.bondsTextBox.Size = new System.Drawing.Size(213, 27);
            this.bondsTextBox.TabIndex = 19;
            // 
            // flawsTextBox
            // 
            this.flawsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flawsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flawsTextBox.Location = new System.Drawing.Point(411, 392);
            this.flawsTextBox.Name = "flawsTextBox";
            this.flawsTextBox.Size = new System.Drawing.Size(213, 27);
            this.flawsTextBox.TabIndex = 19;
            // 
            // ideaslTextBox
            // 
            this.ideaslTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ideaslTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ideaslTextBox.Location = new System.Drawing.Point(411, 301);
            this.ideaslTextBox.Name = "ideaslTextBox";
            this.ideaslTextBox.Size = new System.Drawing.Size(213, 27);
            this.ideaslTextBox.TabIndex = 19;
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(364, 127);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(40, 16);
            this.levelLabel.TabIndex = 17;
            this.levelLabel.Text = "Level";
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(352, 37);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(52, 16);
            this.genderLabel.TabIndex = 17;
            this.genderLabel.Text = "Gender";
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(11, 217);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(80, 16);
            this.backgroundLabel.TabIndex = 17;
            this.backgroundLabel.Text = "Background";
            // 
            // classLabel
            // 
            this.classLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(50, 127);
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
            this.raceLabel.Location = new System.Drawing.Point(51, 37);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(40, 16);
            this.raceLabel.TabIndex = 16;
            this.raceLabel.Text = "Race";
            // 
            // levelBox
            // 
            this.levelBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.levelBox.Location = new System.Drawing.Point(410, 124);
            this.levelBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.levelBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(215, 22);
            this.levelBox.TabIndex = 15;
            this.levelBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelBox.ValueChanged += new System.EventHandler(this.levelBox_ValueChanged);
            // 
            // alignmentLabel
            // 
            this.alignmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.alignmentLabel.AutoSize = true;
            this.alignmentLabel.Location = new System.Drawing.Point(338, 217);
            this.alignmentLabel.Name = "alignmentLabel";
            this.alignmentLabel.Size = new System.Drawing.Size(66, 16);
            this.alignmentLabel.TabIndex = 17;
            this.alignmentLabel.Text = "Alignment";
            // 
            // personalityTraitsTextBox
            // 
            this.personalityTraitsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.personalityTraitsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personalityTraitsTextBox.Location = new System.Drawing.Point(97, 301);
            this.personalityTraitsTextBox.Name = "personalityTraitsTextBox";
            this.personalityTraitsTextBox.Size = new System.Drawing.Size(213, 27);
            this.personalityTraitsTextBox.TabIndex = 18;
            // 
            // idealsLabel
            // 
            this.idealsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.idealsLabel.AutoSize = true;
            this.idealsLabel.Location = new System.Drawing.Point(367, 307);
            this.idealsLabel.Name = "idealsLabel";
            this.idealsLabel.Size = new System.Drawing.Size(37, 16);
            this.idealsLabel.TabIndex = 18;
            this.idealsLabel.Text = "Ideal";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextButton.Location = new System.Drawing.Point(12, 583);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(772, 44);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.characterNameLabel.Location = new System.Drawing.Point(12, 9);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(155, 25);
            this.characterNameLabel.TabIndex = 17;
            this.characterNameLabel.Text = "Character Name";
            this.characterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.characterNameLabel.Visible = false;
            // 
            // statsTableLayoutPanel
            // 
            this.statsTableLayoutPanel.ColumnCount = 2;
            this.statsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.47305F));
            this.statsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.52695F));
            this.statsTableLayoutPanel.Location = new System.Drawing.Point(17, 49);
            this.statsTableLayoutPanel.Name = "statsTableLayoutPanel";
            this.statsTableLayoutPanel.RowCount = 1;
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.statsTableLayoutPanel.Size = new System.Drawing.Size(167, 528);
            this.statsTableLayoutPanel.TabIndex = 18;
            this.statsTableLayoutPanel.Visible = false;
            // 
            // rerollButton
            // 
            this.rerollButton.Image = ((System.Drawing.Image)(resources.GetObject("rerollButton.Image")));
            this.rerollButton.Location = new System.Drawing.Point(190, 47);
            this.rerollButton.Name = "rerollButton";
            this.rerollButton.Size = new System.Drawing.Size(42, 40);
            this.rerollButton.TabIndex = 19;
            this.rerollButton.UseVisualStyleBackColor = true;
            this.rerollButton.Visible = false;
            this.rerollButton.Click += new System.EventHandler(this.rerollButton_Click);
            // 
            // skillsTableLayoutPanel
            // 
            this.skillsTableLayoutPanel.ColumnCount = 1;
            this.skillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillsTableLayoutPanel.Location = new System.Drawing.Point(190, 115);
            this.skillsTableLayoutPanel.Name = "skillsTableLayoutPanel";
            this.skillsTableLayoutPanel.RowCount = 1;
            this.skillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.skillsTableLayoutPanel.Size = new System.Drawing.Size(175, 462);
            this.skillsTableLayoutPanel.TabIndex = 20;
            this.skillsTableLayoutPanel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.Location = new System.Drawing.Point(12, 583);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(772, 44);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Location = new System.Drawing.Point(728, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 60);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreateOrEditCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.skillsTableLayoutPanel);
            this.Controls.Add(this.rerollButton);
            this.Controls.Add(this.statsTableLayoutPanel);
            this.Controls.Add(this.characterNameLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.basicInfoTableLayout);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "CreateOrEditCharacter";
            this.Text = "CreateOrEditCharacter";
            this.Load += new System.EventHandler(this.CreateOrEditCharacter_Load);
            this.basicInfoTableLayout.ResumeLayout(false);
            this.basicInfoTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox raceCcomboBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox backgroundComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox alignmentComboBox;
        private System.Windows.Forms.TableLayoutPanel basicInfoTableLayout;
        private System.Windows.Forms.NumericUpDown levelBox;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label alignmentLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label flawsLabel;
        private System.Windows.Forms.Label bondsLabel;
        private System.Windows.Forms.Label personalityTraitsLabel;
        private System.Windows.Forms.TextBox bondsTextBox;
        private System.Windows.Forms.TextBox flawsTextBox;
        private System.Windows.Forms.TextBox ideaslTextBox;
        private System.Windows.Forms.TextBox personalityTraitsTextBox;
        private System.Windows.Forms.Label idealsLabel;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.TableLayoutPanel statsTableLayoutPanel;
        private System.Windows.Forms.Button rerollButton;
        private System.Windows.Forms.TableLayoutPanel skillsTableLayoutPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
    }
}