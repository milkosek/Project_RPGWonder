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

namespace RPGWonder
{
    //TODO
    //GAMERS
    //  -linki do kart
    //THROW
    //  -per player, per stat
    //SPAWN GENERIC (wall, enemy, chest)
    //CHANGE MAP ~~meh
    public partial class Host : DefaultForm
    {
        private HostTcpConnection connection;
        public static Host instace;
        private string _campaign = "";
        private string _campaignFolder = "";
        private IPAddress ipAddress;

        private MapHandler mapLoader;
        private Map map;

        private (int x, int y) selectedTile;
        private EntityOnMap selectedEntity;
        List<List<Button>> ButtonsMatrix;
        Dictionary<string, EntityOnMap> EntityList;

        public Host(string campaignFolder, string campaign)
        {
            InitializeComponent();

            SetMotif();

            instace = this;
            _campaign = campaign;
            _campaignFolder = campaignFolder;
            //ipAddress = IPAdd.GetMyIPAddress();
            ipAddress = IPAddress.Parse("127.0.0.1");

            mapLoader = new MapHandler(this);
            map = new Map() { };
        }

        private void Host_Load(object sender, System.EventArgs e)
        {
            connection = new HostTcpConnection();
            connection.CreateSession(_campaign, ipAddress);
            CheckForIllegalCrossThreadCalls = false;


            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            EntityList = new Dictionary<string, EntityOnMap> { };

            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns\\" + _campaignFolder + "\\maps\\Equestria8x6.json";

            LoadMap(path);

            coords.Text = map.Name;

            AddEntityOnMap(0, 0, "Icon", @"C:\Users\Victorus\Source\Repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\RPGWonder.ico");
            AddEntityOnMap(1, 0, "Dice", @"C:\Users\Victorus\Source\Repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\Die.png");

            UpdateMap();
        }

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


        public void LoadMap(string mapPath)
        {
            selectedTile.x = 0;
            selectedTile.y = 0;

            //TODO save previous map

            map.ReadFromJSON(mapPath);

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

            EntityList.Clear();

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

                UpdateMap();

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
                ButtonsMatrix[EOM.Y][EOM.X].BackgroundImage = EOM.Icon;
            }

            ButtonsMatrix[selectedTile.y][selectedTile.x].FlatAppearance.BorderSize = 5;
            ButtonsMatrix[selectedTile.y][selectedTile.x].FlatAppearance.BorderColor = System.Drawing.Color.Yellow;

            DisplaySelectedInfo();
            Reload();
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

            Selector.Instance.Selector_Init(this, _campaignFolder);
        }
    }
}
