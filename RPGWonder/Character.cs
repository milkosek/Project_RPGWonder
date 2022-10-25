using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGWonder
{
    class Character : Entity
    {
        private string characterClass;
        private int level;
        private string background;
        private string alignment;
        private int strength;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int wisdom;
        private int charisma;
        private int inspiration;
        private int proficiencyBonus;
        private int armorClass;
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
        private List<Entity> entities;
        private List<AttackOrSpell> attacksAndSpells;
        private int saveStrength;
        private int saveDexterity;
        private int saveConstitution;
        private int saveIntelligence;
        private int saveWisdom;
        private int saveCharisma;
        private bool acrobaticsDEX;
        private bool animalHandlingWIS;
        private bool arcanaINT;
        private bool athleticsSTR;
        private bool deceptionCHA;
        private bool historyINT;
        private bool insightWIS;
        private bool intimidationCHA;
        private bool investigationINT;
        private bool medicineWIS;
        private bool natureINT;
        private bool perceptionWIS;
        private bool performanceCHA;
        private bool persuasionCHA;
        private bool religionINT;
        private bool sleightOfHandDEX;
        private bool stealthDEX;
        private bool survivalWIS;
        private int passiveWisdomPerception;

        internal AttackOrSpell AttackOrSpell
        {
            get => default;
            set
            {
            }
        }
    }
}
