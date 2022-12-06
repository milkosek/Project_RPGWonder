using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RPGWonder
{
    class Campaign: Dataclass
    {
        public long Id;
        public string Name; 
        public List<Character> Characters;
        public List<Entity> Entities;
        public List<Map> Maps;
        public int CurrentMap;
        public List<Asset> Assets;

        public Campaign() { }

        public void ReadFromJSON(string path)
        {
            JObject data = JObject.Parse(File.ReadAllText(path));
            Id = (long)data["id"];
            Name = (string)data["name"];
            CurrentMap = (int)data["current-map"];
        }

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
                if (!File.Exists(path + "\\Campaigns.json"))
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
                    File.WriteAllText(path + "\\Campaigns.json", sb.ToString());
                }
                JObject data = JObject.Parse(File.ReadAllText(path + "\\Campaigns.json"));
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
                File.WriteAllText(path + "\\Campaigns.json", data.ToString());
            }
        }
    }
}
