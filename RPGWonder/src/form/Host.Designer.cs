namespace RPGWonder
{
    partial class Host
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
            this.charlabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.spawn_chest = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.spawn_npc = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.mapTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.coords = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // charlabel
            // 
            this.charlabel.Location = new System.Drawing.Point(0, 0);
            this.charlabel.Name = "charlabel";
            this.charlabel.Size = new System.Drawing.Size(100, 23);
            this.charlabel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.spawn_chest, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.spawn_npc, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button12, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(705, 275);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 250);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // spawn_chest
            // 
            this.spawn_chest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spawn_chest.Location = new System.Drawing.Point(4, 4);
            this.spawn_chest.Name = "spawn_chest";
            this.spawn_chest.Size = new System.Drawing.Size(112, 117);
            this.spawn_chest.TabIndex = 0;
            this.spawn_chest.Text = "Spawn Chest";
            this.spawn_chest.UseVisualStyleBackColor = true;
            this.spawn_chest.Click += new System.EventHandler(this.SpawnChest);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(4, 128);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(112, 118);
            this.button10.TabIndex = 1;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // spawn_npc
            // 
            this.spawn_npc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spawn_npc.Location = new System.Drawing.Point(123, 4);
            this.spawn_npc.Name = "spawn_npc";
            this.spawn_npc.Size = new System.Drawing.Size(113, 117);
            this.spawn_npc.TabIndex = 2;
            this.spawn_npc.Text = "Spawn NPC";
            this.spawn_npc.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(123, 128);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(113, 118);
            this.button12.TabIndex = 3;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // mapTableLayout
            // 
            this.mapTableLayout.BackgroundImage = global::RPGWonder.Properties.Resources.map_placeholder;
            this.mapTableLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapTableLayout.ColumnCount = 2;
            this.mapTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.Location = new System.Drawing.Point(15, 15);
            this.mapTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mapTableLayout.Name = "mapTableLayout";
            this.mapTableLayout.RowCount = 2;
            this.mapTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.Size = new System.Drawing.Size(680, 510);
            this.mapTableLayout.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.coords, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(705, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 250);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // coords
            // 
            this.coords.AutoSize = true;
            this.coords.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coords.Location = new System.Drawing.Point(3, 1);
            this.coords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coords.Name = "coords";
            this.coords.Size = new System.Drawing.Size(39, 13);
            this.coords.TabIndex = 8;
            this.coords.Text = "coords";
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mapTableLayout);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Host";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Host_FormClosed);
            this.Load += new System.EventHandler(this.Host_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label charlabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button spawn_chest;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button spawn_npc;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TableLayoutPanel mapTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label coords;
    }
}