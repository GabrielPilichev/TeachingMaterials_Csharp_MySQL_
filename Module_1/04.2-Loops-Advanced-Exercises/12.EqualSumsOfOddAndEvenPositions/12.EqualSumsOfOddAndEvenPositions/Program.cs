using System.ComponentModel;
using System.Security.Cryptography;

namespace _12.EqualSumsOfOddAndEvenPositions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads from the console two six-digit integers in the range 100000 to 300000.
            The first number entered will always be less than the second.
            Print on the console all numbers between the two numbers that satisfy the following condition:
                -The sum of the digits in even positions must be equal to the sum of the digits in odd positions.
            If no numbers satisfy the condition, no output should be displayed.*/

            // Read input numbers
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            // Iterate through numbers between num1 and num2 (inclusive)
            for (int i = num1; i <= num2; i++)
            {
                // Convert current number to string to access digits
                string currentNumber = i.ToString();

                // Check if the number has exactly 6 digits
                if (currentNumber.Length == 6)
                {
                    // Calculate sums of digits in even and odd positions
                    int evenSum = 0;
                    int oddSum = 0;

                    for (int j = 0; j < currentNumber.Length; j++)
                    {
                        int digit = int.Parse(currentNumber[j].ToString());

                        // Check if position is even or odd (1-based index)
                        if ((j + 1) % 2 == 0)
                        {
                            evenSum += digit;
                        }
                        else
                        {
                            oddSum += digit;
                        }
                    }

                    // Check if sums of even and odd positions are equal
                    if (evenSum == oddSum)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            // Print new line if there were matching numbers
            if (num1 <= num2)
            {
                Console.WriteLine();
            }
        }
    }
}