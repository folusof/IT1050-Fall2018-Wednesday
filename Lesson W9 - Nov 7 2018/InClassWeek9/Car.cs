using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek9
{
    class Car
    {
        public  string  make;
        public  string  model;
        public  int     year;
        public  string  color;
        
        private int     speed;
        private int     topSpeed;

        public void setTopSpeed(int pTopSpeed)
        {
            this.topSpeed = pTopSpeed;
        }

        public int getSpeed()
        {
            return speed;
        }

        public void Honk()
        {
            Console.WriteLine("Honk Honk");
        }

        public void Beep()
        {
            Console.WriteLine("Beep Beep");
        }


        public void speedUp()
        {
            if (speed < topSpeed)
            {
                speed++;
            }
            Console.WriteLine("Speeding Up....");
        }

        public void slowDown()
        {
            if (speed > 0)
            {
                speed--;
            }
            Console.WriteLine("Slowing Down....");
        }

        public void ToString()
        {
            Console.WriteLine("I'm a " + make + " " + model + " and I'm going " + speed + "mph");
        }
    }
}
