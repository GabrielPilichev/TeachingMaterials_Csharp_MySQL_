using System.ComponentModel;

namespace _02.TheLargerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two integers entered by the user and prints the larger of the two.*/

            // Prompt the user to enter the first integer
            Console.Write("Enter the first integer: ");

            // Read the input from the user and convert it to an integer
            int num1 = int.Parse(Console.ReadLine());

            // Prompt the user to enter the second integer
            Console.Write("Enter the second integer: ");

            // Read the input from the user and convert it to an integer
            int num2 = int.Parse(Console.ReadLine());

            // Compare the two integers to determine which is larger
            if (num1 > num2)
            {
                // If num1 is greater than num2, print num1
                Console.WriteLine(num1);
            }
            else
            {
                // If num2 is greater than or equal to num1, print num2
                Console.WriteLine(num2);
            }
        }
    }
}