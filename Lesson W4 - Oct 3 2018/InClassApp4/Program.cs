using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();

            car1.Make = "Ford";
            car1.Model = "Mustang";
            car2.Make = "Chevy";
            car2.Model = "Camaro";

            car1.Speed = 0;
            
            Console.WriteLine("The make of the first car is {0} {1}", car1.Make, car1.Model); 
            Console.WriteLine("The make of the first car is {0} {1}", car2.Make, car1.Model);

            Console.WriteLine("The speed is {0}", car1.Speed);
            car1.SpeedUp();
            Console.WriteLine("The speed is {0}", car1.Speed);
            car1.SpeedUp();
            car1.SpeedUp();
            Console.WriteLine("The speed is {0}", car1.Speed);

            car1.SlowDown();
            Console.WriteLine("The speed is {0}", car1.Speed);

        }
    }
}
