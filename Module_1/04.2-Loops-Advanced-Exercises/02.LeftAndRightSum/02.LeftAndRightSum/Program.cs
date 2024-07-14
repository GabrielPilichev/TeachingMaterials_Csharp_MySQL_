namespace _02.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads 2*n number of integers supplied by the user and checks if the sum of the first n
            // numbers (left sum) is equal to the sum of the second n numbers (right sum).
            // If there is a tie, it prints "Yes, sum = " + the sum. Otherwise it prints "No, diff = " + the difference.
            // The difference is calculated as a positive number (in absolute value).

            // Read the value of n from the user
            Console.Write("Enter the number of integers for each half (n): ");
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            // Read the first n integers and calculate the left sum
            Console.WriteLine("Enter the first n integers:");
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum += number;
            }

            // Read the second n integers and calculate the right sum
            Console.WriteLine("Enter the second n integers:");
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            // Compare the sums and print the result
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}