namespace _05.SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads n number of integers entered by the user and sums them.
            // The number of numbers n is entered from the first line of the input.
            // One whole number is entered from the next n lines.
            // The program must read the numbers, add them, and print the sum.

            // Read the number of integers n
            Console.Write("Enter the number of integers: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            // Read the n integers and sum them
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter integer: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            // Print the sum
            Console.WriteLine("Sum: " + sum);
        }
    }
}