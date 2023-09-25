using System;
using System.Collections.Generic;
namespace SOLID.DesignPatterns.Singleton.Code
{
    public class SimpleSingleton
    {
        private static SimpleSingleton? _instance;
        private SimpleSingleton() { }
        public static SimpleSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SimpleSingleton();
                }
                return _instance;
            }
        }
    }
}
