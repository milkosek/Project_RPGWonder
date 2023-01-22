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
            this.RemoveEntity = new System.Windows.Forms.Button();
            this.spawn_chest = new System.Windows.Forms.Button();
            this.spawn_npc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.charlabel = new System.Windows.Forms.Label();
            this.ChangeMap = new System.Windows.Forms.Button();
            this.nextPlayerButton = new System.Windows.Forms.Button();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.mapTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.controlsLayoutPanel.SuspendLayout();
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
            this.controlsLayoutPanel.Controls.Add(this.RemoveEntity, 0, 8);
            this.controlsLayoutPanel.Controls.Add(this.spawn_chest, 1, 7);
            this.controlsLayoutPanel.Controls.Add(this.spawn_npc, 0, 7);
            this.controlsLayoutPanel.Controls.Add(this.button1, 2, 7);
            this.controlsLayoutPanel.Controls.Add(this.charlabel, 1, 0);
            this.controlsLayoutPanel.Controls.Add(this.ChangeMap, 2, 8);
            this.controlsLayoutPanel.Controls.Add(this.nextPlayerButton, 0, 9);
            this.controlsLayoutPanel.Controls.Add(this.currentPlayerLabel, 2, 0);
            this.controlsLayoutPanel.Controls.Add(this.listView1, 0, 1);
            this.controlsLayoutPanel.Location = new System.Drawing.Point(1500, 30);
            this.controlsLayoutPanel.Location = new System.Drawing.Point(2000, 37);
            this.controlsLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.controlsLayoutPanel.Size = new System.Drawing.Size(520, 1255);
            this.controlsLayoutPanel.TabIndex = 10;
            // 
            // DiceRollMenu
            // 
            this.DiceRollMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiceRollMenu.Location = new System.Drawing.Point(4, 503);
            this.DiceRollMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DiceRollMenu.Name = "DiceRollMenu";
            this.DiceRollMenu.Size = new System.Drawing.Size(166, 120);
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
            this.coords.Location = new System.Drawing.Point(4, 1);
            this.coords.Name = "coords";
            this.coords.Size = new System.Drawing.Size(166, 124);
            this.coords.TabIndex = 8;
            this.coords.Text = "coords";
            this.coords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveEntity
            // 
            this.RemoveEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveEntity.Location = new System.Drawing.Point(5, 1005);
            this.RemoveEntity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveEntity.Name = "RemoveEntity";
            this.RemoveEntity.Size = new System.Drawing.Size(164, 116);
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
            this.spawn_chest.Location = new System.Drawing.Point(178, 880);
            this.spawn_chest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spawn_chest.Name = "spawn_chest";
            this.spawn_chest.Size = new System.Drawing.Size(164, 116);
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
            this.spawn_npc.Location = new System.Drawing.Point(5, 880);
            this.spawn_npc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spawn_npc.Name = "spawn_npc";
            this.spawn_npc.Size = new System.Drawing.Size(164, 116);
            this.spawn_npc.TabIndex = 2;
            this.spawn_npc.Text = "Spawn NPC";
            this.spawn_npc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(351, 880);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 116);
            this.button1.TabIndex = 11;
            this.button1.Text = "Spawn Wall";
            this.button1.UseVisualStyleBackColor = true;
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
            this.charlabel.Text = "Characters";
            this.charlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // nextPlayerButton
            // 
            this.nextPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextPlayerButton.Location = new System.Drawing.Point(4, 913);
            this.nextPlayerButton.Name = "nextPlayerButton";
            this.nextPlayerButton.Size = new System.Drawing.Size(122, 103);
            this.nextPlayerButton.TabIndex = 14;
            this.nextPlayerButton.Text = "Next Player";
            this.nextPlayerButton.UseVisualStyleBackColor = true;
            this.nextPlayerButton.Click += new System.EventHandler(this.nextPlayerButton_Click);
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPlayerLabel.Location = new System.Drawing.Point(262, 1);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(124, 100);
            this.currentPlayerLabel.TabIndex = 15;
            this.currentPlayerLabel.Text = "Current player:";
            this.currentPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapTableLayout
            // 
            this.mapTableLayout.BackgroundImage = global::RPGWonder.Properties.Resources.map_placeholder;
            this.mapTableLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapTableLayout.ColumnCount = 2;
            this.mapTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.Location = new System.Drawing.Point(40, 37);
            this.mapTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mapTableLayout.Name = "mapTableLayout";
            this.mapTableLayout.RowCount = 2;
            this.mapTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapTableLayout.Size = new System.Drawing.Size(1920, 1255);
            this.mapTableLayout.TabIndex = 11;
            this.mapTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.mapTableLayout_Paint);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsLayoutPanel.SetColumnSpan(this.listView1, 3);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 105);
            this.listView1.Name = "listView1";
            this.controlsLayoutPanel.SetRowSpan(this.listView1, 3);
            this.listView1.Size = new System.Drawing.Size(382, 296);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.controlsLayoutPanel);
            this.Controls.Add(this.mapTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Host";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Host_Load);
            this.controlsLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label charlabel;
        private System.Windows.Forms.Button nextPlayerButton;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.ListView listView1;
    }
}