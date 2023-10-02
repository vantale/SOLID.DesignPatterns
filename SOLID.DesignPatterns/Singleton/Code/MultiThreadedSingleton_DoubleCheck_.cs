namespace SOLID.DesignPatterns.Singleton.Code
{
    public sealed class MultiThreadedSingleton_
    {
        private static volatile MultiThreadedSingleton_? _instance;
        private static readonly object lockObject = new();
        private MultiThreadedSingleton_() { }
        public static MultiThreadedSingleton_ GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObject)
                    {
                        if (_instance == null)
                            _instance = new MultiThreadedSingleton_();
                    }
                }
                return _instance;
            }
        }
    }

}