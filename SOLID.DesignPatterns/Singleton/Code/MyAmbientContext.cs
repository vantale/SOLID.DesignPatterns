using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DesignPatterns.Singleton.Code
{
    public class AmbientContext
    {
        public static AmbientContext Current { get; } = new AmbientContext();
        private AmbientContext() { }
        public static void WriteSomething(string something) 
            => Console.WriteLine($"This is your something: { something}");
    }
}
