using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGWonder
{
    class EntityOnMap : Entity
    {
        private long entityID;
        private long mapID;
        private int x;
        private int y;
        private string name;
        Image icon;

        public EntityOnMap(long entityID, long mapID, int coordinatex, int coordinatey, string imagePath)
        {
            this.entityID = entityID;
            this.mapID = mapID;
            this.x = coordinatex;
            this.y = coordinatey;
            this.Icon = new Bitmap(imagePath);
        }

        private void setName(string name)
        {
            this.name = name;
        }

        public long EntityID { get => entityID; set => entityID = value; }
        public long MapID { get => mapID; set => mapID = value; }
        public Image Icon { get => icon; set => icon = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public string Name { get => name; set => name = value; }
    }
}
