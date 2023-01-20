using Newtonsoft.Json.Linq;
using RPGWonder.src.form;
using RPGWonder.src.map;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class Client : DefaultForm
    {
        //Same as host
        private ClientTcpConnection _connection;
        public static Client Instance;
        private IPAddress _ipAddress;

        private string _clientCampaignsPath = Common.Instance.ClientCampaignsPath;
        private Campaign _campaign;
        private MapHandler mapLoader;
        private Map map;

        private (int x, int y) selectedTile;
        private EntityOnMap selectedEntity;
        List<List<Button>> ButtonsMatrix;
        Dictionary<string, EntityOnMap> EntityList;

        private readonly string _character;
        private static string _hostIpAddress;


        public Client(string character, string ipAddr = "127.0.0.1")
        {
            InitializeComponent();
            SetMotif();
            Instance = this;

            _character = character;

            _hostIpAddress = ipAddr;

            _campaign = new Campaign();
            mapLoader = new MapHandler(this);
            map = new Map();
        }

        private void Client_Load(object sender, System.EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            EntityList = new Dictionary<string, EntityOnMap> { };

            //MainMenu._instance.Hide();
            Log.Instance.gameLog.Debug("Attempting to establish connection...");
            try
            {
                _connection = new ClientTcpConnection();
                _connection.Connect(_hostIpAddress);
                _connection.ValidateSystem();
                Log.Instance.gameLog.Debug("Estabilish connection success.");

                //receive map


                //send character


                //gm places characters


                //receive other characters


                //receive new map


                _connection.SendCharacter(Path.GetFileName(_character), File.ReadAllText(_character));
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Establishing connection failed with error: " + exception.Message);
            }

            //LoadMap(_campaign.CurrentMap);

            //coords.Text = map.Name;

            //UpdateMap();
        }

        /// <summary>
        /// Method for reloading the game state.
        /// </summary>
        public void Reload()
        {
            Debug.WriteLine("RELOADING CLIENT!");

            //foreach (ClientData client in _connection.Clients)
            //{
            //    Character character = client.Character;
            //    charlabel.Text = charlabel.Text + "\n" + character.Name;

            //    Debug.WriteLine("RELOADED:", character.Name);
            //}
        }

        public void LoadCampaign(string campaign_tag)
        {
            Debug.WriteLine("LOADING CLIENT CAMPAIGN!");
            _campaign.ReadFromJSON(_clientCampaignsPath + "\\" + campaign_tag);
        }

        public void LoadLoadMap(int mapId)
        {
            Debug.WriteLine("LOADING CLIENT MAP!");
            LoadMap(mapId);
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

            UpdateMap();
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

            //map.EntityList = EntityList;
            //map.SaveToJSON(GetMapById(_campaign.CurrentMap));
        }

        public string GetMapById(int id)
        {
            string path = _clientCampaignsPath + "\\maps";

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
    }
}
