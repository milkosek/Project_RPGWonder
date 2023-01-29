using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System;
using RPGWonder.src.map;
using RPGWonder.src.form;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Drawing;
using RPGWonder.src.net;
using static RPGWonder.Client;

namespace RPGWonder
{
    /// <summary>
    /// Class representing a from with game window as seen by the Host
    /// </summary>
    public partial class Host : DefaultForm
    {
        private HostTcpConnection _connection;
        public static Host Instance;
        private IPAddress _ipAddress;

        private string _campaignFilePath = "";
        private string _campaignFolderPath = "";
        private Campaign _campaign;
        private MapHandler mapLoader;
        private Map map;

        private (int x, int y) selectedTile;
        private EntityOnMap selectedEntity;
        List<List<Button>> ButtonsMatrix;
        Dictionary<string, EntityOnMap> EntityList;

        public delegate void ReloadHost();
        public ReloadHost reloadDelegate;

        private int _currentPLayer = 0;

        private List<Character> _characters;
        private int _listViewSelectedChar;

        /// <summary>
        /// Public contructor of <see cref="Host"/> class.
        /// </summary>
        /// <param name="campaign">The capaign that is hosted.</param>
        public Host(string campaign, string ip)
        {
            InitializeComponent();
            Instance = this;

            _campaignFilePath = campaign;
            _campaignFolderPath = Path.GetDirectoryName(campaign);
            _campaign = new Campaign();
            _campaign.ReadFromJSON(_campaignFilePath);
            
            //ip = "127.0.0.1"; Rollback for testing
            _ipAddress = IPAddress.Parse(ip);

            mapLoader = new MapHandler(this);
            map = new Map() { };

            _characters = new List<Character> { };

            reloadDelegate = new ReloadHost(ReloadEntities);
        }

        private void Host_Load(object sender, EventArgs e)
        {
            SetMotif();
            dice_roll_button.BackColor = Color.SteelBlue;
            exitButton.BackColor = Color.IndianRed;
            spawn_chest_button.BackColor = Color.SeaGreen;
            spawn_npc_button.BackColor = Color.SeaGreen;
            spawn_player_button.BackColor = Color.SeaGreen;
            spawn_wall_button.BackColor = Color.SeaGreen;
            remove_entity_button.BackColor = Color.IndianRed;
            change_map_button.BackColor = Color.SteelBlue;
            changeAsset.BackColor = Color.SteelBlue;
            next_player_button.BackColor = Color.SteelBlue;

            _connection = new HostTcpConnection();
            _connection.CreateSession(_campaignFilePath, _ipAddress);
            CheckForIllegalCrossThreadCalls = false;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            EntityList = new Dictionary<string, EntityOnMap> { };

            LoadMap(_campaign.CurrentMap);

            coords.Text = map.Name;

            currentPlayerLabel.Text = "Current player: You";

            UpdateMap();

            Log.Instance.gameLog.Debug("Attempting to establish connection...");
            try
            {
                _connection = new HostTcpConnection();
                _connection.CreateSession(_campaignFilePath, _ipAddress);
                Log.Instance.gameLog.Debug("Estabilish connection success.");
            }
            catch (Exception exception){
                Log.Instance.errorLog.Error("Establishing connection failed with error: " + exception.Message);
            }

            //ODKOMENTOWAĆ BY UTWORZYĆ KANAŁ I DO NIEGO SIĘ PRZENIEŚĆ
            //Thread discordThread = new Thread(new ThreadStart(
            //    () => DiscordChannelConnection.
            //    CreateGuildThenChannelThenInviteAndOpen()));
            //discordThread.Start();
        }
        /// <summary>
        /// Method for reloading the game state.
        /// </summary>
        public void Reload()
        {
            Debug.WriteLine("RELOADING HOST!");
        }

