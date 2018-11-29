using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek12
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Initializer
            string[] students = { "David Dente", "Nico Graham", "Toby Bird", "Josh Rayle", "Wendy Ford" };

            Console.WriteLine(students[1]);

            Console.WriteLine(students[4]);                     //This
            Console.WriteLine(students[students.Length - 1]);   // or That


            string[]   months = new string[12];

            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "Ocotber";
            months[10] = "November";
            months[11] = "December";

            int j = 0;
            foreach(string month in months)
            {
                Console.WriteLine( (++j) + "  " +  month);
            }

            //for (int i = 0; i < months.Length; i++)
            //{
            //    //Console.WriteLine((i + 1) + " " + months[i]);

            //    Console.Write(i + 1);
            //    Console.Write(": ");
            //    Console.WriteLine(months[i]);
            //}


            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }
//---------------------
            int[] randomNum = new int[1000];
            Random random = new Random();

            for (int a = 0; a < randomNum.Length; a++)
            {
                randomNum[a] = random.Next(0, 1000);
            }

            foreach (int i in randomNum)
            {
                Console.WriteLine(i.ToString());
            }
//---------------------
        }
    }
}
