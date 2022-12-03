using Newtonsoft.Json;
using RPGWonder.src.safedict;
using RPGWonder.src.utils;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RPGWonder
{
    class Character : Entity
    {
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
        public Character(string race, string gender, string characterClass, int level, int experience, string background, string alignment, Safedict<string, int> stats, int proficiencyBonus, int armorClass, int initiativeModifier, int initiative, int speed, string size, int currentHitPoints, int temporaryHitPoints, string personalityTraits, string ideals, string bonds, string flaws, int hitDice, int deathSavesFail, int deathSavesSuccess, string featuresAndTraits, string otherProficienciesAndLanguages, Safedict<string, int> money, List<int> items, List<int> attacksAndSpells, Safedict<string, string> saves, Safedict<string, string> skills, int passiveWisdomPerception, string age, string alliesAndOrgs)
        {
            Race = race;
            Gender = gender;
            CharacterClass = characterClass;
            Level = level;
            Experience = experience;
            Background = background;
            Alignment = alignment;
            Stats = stats;
            ProficiencyBonus = proficiencyBonus;
            ArmorClass = armorClass;
            InitiativeModifier = initiativeModifier;
            Initiative = initiative;
            Speed = speed;
            Size = size;
            CurrentHitPoints = currentHitPoints;
            TemporaryHitPoints = temporaryHitPoints;
            PersonalityTraits = personalityTraits;
            Ideals = ideals;
            Bonds = bonds;
            Flaws = flaws;
            HitDice = hitDice;
            DeathSavesFail = deathSavesFail;
            DeathSavesSuccess = deathSavesSuccess;
            FeaturesAndTraits = featuresAndTraits;
            OtherProficienciesAndLanguages = otherProficienciesAndLanguages;
            Money = money;
            Items = items;
            AttacksAndSpells = attacksAndSpells;
            Saves = saves;
            Skills = skills;
            PassiveWisdomPerception = passiveWisdomPerception;
            Age = age;
            AlliesAndOrgs = alliesAndOrgs;
        }
        public void SaveToJSON()
        {
            StringBuilder sb;
            StringWriter sw;
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\characters";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(path + "\\Counter.json"))
            {
                File.Create(path + "\\Counter.json").Close();
                sb = new StringBuilder();
                sw = new StringWriter(sb);
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartObject();
                    writer.WritePropertyName("max-id");
                    writer.WriteValue(0);
                    writer.WriteEnd();
                }
                File.WriteAllText(path + "\\Counter.json", sb.ToString());
            }
            Dictionary<string, string> Counter = Utils.parseJSON<Dictionary<string, string>>(path + "\\Counter.json");
            int maxId = int.Parse(Counter["max-id"]);
            File.Create(path + "\\" + maxId + ".json").Close();
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
                writer.WritePropertyName("type");
                writer.WriteValue(Type);
                writer.WritePropertyName("description");
                writer.WriteValue(Description);
                writer.WritePropertyName("src");
                writer.WriteValue(Src);
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
                writer.WritePropertyName("initiative-modifier");
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
            File.WriteAllText(path + "\\" + maxId + ".json", sb.ToString());
            sb = new StringBuilder();
            sw = new StringWriter(sb);
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();
                writer.WritePropertyName("max-id");
                writer.WriteValue(maxId + 1);
                writer.WriteEnd();
            }
            File.WriteAllText(path + "\\Counter.json", sb.ToString());
        }
    }
}