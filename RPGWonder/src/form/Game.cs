using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGWonder.src.map;

namespace RPGWonder
{
    public partial class Game : DefaultForm
    {
        private MapHandler mapLoader;
        private Map map;
        private (int x, int y) selectedTile;
        private EntityOnMap selectedEntity;
        List<List<Button>> ButtonsMatrix;
        Dictionary<string, EntityOnMap> EntityList;

        public Game() : base()
        {
            InitializeComponent();

            mapLoader = new MapHandler(this);
            map = new Map() { };

            //string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\maps";

            //map.ReadFromJSON(path);

            coords.Text = "ex"; //map.Name;
        }

        internal DiceRolls DiceRolls
        {
            get => default;
            set
            {
            }
        }

        internal Campaign Campaign
        {
            get => default;
            set
            {
            }
        }

        internal VoiceChat VoiceChat
        {
            get => default;
            set
            {
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //MainMenu.instance.Hide();
            //LoadMap(map.Columns, map.Rows);
            //LoadMap(16, 9);

            //EntityOnMap DieEntity1 = new EntityOnMap(0, 0, 5, 5,
            //    @"C:\Users\Victorus\Source\Repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\Die.png");
            //DieEntity1.Name = "Dice1";

            //EntityOnMap DieEntity2 = new EntityOnMap(0, 0, 8, 8,
            //    @"C:\Users\Victorus\Source\Repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\Die.png");
            //DieEntity2.Name = "Dice2";

            //EntityOnMap LogoEntity = new EntityOnMap(0, 0, 2, 7,
            //    @"C:\Users\Victorus\Source\Repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\RPGWonder.ico");
            //LogoEntity.Name = "Icon";

            //EntityList = new Dictionary<string, EntityOnMap> { };
            //EntityList[DieEntity1.Name] = DieEntity1;
            //EntityList[DieEntity2.Name] = DieEntity2;
            //EntityList[LogoEntity.Name] = LogoEntity;

            UpdateMap();
        }

        private void LoadMap(int Cols, int Rows)
        {
            while (mapTableLayout.Controls.Count > 0)
            {
                mapTableLayout.Controls[0].Dispose();
            }

            mapTableLayout.Size = new Size(1200, 675);

            ButtonsMatrix = mapLoader.makeSquareTiles(mapTableLayout, Cols, Rows);
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

                //UpdateMap();

                fromButton.BackgroundImage = null;
                fromButton.Text = string.Format("{0} {1}", x1, y1);

                selectedTile.x = x2;
                selectedTile.y = y2;
            }
        }

        // 0 - select
        // 1 - move
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
            //foreach (KeyValuePair<string, EntityOnMap> nameEntity in EntityList)
            //{
            //    string name = nameEntity.Key;
            //    EntityOnMap EOM = nameEntity.Value;

            //    ButtonsMatrix[EOM.Y][EOM.X].Text = EOM.Name;
            //    ButtonsMatrix[EOM.Y][EOM.X].BackgroundImage = EOM.Icon;
            //}
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.instance.Close();
        }
    }
}
