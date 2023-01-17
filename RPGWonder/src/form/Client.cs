using RPGWonder.src.map;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class Client : DefaultForm
    {
        private ClientTcpConnection _connection;
        private readonly string _character;
        private static string _hostIpAddress;
        public static Client Instance;

        private MapHandler mapLoader;
        private Map map;
        private (int x, int y) selectedTile;
        private EntityOnMap selectedEntity;
        List<List<Button>> ButtonsMatrix;
        Dictionary<string, EntityOnMap> EntityList;

        public Client(string character, string ipAddr)
        {
            InitializeComponent();
            Instance = this;
            SetMotif();
            _character = character;
            _hostIpAddress = ipAddr;

            mapLoader = new MapHandler(this);
            map = new Map() { };
        }

        private void Client_Load(object sender, System.EventArgs e)
        {
            //MainMenu._instance.Hide();
            Log.Instance.gameLog.Debug("Attempting to establish connection...");
            try
            {
                _connection = new ClientTcpConnection();
                _connection.Connect(_hostIpAddress);
                _connection.ValidateSystem();
                _connection.SendCharacter(File.ReadAllText(_character), Path.GetFileName(_character));
                Log.Instance.gameLog.Debug("Estabilish connection success.");
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Establishing connection failed with error: " + exception.Message);
            }

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            EntityList = new Dictionary<string, EntityOnMap> { };

            string mapPath = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns\\My Super Epic Campaign With Katana\\maps\\Equestria8x6.json";

            LoadMap(mapPath);

            coords.Text = map.Name;

            AddEntityOnMap(0, 0, "Icon", @"C:\Users\Victorus\Source\Repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\RPGWonder.ico");
            AddEntityOnMap(1, 0, "Dice", @"C:\Users\Victorus\Source\Repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\Die.png");

            UpdateMap();
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

            DisplaySelectedInfo();
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

                UpdateMap();

                fromButton.BackgroundImage = null;
                fromButton.Text = string.Format("{0} {1}", x1, y1);

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
            _hostIpAddress = _hostIpAddress;
        }
    }
}
