using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek13
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Ford", "Mustang");

            Car car2 = new Car("Chevy", "Camaro", 1999, "Red");

            //car2.Display1();

            Console.WriteLine( car2.Display2() );

            for (int i = 0; i < 60; i++)
            {
                car2.SpeedUp();
            }

            car2.Display3();

        }
    }
}
