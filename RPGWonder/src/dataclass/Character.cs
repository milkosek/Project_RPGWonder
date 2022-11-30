using RPGWonder.src.safedict;
using System.Collections.Generic;

namespace RPGWonder
{
    class Character : Entity
    {
        private string race;
        private string gender;
        private string characterClass;
        private int level;
        private string background;
        private string alignment;
        private Safedict<string, int> stats = new Safedict<string, int>();
        private int proficiencyBonus;
        private int armorClass;
        private int initiativeModifier;
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
        private Safedict<string, int> money = new Safedict<string, int>();
        private List<int> items = new List<int>();
        private List<int> attacksAndSpells = new List<int>();
        private Safedict<string, string> saves = new Safedict<string, string>();
        private Safedict<string, string> skills = new Safedict<string, string>();
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
        public int ArmorClass { get => armorClass; set => armorClass = value; }
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
        public Safedict<string, int> Money { get => money; set => money = value; }
        public string Age { get => age; set => age = value; }
        public string Height { get => height; set => height = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Eyes { get => eyes; set => eyes = value; }
        public string Skin { get => skin; set => skin = value; }
        public string Hair { get => hair; set => hair = value; }
        public string Race { get => race; set => race = value; }
        public string Gender { get => gender; set => gender = value; }
        public Safedict<string, string> Skills { get => skills; set => skills = value; }
        public Safedict<string, int> Stats { get => stats; set => stats = value; }
        public Safedict<string, string> Saves { get => saves; set => saves = value; }
        public string AlliesAndOrgs { get => alliesAndOrgs; set => alliesAndOrgs = value; }
        public int InitiativeModifier { get => initiativeModifier; set => initiativeModifier = value; }
        internal List<int> Items { get => items; set => items = value; }
        internal List<int> AttacksAndSpells { get => attacksAndSpells; set => attacksAndSpells = value; }
    }
}