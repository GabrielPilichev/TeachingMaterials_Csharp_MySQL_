using System.ComponentModel;

namespace _14.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that prints the hours of the day from 0:00 to 23:59, each on a separate line.
            Hours must be written in the format "{hour}:{minutes}".*/

            // Loop through 24 hours
            for (int hour = 0; hour < 24; hour++)
            {
                // Loop through 60 minutes
                for (int minute = 0; minute < 60; minute++)
                {
                    Console.WriteLine($"{hour:D2}:{minute:D2}");
                }
            }
        }
    }
}