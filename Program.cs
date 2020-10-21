using System;
using Prototype.Factory;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit1 = UnitFactory.newHumanUnit("Vasia", "small");
            var unit2 = UnitFactory.newElfUnit("Masha", "middle");

            Console.WriteLine(unit1);
            Console.WriteLine(unit2);
        }
    }
}
