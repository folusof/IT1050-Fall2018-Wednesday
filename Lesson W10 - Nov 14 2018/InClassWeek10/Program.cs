using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek10
{
    class Program
    {
        static void Main(string[] args)
        {

            SuperHero SuperHero1 = new SuperHero();
            SuperHero SuperHero2 = new SuperHero();
            SuperHero SuperHero3 = new SuperHero();

            SuperHero1.setName("Spiderman");
            SuperHero2.setName("Superman");
            SuperHero3.setName("Wonder Woman");

            SuperHero1.PowerUp(100, false);
            SuperHero2.PowerUp(100, true);
            SuperHero3.PowerUp(200, true);

            Console.WriteLine(SuperHero1.getName() + " has a skill level of " + SuperHero1.skillLevel );
            Console.WriteLine(SuperHero2.getName() + " has a skill level of " + SuperHero2.skillLevel);
            Console.WriteLine(SuperHero3.getName() + " has a skill level of " + SuperHero3.skillLevel);
        }
    }
}
