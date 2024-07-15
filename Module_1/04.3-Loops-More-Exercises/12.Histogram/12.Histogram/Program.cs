namespace _12.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Given n integers in the interval [1…1000]. Of these, some percentage p1 are below 200,
            // another percentage p2 are from 200 to 399, another percentage p3 are from 400 to 599,
            // another percentage p4 are from 600 to 799 and the remaining p5 percentage are from 800 and up.
            // To write a program that calculates and prints the percentages p1, p2, p3, p4 and p5.
            // Example: we have n = 20 numbers: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65.
            // We get the following distribution and visualization:
            // Range Numbers in range Number of numbers Percent
            // < 200 53, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65 12 p1 = 12 / 20 * 100 = 60.00%
            // 200 … 399 250, 200 2 p2 = 2 / 20 * 100 = 10.00%
            // 400 … 599 450 1 p3 = 1 / 20 * 100 = 5.00%
            // 600 … 799 680, 600, 799 3 p4 = 3 / 20 * 100 = 15.00%
            // ≥ 800 920, 800 2 p5 = 2 / 20 * 100 = 10.00%
            // Login
            // The first line of the input contains the integer n (1 ≤ n ≤ 1000) - number of numbers.
            // On the next n lines there is one integer in the interval [1...1000] - the numbers on which the histogram should be calculated.
            // Exit
            // Print the histogram to the console - 5 lines, each containing a number between 0% and 100%, to two decimal places, eg 25.00%, 66.67%, 57.14%.

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < 200)
                {
                    countP1++;
                }
                else if (numbers[i] < 400)
                {
                    countP2++;
                }
                else if (numbers[i] < 600)
                {
                    countP3++;
                }
                else if (numbers[i] < 800)
                {
                    countP4++;
                }
                else
                {
                    countP5++;
                }
            }

            double p1 = (double)countP1 / n * 100;
            double p2 = (double)countP2 / n * 100;
            double p3 = (double)countP3 / n * 100;
            double p4 = (double)countP4 / n * 100;
            double p5 = (double)countP5 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}