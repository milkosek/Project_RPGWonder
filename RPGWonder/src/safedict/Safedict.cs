using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGWonder.src.safedict
{
    public class Safedict<type1, type2> : Dictionary<type1, type2>
    {
        public void Set(type1 key, type2 value)
        {
            if (!ContainsKey(key))
            {
                Add(key, value);
            }
            else
            {
                this[key] = value;
            }
        }
        public type2 Get(type1 key)
        {
            if (!ContainsKey(key))
            {
                return default;
            }
            else
            {
                return this[key];
            }
        }
    }
}