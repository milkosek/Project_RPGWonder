using Newtonsoft.Json;
using System.IO;
namespace RPGWonder
{
    /// <summary>
    /// A class representing a character
    /// </summary>
    public class Character : IDataclass
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
        public int HitDice;
        public int DeathSavesFail;
        public int DeathSavesSuccess;
        public string Equipment;
        public string Description;
        public string Specials;
        public Safedict<string, string> Saves = new Safedict<string, string>();
        public int PassiveWisdomPerception;

        public void SaveToJSON(string path, string TAG)
        {
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
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

        /// <summary>
        /// Show a form with this characters
        /// </summary>
        public void Show()
        {
            ShowCharacter.Instance(this).Show();
        }
    }
}