using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace RPGWonder
{
    /// <summary>
    /// A class representing a campaign
    /// </summary>
    class Campaign : IDataclass
    {
        public string Name;
        public List<Character> Characters;
        public List<Entity> Entities;
        public List<Map> Maps;
        public int CurrentMap;
        public List<Asset> Assets;

        /// <summary>
        /// Initializes a new instance of the Campaign class.
        /// </summary>
        public Campaign() { }

        /// <summary>
        /// Reads the campaign data from a JSON file.
        /// </summary>
        /// <param name="path">The path to the JSON file.</param>
        public void ReadFromJSON(string path)
        {
            string jsonString = File.ReadAllText(path);
            JsonConvert.PopulateObject(jsonString, this);
        }

        /// <summary>
        /// Saves the campaign data to a JSON file.
        /// </summary>
        /// <param name="path">The path to the directory where the JSON file should be saved.</param>
        public void SaveToJSON(string path, string TAG)
        {           
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            if (!Directory.Exists(path + "\\" + TAG))
            {
                Directory.CreateDirectory(path + "\\" + TAG);
            }
            using (StreamWriter streamWriter = new StreamWriter(path + "\\" + TAG + "\\" + TAG + ".json"))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
}
