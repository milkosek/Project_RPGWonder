using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RPGWonder.src.map
{
    class HexButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            var x_0 = ClientSize.Width / 2;
            var y_0 = ClientSize.Height / 2;

            var shape = new PointF[6];

            var r = this.Size.Height/2; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos((90 + a * 60) * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin((90 + a * 60) * Math.PI / 180f));
            }

            // Create a GraphicsPath object and add a polygon.
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddPolygon(shape);

            this.Region = new System.Drawing.Region(myPath);
            base.OnPaint(pevent);
        }
    }
}