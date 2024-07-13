using Microsoft.VisualBasic;
using System.ComponentModel;

namespace _05.SpeedInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a speed(real number) entered by the user and prints
            information about the speed. For speeds up to 10(inclusive), print “slow”. 
            For speeds above 10 and up to 50, print “average”. For speeds above 50 and up to 150,
            print “fast”. For speeds above 150 and up to 1000, print “ultra fast”. For higher speed,
            print “extremely fast”.*/

            // Prompt the user to enter the speed
            Console.Write("Enter the speed: ");

            // Read the input from the user and convert it to a double
            double speed;
            if (double.TryParse(Console.ReadLine(), out speed))
            {
                // Determine and print the speed category
                if (speed <= 10)
                {
                    Console.WriteLine("slow");
                }
                else if (speed <= 50)
                {
                    Console.WriteLine("average");
                }
                else if (speed <= 150)
                {
                    Console.WriteLine("fast");
                }
                else if (speed <= 1000)
                {
                    Console.WriteLine("ultra fast");
                }
                else
                {
                    Console.WriteLine("extremely fast");
                }
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}