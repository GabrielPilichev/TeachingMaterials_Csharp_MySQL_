namespace _13.DivisionWithoutRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Given n number of integers in the interval [1…1000]. Of these, some percentage p1 are divisible by 2 without a remainder,
            // another percentage p2 are divisible by 3 without a remainder, another percentage p3 are divisible by 4 without a remainder.
            // Write a program that calculates and prints the percentages p1, p2 and p3.
            // Example: we have n = 10 numbers: 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. 
            // We get the following distribution and visualization:
            // Division without a remainder of Numbers in the range Number of numbers Percent
            // 2 680, 2, 600, 200, 800, 46, 128 7 p1 = 7.0 / 10 * 100 = 70.00%
            // 3 600 1 p2 = 1 / 10 * 100 = 10.00%
            // 4 680, 600, 200, 800, 128 5 p3 = 5 / 10 * 100 = 50.00%

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    countP1++;
                }
                if (numbers[i] % 3 == 0)
                {
                    countP2++;
                }
                if (numbers[i] % 4 == 0)
                {
                    countP3++;
                }
            }

            double p1 = (double)countP1 / n * 100;
            double p2 = (double)countP2 / n * 100;
            double p3 = (double)countP3 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}