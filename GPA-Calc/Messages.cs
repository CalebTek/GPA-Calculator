using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calc
{
    internal class Messages
    {
        public string AppMSG()
        {
            string appMSG = "Welcome to the GPA Calculator Application. " +
            "\nTo calculate your GPA, input the following according to the prompt: " +
            "\n   1. Your Course Code e.g CSH101, NJS101, JVA101 etc. " +
            "\n   2. Course Unit (0-5). " +
            "\n   3. Course Score (0-100). " +
            "\n \n";
            return appMSG;
        }

        public string NumberOfCourse() => $"How many Course(s) do you want to register: ";

        public string NumberOfCourseERR() => $"Invalid input,Please enter a number: ";

        public string StartMSG() => "Would you like to begin registering the courses? Y or N: ";

        public string CourseCodeERR()
        {

            string courseCodeMSG = $"Invalid input" +
                $"\nNote:" +
                $"\nCSH101, NJS101, and JVA101 are examples of acceptable course codes." +
                $"\nCourse Code must be six (6) characters long." +
                $"\nThere must be three (3) alphabets and numbers in the course code." +
                $"\nCourse Code must not be blank." +
                $"\nThe same course code cannot be registered twice.\n";

            return courseCodeMSG;
        }


        public string CourseUnitERR()
        {
            string courseUnitErr = $"Invalid input" +
                $"\nNote:" +
                $"\nNo course unit can be lower than zero (0) or higher than five (5).\n";
            return courseUnitErr;
        }

        public string CourseScoreERR()
        {
            string courseScoreErr = $"Invalid input" +
                $"\nNo course Score can be lower than zero (0) or higher than hundred (100).\n";
            return courseScoreErr;
        }


    }
}
