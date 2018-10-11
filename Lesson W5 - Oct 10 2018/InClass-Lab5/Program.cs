using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           int num01 = 23;
           if (num01 == 40)            {
               Console.WriteLine("num01 is equal to 40");
           }
           else            {
               Console.WriteLine("num01 is not equal to 40");
           }
            
           bool isCold;

           isCold = false;
           if (isCold)
           {
               Console.WriteLine("It is cold");
           }
           else
           {
               Console.WriteLine("It is hot");
           }
           */


            int grade;

            //grade = 75;

            Console.WriteLine("Enter a grade value:");
            grade = int.Parse(Console.ReadLine());


            while (grade > 0)
            {
                if (grade >= 90)
                {
                    Console.WriteLine("A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("D");
                }
                else if (grade > 0)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    Console.WriteLine("Invalid grade");
                }

                Console.WriteLine("Enter a grade value:");
                grade = int.Parse(Console.ReadLine());
            }
            /*
            int i = 0;

            while (i < 11)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
             */

        }
    }
}
