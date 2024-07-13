using System.ComponentModel;

namespace _07.ValidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that checks whether a number entered by the user is valid.
            For a number to be valid, it must be greater than or equal to 1 and at the same time 
            divisible by 5 without a remainder.If the number is valid, print "Valid!".Otherwise, print "Invalid!".*/

            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is valid
            if (number >= 1 && number % 5 == 0)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
    }
}