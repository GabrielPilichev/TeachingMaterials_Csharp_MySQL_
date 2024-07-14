using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System;

namespace _08.Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Annie loves to travel and wants to visit several different destinations this year.
            Once she's chosen a destination, she'll estimate how much money she'll need to get there and start saving. 
            When she has saved enough, she will be able to travel.

            From the console, the destination and the minimum budget that will be needed for the trip 
            will be read first each time.
            Then a few sums will be read that Annie saves by working, and when she has saved enough for the trip, 
            she will leave, and the console should read:
                "Going to {destination}!"
            When she has visited all the destinations she wants, she will enter "End" instead of a destination 
            and the program will end.*/

            string input;
            int savings;

            while (true)
            {
                // Read destination
                input = Console.ReadLine();
                if (input == "End")
                    break;

                string destination = input;

                // Read minimum budget needed for the trip
                int minBudget = int.Parse(Console.ReadLine());

                // Initialize savings accumulator
                savings = 0;

                // Read savings until enough for the trip
                while (savings < minBudget)
                {
                    int currentSavings = int.Parse(Console.ReadLine());
                    savings += currentSavings;
                }

                // Output message when enough savings collected
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}