        public void NewPLayerConnected()
        {
            Debug.WriteLine("INFORMING NEW CLIENT!");

            charlabel.Text = "Characters:\n";

            _characters.Clear();

            foreach (ClientData client in _connection.Clients)
            {
                Character character = client.Character;
                charlabel.Text = charlabel.Text + character.Name + " Lvl." + character.Level + "\n";

                _characters.Add(character);

                HostBroadcastCharacter();
            }

            PopulateCharactersList();

            HostTcpConnection.BroadcastCampaign(Path.GetFileName(_campaignFilePath), File.ReadAllText(_campaignFilePath));

            HostBroadcastMap(true);
        }

        private void HostBroadcastMap(bool changeMap = false)
        {
            if (changeMap)
            {
                HostTcpConnection.BroadcastMap(Path.GetFileName(GetMapById(_campaign.CurrentMap)), File.ReadAllText(GetMapById(_campaign.CurrentMap)));
            }
            else
            {
                HostTcpConnection.BroadcastMapUpdate(Path.GetFileName(GetMapById(_campaign.CurrentMap)), File.ReadAllText(GetMapById(_campaign.CurrentMap)));
            }
        }

        private void HostBroadcastCharacter()
        {
            //TODO broadcast chars 
            //HostTcpConnection.BroadcastCharacter(Path.GetFileName(), File.ReadAllText());
        }
        public void ReloadEntities()
        {
            EntityList.Clear();

            map.ReadFromJSON(GetMapById(_campaign.CurrentMap));

            if (map.EntityList != null)
            {
                EntityList = map.EntityList;
            }

            UpdateMap();
        }

        public void LoadMap(int mapId)
        {
            _campaign.CurrentMap = mapId;

            selectedTile.x = 0;
            selectedTile.y = 0;

            EntityList.Clear();

            map.ReadFromJSON(GetMapById(_campaign.CurrentMap));

            if (map.EntityList != null)
            {
                EntityList = map.EntityList;
            }

            DisplayMap(map);

            UpdateAndBroadcastMap(true);
        }

        private void DisplayMap(Map map)
        {
            while (mapTableLayout.Controls.Count > 0)
            {
                mapTableLayout.Controls[0].Dispose();
            }

            ButtonsMatrix = mapLoader.makeSquareTiles(mapTableLayout, map.Columns, map.Rows);

            // TODO wait for asset implementation
            //mapTableLayout.BackgroundImage = map.BGImage;
        }

        private void PopulateCharactersList()
        {
            charactersListView.Items.Clear();

            foreach (ClientData client in _connection.Clients)
            {
                Character character = client.Character;
                ListViewItem item = new ListViewItem(character.Name);

                item.SubItems.Add(character.Level.ToString());
                item.SubItems.Add(character.CurrentHitPoints.ToString());
                item.SubItems.Add(character.Initiative.ToString());

                charactersListView.Items.Add(item); 
            }
        }

        // 0 - LMB select
        // 1 - RMB move
        public void MapTileAction(string myText, int actionType)
        {
            int pressedButtonX = Int32.Parse(myText.Split(' ')[0]);
            int pressedButtonY = Int32.Parse(myText.Split(' ')[1]);

            switch (actionType)
            {
                case 0:
                    selectedTile.x = pressedButtonX;
                    selectedTile.y = pressedButtonY;

                    UpdateMap();

                    break;

                case 1:
                    if (_currentPLayer == 0)
                    {
                        MoveOnMap(selectedTile.x, selectedTile.y, pressedButtonX, pressedButtonY);

                        UpdateAndBroadcastMap();
                    }
                    break;
            }

            //UpdateMap();
        }

        // x1, y1 - from
        // x2, y2 - to
        private void MoveOnMap(int x1, int y1, int x2, int y2)
        {
            Button fromButton = ButtonsMatrix[y1][x1];
            Button toButton = ButtonsMatrix[y2][x2];

            // if a move is valid - not from empty tile and not to the same tile 
            if (fromButton.Text != string.Format("{0} {1}", x1, y1) &&
                toButton.Text == string.Format("{0} {1}", x2, y2) &&
                fromButton != toButton)
            {
                selectedEntity.X = x2;
                selectedEntity.Y = y2;

                selectedTile.x = x2;
                selectedTile.y = y2;
            }
        }

