using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dAmount1;
            decimal dAmount2;
            decimal dAmount3;
            decimal dResult;

            // User enters 1st number
            Console.WriteLine("Enter the amount for the first number:");
            dAmount1 = decimal.Parse(Console.ReadLine());

            // User enters 2nd number
            Console.WriteLine("Enter the amount for the second number:");
            dAmount2 = decimal.Parse(Console.ReadLine());

            // User enters 3rd number
            Console.WriteLine("Enter the amount for the third number:");
            dAmount3 = decimal.Parse(Console.ReadLine());

            // Display result
            dResult = dAmount1 + dAmount2 - dAmount3;
            Console.WriteLine("The result of {0:C} + {1:C} - {2:C} is \\ {3:C}",dAmount1,dAmount2,dAmount3,dResult);
        }
    }
}
