using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGWonder
{
    class Campaign
    {
        private long id;
        private List<Character> characters;
        private List<Entity> entities;
        private List<Map> maps;
        private int currentMap;
        private List<Asset> assets;

        internal Entity Entity
        {
            get => default;
            set
            {
            }
        }

        internal Map Map
        {
            get => default;
            set
            {
            }
        }

        internal Asset Asset
        {
            get => default;
            set
            {
            }
        }
    }
}
