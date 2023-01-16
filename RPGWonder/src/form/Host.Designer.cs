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
            this.controlsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DiceRollMenu = new System.Windows.Forms.Button();
            this.coords = new System.Windows.Forms.Label();
            this.ChangeMap = new System.Windows.Forms.Button();
            this.RemoveEntity = new System.Windows.Forms.Button();
            this.spawn_chest = new System.Windows.Forms.Button();
            this.spawn_npc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.charactersTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.charlabel = new System.Windows.Forms.Label();
            this.mapTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.controlsLayoutPanel.SuspendLayout();
            this.charactersTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsLayoutPanel
            // 
            this.controlsLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.controlsLayoutPanel.ColumnCount = 3;
            this.controlsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlsLayoutPanel.Controls.Add(this.DiceRollMenu, 0, 4);
            this.controlsLayoutPanel.Controls.Add(this.coords, 0, 0);
            this.controlsLayoutPanel.Controls.Add(this.ChangeMap, 2, 8);
            this.controlsLayoutPanel.Controls.Add(this.RemoveEntity, 0, 8);
            this.controlsLayoutPanel.Controls.Add(this.spawn_chest, 1, 7);
            this.controlsLayoutPanel.Controls.Add(this.spawn_npc, 0, 7);
            this.controlsLayoutPanel.Controls.Add(this.button1, 2, 7);
            this.controlsLayoutPanel.Controls.Add(this.charactersTabs, 0, 1);
            this.controlsLayoutPanel.Controls.Add(this.charlabel, 1, 0);
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
            this.controlsLayoutPanel.Size = new System.Drawing.Size(390, 1020);
            this.controlsLayoutPanel.TabIndex = 10;
            // 
            // DiceRollMenu
            // 
            this.DiceRollMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiceRollMenu.Location = new System.Drawing.Point(3, 407);
            this.DiceRollMenu.Margin = new System.Windows.Forms.Padding(2);
            this.DiceRollMenu.Name = "DiceRollMenu";
            this.DiceRollMenu.Size = new System.Drawing.Size(124, 96);
            this.DiceRollMenu.TabIndex = 9;
            this.DiceRollMenu.Text = "Dice Menu";
            this.DiceRollMenu.UseVisualStyleBackColor = true;
            this.DiceRollMenu.Click += new System.EventHandler(this.DiceRollMenu_Click);
            // 
            // coords
            // 
            this.coords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coords.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coords.Location = new System.Drawing.Point(3, 1);
            this.coords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coords.Name = "coords";
            this.coords.Size = new System.Drawing.Size(124, 100);
            this.coords.TabIndex = 8;
            this.coords.Text = "coords";
            // 
            // ChangeMap
            // 
            this.ChangeMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeMap.Location = new System.Drawing.Point(262, 812);
            this.ChangeMap.Name = "ChangeMap";
            this.ChangeMap.Size = new System.Drawing.Size(124, 94);
            this.ChangeMap.TabIndex = 10;
            this.ChangeMap.Text = "Change Map";
            this.ChangeMap.UseVisualStyleBackColor = true;
            this.ChangeMap.Click += new System.EventHandler(this.ChangeMap_Click);
            // 
            // RemoveEntity
            // 
            this.RemoveEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveEntity.Location = new System.Drawing.Point(4, 812);
            this.RemoveEntity.Name = "RemoveEntity";
            this.RemoveEntity.Size = new System.Drawing.Size(122, 94);
            this.RemoveEntity.TabIndex = 3;
            this.RemoveEntity.Text = "Remove Entity";
            this.RemoveEntity.UseVisualStyleBackColor = true;
            this.RemoveEntity.Click += new System.EventHandler(this.RemoveEntity_Click);
            // 
            // spawn_chest
            // 
            this.spawn_chest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_chest.Location = new System.Drawing.Point(133, 711);
            this.spawn_chest.Name = "spawn_chest";
            this.spawn_chest.Size = new System.Drawing.Size(122, 94);
            this.spawn_chest.TabIndex = 0;
            this.spawn_chest.Text = "Spawn Chest";
            this.spawn_chest.UseVisualStyleBackColor = true;
            this.spawn_chest.Click += new System.EventHandler(this.SpawnChest);
            // 
            // spawn_npc
            // 
            this.spawn_npc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_npc.Location = new System.Drawing.Point(4, 711);
            this.spawn_npc.Name = "spawn_npc";
            this.spawn_npc.Size = new System.Drawing.Size(122, 94);
            this.spawn_npc.TabIndex = 2;
            this.spawn_npc.Text = "Spawn NPC";
            this.spawn_npc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(262, 711);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 94);
            this.button1.TabIndex = 11;
            this.button1.Text = "Spawn Wall";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // charactersTabs
            // 
            this.charactersTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsLayoutPanel.SetColumnSpan(this.charactersTabs, 3);
            this.charactersTabs.Controls.Add(this.tabPage1);
            this.charactersTabs.Controls.Add(this.tabPage2);
            this.charactersTabs.Location = new System.Drawing.Point(4, 105);
            this.charactersTabs.Name = "charactersTabs";
            this.controlsLayoutPanel.SetRowSpan(this.charactersTabs, 3);
            this.charactersTabs.SelectedIndex = 0;
            this.charactersTabs.Size = new System.Drawing.Size(382, 296);
            this.charactersTabs.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(374, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(374, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // charlabel
            // 
            this.charlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charlabel.Location = new System.Drawing.Point(133, 1);
            this.charlabel.Name = "charlabel";
            this.charlabel.Size = new System.Drawing.Size(122, 100);
            this.charlabel.TabIndex = 13;
            this.charlabel.Text = "charlabel";
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
            this.charactersTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlsLayoutPanel;
        private System.Windows.Forms.Button spawn_chest;
        private System.Windows.Forms.Button spawn_npc;
        private System.Windows.Forms.TableLayoutPanel mapTableLayout;
        private System.Windows.Forms.Label coords;
        private System.Windows.Forms.Button DiceRollMenu;
        private System.Windows.Forms.Button RemoveEntity;
        private System.Windows.Forms.Button ChangeMap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl charactersTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label charlabel;
    }
}