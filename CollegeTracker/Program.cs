using System;

namespace CollegeTracker
{
    class MainClass
    {
        static string[,,,] masterArray = new string[4, 2, 6, 2];
        static string[] yearArray = new string[4];
        static string[] semesterArray = new string[2];
        static string[] classArray = new string[6];
        static string[] detailArray = new string[2];
        static string[] headingArray = { "Year", "Semester", "Class", "Result" };


        public static void Main(string[] args)
        {
            


        }

        static void ArrayYearInit()
        {
            int year = 0;
            for (int i = 0; i < yearArray.Length; i++)
            {
                year = i + 1;
                yearArray[i] = year.ToString();

            }
        }

        static void ArraySemesterInit()
        {
            int semester = 0;
            for (int i = 0; i < semesterArray.Length; i++)
            {
                semester = i + 1;
                semesterArray = 
            }
        }
    }
}
