using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Threading;
using System;

namespace _10.UnitConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that converts a distance between the following 3 units of measurement: mm, cm, m.
            Use the correspondences from the table below:
            Input unit Output unit
                1 meter(m) 1000 millimeters(mm)
                1 meter(m) 100 centimeters(cm)
            The input consists of three lines entered by the user:
                - First line: number to convert - real number
                - Second row: input unit of measurement -text
                - Third line: output measurement unit(for the result) -text
            Print the result of the unit conversion formatted to the third decimal place on the console.*/

            // Prompt the user to enter the number to convert
            Console.Write("Enter the number to convert: ");
            double number = double.Parse(Console.ReadLine());

            // Prompt the user to enter the input unit
            Console.Write("Enter the input unit (mm, cm, m): ");
            string inputUnit = Console.ReadLine().ToLower(); // Convert input to lowercase for case-insensitive comparison

            // Prompt the user to enter the output unit
            Console.Write("Enter the output unit (mm, cm, m): ");
            string outputUnit = Console.ReadLine().ToLower(); // Convert input to lowercase for case-insensitive comparison

            double result = 0;

            // Perform the conversion based on input and output units
            switch (inputUnit)
            {
                case "mm":
                    if (outputUnit == "mm")
                    {
                        result = number; // mm to mm is 1:1
                    }
                    else if (outputUnit == "cm")
                    {
                        result = number / 10.0; // mm to cm (1 mm = 0.1 cm)
                    }
                    else if (outputUnit == "m")
                    {
                        result = number / 1000.0; // mm to m (1 mm = 0.001 m)
                    }
                    break;
                case "cm":
                    if (outputUnit == "mm")
                    {
                        result = number * 10.0; // cm to mm (1 cm = 10 mm)
                    }
                    else if (outputUnit == "cm")
                    {
                        result = number; // cm to cm is 1:1
                    }
                    else if (outputUnit == "m")
                    {
                        result = number / 100.0; // cm to m (1 cm = 0.01 m)
                    }
                    break;
                case "m":
                    if (outputUnit == "mm")
                    {
                        result = number * 1000.0; // m to mm (1 m = 1000 mm)
                    }
                    else if (outputUnit == "cm")
                    {
                        result = number * 100.0; // m to cm (1 m = 100 cm)
                    }
                    else if (outputUnit == "m")
                    {
                        result = number; // m to m is 1:1
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input unit.");
                    return; // Exit the program if the input unit is invalid
            }
        }
    }
}