namespace _02.SumOfPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a pair of numbers and calculates the sum of each. 
            // If the sum of a pair is greater than a given number n, print "Bigger Sum!" on the console.
            // The console reads:
            // • n – an integer to which the sum will be compared
            // • m – an integer in the range [1..100], which represents the number of pairs of numbers 
            //   that will be entered on the following lines
            // • On the next m-rows – two integers on separate rows (one pair)

            int n = int.Parse(Console.ReadLine()); // the number to compare sums against
            int m = int.Parse(Console.ReadLine()); // number of pairs of numbers

            bool foundBiggerSum = false;

            for (int i = 0; i < m; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int sum = num1 + num2;

                if (sum > n)
                {
                    foundBiggerSum = true;
                }
            }

            if (foundBiggerSum)
            {
                Console.WriteLine("Bigger Sum!");
            }
        }
    }
}