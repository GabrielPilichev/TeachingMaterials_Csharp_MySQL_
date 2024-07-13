using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace _02.NumberBetween_100And100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that checks if the number entered by the user is in the interval[-100, 100] 
            and is different from 0 and outputs "Yes" if it meets the conditions or "No" if it does not.*/

            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is in the interval [-100, 100] and different from 0
            if (number >= -100 && number <= 100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}