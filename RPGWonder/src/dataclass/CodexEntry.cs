using Newtonsoft.Json;
using System.IO;

namespace RPGWonder
{
    public class CodexEntry : IDataclass
    {
        public string Title;
        public string Text;
        public void ReadFromJSON(string path)
        {
            string jsonString = File.ReadAllText(path);
            JsonConvert.PopulateObject(jsonString, this);
        }

        public void SaveToJSON(string path, string TAG)
        {
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter streamWriter = new StreamWriter(path + "\\" + TAG + ".json"))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
}