        private void DisplaySelectedInfo()
        {
            string tmpString = "";

            if (EntityList.ContainsKey(ButtonsMatrix[selectedTile.y][selectedTile.x].Text))
            {
                selectedEntity = EntityList[ButtonsMatrix[selectedTile.y][selectedTile.x].Text];

                tmpString += "Name: " + selectedEntity.Name + "\n";
            }

            tmpString += "x: " + selectedTile.x + "\n";
            tmpString += "y: " + selectedTile.y;
            coords.Text = tmpString;
        }

        private void UpdateMap()
        {
            if (map.Columns > 0 && map.Rows > 0)
            {
                for (int yC = 0; yC < map.Rows; yC++)
                {
                    for (int xC = 0; xC < map.Columns; xC++)
                    {
                        ButtonsMatrix[yC][xC].Text = string.Format("{0} {1}", xC, yC);
                        ButtonsMatrix[yC][xC].BackgroundImage = null;

                        ButtonsMatrix[yC][xC].FlatAppearance.BorderSize = 1;
                        ButtonsMatrix[yC][xC].FlatAppearance.BorderColor = System.Drawing.Color.White;
                    }
                }

                foreach (KeyValuePair<string, EntityOnMap> nameEntity in EntityList)
                {
                    string name = nameEntity.Key;
                    EntityOnMap EOM = nameEntity.Value;

                    ButtonsMatrix[EOM.Y][EOM.X].Text = EOM.Name;
                    ButtonsMatrix[EOM.Y][EOM.X].BackgroundImage = new Bitmap(_campaignFolderPath + EOM.ImagePath);
                }

                ButtonsMatrix[selectedTile.y][selectedTile.x].FlatAppearance.BorderSize = 5;
                ButtonsMatrix[selectedTile.y][selectedTile.x].FlatAppearance.BorderColor = System.Drawing.Color.Yellow;

                DisplaySelectedInfo();

                map.EntityList = EntityList;
                map.SaveToJSON(GetMapById(_campaign.CurrentMap));
            }
        }

        public void UpdateAndBroadcastMap(bool changeMap = false)
        {
            if (changeMap)
            {
                UpdateMap();

                HostBroadcastMap(changeMap);
            }
            else
            {
                UpdateMap();

                HostBroadcastMap();
            }
        }

        public string GetMapById(int id)
        {
            string path = Common.Instance.CampaignsPath + "\\" + _campaign.Name + "\\maps";

            string[] filePaths = Directory.GetFiles(path, "*.json");
            foreach (string filePath in filePaths)
            {
                JObject map = JObject.Parse(File.ReadAllText(filePath));

                if ((int)map["Id"] == id)
                {
                    return filePath;
                }
            }
           
            return filePaths[0];
        }

