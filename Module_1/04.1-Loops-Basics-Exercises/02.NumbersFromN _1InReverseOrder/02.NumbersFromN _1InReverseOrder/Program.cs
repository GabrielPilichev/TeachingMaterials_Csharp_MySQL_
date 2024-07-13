namespace _02.NumbersFromN__1InReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a positive integer n entered by the user 
            // and prints the numbers n through 1 in reverse order (from largest to smallest).

            // Read the positive integer n from the user
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());

            // Print numbers from n to 1 in reverse order
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}