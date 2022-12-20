using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RPGWonder
{
    /// <summary>
    /// A class representing a character
    /// </summary>
    class Character : IDataclass
    {
        public string Name;
        public string Race;
        public string Gender;
        public string CharacterClass;
        public int Level;
        public int Experience;
        public string Background;
        public string Alignment;
        public Safedict<string, int> Abilities = new Safedict<string, int>();
        public int ProficiencyBonus;
        public int ArmorClass;
        public int InitiativeModifier;
        public int Initiative;
        public int Speed;
        public string Size;
        public int CurrentHitPoints;
        public int TemporaryHitPoints;
        public string PersonalityTraits;
        public string Ideals;
        public string Bonds;
        public string Flaws;
        public int HitDice;
        public int DeathSavesFail;
        public int DeathSavesSuccess;
        public string FeaturesAndTraits;
        public string OtherProficienciesAndLanguages;
        public Safedict<string, int> Money = new Safedict<string, int>();
        public List<int> Items = new List<int>();
        public List<int> AttacksAndSpells = new List<int>();
        public Safedict<string, string> Saves = new Safedict<string, string>();
        public Safedict<string, string> Skills = new Safedict<string, string>();
        public int PassiveWisdomPerception;
        public string Age;
        public string AlliesAndOrgs;

        /// <summary>
        /// Initializes a new instance of the Character class.
        /// </summary>
        public Character() { }

        /// <summary>
        /// Saves the campaign data to a JSON file.
        /// </summary>
        /// <param name="path">The path to the directory where the JSON file should be saved.</param>
        public void SaveToJSON(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(path + "\\00_Characters.json"))
            {
                string json = "{\"max-id\": 0,\"characters\": []}";
                File.WriteAllText(path + "\\00_Characters.json", json);
            }
            JObject data = JObject.Parse(File.ReadAllText(path + "\\00_Characters.json"));
            long maxId = (long)data["max-id"];
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter streamWriter = new StreamWriter(path + "\\" + Name + ".json"))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, this);
            }
            data["max-id"] = maxId + 1;
            ((JArray)data["characters"]).Add("\\" + Name + ".json");
            File.WriteAllText(path + "\\00_Characters.json", data.ToString());
        }

        /// <summary>
        /// Reads the campaign data from a JSON file.
        /// </summary>
        /// <param name="path">The path to the JSON file.</param>
        public void ReadFromJSON(string path)
        {
            string jsonString = File.ReadAllText(path);
            JsonConvert.PopulateObject(jsonString, this);
        }
    }
}