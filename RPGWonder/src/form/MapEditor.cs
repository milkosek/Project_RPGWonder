using System.Windows.Forms;

namespace RPGWonder
{
    public partial class MapEditor : Form
    {
        public MapEditor()
        {
            InitializeComponent();
        }

        internal Map Map
        {
            get => default;
            set
            {
            }
        }
    }
}
