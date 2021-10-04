using AbstractFactory;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory
            var discover = new Discover();
            var southAmerica = new SouthAmerica(discover);
            southAmerica.DiedSouthAmerica();
            // end history



            Console.ReadKey();

        }
    }
}
