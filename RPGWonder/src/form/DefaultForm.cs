using System.Drawing;
using System.Windows.Forms;

namespace RPGWonder
{
    public class DefaultForm : Form
    {
        public DefaultForm()
        {
            BackColor = Color.FromArgb(40, 40, 40);
            ForeColor = Color.White;
        }

        public void SetMotif()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.FromArgb(64, 64, 64);
                    control.ForeColor = Color.White;
                    control.Font = new Font(control.Font, FontStyle.Bold);
                }
                else if (control is Label)
                {
                    control.ForeColor = Color.White;
                }
                else if (control is TextBox)
                {
                    control.BackColor = Color.FromArgb(64, 64, 64);
                    control.ForeColor = Color.White;
                }
                else if (control is ComboBox)
                {
                    control.BackColor = Color.FromArgb(64, 64, 64);
                    control.ForeColor = Color.White;
                }
                else if (control is ListBox)
                {
                    control.BackColor = Color.FromArgb(64, 64, 64);
                    control.ForeColor = Color.White;
                }
                else if (control is TabPage)
                {
                    control.BackColor = Color.FromArgb(64, 64, 64);
                    control.ForeColor = Color.White;
                }
                else if (control is TabControl)
                {
                    control.BackColor = Color.FromArgb(64, 64, 64);
                    control.ForeColor = Color.White;
                }
                // You can add more conditions for other types of controls here
            }
        }
    }
}
