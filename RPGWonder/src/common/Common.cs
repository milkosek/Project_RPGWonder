using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;

namespace RPGWonder
{
    public sealed class Common
    {
        /// <summary>
        /// A singleton instance of the Common class.
        /// </summary>
        private static Common instance = null;
        Common(
                JObject races,
                JObject classes,
                JObject backgrounds,
                JObject genders,
                JObject alignments,
                JObject defines,
                JObject proficiencies,
                JObject abilities,
                JObject skills,
                JObject levels
            )
        {
            Debug.WriteLine("Loading races");
            Races = races;
            Debug.WriteLine("Loading classes");
            Classes = classes;
            Debug.WriteLine("Loading backgrounds");
            Backgrounds = backgrounds;
            Debug.WriteLine("Loading genders");
            Genders = genders;
            Debug.WriteLine("Loading alignments");
            Alignments = alignments;
            Debug.WriteLine("Loading defines");
            Defines = defines;
            Debug.WriteLine("Loading proficiencies");
            Proficiencies = proficiencies;
            Debug.WriteLine("Loading abilities");
            Abilities = abilities;
            Debug.WriteLine("Loading skills");
            Skills = skills;
            Debug.WriteLine("Loading levels");
            Levels = levels;
        }
        public JObject Races;
        public JObject Classes;
        public JObject Backgrounds;
        public JObject Genders;
        public JObject Alignments;
        public JObject Defines;
        public JObject Proficiencies;
        public JObject Abilities;
        public JObject Skills;
        public JObject Levels;

        /// <summary>
        /// Private constructor for the Common class.
        /// </summary>
        /// <param name="races">A JObject containing information about the races in the game.</param>
        /// <param name="classes">A JObject containing information about the classes in the game.</param>
        /// <param name="backgrounds">A JObject containing information about the backgrounds in the game.</param>
        /// <param name="genders">A JObject containing information about the genders in the game.</param>
        /// <param name="alignments">A JObject containing information about the alignments in the game.</param>
        /// <param name="defines">A JObject containing information about the defines in the game.</param>
        /// <param name="proficiencies">A JObject containing information about the proficiencies in the game.</param>
        /// <param name="stats">A JObject containing information about the stats in the game.</param>
        /// <param name="skills">A JObject containing information about the skills in the game.</param>
        /// <param name="levels">A JObject containing information about the levels in the game.</param>
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
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Abilities.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Skills.json")),
                            JObject.Parse(File.ReadAllText("..\\..\\systemPresets\\" + Properties.Settings.Default.System + "\\Levels.json"))
                        );
                }
                return instance;
            }
        }
    }
}