namespace _01.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a number n entered by the user and prints the even powers of 2 ≤ 2^n:
          2^0, 2^2, 2^4, 2^6, …, 2^n.*/

            // Read the input number from the user
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            // Loop through even powers from 0 to n
            for (int i = 0; i <= n; i += 2)
            {
                // Calculate 2^i
                int result = (int)Math.Pow(2, i);
                // Print the result
                Console.WriteLine($"2^{i} = {result}");
            }
        }
    }
}