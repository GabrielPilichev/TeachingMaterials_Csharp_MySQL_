using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;
using System;

namespace _07.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*The fruit shop operates at the following prices on working days:
                fruit banana apple orange grapefruit kiwi pineapple grapes
                price 2.50   1.20  0.85   1.45       2.70 5.50      3.85
            Saturdays and Sundays the store operates at higher prices:
                fruit banana apple orange grapefruit kiwi pineapple grapes
                price 2.70   1.25  0.90   1.60       3.00 5.60      4.20
            Write a program that reads from the console fruit(banana / apple / orange / grapefruit / kiwi / pineapple / grapes),
            day of the week(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) and quantity(real number)
            entered by the user, and calculates the price according to the prices in the tables above.
            Print the result rounded to 2 decimal places. Invalid day of the week or invalid fruit name to print "error".*/


            // Prompt the user to enter the fruit, day of the week, and quantity
            Console.Write("Enter the fruit: ");
            string fruit = Console.ReadLine().Trim().ToLower();

            Console.Write("Enter the day of the week: ");
            string dayOfWeek = Console.ReadLine().Trim().ToLower();

            Console.Write("Enter the quantity: ");
            double quantity = double.Parse(Console.ReadLine());

            // Define the price variable
            double price = 0;

            // Determine if the day is a working day or weekend
            bool isWorkingDay = dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" ||
                                dayOfWeek == "thursday" || dayOfWeek == "friday";

            bool isWeekend = dayOfWeek == "saturday" || dayOfWeek == "sunday";

            if (isWorkingDay)
            {
                // Set prices for working days
                if (fruit == "banana") price = 2.50;
                else if (fruit == "apple") price = 1.20;
                else if (fruit == "orange") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price = 2.70;
                else if (fruit == "pineapple") price = 5.50;
                else if (fruit == "grapes") price = 3.85;
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (isWeekend)
            {
                // Set prices for weekends
                if (fruit == "banana") price = 2.70;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "orange") price = 0.90;
                else if (fruit == "grapefruit") price = 1.60;
                else if (fruit == "kiwi") price = 3.00;
                else if (fruit == "pineapple") price = 5.60;
                else if (fruit == "grapes") price = 4.20;
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else
            {
                // If the day is invalid
                Console.WriteLine("error");
                return;
            }

            // Calculate and print the total cost
            double totalCost = quantity * price;
            Console.WriteLine($"{totalCost:F2}");
        }
    }

}
