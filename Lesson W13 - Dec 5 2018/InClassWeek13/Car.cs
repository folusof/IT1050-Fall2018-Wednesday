using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek13
{
    class Car
    {
        private string  Make;
        private string  Model;
        private int     Year;
        private int     Speed;
        private string  Color;
        private string  Transmission;
        private int     Mileage;

        public Car(string pMake, string pModel)
        {
            this.Make = pMake;
            this.Model = pModel;
        }

        public Car(string pMake, string pModel, int pYear, string pColor)
        {
            this.Make = pMake;
            this.Model = pModel;
            this.Year = pYear;
            this.Color = pColor;
        }

        public Car(string pMake, int pYear)
        {
            this.Make = pMake;
            this.Year = pYear;
        }

        public void Display1()
        {
            Console.WriteLine("My " + Year + " " + this.Make + " " + this.Model + " is " + this.Color);
        }

        public string Display2()
        {
            string sDisplay;

            sDisplay = "My " + Year + " " + this.Make + " " + this.Model + " is " + this.Color;
            return sDisplay;
        }

        public void Display3()
        {
            Console.WriteLine("My " + Year + " " + this.Make + " " + this.Model + 
                                " is going " + this.Speed + " MPH.");
        }

        public void SpeedUp()
        {
            this.Speed++;
        }

    }
}
