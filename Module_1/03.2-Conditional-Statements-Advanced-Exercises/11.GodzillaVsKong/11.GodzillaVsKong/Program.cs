using System.ComponentModel;
using System;

namespace _11.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Filming for the highly anticipated Godzilla vs.Kong movie begins. Screenwriter Adam Wingard asks you
             to write a program to calculate whether the budgeted funds are sufficient to make the film.
             The shoot will require a certain number of extras, clothing for each extra, and decor.
             It is known that:
                 - The set for the film is worth 10 % of the budget.
                 - For more than 150 extras, there is a 10 % clothing discount.*/

            // Prompt the user to enter the budget, number of extras, cost per clothing, and decor cost
            Console.Write("Enter the budget: ");
            double budget = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of extras: ");
            int numberOfExtras = int.Parse(Console.ReadLine());

            Console.Write("Enter the cost per clothing: ");
            double clothingCostPerExtra = double.Parse(Console.ReadLine());

            Console.Write("Enter the decor cost: ");
            double decorCost = double.Parse(Console.ReadLine());

            // Calculate the set cost (10% of the budget)
            double setCost = budget * 0.10;

            // Calculate the clothing cost for extras
            double clothingCost = numberOfExtras * clothingCostPerExtra;

            // Apply the clothing discount if there are more than 150 extras
            if (numberOfExtras > 150)
            {
                clothingCost *= 0.90; // 10% discount
            }

            // Calculate the total cost
            double totalCost = setCost + clothingCost + decorCost;

            // Check if the budget is sufficient
            if (budget >= totalCost)
            {
                Console.WriteLine("The budget is sufficient. Let's start filming!");
            }
            else
            {
                Console.WriteLine("The budget is not sufficient. We need more funds.");
            }
        }
    }
}