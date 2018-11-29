using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek11
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            string studentName1;
            string studentName2;
            string studentName3;
            string studentName4;
            string studentName5;
            string studentName6;
            string studentName7;
            string studentName8;
            string studentName9;
            string studentName10;

            studentName1 = "Eli";
            studentName2 = "Alex";
            studentName3 = "Josh";
            studentName4 = "Michael O.";
            studentName5 = "Wendy";
            studentName6 = "Anthony";
            studentName7 = "Michael M.";
            studentName8 = "Sean";
            studentName9 = "Toby";
            studentName10 = "Eleasar";

            Console.WriteLine(studentName1 + " is a student in this class");
            Console.WriteLine(studentName2 + " is a student in this class");
            Console.WriteLine(studentName3 + " is a student in this class");
            Console.WriteLine(studentName4 + " is a student in this class");
            Console.WriteLine(studentName5 + " is a student in this class");
            Console.WriteLine(studentName6 + " is a student in this class");
            Console.WriteLine(studentName7 + " is a student in this class");
            Console.WriteLine(studentName8 + " is a student in this class");
            Console.WriteLine(studentName9 + " is a student in this class");
            Console.WriteLine(studentName10 + " is a student in this class");
*/

            /*
            string[] studentName = new string[10];

            studentName[0] = "Eli";
            studentName[1] = "Alex";
            studentName[2] = "Josh";
            studentName[3] = "Michael O.";
            studentName[4] = "Wendy";
            studentName[5] = "Anthony";
            studentName[6] = "Michael M.";
            studentName[7] = "Sean";
            studentName[8] = "Toby";
            studentName[9] = "Eleasar";
            
            string[] studentName = {"Eli","Alex","Josh","Michael O.","Wendy",
                                    "Anthony","Michael M.","Sean","Toby","Eleasar","Nico"};
            */
            int arrayIndex;
            int counter;
            string[] studentName = new string[15];
            string   varStudentName;

            arrayIndex = 0;
            while (true) 
            {
                Console.WriteLine("Please enter the student name (type EXIT to quit):");
                varStudentName = Console.ReadLine();
                if (varStudentName == "EXIT") break;
                studentName[arrayIndex++] = varStudentName;
            }

            for (counter = 0; counter < studentName.Length; counter++)
            {
                if ((studentName[counter] != null) && (studentName[counter] != ""))
                {
                    Console.WriteLine(studentName[counter] + " is a student in this class");
                }
            }
        }
    }
}