        private bool TileEmpty(int x, int y)
        {
            if (ButtonsMatrix[y][x].Text == string.Format("{0} {1}", x, y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AddEntityOnMap(int x, int y, string name, string path, bool character = false) 
        {
            if (!TileEmpty(x, y))
            {
                return;
            }

            string tempName;

            if (character)
            {
                tempName = name;
            }
            else
            {
                int iter = 0;
                tempName = name + iter.ToString();

                while (EntityList.ContainsKey(tempName))
                {
                    tempName = name + iter.ToString();
                    iter += 1;
                }
            }

            EntityOnMap tempEntity = new EntityOnMap(0, 0, x, y, path);

            tempEntity.Name = tempName;

            EntityList[tempEntity.Name] = tempEntity;
        }

        public void nextPLayer()
        {
            if (_connection.Clients.Count > 0)
            {
                _currentPLayer++;

                if (_currentPLayer >= 1 + _connection.Clients.Count)
                {
                    _currentPLayer = 0;
                    currentPlayerLabel.Text = "Current player: You";
                }
                else
                {
                    //TODO get char name
                    currentPlayerLabel.Text = "Current player: " + (_connection.Clients[_currentPLayer - 1].Character.Name);

                    HostTcpConnection.YourTurn(_currentPLayer - 1);
                }
            }
        }

        private void next_player_button_Click(object sender, EventArgs e)
        {
            nextPLayer();
        }

        private void change_map_button_Click(object sender, EventArgs e)
        {
            Selector.Instance.Show();
            Selector.Instance.WindowState = FormWindowState.Normal;

            Selector.Instance.Selector_Init(this, _campaign.Name);
        }

        private void remove_entity_button_Click(object sender, EventArgs e)
        {
            if (_currentPLayer == 0)
            {
                EntityList.Remove(ButtonsMatrix[selectedTile.y][selectedTile.x].Text);

                UpdateAndBroadcastMap();
            }
        }

        private void spawn_chest_button_Click(object sender, EventArgs e)
        {
            if (_currentPLayer == 0)
            {
                if (TileEmpty(selectedTile.x, selectedTile.y))
                {
                    AddEntityOnMap(selectedTile.x, selectedTile.y, "Chest", "\\entityAssets\\chest.png");

                    UpdateAndBroadcastMap();
                }
            }
        }


        private void spawn_wall_button_Click(object sender, EventArgs e)
        {
            if (_currentPLayer == 0)
            {
                if (TileEmpty(selectedTile.x, selectedTile.y))
                {
                    AddEntityOnMap(selectedTile.x, selectedTile.y, "Wall", "\\entityAssets\\wall.png");

                    UpdateAndBroadcastMap();
                }
            }
        }

        private void dice_roll_button_Click(object sender, EventArgs e)
        {
            DiceDisplay.Instance.Show();
            DiceDisplay.Instance.WindowState = FormWindowState.Normal;
        }

        private void character_selected(object sender, EventArgs e)
        {
            ShowCharacter showChar = new ShowCharacter(_connection.Clients[_listViewSelectedChar].Character);
            showChar.Show();
        }

        private void selected_char_changed(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _listViewSelectedChar = e.ItemIndex;
        }

        private void spawn_player_button_Click(object sender, EventArgs e)
        {
            if (TileEmpty(selectedTile.x, selectedTile.y))
            {
                foreach(Character chara in _characters)
                {
                    if (!EntityList.ContainsKey(chara.Name))
                    {
                        AddEntityOnMap(selectedTile.x, selectedTile.y, chara.Name, "\\entityAssets\\knight.png", true);

                        break;
                    }
                }

                UpdateAndBroadcastMap();
            }
        }
        private void changeAsset_Click(object sender, EventArgs e)
        {
            string assetPath = string.Empty;
            string targetPath = _campaignFolderPath + "\\assets";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.GetFullPath(targetPath);
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                targetPath = Path.GetFullPath(targetPath).ToLower();

                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    assetPath = openFileDialog.FileName.ToLower();

                    try
                    {
                        if (assetPath.Contains(targetPath))
                        {
                            Image asset = Image.FromFile(assetPath);
                            mapTableLayout.BackgroundImage = asset;
                            Log.Instance.gameLog.Debug("Asset changed successfully.");
                            HostTcpConnection.BroadcastAsset(assetPath);
                        }
                        else
                        {
                            Log.Instance.errorLog.Error("You chose an asset outside of campaign");
                        }
                    }
                    catch (IOException exception)
                    {
                        Log.Instance.errorLog.Error("An error occurred: " + exception.Message);
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void codexButton_Click(object sender, EventArgs e)
        {
            ShowCodex.Instance(_campaign).Show();
        }
    }
}
