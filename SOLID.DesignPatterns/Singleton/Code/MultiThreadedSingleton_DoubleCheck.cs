namespace SOLID.DesignPatterns.Singleton.Code
{
    // Singleton implementation using double checked locking.
    public sealed class MultiThreadedSingleton
    {
        /*
        * We are using volatile to ensure
        * that assignment to the instance variable finishes
        * before it's accessed.
        */
        private static volatile MultiThreadedSingleton? _instance;
        private static readonly object lockObject = new();
        private MultiThreadedSingleton() { }
        public static MultiThreadedSingleton GetInstance
        {
            get
            {
                // First Check
                if (_instance == null)
                {
                    lock (lockObject)
                    {
                        // Second(Double) Check
                        if (_instance == null)
                            _instance = new MultiThreadedSingleton();
                    }
                }
                return _instance;
            }
        }
    }

}