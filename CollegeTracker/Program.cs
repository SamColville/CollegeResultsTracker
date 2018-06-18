using System;

namespace CollegeTracker
{
    class MainClass
    {
        static string[,,,] masterArray = new string[4, 2, 6, 6];
        static string[] yearArray = new string[4];
        static string[] semesterArray = new string[2];
        static string[] moduleArray = new string[6];
        static string[] resultArray = new string[6];
        static string[] headingArray = { "Year", "Semester", "Class", "Result" };


        public static void Main(string[] args)
        {
            int choice = 0;
            string choiceStr = "";
            ArrayInit();

            while(choice != 4)
            {
                choiceStr = MenuDisplay(ref choice);

                switch(choice)
                {
                    case 1:
                        OptionMainOne();
                        break;
                    case 2:
                        OptionMainTwo();
                        break;
                    case 3:
                        OptionMainThree();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using this program");
                        break;
                    default:
                        break;
                }
            }


        }

        static string MenuDisplay(ref int choice)
        {
            string choiceStr = "";

            Console.WriteLine("Main Menu");
            Console.WriteLine("(Enter number indicated below)");
            Console.WriteLine("1. Display results");
            Console.WriteLine("2. Display analysis");
            Console.WriteLine("3. Enter new data");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.WriteLine("Option: ");
            choiceStr = Console.ReadLine();
            choice = int.Parse(choiceStr);

            return choiceStr;
        }

        static void OptionMainOne()
        {
            Console.WriteLine(masterArray);
        }

        static void OptionMainTwo()
        {
            Console.WriteLine("Option 2 selected");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            //Options for average, standard deviation
            //more?
        }

        static void OptionMainThree()
        {
            int year, semester;
            double finalMark;
            string module;


            Console.Write("Enter the year of study:  ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter semester:  ");
            semester = int.Parse(Console.ReadLine());

            for (int i = 0; i < max; i++)
            {

            }



        }

        static void ArrayInit()
        {
            int year = 0;
            for (int i = 0; i < yearArray.Length; i++)
            {
                year = i + 1;
                yearArray[i] = year.ToString();

            }
            int semester = 0;
            for (int i = 0; i < semesterArray.Length; i++)
            {
                semester = i + 1;
                semesterArray[i] = semester.ToString();
            }

            for (int i = 0; i < moduleArray.Length; i++)
            {
                moduleArray[i] = "";
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = "";
            }


        }

        static void ClassInput()
        {
            
        }
    }
}
