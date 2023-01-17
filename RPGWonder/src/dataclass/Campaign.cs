using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace RPGWonder
{
    /// <summary>
    /// A class representing a _campaign
    /// </summary>
    class Campaign : IDataclass
    {
        public string Name;
        //public List<Character> Characters;
        //public List<Entity> Entities;
        //public List<Map> Maps;
        public int CurrentMap;
        //public List<Asset> Assets;
        public Safedict<string, CodexEntry> CodexEntries = new Safedict<string, CodexEntry>();

        public void ReadFromJSON(string path)
        {
            string jsonString = File.ReadAllText(path);
            JObject jObject = JObject.Parse(jsonString);
            string fullPath = Path.GetFullPath(path);
            string parentDir = Path.GetDirectoryName(fullPath);
            Name = (string)jObject["Name"];
            CurrentMap = (int)jObject["CurrentMap"];
            DirectoryInfo dir = new DirectoryInfo(parentDir + "\\codex");
            FileInfo[] jsonFiles = dir.GetFiles("*.json");
            foreach (FileInfo jsonFile in jsonFiles)
            {
                CodexEntry codexEntry = new CodexEntry();
                codexEntry.ReadFromJSON(jsonFile.FullName);
                CodexEntries.Set(jsonFile.Name.Replace(jsonFile.Extension, ""), codexEntry);
            }
        }

        public void SaveToJSON(string path, string TAG)
        {           
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            if (!Directory.Exists(path + "\\" + TAG))
            {
                Directory.CreateDirectory(path + "\\" + TAG);
            }
            JObject jObject = new JObject();
            jObject["Name"] = Name;
            jObject["CurrentMap"] = CurrentMap;
            using (StreamWriter file = File.CreateText(path + "\\" + TAG + "\\" + TAG + ".json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                jObject.WriteTo(writer);
            }
            if (!Directory.Exists(path + "\\" + TAG + "\\codex"))
            {
                Directory.CreateDirectory(path + "\\" + TAG + "\\codex");
            }
            foreach (KeyValuePair<string, CodexEntry> entry in CodexEntries)
            {
                entry.Value.SaveToJSON(path + "\\" + TAG + "\\codex", entry.Key);
            }
        }
    }
}
