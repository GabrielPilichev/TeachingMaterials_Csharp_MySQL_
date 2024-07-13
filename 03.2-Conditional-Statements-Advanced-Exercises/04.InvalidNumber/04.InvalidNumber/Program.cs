using System;

namespace _04.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A given number is valid if it is in the range[100…200]. To write a program that 
            reads an integer entered by the user and prints "invalid" if the entered number is not valid.*/

            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is in the range [100…200]
            if (number < 100 || number > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}