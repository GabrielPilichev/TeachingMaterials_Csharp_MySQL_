using System.Threading;
using System;

namespace _05.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Your task is to write a program that calculates whether a player has succeeded in winning a leg. 
            (A leg is called a single game of darts)
            The player initially starts with 301 points.The player throws the arrow on the board, 
            and for each square hit, he gets a certain number of points.Each field has three sectors: 
            Single(Single) sector, from which the number of points from the field is taken.Double(Double), 
            the doubled points from the field are taken from it, and Triple(Triple) sector, the points 
            from which are multiplied by 3.
            The points obtained from each shot are subtracted from the starting points, until 0 is reached.

            Note: If a shot gives more points than available, it is considered a failure and the player must roll again 
            until he hits points equal to or less than the remaining - such a shot is considered a success.

            Example: With 100 points available, a shot giving more than 100 points is a failure. 
            With 100 points available, a hit giving less than or equal to 100 points is successful.*/

            // Darts game simulation

            int initialPoints = 301;
            int currentPoints = initialPoints;

            while (currentPoints > 0)
            {
                string input = Console.ReadLine();

                if (input == "Retire")
                {
                    Console.WriteLine($"Retired!");
                    break;
                }

                int points = int.Parse(input.Substring(1));  // Extract points from input
                char multiplier = input[0];  // Determine the multiplier: S, D, or T

                int score = 0;

                // Calculate the score based on multiplier
                switch (multiplier)
                {
                    case 'S':
                        score = points;
                        break;
                    case 'D':
                        score = 2 * points;
                        break;
                    case 'T':
                        score = 3 * points;
                        break;
                }

                // Check if the score is valid
                if (score <= currentPoints)
                {
                    currentPoints -= score;
                }
                else
                {
                    continue;  // Invalid shot, skip and read next input
                }

                if (currentPoints == 0)
                {
                    Console.WriteLine($"Won the leg with {initialPoints - currentPoints} points.");
                    break;
                }
            }
        }
    }
}