using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek9
{
    class Program
    {
        static void Main(string[] args)
        {


            Car myFirstCar = new Car();
            Car mySecondCar = new Car();
            Car myThirdCar = new Car();

            myFirstCar.make = "Chevy";
            myFirstCar.model = "Camaro";
            //myFirstCar.topSpeed = 280;
            myFirstCar.setTopSpeed(280);
//            myFirstCar.speedUp();
//            myFirstCar.speedUp();
            //Console.WriteLine(myFirstCar.getSpeed());
            for (int i = 0; i <= 200; i++)
            {
                myFirstCar.speedUp();
            }
                myFirstCar.ToString();

        }
    }
}
