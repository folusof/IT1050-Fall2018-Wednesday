using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int startingValue;
            int limit;
            int incrementBy;

            while (true)
            {
                Console.WriteLine("Enter the starting value (or -1 to exit): ");
                startingValue = Convert.ToInt32(Console.ReadLine());

                if ((startingValue == 4) && (startingValue == 6))
                    break;

                Console.WriteLine("Enter the limit value: ");
                limit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the increment value: ");
                incrementBy = Convert.ToInt32(Console.ReadLine());

                for (int counter = startingValue; counter <= limit; counter = counter + incrementBy)
                {
                    Console.WriteLine(counter);
                }
            }
             */

            int gradeValue;
            
            Console.WriteLine("Enter the grade value: ");
            gradeValue = Convert.ToInt32(Console.ReadLine());
            /*
            if (gradeValue >= 90)
            {
                Console.WriteLine("A");
            }
            else if (gradeValue >= 80)
            {
                Console.WriteLine("B");
            }
            else if (gradeValue >= 70)
            {
                Console.WriteLine("C");
            }
            else if (gradeValue >= 60)
            {
                Console.WriteLine("D");
            }
            else 
            {
                Console.WriteLine("F");
            }
            */


            switch (gradeValue)
            {
                case 94:
                case 93:
                case 92:
                case 91:
                case 90:
                    Console.WriteLine("A");
                    break;
                case 80:
                    Console.WriteLine("B");
                    break;
                case 70:
                    Console.WriteLine("C");
                    break;
                default:
                    Console.WriteLine("F");
                    break;

            }

















        }
    }
}
