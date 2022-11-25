using RPGWonder.src.utils;
using System;
using System.Collections.Generic;

namespace RPGWonder.src.common
{
    public sealed class Common
    {
        private static readonly Common instance = new Common();
        private Common() { }
        public static Common Instance
        {
            get
            {
                return instance;
            }
        }
        public Dictionary<string, string> Races = Utils.parseJSON<Dictionary<string, string>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Races.json") ;
        public Dictionary<string, string> Classnames = Utils.parseJSON<Dictionary<string, string>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Classes.json");
        public Dictionary<string, string> Backgrounds = Utils.parseJSON<Dictionary<string, string>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Backgrounds.json");
        public Dictionary<string, string> Genders = Utils.parseJSON<Dictionary<string, string>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Genders.json");
        public Dictionary<string, string> Alignments = Utils.parseJSON<Dictionary<string, string>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Alignments.json");
        public Dictionary<string, string> Defines =Utils.parseJSON<Dictionary<string, string>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Defines.json");
        public Dictionary<string, string> Proficiencies = Utils.parseJSON<Dictionary<string, string>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Proficiencies.json");
        public Dictionary<string, Dictionary<string, string>> Stats = Utils.parseJSON<Dictionary<string, Dictionary<string, string>>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Stats.json");
        public Dictionary<string, Dictionary<string, string>> RacialIncreases = Utils.parseJSON<Dictionary<string, Dictionary<string, string>>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\RacialIncreases.json");
        public Dictionary<string, Dictionary<string, string>> Skills = Utils.parseJSON<Dictionary<string, Dictionary<string, string>>>
            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Skills.json");
    }
}
