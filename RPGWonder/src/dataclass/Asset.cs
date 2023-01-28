namespace RPGWonder
{
    class Asset
    {
        private readonly string _src;
        public Asset(string src)
        {
            _src = src;
        }

        public string Src => _src;
    }
}
