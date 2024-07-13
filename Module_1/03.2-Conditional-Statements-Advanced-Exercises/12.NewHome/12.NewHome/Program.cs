using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace _12.NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Marin and Nellie buy a house not far from Sofia.Nellie loves flowers so much that she convinces you to write
            a program to calculate how much it will cost them to plant a certain number of flowers and whether 
            the available budget will be enough for them.Different flowers have different prices.
                Flower                  Rose Dahlia Tulip Narcissus Gladiola
                Price                   5    3.80   2.80   3        2.50

            The following discounts are available:
                - If Nellie buys more than 80 roses ➡ 10 % discount on the final price
                - If Nellie buys more than 90 dahlias ➡ 15 % discount on the final price
                - If Nellie buys more than 80 tulips ➡ 15 % discount on the final price
                - If Nellie buys less than 120 daffodils ➡ the price increases by 15 %
                - If Nellie buys less than 80 gladioli ➡the price increases by 20 %
            3 lines are read from the console:
                - Flower type - text with options - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
                - Number of flowers - an integer in the range[10…1000]
                - Budget - an integer in the range[50…2500]

            To print to the console on one line:
                - If the budget is sufficient ➡ "Hey, you have a great garden with {number of flowers} {type of flowers} and {remaining amount} leva left."
                - If the budget is NOT sufficient ➡ "Not enough money, you need {necessary amount} leva more."
            Amount to be formatted to the second decimal place.*/

            // Flower prices
            const double RosePrice = 5.00;
            const double DahliaPrice = 3.80;
            const double TulipPrice = 2.80;
            const double NarcissusPrice = 3.00;
            const double GladiolaPrice = 2.50;

            // Read input from the user
            Console.Write("Enter flower type (Roses, Dahlias, Tulips, Narcissus, Gladiolus): ");
            string flowerType = Console.ReadLine().ToLower();

            Console.Write("Enter number of flowers (10-1000): ");
            int numberOfFlowers = int.Parse(Console.ReadLine());

            Console.Write("Enter budget (50-2500): ");
            double budget = double.Parse(Console.ReadLine());

            // Calculate total price based on flower type and number of flowers
            double totalPrice = 0;

            switch (flowerType)
            {
                case "roses":
                    totalPrice = numberOfFlowers * RosePrice;
                    // Apply discount if more than 80 roses
                    if (numberOfFlowers > 80)
                    {
                        totalPrice *= 0.90; // 10% discount
                    }
                    break;
                case "dahlias":
                    totalPrice = numberOfFlowers * DahliaPrice;
                    // Apply discount if more than 90 dahlias
                    if (numberOfFlowers > 90)
                    {
                        totalPrice *= 0.85; // 15% discount
                    }
                    break;
                case "tulips":
                    totalPrice = numberOfFlowers * TulipPrice;
                    // Apply discount if more than 80 tulips
                    if (numberOfFlowers > 80)
                    {
                        totalPrice *= 0.85; // 15% discount
                    }
                    break;
                case "narcissus":
                    totalPrice = numberOfFlowers * NarcissusPrice;
                    // Increase price if less than 120 narcissus
                    if (numberOfFlowers < 120)
                    {
                        totalPrice *= 1.15; // 15% increase
                    }
                    break;
                case "gladiolus":
                    totalPrice = numberOfFlowers * GladiolaPrice;
                    // Increase price if less than 80 gladiolus
                    if (numberOfFlowers < 80)
                    {
                        totalPrice *= 1.20; // 20% increase
                    }
                    break;
                default:
                    Console.WriteLine("Invalid flower type.");
                    return;
            }

            // Check if the budget is sufficient
            if (budget >= totalPrice)
            {
                double remainingAmount = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {remainingAmount:F2} leva left.");
            }
            else
            {
                double necessaryAmount = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {necessaryAmount:F2} leva more.");
            }
        }
    }
}