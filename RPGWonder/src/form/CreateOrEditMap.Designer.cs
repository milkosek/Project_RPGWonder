namespace RPGWonder
{
    partial class CreateOrEditMap
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.columnsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.columnsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.nameLabel.Location = new System.Drawing.Point(42, 10);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 26);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.nameTextBox.Location = new System.Drawing.Point(117, 7);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(341, 32);
            this.nameTextBox.TabIndex = 7;
            // 
            // rowsLabel
            // 
            this.rowsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rowsLabel.Location = new System.Drawing.Point(46, 57);
            this.rowsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(67, 26);
            this.rowsLabel.TabIndex = 8;
            this.rowsLabel.Text = "Rows";
            // 
            // columnsLabel
            // 
            this.columnsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.columnsLabel.Location = new System.Drawing.Point(14, 105);
            this.columnsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(99, 26);
            this.columnsLabel.TabIndex = 9;
            this.columnsLabel.Text = "Columns";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.10373F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.89626F));
            this.tableLayoutPanel1.Controls.Add(this.columnsNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.columnsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rowsLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rowsNumericUpDown, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 142);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // columnsNumericUpDown
            // 
            this.columnsNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.columnsNumericUpDown.Location = new System.Drawing.Point(118, 102);
            this.columnsNumericUpDown.Name = "columnsNumericUpDown";
            this.columnsNumericUpDown.Size = new System.Drawing.Size(339, 32);
            this.columnsNumericUpDown.TabIndex = 11;
            // 
            // rowsNumericUpDown
            // 
            this.rowsNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rowsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rowsNumericUpDown.Location = new System.Drawing.Point(118, 54);
            this.rowsNumericUpDown.Name = "rowsNumericUpDown";
            this.rowsNumericUpDown.Size = new System.Drawing.Size(339, 32);
            this.rowsNumericUpDown.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(5, 154);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(460, 36);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CreateOrEditMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 196);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateOrEditMap";
            this.Text = "CreateOrEditMap";
            this.Load += new System.EventHandler(this.CreateOrEditMap_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.Label columnsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown columnsNumericUpDown;
        private System.Windows.Forms.NumericUpDown rowsNumericUpDown;
        private System.Windows.Forms.Button saveButton;
    }
}