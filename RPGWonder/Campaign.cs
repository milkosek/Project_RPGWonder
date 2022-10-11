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
        private list<Character> characters;
        private list<Entity> entities;
        private list<Map> maps;
        private int currentMap;
        private list<Asset> assets;

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
