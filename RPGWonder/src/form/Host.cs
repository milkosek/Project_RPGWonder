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
    //TODO
    //GAMERS
    //  -linki do kart
    //THROW
    //  -per player, per stat
    //SPAWN GENERIC (wall, enemy, chest)

    /// <summary>
    /// Class representing a from with game window as seen by the Host
    /// </summary>
    public partial class Host : DefaultForm
    {
        private HostTcpConnection _connection;
        public static Host Instance;
        private IPAddress _ipAddress;

        private string _campaignPath = "";
        private Campaign _campaign;
        private MapHandler mapLoader;
        private Map map;

        private (int x, int y) selectedTile;
        private EntityOnMap selectedEntity;
        List<List<Button>> ButtonsMatrix;
        Dictionary<string, EntityOnMap> EntityList;

        public delegate void ReloadHost(int mapId);
        public ReloadHost reloadDelegate;

        private int _currentPLayer = 0;

        /// <summary>
        /// Public contructor of <see cref="Host"/> class.
        /// </summary>
        /// <param name="campaign">The capaign that is hosted.</param>
        public Host(string campaign, string ip)
        {
            InitializeComponent();
            SetMotif();
            Instance = this;

            _campaignPath = campaign;
            _campaign = new Campaign();
            _campaign.ReadFromJSON(_campaignPath);

            _ipAddress = IPAddress.Parse(ip);

            mapLoader = new MapHandler(this);
            map = new Map() { };

            reloadDelegate = new ReloadHost(LoadMap);
        }

        private void Host_Load(object sender, EventArgs e)
        {
            _connection = new HostTcpConnection();
            _connection.CreateSession(_campaignPath, _ipAddress);
            CheckForIllegalCrossThreadCalls = false;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            EntityList = new Dictionary<string, EntityOnMap> { };

            LoadMap(_campaign.CurrentMap);

            coords.Text = map.Name;

            currentPlayerLabel.Text = "Current player: You";

            UpdateMap();

            Log.Instance.gameLog.Debug("Attempting to establish connection...");
            try
            {
                _connection = new HostTcpConnection();
                _connection.CreateSession(_campaignPath, _ipAddress);
                Log.Instance.gameLog.Debug("Estabilish connection success.");

                //receive all character


                //broadcast characters


                //SYNC
            }
            catch (Exception exception)
            {
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

            charlabel.Text = "Characters:\n";

            foreach (ClientData client in _connection.Clients)
            {
                Character character = client.Character;
                charlabel.Text = charlabel.Text + character.Name + "\n";
            }

            HostTcpConnection.BroadcastCampaign(Path.GetFileName(_campaignPath), File.ReadAllText(_campaignPath));
            
            HostBroadcastMap();
        }

        private void HostBroadcastMap() 
        {
            HostTcpConnection.BroadcastMap(Path.GetFileName(GetMapById(_campaign.CurrentMap)), File.ReadAllText(GetMapById(_campaign.CurrentMap)));
        }

        private void DiceRollMenu_Click(object sender, EventArgs e)
        {
            DiceDisplay.Instance.Show();
            DiceDisplay.Instance.WindowState = FormWindowState.Normal;
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

            UpdateAndBroadcastMap();
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
                ButtonsMatrix[EOM.Y][EOM.X].BackgroundImage = new Bitmap(EOM.ImagePath);
            }

            ButtonsMatrix[selectedTile.y][selectedTile.x].FlatAppearance.BorderSize = 5;
            ButtonsMatrix[selectedTile.y][selectedTile.x].FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            
            DisplaySelectedInfo();

            map.EntityList = EntityList;
            map.SaveToJSON(GetMapById(_campaign.CurrentMap));
        }

        private void UpdateAndBroadcastMap()
        {
            UpdateMap();

            HostBroadcastMap();
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

        private void SpawnChest(object sender, System.EventArgs e)
        {
            if (_currentPLayer == 0)
            {
                if (TileEmpty(selectedTile.x, selectedTile.y))
                {
                    AddEntityOnMap(selectedTile.x, selectedTile.y, "Chest", @"C:\Users\Victorus\source\repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\chest.png");

                    UpdateAndBroadcastMap();
                }
            }
        }

        private void AddEntityOnMap(int x, int y, string name, string path) 
        {
            if (!TileEmpty(x, y))
            {
                return;
            }

            int iter = 0;
            string tempName = name + iter.ToString();

            while (EntityList.ContainsKey(tempName))
            {
                tempName = name + iter.ToString();
                iter += 1;
            }

            EntityOnMap tempEntity = new EntityOnMap(0, 0, x, y, path);

            tempEntity.Name = tempName;

            EntityList[tempEntity.Name] = tempEntity;
        }

        private void RemoveEntity_Click(object sender, EventArgs e)
        {
            if (_currentPLayer == 0)
            {
                EntityList.Remove(ButtonsMatrix[selectedTile.y][selectedTile.x].Text);

                UpdateAndBroadcastMap();
            }
        }

        private void ChangeMap_Click(object sender, EventArgs e)
        {
            Selector.Instance.Show();
            Selector.Instance.WindowState = FormWindowState.Normal;

            Selector.Instance.Selector_Init(this, _campaign.Name);
        }

        private void nextPlayerButton_Click(object sender, EventArgs e)
        {
            nextPLayer();
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
                    //Debug.WriteLine("Current player:");
                    //Debug.WriteLine(_currentPLayer);
                    //Debug.WriteLine("clients count:");
                    //Debug.WriteLine(_connection.Clients.Count);
                    //Debug.WriteLine("clients count:");
                    //Debug.WriteLine(_connection.Clients);

                    //TODO get char name
                    currentPlayerLabel.Text = "Current player: " + (_currentPLayer - 1);

                    HostTcpConnection.YourTurn(_currentPLayer - 1);
                }
            }
        }
    }
}
