using System.ComponentModel;
using System.Diagnostics;

namespace _05.NeighborhoodShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*An enterprising Bulgarian opens neighborhood shops in several cities 
            and sells at different prices depending on the city:
            city​/product coffee water juice sweets peanuts
                 Sofia   0.50   0.80  1.20  1.45   1.60
                 Plovdiv 0.40   0.70  1.15  1.30   1.50
                 Varna   0.45   0.70  1.10  1.35   1.55
            Write a program that reads a product(string), city(string), and quantity(decimal number) 
            entered by the user and calculates and prints 
            how much the corresponding quantity of the selected product costs in the specified city.*/

            // Prompt the user to enter the product, city, and quantity
            Console.Write("Enter the product: ");
            string product = Console.ReadLine().Trim().ToLower();

            Console.Write("Enter the city: ");
            string city = Console.ReadLine().Trim().ToLower();

            Console.Write("Enter the quantity: ");
            decimal quantity = decimal.Parse(Console.ReadLine());

            // Define the price variable
            decimal price = 0;

            // Determine the price based on the city and product
            switch (city)
            {
                case "sofia":
                    if (product == "coffee") price = 0.50m;
                    else if (product == "water") price = 0.80m;
                    else if (product == "juice") price = 1.20m;
                    else if (product == "sweets") price = 1.45m;
                    else if (product == "peanuts") price = 1.60m;
                    break;

                case "plovdiv":
                    if (product == "coffee") price = 0.40m;
                    else if (product == "water") price = 0.70m;
                    else if (product == "juice") price = 1.15m;
                    else if (product == "sweets") price = 1.30m;
                    else if (product == "peanuts") price = 1.50m;
                    break;

                case "varna":
                    if (product == "coffee") price = 0.45m;
                    else if (product == "water") price = 0.70m;
                    else if (product == "juice") price = 1.10m;
                    else if (product == "sweets") price = 1.35m;
                    else if (product == "peanuts") price = 1.55m;
                    break;

                default:
                    Console.WriteLine("Invalid city entered.");
                    return;
            }

            // Calculate and print the total cost
            decimal totalCost = quantity * price;
            Console.WriteLine($"Total cost: {totalCost:F2}");

        }
    }
}