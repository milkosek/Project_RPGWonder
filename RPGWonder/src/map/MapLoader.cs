using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGWonder.src.map
{
    class MapLoader
    {
        private Game game;

        public MapLoader(Game game)
        {
            this.game = game;
        }

        public List<Button> makeSquareTiles(TableLayoutPanel layout, int columnCount, int rowCount)
        {
            List<Button> ButtonsList = new List<Button> {};
            
            layout.ColumnCount = columnCount;
            layout.RowCount = rowCount;

            layout.ColumnStyles.Clear();
            layout.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                layout.RowStyles.Add(new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    int buttonId = i * columnCount + j;
                    var button = new Button();
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = System.Drawing.Color.Transparent;

                    button.Text = string.Format("{0}", buttonId);
                    button.Name = string.Format("button_{0}", buttonId);

                    button.Margin = new Padding(0, 0, 0, 0);

                    button.Height = button.Width;

                    button.Dock = DockStyle.Fill;
                    button.Click += new EventHandler(btn_click);
                    layout.Controls.Add(button, j, i);

                    ButtonsList.Add(button);
                }
            }

            return ButtonsList;
        }

        protected void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Debug.WriteLine(btn.Text);

            game.SetTextForCoords(btn.Text);
        }

        //TODO BACKLOG hex tile border
        public void makeHexTiles(TableLayoutPanel layout, int rowCount, int columnCount)
        {
            layout.ColumnCount = columnCount;
            layout.RowCount = rowCount;

            layout.ColumnStyles.Clear();
            layout.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                layout.RowStyles.Add(new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    int buttonId = i * columnCount + j;
                    var button = new HexButton();
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = System.Drawing.Color.Transparent;

                    button.Text = string.Format("{0}", buttonId);
                    button.Name = string.Format("button_{0}", buttonId);

                    button.Dock = DockStyle.Fill;
                    button.Height = button.Height * 2;
                    layout.Controls.Add(button, j, i);
                }
            }
        }
    }
}
