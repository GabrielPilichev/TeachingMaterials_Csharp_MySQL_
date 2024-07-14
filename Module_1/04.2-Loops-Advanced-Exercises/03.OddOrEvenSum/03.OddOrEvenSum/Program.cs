namespace _03.OddOrEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that receives a number n on the first line.
            It then reads n number of integers supplied by the user and checks that the sum of the even numbers
            is equal to the sum of the odd numbers. If there is a tie, print two lines: "Yes" and on a new line 
            "Sum = " + the sum. Otherwise, print "No" and on a new line "Diff = " + the difference.
            The difference is calculated in absolute value. */

            // Read the value of n from the user
            Console.Write("Enter the number of integers (n): ");
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            // Read n integers and calculate the sum of even and odd indexed numbers
            Console.WriteLine("Enter the integers:");
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            // Compare the sums and print the result
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}