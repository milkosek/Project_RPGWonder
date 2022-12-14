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
        List<List<Button>> ButtonsList;

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
            ButtonsList[5][5].BackgroundImage = myimage;
            ButtonsList[5][5].Text = "DICE";
        }

        private void LoadMap(int Cols, int Rows)
        {
            while (mapTableLayout.Controls.Count > 0)
            {
                mapTableLayout.Controls[0].Dispose();
            }

            mapTableLayout.Size = new Size(1200, 675);

            ButtonsList = mapLoader.makeSquareTiles(mapTableLayout, Cols, Rows);
        }

        private void Move(int x1, int y1, int x2, int y2)
        {
            Button from = ButtonsList[y1][x1];
            Button to = ButtonsList[y2][x2];

            if (from.Text != string.Format("{0} {1}", x1, y1))
            {
                to.BackgroundImage = from.BackgroundImage;
                to.Text = from.Text;

                from.BackgroundImage = null;
                from.Text = string.Format("{0} {1}", x1, y1);
            }

            selectedTile.x = -1;
        }

        public void SetTextForCoords(string myText)
        {
            selectedTile.x = Int32.Parse(myText.Split(' ')[0]);
            selectedTile.y = Int32.Parse(myText.Split(' ')[1]);

            string tmpString = "";
            tmpString += "x: " + selectedTile.x;
            tmpString += "\ny: " + selectedTile.y;
            coords.Text = tmpString;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.instance.Close();
        }
    }
}
