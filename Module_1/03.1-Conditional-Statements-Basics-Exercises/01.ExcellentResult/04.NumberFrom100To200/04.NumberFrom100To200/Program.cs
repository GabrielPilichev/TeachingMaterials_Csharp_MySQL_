using System.ComponentModel;

namespace _04.NumberFrom100To200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads an integer entered by the user and checks whether 
                it is less than 100, between 100 and 200, or greater than 200.To print 
                messages accordingly, as in the examples below:*/

            // Prompt the user to enter an integer
            Console.Write("Enter an integer: ");

            // Read the input from the user and convert it to an integer
            int num = int.Parse(Console.ReadLine());

            // Check if the integer is less than 100
            if (num < 100)
            {
                // If num is less than 100, print "Less than 100"
                Console.WriteLine("Less than 100");
            }
            // Check if the integer is between 100 and 200
            else if (num >= 100 && num <= 200)
            {
                // If num is between 100 and 200 (inclusive), print "Between 100 and 200"
                Console.WriteLine("Between 100 and 200");
            }
            // Check if the integer is greater than 200
            else
            {
                // If num is greater than 200, print "Greater than 200"
                Console.WriteLine("Greater than 200");
            }
        }
    }
}