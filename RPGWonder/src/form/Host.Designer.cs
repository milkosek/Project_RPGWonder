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
            this.controlsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.spawn_chest = new System.Windows.Forms.Button();
            this.DiceRollMenu = new System.Windows.Forms.Button();
            this.spawn_npc = new System.Windows.Forms.Button();
            this.RemoveEntity = new System.Windows.Forms.Button();
            this.coords = new System.Windows.Forms.Label();
            this.ChangeMap = new System.Windows.Forms.Button();
            this.mapTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.controlsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // charlabel
            // 
            this.charlabel.Location = new System.Drawing.Point(0, 0);
            this.charlabel.Name = "charlabel";
            this.charlabel.Size = new System.Drawing.Size(100, 23);
            this.charlabel.TabIndex = 0;
            // 
            // controlsLayoutPanel
            // 
            this.controlsLayoutPanel.AutoSize = true;
            this.controlsLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.controlsLayoutPanel.ColumnCount = 3;
            this.controlsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlsLayoutPanel.Controls.Add(this.spawn_chest, 0, 7);
            this.controlsLayoutPanel.Controls.Add(this.DiceRollMenu, 0, 4);
            this.controlsLayoutPanel.Controls.Add(this.spawn_npc, 1, 7);
            this.controlsLayoutPanel.Controls.Add(this.RemoveEntity, 2, 7);
            this.controlsLayoutPanel.Controls.Add(this.coords, 0, 0);
            this.controlsLayoutPanel.Controls.Add(this.ChangeMap, 2, 8);
            this.controlsLayoutPanel.Location = new System.Drawing.Point(1500, 30);
            this.controlsLayoutPanel.Name = "controlsLayoutPanel";
            this.controlsLayoutPanel.RowCount = 10;
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsLayoutPanel.Size = new System.Drawing.Size(400, 1020);
            this.controlsLayoutPanel.TabIndex = 10;
            // 
            // spawn_chest
            // 
            this.spawn_chest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_chest.Location = new System.Drawing.Point(4, 711);
            this.spawn_chest.Name = "spawn_chest";
            this.spawn_chest.Size = new System.Drawing.Size(126, 94);
            this.spawn_chest.TabIndex = 0;
            this.spawn_chest.Text = "Spawn Chest";
            this.spawn_chest.UseVisualStyleBackColor = true;
            this.spawn_chest.Click += new System.EventHandler(this.SpawnChest);
            // 
            // DiceRollMenu
            // 
            this.DiceRollMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiceRollMenu.Location = new System.Drawing.Point(3, 407);
            this.DiceRollMenu.Margin = new System.Windows.Forms.Padding(2);
            this.DiceRollMenu.Name = "DiceRollMenu";
            this.DiceRollMenu.Size = new System.Drawing.Size(128, 96);
            this.DiceRollMenu.TabIndex = 9;
            this.DiceRollMenu.Text = "DiceMenu";
            this.DiceRollMenu.UseVisualStyleBackColor = true;
            this.DiceRollMenu.Click += new System.EventHandler(this.DiceRollMenu_Click);
            // 
            // spawn_npc
            // 
            this.spawn_npc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_npc.Location = new System.Drawing.Point(137, 711);
            this.spawn_npc.Name = "spawn_npc";
            this.spawn_npc.Size = new System.Drawing.Size(126, 94);
            this.spawn_npc.TabIndex = 2;
            this.spawn_npc.Text = "Spawn NPC";
            this.spawn_npc.UseVisualStyleBackColor = true;
            // 
            // RemoveEntity
            // 
            this.RemoveEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveEntity.Location = new System.Drawing.Point(270, 711);
            this.RemoveEntity.Name = "RemoveEntity";
            this.RemoveEntity.Size = new System.Drawing.Size(126, 94);
            this.RemoveEntity.TabIndex = 3;
            this.RemoveEntity.Text = "Remove Entity";
            this.RemoveEntity.UseVisualStyleBackColor = true;
            this.RemoveEntity.Click += new System.EventHandler(this.RemoveEntity_Click);
            // 
            // coords
            // 
            this.coords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coords.AutoSize = true;
            this.coords.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coords.Location = new System.Drawing.Point(3, 1);
            this.coords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coords.Name = "coords";
            this.coords.Size = new System.Drawing.Size(128, 100);
            this.coords.TabIndex = 8;
            this.coords.Text = "coords";
            // 
            // ChangeMap
            // 
            this.ChangeMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeMap.Location = new System.Drawing.Point(270, 812);
            this.ChangeMap.Name = "ChangeMap";
            this.ChangeMap.Size = new System.Drawing.Size(126, 94);
            this.ChangeMap.TabIndex = 10;
            this.ChangeMap.Text = "Change Map";
            this.ChangeMap.UseVisualStyleBackColor = true;
            this.ChangeMap.Click += new System.EventHandler(this.ChangeMap_Click);
            // 
            // mapTableLayout
            // 
            this.mapTableLayout.BackgroundImage = global::RPGWonder.Properties.Resources.map_placeholder;
            this.mapTableLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapTableLayout.ColumnCount = 2;
            this.mapTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.Location = new System.Drawing.Point(30, 30);
            this.mapTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mapTableLayout.Name = "mapTableLayout";
            this.mapTableLayout.RowCount = 2;
            this.mapTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.Size = new System.Drawing.Size(1440, 1020);
            this.mapTableLayout.TabIndex = 11;
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.controlsLayoutPanel);
            this.Controls.Add(this.mapTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Host";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Host_FormClosed);
            this.Load += new System.EventHandler(this.Host_Load);
            this.controlsLayoutPanel.ResumeLayout(false);
            this.controlsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charlabel;
        private System.Windows.Forms.TableLayoutPanel controlsLayoutPanel;
        private System.Windows.Forms.Button spawn_chest;
        private System.Windows.Forms.Button spawn_npc;
        private System.Windows.Forms.TableLayoutPanel mapTableLayout;
        private System.Windows.Forms.Label coords;
        private System.Windows.Forms.Button DiceRollMenu;
        private System.Windows.Forms.Button RemoveEntity;
        private System.Windows.Forms.Button ChangeMap;
    }
}