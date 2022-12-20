namespace RPGWonder
{
    class Entity : Asset
    {
        private long id;
        private string name;
        private string type;
        private string description;
        private string src;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public string Src { get => src; set => src = value; }
    }
}
