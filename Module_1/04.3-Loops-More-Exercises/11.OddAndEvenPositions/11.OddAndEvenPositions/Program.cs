using System.Security.Cryptography;

namespace _11.OddAndEvenPositions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Your task is to write a program that reads n numbers entered by the user and calculates:
            -Sum, minimum, and maximum of numbers in odd positions(1, 3, 5, ...)
            -Sum, minimum, and maximum of numbers in even positions(2, 4, 6, ...)

            If there is no minimum or maximum element for odd or even positions, print "No".

            Output format:
            "OddSum=" + { sum of numbers in odd positions},
            "OddMin=" + { minimum value of numbers in odd positions} / { "No"},
            "OddMax=" + { maximum value of numbers in odd positions} / { "No"},
            "EvenSum=" + { sum of numbers in even positions},
            "EvenMin=" + { minimum value of numbers in even positions} / { "No"},
            "EvenMax=" + { maximum value of numbers in even positions} / { "No"}

            Each number must be formatted to the second decimal place.*/

            // Read the number of integers
            int n = int.Parse(Console.ReadLine());

            // Array to store the numbers
            int[] numbers = new int[n];

            // Read the numbers
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Variables to store sums, min, and max
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            // Iterate through the numbers and calculate sums, min, and max
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) // Even positions (0-based index)
                {
                    evenSum += numbers[i];
                    if (numbers[i] < evenMin)
                    {
                        evenMin = numbers[i];
                    }
                    if (numbers[i] > evenMax)
                    {
                        evenMax = numbers[i];
                    }
                }
                else // Odd positions
                {
                    oddSum += numbers[i];
                    if (numbers[i] < oddMin)
                    {
                        oddMin = numbers[i];
                    }
                    if (numbers[i] > oddMax)
                    {
                        oddMax = numbers[i];
                    }
                }
            }

            // Print the results
            Console.WriteLine($"OddSum={oddSum:f2}");
            Console.WriteLine($"OddMin={(oddMin != double.MaxValue ? oddMin.ToString("f2") : "No")}");
            Console.WriteLine($"OddMax={(oddMax != double.MinValue ? oddMax.ToString("f2") : "No")}");
            Console.WriteLine($"EvenSum={evenSum:f2}");
            Console.WriteLine($"EvenMin={(evenMin != double.MaxValue ? evenMin.ToString("f2") : "No")}");
            Console.WriteLine($"EvenMax={(evenMax != double.MinValue ? evenMax.ToString("f2") : "No")}");
        }
    }
}