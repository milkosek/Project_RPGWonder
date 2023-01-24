    using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;

namespace RPGWonder
{
    public sealed class Common
    {
        /// <summary>
        /// A singleton _instance of the Common class.
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
                JObject levels,
                JObject taskDifficulties,
                JObject sizes
            )
        {
            Log.Instance.gameLog.Debug("Loading races");
            Races = races;
            Log.Instance.gameLog.Debug("Loading classes");
            Classes = classes;
            Log.Instance.gameLog.Debug("Loading backgrounds");
            Backgrounds = backgrounds;
            Log.Instance.gameLog.Debug("Loading genders");
            Genders = genders;
            Log.Instance.gameLog.Debug("Loading alignments");
            Alignments = alignments;
            Log.Instance.gameLog.Debug("Loading defines");
            Defines = defines;
            Log.Instance.gameLog.Debug("Loading proficiencies");
            Proficiencies = proficiencies;
            Log.Instance.gameLog.Debug("Loading abilities");
            Abilities = abilities;
            Log.Instance.gameLog.Debug("Loading skills");
            Skills = skills;
            Log.Instance.gameLog.Debug("Loading levels");
            Levels = levels;
            Log.Instance.gameLog.Debug("Loading task difficulties");
            TaskDifficulties = taskDifficulties;
            Log.Instance.gameLog.Debug("Loading sizes");
            Sizes = sizes;
            CampaignsPath = Properties.Settings.Default.Path + "userData\\" + Properties.Settings.Default.System + "\\campaigns";
            CharactersPath = Properties.Settings.Default.Path + "userData\\" + Properties.Settings.Default.System + "\\characters";
            ClientCampaignsPath = Properties.Settings.Default.Path + "userData\\" + Properties.Settings.Default.System + "\\clientCampaign";
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
        public JObject TaskDifficulties;
        public JObject Sizes;
        public string CampaignsPath;
        public string CharactersPath;
        public string ClientCampaignsPath;

        public static Common Instance
        {
            get
            {
                if (instance == null)
                {
                    try
                    {
                        instance = new Common(
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Races.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Classes.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Backgrounds.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Genders.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Alignments.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Defines.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Proficiencies.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Abilities.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Skills.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Levels.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Task Difficulties.json")),
                            JObject.Parse(File.ReadAllText(Properties.Settings.Default.Path + "systemPresets\\" + Properties.Settings.Default.System + "\\Sizes.json"))
                        );
                    }
                    catch (Exception)
                    {
                        Log.Instance.errorLog.Error("Couldn't read commons!");
                    }
                }
                return instance;
            }
        }
    }
}