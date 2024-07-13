using System.ComponentModel;

namespace _07.DayOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads an integer entered by the user and prints the day of the week(in English),
            in the range[1...7], or prints "Error" in case the entered number is invalid.*/

            // Prompt the user to enter an integer
            Console.Write("Enter a number (1-7) to get the corresponding day of the week: ");

            // Read the input from the user and convert it to an integer
            int num = int.Parse(Console.ReadLine());

            // Determine and print the corresponding day of the week or an error message
            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}