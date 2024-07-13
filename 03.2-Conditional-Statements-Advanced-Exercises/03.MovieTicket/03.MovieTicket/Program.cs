using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace _03.MovieTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads the day of the week(text) -entered by the user 
            and prints on the console the price of a movie ticket according to the day of the week:*/

            // Prompt the user to enter the day of the week
            Console.Write("Enter the day of the week: ");
            string dayOfWeek = Console.ReadLine().Trim().ToLower();

            // Determine the price of the movie ticket based on the day of the week
            switch (dayOfWeek)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                    Console.WriteLine("Ticket Price: $10");
                    break;
                case "friday":
                case "saturday":
                case "sunday":
                    Console.WriteLine("Ticket Price: $15");
                    break;
                default:
                    Console.WriteLine("Invalid day entered.");
                    break;
            }
        }
    }
}