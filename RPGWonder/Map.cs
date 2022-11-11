using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGWonder
{
    class Map : Asset
    {
        private long id;
        private Asset asset;
        private System.Collections.Generic.List<RPGWonder.EntityOnMap> entitiesOnMap;
        private List<int> dimensions;

        internal EntityOnMap EntityOnMap
        {
            get => default;
            set
            {
            }
        }
    }
}
