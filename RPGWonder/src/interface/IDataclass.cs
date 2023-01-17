namespace RPGWonder
{

    /// <summary>
    /// Interface that defines the basic functionality for a data class.
    /// </summary>
    public interface IDataclass
    {

        /// <summary>
        /// Saves the data to a JSON file at the specified path with the specified tag.
        /// </summary>
        /// <param name="path">The path to the JSON file.</param>
        /// <param name="TAG">The tag to be used when saving the data.</param>
        void SaveToJSON(string path, string TAG);

        /// <summary>
        /// Reads the data from a JSON file at the specified path.
        /// </summary>
        /// <param name="path">The path to the JSON file.</param>
        void ReadFromJSON(string path);
    }
}
