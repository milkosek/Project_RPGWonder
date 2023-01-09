using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RPGWonder
{
    class Map : Asset
    {
        // The ID of the map
        public long Id;
        // The name of the map
        public string Name;
        // The number of rows in the map
        public int Rows;
        // The number of columns in the map
        public int Columns;

        internal EntityOnMap EntityOnMap
        {
            get => default;
            set
            {
            }
        }

        public void SaveToJSON(string path, string TAG)
        {
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter streamWriter = new StreamWriter(path + "\\" + TAG + ".json"))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, this);
            }
        }

        public void ReadFromJSON(string path)
        {
            string jsonString = File.ReadAllText(path);
            JsonConvert.PopulateObject(jsonString, this);
        }
    }
}