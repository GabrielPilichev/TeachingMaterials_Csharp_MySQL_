using System.ComponentModel;

namespace _07.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates how many natural number solutions(including zero) the equation has:
                x1 + x2 + x3 = n
            The number n is an integer and is entered from the console.*/

            // Read the integer n from the console
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            // Loop through possible values of x1
            for (int x1 = 0; x1 <= n; x1++)
            {
                // Loop through possible values of x2
                for (int x2 = 0; x2 <= n - x1; x2++)
                {
                    // Calculate x3
                    int x3 = n - x1 - x2;

                    // Check if x3 is non-negative
                    if (x3 >= 0)
                    {
                        // Increment the count of solutions
                        count++;
                    }
                }
            }

            // Print the number of solutions
            Console.WriteLine($"Number of solutions for x1 + x2 + x3 = {n}: {count}");
        }
    }
}