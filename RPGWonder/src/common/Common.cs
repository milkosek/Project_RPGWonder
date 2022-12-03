using RPGWonder.src.utils;
using System.Collections.Generic;

namespace RPGWonder
{
    public sealed class Common
    {
        private static Common instance = null;

        Common(
                Dictionary<string, Dictionary<string, string>> races,
                Dictionary<string, string> classes,
                Dictionary<string, string> backgrounds,
                Dictionary<string, string> genders,
                Dictionary<string, string> alignments,
                Dictionary<string, string> defines,
                Dictionary<string, string> proficiencies,
                Dictionary<string, Dictionary<string, string>> stats,
                Dictionary<string, Dictionary<string, string>> racialIncreases,
                Dictionary<string, Dictionary<string, string>> skills,
                Dictionary<string, Dictionary<string, string>> levels
            )
        {
            Races = races;
            Classes = classes;
            Backgrounds = backgrounds;
            Genders = genders;
            Alignments = alignments;
            Defines = defines;
            Proficiencies = proficiencies;
            Stats = stats;
            RacialIncreases = racialIncreases;
            Skills = skills;
            Levels = levels;
        }
        public Dictionary<string, Dictionary<string, string>> Races;
        public Dictionary<string, string> Classes;
        public Dictionary<string, string> Backgrounds;
        public Dictionary<string, string> Genders;
        public Dictionary<string, string> Alignments;
        public Dictionary<string, string> Defines;
        public Dictionary<string, string> Proficiencies;
        public Dictionary<string, Dictionary<string, string>> Stats;
        public Dictionary<string, Dictionary<string, string>> RacialIncreases;
        public Dictionary<string, Dictionary<string, string>> Skills;
        public Dictionary<string, Dictionary<string, string>> Levels;
        public static Common Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Common(
                            Utils.parseJSON<Dictionary<string, Dictionary<string, string>>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Races.json"),
                            Utils.parseJSON<Dictionary<string, string>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Classes.json"),
                            Utils.parseJSON<Dictionary<string, string>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Backgrounds.json"),
                            Utils.parseJSON<Dictionary<string, string>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Genders.json"),
                            Utils.parseJSON<Dictionary<string, string>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Alignments.json"),
                            Utils.parseJSON<Dictionary<string, string>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Defines.json"),
                            Utils.parseJSON<Dictionary<string, string>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Proficiencies.json"),
                            Utils.parseJSON<Dictionary<string, Dictionary<string, string>>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Stats.json"),
                            Utils.parseJSON<Dictionary<string, Dictionary<string, string>>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\RacialIncreases.json"),
                            Utils.parseJSON<Dictionary<string, Dictionary<string, string>>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Skills.json"),
                            Utils.parseJSON<Dictionary<string, Dictionary<string, string>>>
                            ("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Levels.json")
                        );
                }
                return instance;
            }
        }
    }
}