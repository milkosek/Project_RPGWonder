using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPGWonder.src.safedict;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RPGWonder
{
    class Character : Dataclass
    {
        public string Name;
        public string Race;
        public string Gender;
        public string CharacterClass;
        public int Level;
        public int Experience;
        public string Background;
        public string Alignment;
        public Safedict<string, int> Stats = new Safedict<string, int>();
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
        public Character() { }
        public void SaveToJSON(string path)
        {
            StringBuilder sb;
            StringWriter sw;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(path + "\\00_Characters.json"))
            {
                sb = new StringBuilder();
                sw = new StringWriter(sb);
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartObject();
                    writer.WritePropertyName("max-id");
                    writer.WriteValue(0);
                    writer.WritePropertyName("characters");
                    writer.WriteStartArray();
                    writer.WriteEndArray();
                    writer.WriteEnd();
                }
                File.WriteAllText(path + "\\00_Characters.json", sb.ToString());
            }
            JObject data = JObject.Parse(File.ReadAllText(path + "\\00_Characters.json"));
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
                writer.WritePropertyName("race");
                writer.WriteValue(Race);
                writer.WritePropertyName("gender");
                writer.WriteValue(Gender);
                writer.WritePropertyName("characterClass");
                writer.WriteValue(CharacterClass);
                writer.WritePropertyName("level");
                writer.WriteValue(Level);
                writer.WritePropertyName("experience");
                writer.WriteValue(Experience);
                writer.WritePropertyName("background");
                writer.WriteValue(Background);
                writer.WritePropertyName("alignment");
                writer.WriteValue(Alignment);
                writer.WritePropertyName("stats");
                writer.WriteStartObject();
                for (int i = 0; i < Stats.Count; i++)
                {
                    string TAG = Stats.Keys.ToList()[i];
                    writer.WritePropertyName(TAG);
                    writer.WriteValue(Stats[TAG]);
                }
                writer.WriteEnd();
                writer.WritePropertyName("proficiencyBonus");
                writer.WriteValue(ProficiencyBonus);
                writer.WritePropertyName("armorClass");
                writer.WriteValue(ArmorClass);
                writer.WritePropertyName("initiative");
                writer.WriteValue(Initiative);
                writer.WritePropertyName("initiativeModifier");
                writer.WriteValue(InitiativeModifier);
                writer.WritePropertyName("speed");
                writer.WriteValue(Speed);
                writer.WritePropertyName("size");
                writer.WriteValue(Size);
                writer.WritePropertyName("currentHitPoints");
                writer.WriteValue(CurrentHitPoints);
                writer.WritePropertyName("temporaryHitPoints");
                writer.WriteValue(TemporaryHitPoints);
                writer.WritePropertyName("personalityTraits");
                writer.WriteValue(PersonalityTraits);
                writer.WritePropertyName("ideals");
                writer.WriteValue(Ideals);
                writer.WritePropertyName("bonds");
                writer.WriteValue(Bonds);
                writer.WritePropertyName("flaws");
                writer.WriteValue(Flaws);
                writer.WritePropertyName("hitDice");
                writer.WriteValue(HitDice);
                writer.WritePropertyName("deathSavesFail");
                writer.WriteValue(DeathSavesFail);
                writer.WritePropertyName("deathSavesSuccess");
                writer.WriteValue(DeathSavesSuccess);
                writer.WritePropertyName("featuresAndTraits");
                writer.WriteValue(FeaturesAndTraits);
                writer.WritePropertyName("otherProficienciesAndLanguages");
                writer.WriteValue(OtherProficienciesAndLanguages);
                writer.WritePropertyName("money");
                writer.WriteStartObject();
                for (int i = 0; i < Money.Count; i++)
                {
                    string TAG = Money.Keys.ToList()[i];
                    writer.WritePropertyName(TAG);
                    writer.WriteValue(Money[TAG]);
                }
                writer.WriteEnd();
                writer.WritePropertyName("items");
                writer.WriteStartObject();
                for (int i = 0; i < Items.Count; i++)
                {
                    int TAG = Items[i];
                    writer.WritePropertyName(TAG.ToString());
                }
                writer.WriteEnd();
                writer.WritePropertyName("attacksAndSpells");
                writer.WriteStartObject();
                for (int i = 0; i < AttacksAndSpells.Count; i++)
                {
                    int TAG = AttacksAndSpells[i];
                    writer.WritePropertyName(TAG.ToString());
                }
                writer.WriteEnd();
                writer.WritePropertyName("saves");
                writer.WriteStartObject();
                for (int i = 0; i < Saves.Count; i++)
                {
                    string TAG = Saves.Keys.ToList()[i];
                    writer.WritePropertyName(TAG);
                    writer.WriteValue(Saves[TAG]);
                }
                writer.WriteEnd();
                writer.WritePropertyName("skills");
                writer.WriteStartObject();
                for (int i = 0; i < Skills.Count; i++)
                {
                    string TAG = Skills.Keys.ToList()[i];
                    writer.WritePropertyName(TAG);
                    writer.WriteValue(Skills[TAG]);
                }
                writer.WriteEnd();
                writer.WritePropertyName("passiveWisdomPerception");
                writer.WriteValue(PassiveWisdomPerception);
                writer.WritePropertyName("age");
                writer.WriteValue(Age);
                writer.WritePropertyName("alliesAndOrgs");
                writer.WriteValue(AlliesAndOrgs);
                writer.WriteEnd();
            }
            data["max-id"] = maxId + 1;
            ((JArray)data["characters"]).Add("\\" + Name + ".json");
            File.WriteAllText(path + "\\" + Name + ".json", sb.ToString());
            File.WriteAllText(path + "\\00_Characters.json", data.ToString());
        }
        public void ReadFromJSON(string path)
        {
            JObject data = JObject.Parse(File.ReadAllText(path));
            Race = (string)data["race"];
            Gender = (string)data["gender"];
            CharacterClass = (string)data["characterClass"];
            Level = (int)data["level"];
            Experience = (int)data["experience"];
            Background = (string)data["background"];
            Alignment = (string)data["alignment"];
            Stats.Clear();
            foreach (JProperty prop in data["stats"])
            {
                Stats.Set(prop.Name, (int)data["stats"][prop.Name]);
            }
            ProficiencyBonus = (int)data["proficiencyBonus"];
            ArmorClass = (int)data["armorClass"];
            InitiativeModifier = (int)data["initiativeModifier"];
            Initiative = (int)data["initiative"];
            Speed = (int)data["speed"];
            Size = (string)data["size"];
            CurrentHitPoints = (int)data["currentHitPoints"];
            TemporaryHitPoints = (int)data["temporaryHitPoints"];
            PersonalityTraits = (string)data["personalityTraits"];
            Ideals = (string)data["ideals"];
            Bonds = (string)data["bonds"];
            Flaws = (string)data["flaws"];
            HitDice = (int)data["hitDice"];
            DeathSavesFail = (int)data["deathSavesFail"];
            DeathSavesSuccess = (int)data["deathSavesSuccess"];
            FeaturesAndTraits = (string)data["featuresAndTraits"];
            OtherProficienciesAndLanguages = (string)data["otherProficienciesAndLanguages"];
            Money.Clear();
            foreach (JProperty prop in data["money"])
            {
                Money.Set(prop.Name, (int)data["money"][prop.Name]);
            }
            Items.Clear();
            foreach (JProperty prop in data["items"])
            {
                Items.Add((int)data["items"][prop.Name]);
            }
            AttacksAndSpells.Clear();
            foreach (JProperty prop in data["attacksAndSpells"])
            {
                AttacksAndSpells.Add((int)data["attacksAndSpells"][prop.Name]);
            }
            Saves.Clear();
            foreach (JProperty prop in data["saves"])
            {
                Saves.Set(prop.Name, (string)data["saves"][prop.Name]);
            }
            Skills.Clear();
            foreach (JProperty prop in data["skills"])
            {
                Skills.Set(prop.Name, (string)data["skills"][prop.Name]);
            }
            PassiveWisdomPerception = (int)data["passiveWisdomPerception"];
            Age = (string)data["age"];
            AlliesAndOrgs = (string)data["alliesAndOrgs"];
        }
    }
}