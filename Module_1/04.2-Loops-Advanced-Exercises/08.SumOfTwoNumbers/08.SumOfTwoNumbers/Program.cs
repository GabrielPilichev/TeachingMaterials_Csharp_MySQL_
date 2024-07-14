using System.ComponentModel;

namespace _08.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that checks all possible pairs of numbers within a given range.
            It prints which pair's sum equals a given magic number.
            If no such combination is found, print a message that it's not found.*/

            // Read input
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool found = false;

            // Check all combinations of pairs
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination found: {i} + {j} = {magicNumber}");
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            // If no combination is found
            if (!found)
            {
                Console.WriteLine($"No combination found with sum {magicNumber}");
            }
        }
    }
}