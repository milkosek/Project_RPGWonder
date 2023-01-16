using log4net;
using log4net.Config;

namespace RPGWonder
{
    public sealed class Log
    {
        private static Log instance = null;
        public ILog errorLog;
        public ILog gameLog;

        Log()
        {
            XmlConfigurator.Configure();
            errorLog = LogManager.GetLogger("ErrorLogger");
            gameLog = LogManager.GetLogger("GameLogger");
        }

        public static Log Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Log();
                }
                return instance;
            }
        }
    }
}
