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
            this.exitButton = new System.Windows.Forms.Button();
            this.changeAsset = new System.Windows.Forms.Button();
            this.next_player_button = new System.Windows.Forms.Button();
            this.dice_roll_button = new System.Windows.Forms.Button();
            this.coords = new System.Windows.Forms.Label();
            this.spawn_npc_button = new System.Windows.Forms.Button();
            this.spawn_wall_button = new System.Windows.Forms.Button();
            this.charlabel = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.charactersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spawn_chest_button = new System.Windows.Forms.Button();
            this.change_map_button = new System.Windows.Forms.Button();
            this.remove_entity_button = new System.Windows.Forms.Button();
            this.spawn_player_button = new System.Windows.Forms.Button();
            this.mapTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.codexButton = new System.Windows.Forms.Button();
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
            this.controlsLayoutPanel.Controls.Add(this.codexButton, 0, 6);
            this.controlsLayoutPanel.Controls.Add(this.exitButton, 2, 4);
            this.controlsLayoutPanel.Controls.Add(this.changeAsset, 1, 9);
            this.controlsLayoutPanel.Controls.Add(this.next_player_button, 0, 9);
            this.controlsLayoutPanel.Controls.Add(this.dice_roll_button, 0, 4);
            this.controlsLayoutPanel.Controls.Add(this.coords, 0, 0);
            this.controlsLayoutPanel.Controls.Add(this.spawn_npc_button, 0, 7);
            this.controlsLayoutPanel.Controls.Add(this.spawn_wall_button, 2, 7);
            this.controlsLayoutPanel.Controls.Add(this.charlabel, 1, 0);
            this.controlsLayoutPanel.Controls.Add(this.currentPlayerLabel, 2, 0);
            this.controlsLayoutPanel.Controls.Add(this.charactersListView, 0, 1);
            this.controlsLayoutPanel.Controls.Add(this.spawn_chest_button, 1, 7);
            this.controlsLayoutPanel.Controls.Add(this.change_map_button, 2, 9);
            this.controlsLayoutPanel.Controls.Add(this.remove_entity_button, 2, 8);
            this.controlsLayoutPanel.Controls.Add(this.spawn_player_button, 0, 8);
            this.controlsLayoutPanel.Location = new System.Drawing.Point(2000, 37);
            this.controlsLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(351, 505);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(164, 116);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeAsset
            // 
            this.changeAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeAsset.Location = new System.Drawing.Point(178, 1130);
            this.changeAsset.Margin = new System.Windows.Forms.Padding(4);
            this.changeAsset.Name = "changeAsset";
            this.changeAsset.Size = new System.Drawing.Size(164, 120);
            this.changeAsset.TabIndex = 12;
            this.changeAsset.Text = "Change Background";
            this.changeAsset.UseVisualStyleBackColor = true;
            this.changeAsset.Click += new System.EventHandler(this.changeAsset_Click);
            // 
            // next_player_button
            // 
            this.next_player_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next_player_button.Location = new System.Drawing.Point(5, 1130);
            this.next_player_button.Margin = new System.Windows.Forms.Padding(4);
            this.next_player_button.Name = "next_player_button";
            this.next_player_button.Size = new System.Drawing.Size(164, 120);
            this.next_player_button.TabIndex = 17;
            this.next_player_button.Text = "Next Player";
            this.next_player_button.UseVisualStyleBackColor = true;
            this.next_player_button.Click += new System.EventHandler(this.next_player_button_Click);
            // 
            // dice_roll_button
            // 
            this.dice_roll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dice_roll_button.Location = new System.Drawing.Point(5, 505);
            this.dice_roll_button.Margin = new System.Windows.Forms.Padding(4);
            this.dice_roll_button.Name = "dice_roll_button";
            this.dice_roll_button.Size = new System.Drawing.Size(164, 116);
            this.dice_roll_button.TabIndex = 9;
            this.dice_roll_button.Text = "Dice Menu";
            this.dice_roll_button.UseVisualStyleBackColor = true;
            this.dice_roll_button.Click += new System.EventHandler(this.dice_roll_button_Click);
            // 
            // coords
            // 
            this.coords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coords.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coords.Location = new System.Drawing.Point(5, 5);
            this.coords.Margin = new System.Windows.Forms.Padding(4);
            this.coords.Name = "coords";
            this.coords.Size = new System.Drawing.Size(164, 116);
            this.coords.TabIndex = 8;
            this.coords.Text = "coords";
            this.coords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spawn_npc_button
            // 
            this.spawn_npc_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_npc_button.Location = new System.Drawing.Point(4, 878);
            this.spawn_npc_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spawn_npc_button.Name = "spawn_npc_button";
            this.spawn_npc_button.Size = new System.Drawing.Size(166, 120);
            this.spawn_npc_button.TabIndex = 2;
            this.spawn_npc_button.Text = "Spawn NPC";
            this.spawn_npc_button.UseVisualStyleBackColor = true;
            // 
            // spawn_wall_button
            // 
            this.spawn_wall_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_wall_button.Location = new System.Drawing.Point(350, 878);
            this.spawn_wall_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spawn_wall_button.Name = "spawn_wall_button";
            this.spawn_wall_button.Size = new System.Drawing.Size(166, 120);
            this.spawn_wall_button.TabIndex = 11;
            this.spawn_wall_button.Text = "Spawn Wall";
            this.spawn_wall_button.UseVisualStyleBackColor = true;
            this.spawn_wall_button.Click += new System.EventHandler(this.spawn_wall_button_Click);
            // 
            // charlabel
            // 
            this.charlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charlabel.Location = new System.Drawing.Point(178, 5);
            this.charlabel.Margin = new System.Windows.Forms.Padding(4);
            this.charlabel.Name = "charlabel";
            this.charlabel.Size = new System.Drawing.Size(164, 116);
            this.charlabel.TabIndex = 13;
            this.charlabel.Text = "Characters";
            this.charlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPlayerLabel.Location = new System.Drawing.Point(351, 5);
            this.currentPlayerLabel.Margin = new System.Windows.Forms.Padding(4);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(164, 116);
            this.currentPlayerLabel.TabIndex = 15;
            this.currentPlayerLabel.Text = "Current player:";
            this.currentPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charactersListView
            // 
            this.charactersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charactersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.controlsLayoutPanel.SetColumnSpan(this.charactersListView, 3);
            this.charactersListView.FullRowSelect = true;
            this.charactersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.charactersListView.HideSelection = false;
            this.charactersListView.Location = new System.Drawing.Point(4, 128);
            this.charactersListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charactersListView.Name = "charactersListView";
            this.controlsLayoutPanel.SetRowSpan(this.charactersListView, 3);
            this.charactersListView.Size = new System.Drawing.Size(512, 370);
            this.charactersListView.TabIndex = 16;
            this.charactersListView.UseCompatibleStateImageBehavior = false;
            this.charactersListView.View = System.Windows.Forms.View.Details;
            this.charactersListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.selected_char_changed);
            this.charactersListView.DoubleClick += new System.EventHandler(this.character_selected);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lvl";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HP";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Init";
            this.columnHeader4.Width = 40;
            // 
            // spawn_chest_button
            // 
            this.spawn_chest_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_chest_button.Location = new System.Drawing.Point(178, 880);
            this.spawn_chest_button.Margin = new System.Windows.Forms.Padding(4);
            this.spawn_chest_button.Name = "spawn_chest_button";
            this.spawn_chest_button.Size = new System.Drawing.Size(164, 116);
            this.spawn_chest_button.TabIndex = 0;
            this.spawn_chest_button.Text = "Spawn Chest";
            this.spawn_chest_button.UseVisualStyleBackColor = true;
            this.spawn_chest_button.Click += new System.EventHandler(this.spawn_chest_button_Click);
            // 
            // change_map_button
            // 
            this.change_map_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_map_button.Location = new System.Drawing.Point(351, 1130);
            this.change_map_button.Margin = new System.Windows.Forms.Padding(4);
            this.change_map_button.Name = "change_map_button";
            this.change_map_button.Size = new System.Drawing.Size(164, 120);
            this.change_map_button.TabIndex = 10;
            this.change_map_button.Text = "Change Map";
            this.change_map_button.UseVisualStyleBackColor = true;
            this.change_map_button.Click += new System.EventHandler(this.change_map_button_Click);
            // 
            // remove_entity_button
            // 
            this.remove_entity_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_entity_button.Location = new System.Drawing.Point(351, 1005);
            this.remove_entity_button.Margin = new System.Windows.Forms.Padding(4);
            this.remove_entity_button.Name = "remove_entity_button";
            this.remove_entity_button.Size = new System.Drawing.Size(164, 116);
            this.remove_entity_button.TabIndex = 3;
            this.remove_entity_button.Text = "Remove Entity";
            this.remove_entity_button.UseVisualStyleBackColor = true;
            this.remove_entity_button.Click += new System.EventHandler(this.remove_entity_button_Click);
            // 
            // spawn_player_button
            // 
            this.spawn_player_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_player_button.Location = new System.Drawing.Point(5, 1005);
            this.spawn_player_button.Margin = new System.Windows.Forms.Padding(4);
            this.spawn_player_button.Name = "spawn_player_button";
            this.spawn_player_button.Size = new System.Drawing.Size(164, 116);
            this.spawn_player_button.TabIndex = 18;
            this.spawn_player_button.Text = "Spawn Next Player";
            this.spawn_player_button.UseVisualStyleBackColor = true;
            this.spawn_player_button.Click += new System.EventHandler(this.spawn_player_button_Click);
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
            // 
            // codexButton
            // 
            this.codexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codexButton.Location = new System.Drawing.Point(5, 755);
            this.codexButton.Margin = new System.Windows.Forms.Padding(4);
            this.codexButton.Name = "codexButton";
            this.codexButton.Size = new System.Drawing.Size(164, 116);
            this.codexButton.TabIndex = 12;
            this.codexButton.Text = "Codex";
            this.codexButton.UseVisualStyleBackColor = true;
            this.codexButton.Click += new System.EventHandler(this.codexButton_Click);
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2422, 1329);
            this.Controls.Add(this.controlsLayoutPanel);
            this.Controls.Add(this.mapTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Host";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Host_Load);
            this.controlsLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlsLayoutPanel;
        private System.Windows.Forms.Button spawn_chest_button;
        private System.Windows.Forms.Button spawn_npc_button;
        private System.Windows.Forms.TableLayoutPanel mapTableLayout;
        private System.Windows.Forms.Label coords;
        private System.Windows.Forms.Button dice_roll_button;
        private System.Windows.Forms.Button remove_entity_button;
        private System.Windows.Forms.Button change_map_button;
        private System.Windows.Forms.Button spawn_wall_button;
        private System.Windows.Forms.Label charlabel;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.ListView charactersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button next_player_button;
        private System.Windows.Forms.Button spawn_player_button;
        private System.Windows.Forms.Button changeAsset;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button codexButton;
    }
}