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

namespace RPGWonder
{
    //TODO
    //GAMERS
    //  -linki do kart
    //THROW
    //  -per player, per stat
    //SPAWN GENERIC (wall, enemy, chest)
    //CHANGE MAP done
    /// <summary>
    /// Class representing a from with game window as seen by the Host
    /// </summary>
    public partial class Host : DefaultForm
    {
        private HostTcpConnection _connection;
        public static Host instace;
        private IPAddress ipAddress;

        private string _campaignPath = "";
        private Campaign _campaign;
        private MapHandler mapLoader;
        private Map map;

        private (int x, int y) selectedTile;
        private EntityOnMap selectedEntity;
        List<List<Button>> ButtonsMatrix;
        Dictionary<string, EntityOnMap> EntityList;

        private string _campaign = "";
        private IPAddress _ipAddress;

        /// <summary>
        /// Public contructor of <see cref="Host"/> class.
        /// </summary>
        /// <param name="campaign">The capaign that is hosted.</param>
        public Host(string campaign)
        {
            InitializeComponent();
            SetMotif();
            instace = this;

            _campaignPath = campaign;
            _campaign = new Campaign();
            _campaign.ReadFromJSON(_campaignPath);

            //ipAddress = IPAdd.GetMyIPAddress();
            ipAddress = IPAddress.Parse("127.0.0.1");

            mapLoader = new MapHandler(this);
            map = new Map() { };
        }

        private void Host_Load(object sender, System.EventArgs e)
            _campaign = campaign;
            Debug.WriteLine(_campaign);
            try
            {
                _ipAddress = IPAdd.GetMyIPAddress();
                //ipAddress = IPAddress.Parse("127.0.0.1");
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Error getting ip: " + exception);
                Close();
            }
            finally
            {
                Log.Instance.gameLog.Debug("Got ip adress: " + _ipAddress);
            }

        }
        private void Host_Load(object sender, EventArgs e)
        {
            connection = new HostTcpConnection();
            connection.CreateSession(_campaignPath, ipAddress);
            CheckForIllegalCrossThreadCalls = false;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            EntityList = new Dictionary<string, EntityOnMap> { };

            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns\\" + _campaign.Name + "\\maps\\Equestria8x6.json";

            LoadMap(_campaign.CurrentMap, true);

            coords.Text = map.Name;

            UpdateMap();
            Log.Instance.gameLog.Debug("Attempting to establish connection...");
            try
            {
                _connection = new HostTcpConnection();
                _connection.CreateSession(_campaign, _ipAddress);
                Log.Instance.gameLog.Debug("Estabilish connection success.");
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Establishing connection failed with error: " + exception.Message);
            }
        }


        /// <summary>
        /// Method for reloading the game state.
        /// </summary>
        public void Reload()
        {
            foreach (ClientData client in connection.Clients)
            {
                Character character = client.Character;
                charlabel.Text = charlabel.Text + character.Name;
            }
        }

        private void Host_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void DiceRollMenu_Click(object sender, EventArgs e)
        {
            DiceDisplay.Instance.Show();
            DiceDisplay.Instance.WindowState = FormWindowState.Normal;
        }


        public void LoadMap(int mapId, bool firstLoad = false)
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

            selectedTile.x = 0;
            selectedTile.y = 0;

            UpdateMap();
        }

        private void DisplayMap(Map map)
        {
            while (mapTableLayout.Controls.Count > 0)
            {
                mapTableLayout.Controls[0].Dispose();
            }

            ButtonsMatrix = mapLoader.makeSquareTiles(mapTableLayout, map.Columns, map.Rows);

            // TODO load entities from map

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
                    break;

                case 1:
                    MoveOnMap(selectedTile.x, selectedTile.y, pressedButtonX, pressedButtonY);
                    break;
            }

            UpdateMap();
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

        public string GetMapById(int id)
        {
            string[] subdirectoryPaths = Directory.GetDirectories(Common.Instance.CampaignsPath);

            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns\\" + _campaign.Name + "\\maps";

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
            if (TileEmpty(selectedTile.x, selectedTile.y))
            {
                AddEntityOnMap(selectedTile.x, selectedTile.y, "Chest", @"C:\Users\Victorus\source\repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\chest.png");

                UpdateMap();
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
            EntityList.Remove(ButtonsMatrix[selectedTile.y][selectedTile.x].Text);

            UpdateMap();
        }

        private void ChangeMap_Click(object sender, EventArgs e)
        {
            Selector.Instance.Show();
            Selector.Instance.WindowState = FormWindowState.Normal;

            Selector.Instance.Selector_Init(this, _campaign.Name);
        }
    }
}
