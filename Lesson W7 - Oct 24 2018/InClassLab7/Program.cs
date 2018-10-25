using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i;

            //i = 0;

            //while (i <= 25)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("while output ");
            //    i++;
            //}

            //for (i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i*3);
            //}

            /*
            int userInput = 1;

            do 
            {
                Console.Write("Enter 0 to end: ");
                userInput = Convert.ToInt32(Console.ReadLine());

            } while (userInput != 0);

            while (1)
            {
                Console.WriteLine(i);
            }
            */

            int i;
            int j;

            for (i = 1; i < 11; i++)
            {
                for (j = i; j < 11; j++)
                {
                    Console.WriteLine(i + ", " + j);
                }
            }














        }
    }
}
