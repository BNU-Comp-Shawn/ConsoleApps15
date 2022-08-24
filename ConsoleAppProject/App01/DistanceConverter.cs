using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// converts distance from miles to feet
    /// </summary>
    /// <author>
    /// Shawn Reffell-Wyse  version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

        /// <summary>
        ///  IT inputs the distance measured in miles 
        ///  calculates it in feet and outputs distance in feet
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();    
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("  Convert Miles to Feet  ");
            Console.WriteLine("  by Shawn Reffell-Wyse  ");
            Console.WriteLine("---------------------------");
        }

        /// <summary>
        /// Prompt user to enter distance in miles
        /// Input the miles as double number.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Enter number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }
    }
}
