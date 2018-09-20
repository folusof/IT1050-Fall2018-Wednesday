using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string myName = "Howard Dayton";

            Console.WriteLine("Hello ");
            Console.Write("World! " + myName);
            Console.ReadLine();
            */

            Student firstStudent = new Student();
            Student secondStudent = new Student();
            Student thirdStudent = new Student();

            firstStudent.studentName = "Howard";
            secondStudent.studentName = "Anthony";
            thirdStudent.studentName = "Toby";

            Console.WriteLine("Hello, my name is " + firstStudent.studentName );
            Console.WriteLine("Hello, my name is " + secondStudent.studentName);
            Console.WriteLine("Hello, my name is " + thirdStudent.studentName);
            Console.ReadLine();


        }
    }


    
    
}
