using System.ComponentModel;
using System.Runtime.InteropServices;

namespace _09.BonusPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Given an integer - initial number of points.Bonus points are accrued on it according to the rules
            described below. Write a program that calculates the bonus points that the number receives and 
            the total number of points(the number +the bonus).
                - If the number is up to and including 100, the bonus points are 5.
                - If the number is greater than 100, the bonus points are 20 % of the number.
                - If the number is greater than 1000, the bonus points are 10 % of the number.

                - Additional bonus points(charged separately from the previous ones):
                    - For an even number. + 1 pt.
                    - For a number that ends in 5. + 2 pt.*/

            // Prompt the user to enter the initial number of points
            Console.Write("Enter the initial number of points: ");
            int initialPoints = int.Parse(Console.ReadLine());

            // Calculate the basic bonus points
            double bonusPoints = 0;

            if (initialPoints <= 100)
            {
                bonusPoints = 5;
            }
            else if (initialPoints > 100 && initialPoints <= 1000)
            {
                bonusPoints = initialPoints * 0.20;
            }
            else if (initialPoints > 1000)
            {
                bonusPoints = initialPoints * 0.10;
            }

            // Calculate the additional bonus points
            if (initialPoints % 2 == 0)
            {
                bonusPoints += 1;
            }

            if (initialPoints % 10 == 5)
            {
                bonusPoints += 2;
            }

            // Calculate the total points
            double totalPoints = initialPoints + bonusPoints;

            // Display the bonus points and the total points
            Console.WriteLine($"Bonus points: {bonusPoints}");
            Console.WriteLine($"Total points: {totalPoints}");
        }
    }
}