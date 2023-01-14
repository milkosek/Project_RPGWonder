using System.Windows.Forms;

namespace RPGWonder
{
    public partial class MapEditor : DefaultForm
    {
        public MapEditor()
        {
            InitializeComponent();
            SetMotif();
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
