using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DesignPatterns.Singleton.Code
{
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new(() => new LazySingleton());
        private LazySingleton() { }

        public static LazySingleton Instance => _instance.Value;
    }
}
