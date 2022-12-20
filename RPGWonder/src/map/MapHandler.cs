using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGWonder.src.map
{
    class MapHandler
    {
        private Game game;

        public MapHandler(Game game)
        {
            this.game = game;
        }

        public List<List<Button>> makeSquareTiles(TableLayoutPanel layout, int columnCount, int rowCount)
        {
            List<List<Button>> ButtonsMatrix = new List<List<Button>> { };
            
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
                List<Button> rowOfButtons = new List<Button>();

                for (int j = 0; j < columnCount; j++)
                {
                    (int x, int y) buttonId = (j, i);
                    var button = new Button();
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0, 0);
                    button.BackColor = Color.Transparent;

                    button.Text = string.Format("{0} {1}", buttonId.x, buttonId.y);
                    button.Name = string.Format("{0} {1}", buttonId.x, buttonId.y);

                    button.Margin = new Padding(0, 0, 0, 0);

                    button.Height = button.Width;

                    button.Dock = DockStyle.Fill;
                    button.MouseDown += new MouseEventHandler(btn_click);

                    button.TextAlign = System.Drawing.ContentAlignment.BottomRight;
                    button.BackgroundImageLayout = ImageLayout.Stretch;

                    layout.Controls.Add(button, j, i);

                    rowOfButtons.Add(button);
                }

                ButtonsMatrix.Add(rowOfButtons);
            }

            return ButtonsMatrix;
        }

        protected void btn_click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            
            if (e.Button == MouseButtons.Left)
            {
                game.MapTileAction(btn.Name, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                game.MapTileAction(btn.Name, 1);
            }
        }
    }
}
