namespace _03.NumbersFrom1_Nthrough3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number n entered by the user 
            // and prints the numbers 1 through n with a step of 3.

            // Read the number n from the user
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            // Print numbers from 1 to n with a step of 3
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}