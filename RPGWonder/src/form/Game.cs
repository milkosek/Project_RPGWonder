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
    public partial class Game : Form
    {
        private MapHandler mapLoader;
        private Map map;
        private (int x, int y) selectedTile;
        List<List<Button>> ButtonsMatrix;
        List<List<EntityOnMap>> EntityMatrix;

        public Game()
        {
            InitializeComponent();
            mapLoader = new MapHandler(this);
            map = new Map() { };

            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\maps\\Equestria.json";

            map.ReadFromJSON(path);

            coords.Text = map.Name;
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

        internal Connection Connection
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
            MainMenu.instance.Hide();
            LoadMap(map.Columns, map.Rows);

            Image myimage = new Bitmap(@"C:\Users\Victorus\Source\Repos\milkosek\Project_RPGWonder\RPGWonder\src\asset\Die.png");
            ButtonsMatrix[5][5].BackgroundImage = myimage;
            ButtonsMatrix[5][5].Text = "DICE";
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
            Button from = ButtonsMatrix[y1][x1];
            Button to = ButtonsMatrix[y2][x2];

            if (from.Text != string.Format("{0} {1}", x1, y1) && from != to)
            {
                to.BackgroundImage = from.BackgroundImage;
                to.Text = from.Text;

                from.BackgroundImage = null;
                from.Text = string.Format("{0} {1}", x1, y1);
            }

            selectedTile.x = x2;
            selectedTile.y = y2;
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

                    string tmpString = "";
                    tmpString += "x: " + selectedTile.x;
                    tmpString += "\ny: " + selectedTile.y;
                    coords.Text = tmpString;
                    break;

                case 1:
                    MoveOnMap(selectedTile.x, selectedTile.y, pressedButtonX, pressedButtonY);
                    break;
            }

        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.instance.Close();
        }
    }
}
