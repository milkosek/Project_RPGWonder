using System.Windows.Forms;

namespace RPGWonder
{
    public partial class Settings : DefaultForm
    {
        private static Settings instance = null;
        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                }
                return instance;
            }
        }
        private Settings()
        {
            InitializeComponent();
            SetMotif();
        }

        protected override void Dispose(bool disposing)
        {
            instance = null;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
