using System;
using System.Windows.Forms;

namespace RPGWonder
{
    internal static class Program
    {
        public static MainMenu MainMenu
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /// <summary>
            /// Initialise Common
            /// </summary>
            _ = Common.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
