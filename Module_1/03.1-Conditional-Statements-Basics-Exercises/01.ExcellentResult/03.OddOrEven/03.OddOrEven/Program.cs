using System.ComponentModel;
using System.Security.Cryptography;

namespace _03.OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads an integer entered by the user and 
              prints to the console whether it is even or odd.*/

            // Prompt the user to enter an integer
            Console.Write("Enter an integer: ");

            // Read the input from the user and convert it to an integer
            int num = int.Parse(Console.ReadLine());

            // Check if the integer is even or odd
            // An integer is even if it is divisible by 2 with no remainder (num % 2 == 0)
            if (num % 2 == 0)
            {
                // If num is even, print "Even"
                Console.WriteLine("Even");
            }
            else
            {
                // If num is odd, print "Odd"
                Console.WriteLine("Odd");
            }
        }
    }
}