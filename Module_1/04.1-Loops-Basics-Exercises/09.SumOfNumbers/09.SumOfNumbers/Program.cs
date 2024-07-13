namespace _09.SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads an integer from the console and on each successive line
            // reads integers until their sum is greater than or equal to the original number.
            // After completion, print the sum of the entered numbers.

            Console.Write("Enter the target number: ");
            int targetNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < targetNumber)
            {
                Console.Write("Enter a number: ");
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine("The sum of the entered numbers is: " + sum);
        }
    }
}