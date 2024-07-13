using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace _12.SmallestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that, until receiving the "Stop" command, reads integers entered by the user
            and finds the smallest among them. Enter one number per line.*/

            int minNumber = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                    break;

                if (int.TryParse(input, out int number))
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or 'Stop' to finish.");
                }
            }

            Console.WriteLine($"The smallest number entered is: {minNumber}");
        }
    }
}