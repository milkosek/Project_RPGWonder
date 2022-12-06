using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace RPGWonder
{
    public sealed class Common
    {
        private static Common instance = null;

        Common(
                JObject races,
                JObject classes,
                JObject backgrounds,
                JObject genders,
                JObject alignments,
                JObject defines,
                JObject proficiencies,
                JObject stats,
                JObject racialIncreases,
                JObject skills,
                JObject levels
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
        public JObject Races;
        public JObject Classes;
        public JObject Backgrounds;
        public JObject Genders;
        public JObject Alignments;
        public JObject Defines;
        public JObject Proficiencies;
        public JObject Stats;
        public JObject RacialIncreases;
        public JObject Skills;
        public JObject Levels;
        public static Common Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Common(
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Races.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Classes.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Backgrounds.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Genders.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Alignments.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Defines.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Proficiencies.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Stats.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\RacialIncreases.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Skills.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Levels.json"))
                        );
                }
                return instance;
            }
        }
    }
}