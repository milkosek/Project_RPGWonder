namespace RPGWonder
{
    public interface IDataclass
    {
        void SaveToJSON(string path);
        void ReadFromJSON(string path);
    }
}
