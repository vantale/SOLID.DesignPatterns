namespace SOLID.DesignPatterns.Singleton.Lazy
{
    internal class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _lazy = new(() => new LazySingleton());
        public static LazySingleton Instance { get { return _lazy.Value; } }
        private LazySingleton()
        {
        }
    }
}
