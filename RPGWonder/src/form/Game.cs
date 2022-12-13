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
        private MapLoader mapLoader;
        private Map map;

        public Game()
        {
            InitializeComponent();
            mapLoader = new MapLoader(this);
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
        }

        private void LoadMap(int Cols, int Rows)
        {
            while (mapTableLayout.Controls.Count > 0)
            {
                mapTableLayout.Controls[0].Dispose();
            }

            mapTableLayout.Size = new Size(1200, 675);

            List<Button> ButtonsList = mapLoader.makeSquareTiles(mapTableLayout, Cols, Rows);
        }

        public void SetTextForCoords(string myText)
        {
            string tmpString = "";
            tmpString += "x: " + Int32.Parse(myText) % map.Columns;
            tmpString += "\ny: " + Int32.Parse(myText) / map.Columns;
            coords.Text = tmpString;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.instance.Close();
        }
    }
}
