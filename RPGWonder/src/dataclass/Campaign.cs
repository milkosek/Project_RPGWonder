using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RPGWonder
{
    /// <summary>
    /// A class representing a campaign
    /// </summary>
    class Campaign : Dataclass
    {
        public long Id;
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
            JObject data = JObject.Parse(File.ReadAllText(path));
            Id = (long)data["id"];
            Name = (string)data["name"];
            CurrentMap = (int)data["current-map"];
        }

        /// <summary>
        /// Saves the campaign data to a JSON file.
        /// </summary>
        /// <param name="path">The path to the directory where the JSON file should be saved.</param>
        public void SaveToJSON(string path)
        {
            if (!Directory.Exists(path + "\\" + Name))
            {
                Directory.CreateDirectory(path + "\\" + Name + "\\characters");
                Directory.CreateDirectory(path + "\\" + Name + "\\entities");
                Directory.CreateDirectory(path + "\\" + Name + "\\maps");
                Directory.CreateDirectory(path + "\\" + Name + "\\assets");
                StringBuilder sb;
                StringWriter sw;
                if (!File.Exists(path + "\\00_Campaigns.json"))
                {
                    sb = new StringBuilder();
                    sw = new StringWriter(sb);
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        writer.Formatting = Formatting.Indented;
                        writer.WriteStartObject();
                        writer.WritePropertyName("max-id");
                        writer.WriteValue(0);
                        writer.WritePropertyName("campaigns");
                        writer.WriteStartArray();
                        writer.WriteEndArray();
                        writer.WriteEnd();
                    }
                    File.WriteAllText(path + "\\00_Campaigns.json", sb.ToString());
                }
                JObject data = JObject.Parse(File.ReadAllText(path + "\\00_Campaigns.json"));
                long maxId = (long)data["max-id"];
                sb = new StringBuilder();
                sw = new StringWriter(sb);
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartObject();
                    writer.WritePropertyName("id");
                    writer.WriteValue(maxId);
                    writer.WritePropertyName("name");
                    writer.WriteValue(Name);
                    writer.WritePropertyName("current-map");
                    writer.WriteValue(CurrentMap);
                    writer.WriteEnd();
                }
                data["max-id"] = maxId + 1;
                ((JArray)data["campaigns"]).Add("\\" + Name + "\\" + Name + ".json");
                File.WriteAllText(path + "\\" + Name + "\\" + Name + ".json", sb.ToString());
                File.WriteAllText(path + "\\00_Campaigns.json", data.ToString());
            }
        }
    }
}
