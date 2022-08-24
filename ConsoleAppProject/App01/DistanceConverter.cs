using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// converts distance from miles to feet
    /// converts distance from feet to miles
    /// converts distance from miles to metres
    /// </summary>
    /// <author>
    /// Shawn Reffell-Wyse  version 0.3
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        /// <summary>
        ///  IT inputs the distance measured in miles 
        ///  calculates it in feet and outputs distance in feet
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Enter the number of miles > ");
           
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));

        }
        /// <summary>
        /// Prompt user to enter distance in miles
        /// Input as double number
        /// </summary>

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }
        /// <summary>
        /// Prompt user to enter distance in feet
        /// Input feet as double number
        /// </summary>

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            miles = InputDistance("Enter the number of miles > ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
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

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }


        /// <summary>
        /// 
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" + 
                $" is {toDistance} {toUnit}!");
        }

       
        
        private void OutputHeading(string prompt)
        {
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("    Distance Convert   ");
            Console.WriteLine("  by Shawn Reffell-Wyse  ");
            Console.WriteLine("---------------------------");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}
