using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassApp4
{
    class Car
    {
        public string make;
        public string Make 
        {
            get {return make;}
            set { make = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value;}
        }

        private string color;

        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value;}
        }

        public void SpeedUp()
        {
            speed = speed + 10;
        }

        public void SlowDown()
        {
            speed = speed - 10;
        }
    }
}
