using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Reflection;
using System;

namespace _08.HolidayOrWorkingDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads the day of the week(text), in English - entered by the user.
            If the day is working, it prints on the console - "Working day", if it is a holiday - "Weekend".
            If a text other than a day of the week is entered, "Error" will be printed.*/

            // Prompt the user to enter the day of the week
            Console.Write("Enter the day of the week (Monday to Sunday): ");

            // Read the input from the user
            string dayOfWeek = Console.ReadLine().Trim(); // Trim to remove any leading or trailing whitespace

            // Convert the input to lowercase for case-insensitive comparison
            dayOfWeek = dayOfWeek.ToLower();

            // Check the input and categorize accordingly
            switch (dayOfWeek)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    Console.WriteLine("Working day");
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}