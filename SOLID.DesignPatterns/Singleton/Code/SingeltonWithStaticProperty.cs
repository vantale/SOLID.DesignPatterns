using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DesignPatterns.Singleton.Code
{
    internal class SingeltonWithStaticProperty
    {
        public static SingeltonWithStaticProperty Instance { get; } = new ();
        private SingeltonWithStaticProperty() { }
    }
}
