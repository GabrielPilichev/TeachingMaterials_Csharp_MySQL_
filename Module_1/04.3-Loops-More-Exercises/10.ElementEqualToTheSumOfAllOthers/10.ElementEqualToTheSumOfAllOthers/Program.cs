using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _10.ElementEqualToTheSumOfAllOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Your task is to write a program that reads n number of integers entered by the user
            and checks whether there is a number among them that is equal to the sum of all the others. 
            If such a number exists, print "Yes" followed by "Sum = " and its value.
            If no such number exists, print "No" followed by "Diff = " and the absolute difference
            between the largest element and the sum of the others.

            Input:
                - First input is the number of integers n.
                - Next n inputs are the integers themselves.

            Output:
                - Print "Yes", "Sum = " + value if a number equals the sum of all others.
                - Print "No", "Diff = " + absolute difference if no such number exists.*/

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int max = int.MinValue;

            // Calculate the sum of all numbers and find the maximum number
            foreach (int num in numbers)
            {
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }

            // Check if there exists a number that equals the sum of all others
            bool found = false;
            foreach (int num in numbers)
            {
                int sumOfOthers = sum - num;
                if (num == sumOfOthers)
                {
                    Console.WriteLine($"Yes");
                    Console.WriteLine($"Sum = {num}");
                    found = true;
                    break;
                }
            }

            // If no such number is found, calculate and print the difference
            if (!found)
            {
                int difference = Math.Abs(max - (sum - max));
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}