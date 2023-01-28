using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace RPGWonder
{
    class Map : IDataclass
    {
        // The ID of the map
        public long Id;
        // The name of the map
        public string Name;
        // The number of columns in the map
        public int Columns;
        // The number of rows in the map
        public int Rows;
        // Dictrionary of entities assigned to keys representig their position on map in (string)"x y" format
        public Dictionary<string, EntityOnMap> EntityList;

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

        public void SaveToJSON(string path)
        {
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter streamWriter = new StreamWriter(path))
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