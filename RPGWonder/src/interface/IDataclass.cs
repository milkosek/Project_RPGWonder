    namespace RPGWonder
{
    public interface IDataclass
    {
        void SaveToJSON(string path, string TAG);
        void ReadFromJSON(string path);
    }
}
