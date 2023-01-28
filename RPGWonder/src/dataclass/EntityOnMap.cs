namespace RPGWonder
{
    class EntityOnMap
    {
        private long _entityID;
        private long _mapID;
        private int _x;
        private int _y;
        private string _name;
        private string _imagePath;

        public EntityOnMap(long entityID, long mapID, int coordinatex, int coordinatey, string imagePath)
        {
            _entityID = entityID;
            _mapID = mapID;
            _x = coordinatex;
            _y = coordinatey;
            _imagePath = imagePath;
        }

        public long EntityID { get => _entityID; set => _entityID = value; }
        public long MapID { get => _mapID; set => _mapID = value; }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public string Name { get => _name; set => _name = value; }
        public string ImagePath { get => _imagePath; set => _imagePath = value; }
    }
}
