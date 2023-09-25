using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DesignPatterns.Singleton.Code
{
    /*
    public class DerivedSingleton2: ParentSingleton
    {

    }
    */
    public class ParentSingleton
    {
        private static ParentSingleton? _instance;
        private ParentSingleton() { }
        public static ParentSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ParentSingleton();
                }
                return _instance;
            }
        }

        public class DerivedSingleton : ParentSingleton
        {

        }
    }
}
