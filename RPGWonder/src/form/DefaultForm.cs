using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class DefaultForm : Form
    {
        public bool isMain = false;
        public DefaultForm ()
        {
            //FormClosing += DefaultForm_FormClosing;
        }
        private void DefaultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (isMain)
            {
                Environment.Exit(0);
            }
            Hide();
        }
        private void ProcessControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
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
                else if (control is TableLayoutPanel)
                {
                    foreach (Control button in control.Controls)
                    {
                        if (button is Button)
                        {
                            button.BackColor = Color.FromArgb(64, 64, 64);
                            button.ForeColor = Color.White;
                            button.Font = new Font(control.Font, FontStyle.Bold);
                        }
                    }
                }
                // You can add more conditions for other types of controls here
                ProcessControls(control.Controls);
            }
        }

        public void SetMotif()
        {
            BackColor = Color.FromArgb(40, 40, 40);
            ForeColor = Color.White;
            ProcessControls(Controls);
        }

    }
}
