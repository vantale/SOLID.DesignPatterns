namespace SOLID.DesignPatterns.Singleton.Code
{
    //Singleton implementation using single lock
    public sealed class MultiThreadedSingleLockSingleton
    {
        /*
        * We are using volatile to ensure
        * that assignment to the instance variable finishes
        * before it's access.
        */
        private static volatile MultiThreadedSingleLockSingleton? _instance;
        private static readonly object lockObject = new();
        private MultiThreadedSingleLockSingleton() { }
        public static MultiThreadedSingleLockSingleton GetInstance
        {
            get
            {
                // Locking it first
                lock (lockObject)
                {
                    // Single check
                    if (_instance == null)
                    {
                        _instance = new MultiThreadedSingleLockSingleton();
                    }
                }
                return _instance;
            }
        }
    }
}
