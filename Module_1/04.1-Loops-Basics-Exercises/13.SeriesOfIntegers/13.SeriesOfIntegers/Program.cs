using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace _13.SeriesOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads n number of integers.Print the largest and smallest number entered.
            The first line of input gives the number n, and the next n lines give an integer.*/

            Console.WriteLine("Enter the number of integers (n):");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input for n. Please enter a positive integer.");
                return;
            }

            int largest = int.MinValue;
            int smallest = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter integer #{i + 1}:");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Decrement i to repeat current iteration
                    continue;
                }

                if (number > largest)
                    largest = number;

                if (number < smallest)
                    smallest = number;
            }

            Console.WriteLine($"The largest number entered is: {largest}");
            Console.WriteLine($"The smallest number entered is: {smallest}");
        }
    }
}