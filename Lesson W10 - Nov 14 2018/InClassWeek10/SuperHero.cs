using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek10
{
    class SuperHero
    {
        private     string		Name;
        public      string		Power;
        public      int         skillLevel;
        public      int         Health;
        private     string      AlterEgo;
        public      string      Alignment;
        public      string      Weakness;
        private     int         Age;
        public      string      Gender;
        public      string      Sidekicks;

        public void setName(string pName) 
        {
            this.Name = pName;
        }

        public string getName()
        {
            return this.Name;
        }


        public 	string 	Attack(string target)
        {
            return "";
        }

        public 	string	Defense (string target)
        {
            return "";
        }

        public 	int	PowerUp(int amount, bool boost)
        {
            this.skillLevel = this.skillLevel + amount;

            if (boost == true)
            {
                this.skillLevel = this.skillLevel + amount;
            }

            return 0;
        }

        public int heal(int amount, int duration)
        {

            return 0;
        }


    }
}
