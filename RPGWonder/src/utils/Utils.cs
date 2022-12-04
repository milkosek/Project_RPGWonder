using Newtonsoft.Json;
using System;
using System.IO;

namespace RPGWonder
{
    public static class Utils
    {
        public static returnType parseJSON<returnType>(string path)
        {
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                text.Replace('\n', ' ');
                return JsonConvert.DeserializeObject<returnType>(text);
            }
            else
            {
                throw new Exception("No file " + path);
            }
        }
    }
}
