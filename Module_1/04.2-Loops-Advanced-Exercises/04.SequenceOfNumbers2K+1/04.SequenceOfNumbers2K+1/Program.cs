using System.ComponentModel;

namespace _04.SequenceOfNumbers2K_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a number n entered by the user
            and prints all numbers ≤ n from the sequence: 1, 3, 7, 15, 31, ….
            Each subsequent number is calculated by multiplying the previous one by 2 and adding 1.*/

            // Read the value of n from the user
            Console.Write("Enter a number (n): ");
            int n = int.Parse(Console.ReadLine());

            int currentNumber = 1;

            // Print all numbers in the sequence less than or equal to n
            while (currentNumber <= n)
            {
                Console.WriteLine(currentNumber);
                currentNumber = currentNumber * 2 + 1;
            }
        }
    }
}