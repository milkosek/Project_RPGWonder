using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGWonder
{
    class Character : Entity
    {
        private string race;
        private string gender;
        private string characterName;
        private string characterClass;
        private int level;
        private string background;
        private string alignment;
        private Dictionary<string, int> stats = new Dictionary<string, int>();
        private int proficiencyBonus;
        private int armourClass;
        private int initiative;
        private int speed;
        private int currentHitPoints;
        private int temporaryHitPoints;
        private string personalityTraits;
        private string ideals;
        private string bonds;
        private string flaws;
        private int hitDice;
        private int deathSavesFail;
        private int deathSavesSuccess;
        private string featuresAndTraits;
        private string otherProficienciesAndLanguages;
        private List<int> money;
        private List<Entity> items;
        private List<AttackOrSpell> attacksAndSpells;
        private int saveStrength;
        private int saveDexterity;
        private int saveConstitution;
        private int saveIntelligence;
        private int saveWisdom;
        private int saveCharisma;
        private Dictionary<string, string> skills = new Dictionary<string, string>();
        private int passiveWisdomPerception;
        private string age;
        private string height;
        private string weight;
        private string eyes;
        private string skin;
        private string hair;
        private string alliesAndOrgs;


        public int PassiveWisdomPerception { get => passiveWisdomPerception; set => passiveWisdomPerception = value; }
        public string CharacterClass { get => characterClass; set => characterClass = value; }
        public int Level { get => level; set => level = value; }
        public string Background { get => background; set => background = value; }
        public string Alignment { get => alignment; set => alignment = value; }
        public int ProficiencyBonus { get => proficiencyBonus; set => proficiencyBonus = value; }
        public int ArmourClass { get => armourClass; set => armourClass = value; }
        public int Initiative { get => initiative; set => initiative = value; }
        public int Speed { get => speed; set => speed = value; }
        public int CurrentHitPoints { get => currentHitPoints; set => currentHitPoints = value; }
        public int TemporaryHitPoints { get => temporaryHitPoints; set => temporaryHitPoints = value; }
        public string PersonalityTraits { get => personalityTraits; set => personalityTraits = value; }
        public string Ideals { get => ideals; set => ideals = value; }
        public string Bonds { get => bonds; set => bonds = value; }
        public string Flaws { get => flaws; set => flaws = value; }
        public int HitDice { get => hitDice; set => hitDice = value; }
        public int DeathSavesFail { get => deathSavesFail; set => deathSavesFail = value; }
        public int DeathSavesSuccess { get => deathSavesSuccess; set => deathSavesSuccess = value; }
        public string FeaturesAndTraits { get => featuresAndTraits; set => featuresAndTraits = value; }
        public string OtherProficienciesAndLanguages { get => otherProficienciesAndLanguages; set => otherProficienciesAndLanguages = value; }
        public List<int> Money { get => money; set => money = value; }
        public int SaveStrength { get => saveStrength; set => saveStrength = value; }
        public int SaveDexterity { get => saveDexterity; set => saveDexterity = value; }
        public int SaveConstitution { get => saveConstitution; set => saveConstitution = value; }
        public int SaveIntelligence { get => saveIntelligence; set => saveIntelligence = value; }
        public int SaveWisdom { get => saveWisdom; set => saveWisdom = value; }
        public int SaveCharisma { get => saveCharisma; set => saveCharisma = value; }
        public string CharacterName { get => characterName; set => characterName = value; }
        public string Age { get => age; set => age = value; }
        public string Height { get => height; set => height = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Eyes { get => eyes; set => eyes = value; }
        public string Skin { get => skin; set => skin = value; }
        public string Hair { get => hair; set => hair = value; }
        public string Race { get => race; set => race = value; }
        public string Gender { get => gender; set => gender = value; }
        public Dictionary<string, string> Skills { get => skills; set => skills = value; }
        public Dictionary<string, int> Stats { get => stats; set => stats = value; }

        internal AttackOrSpell AttackOrSpell
        {
            get => default;
            set
            {
            }
        }

        internal List<Entity> Items { get => items; set => items = value; }
        internal List<AttackOrSpell> AttacksAndSpells { get => attacksAndSpells; set => attacksAndSpells = value; }
    }
}
