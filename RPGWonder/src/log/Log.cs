using log4net;
using log4net.Config;

namespace RPGWonder
{

    /// <summary>
    /// A singleton class that provides logging functionality.
    /// </summary>
    public sealed class Log
    {
        private static Log _instance = null;

        /// <summary>
        /// The error log.
        /// </summary>
        public ILog errorLog;

        /// <summary>
        /// The game log.
        /// </summary>
        public ILog gameLog;

        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        Log()
        {
            XmlConfigurator.Configure();
            errorLog = LogManager.GetLogger("ErrorLogger");
            gameLog = LogManager.GetLogger("GameLogger");
        }

        /// <summary>
        /// Gets the _instance of the <see cref="Log"/> class.
        /// </summary>
        public static Log Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Log();
                }
                return _instance;
            }
        }
    }
}
