using System.ComponentModel;

namespace _01.NumbersFrom1000EndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that prints the numbers in the range[1…1000] that end in 7.*/

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}