using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// app prompts user to input a distance and 
    ///measures in one unit (fromUnit) and
    ///outputs the distance in another unit (toUnit)
    /// </summary>
    /// <author>
    /// Shawn Reffell-Wyse  version 0.6
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";


        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        ///  IT inputs the distance measured in miles 
        ///  calculates it in feet and outputs distance in feet
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Select the from distance unit > ");
            toUnit = SelectUnit(" Select the to distance unit > ");

            Console.WriteLine($"\n converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if(fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Prompt the user to enter distance in miles
        /// Input miles as double number
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

 

        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance}  {fromUnit}" + 
                $" is {toDistance} {toUnit}!\n");
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("    Distance Convert   ");
            Console.WriteLine("  by Shawn Reffell-Wyse  ");
            Console.WriteLine("---------------------------");

        }
    }
}
