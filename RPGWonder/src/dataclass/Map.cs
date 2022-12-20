using System.Collections.Generic;

namespace RPGWonder
{
    class Map : Asset
    {
        // The ID of the map
        public long Id;
        // The name of the map
        public string Name;
        // The number of rows in the map
        public int Rows;
        // The number of columns in the map
        public int Columns;

        internal EntityOnMap EntityOnMap
        {
            get => default;
            set
            {
            }
        }

        // Save the map to a JSON file
        public void SaveToJSON(string path)
        {
            // Create a StringBuilder and a StringWriter
            StringBuilder sb;
            StringWriter sw;
            // Check if the directory specified in the path parameter exists
            // If it doesn't, create it
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            // Check if the Maps.json file exists in the specified directory
            // If it doesn't, create it and write some default data to it
            if (!File.Exists(path + "\\Maps.json"))
            {
                File.Create(path + "\\Maps.json").Close();
                sb = new StringBuilder();
                sw = new StringWriter(sb);
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartObject();
                    writer.WritePropertyName("max-id");
                    writer.WriteValue(0);
                    writer.WritePropertyName("maps");
                    writer.WriteStartArray();
                    writer.WriteEndArray();
                    writer.WriteEnd();
                }
                File.WriteAllText(path + "\\Maps.json", sb.ToString());
            }
            // Parse the Maps.json file and get the current maximum ID of the maps stored in it
            JObject data = JObject.Parse(File.ReadAllText(path + "\\Maps.json"));
            long maxId = (long)data["max-id"];
            // Create a new JSON object containing the map data and add it to the Maps.json file
            sb = new StringBuilder();
            sw = new StringWriter(sb);
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();
                writer.WritePropertyName("id");
                writer.WriteValue(maxId);

                writer.WritePropertyName("name");
                writer.WriteValue(Name);
                writer.WritePropertyName("rows");
                writer.WriteValue(Rows);
                writer.WritePropertyName("columns");
                writer.WriteValue(Columns);
                writer.WriteEnd();
            }
            // Increment the max-id value in the Maps.json file
            data["max-id"] = maxId + 1;
            // Add the new map to the array of maps in the Maps.json file
            ((JArray)data["maps"]).Add("\\" + Name + ".json");
            // Write the updated Maps.json file to the specified directory
            File.WriteAllText(path + "\\Maps.json", data.ToString());
        }

        // Read a map from a JSON file
        public void ReadFromJSON(string path)
        {
            // Parse the JSON data from the specified file
            JObject data = JObject.Parse(File.ReadAllText(path));
            // Set the Map object's properties according to the JSON data
            Id = (int)data["id"];
            Name = (string)data["name"];
            Columns = (int)data["columns"];
            Rows = (int)data["rows"];
        }
    }
}