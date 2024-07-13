using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace _06.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Petya has a children's toy shop. She gets a big order to fulfill. With the money he will earn, 
            he wants to go on a trip. To write a program that calculates the profit from the order.
                Toy prices:
                    Puzzle - BGN 2.60.
                    Talking doll -BGN 3
                    Teddy bear -BGN 4.10.
                    Mignon - BGN 8.20.
                    Truck - BGN 2
            If the ordered toys are 50 or more, the store discounts 25 % of the total price.
            From the money earned, Petya must give 10 % for the rent of the shop.
            To calculate whether the money will be enough for her to go on an excursion.*/

            Console.Write("Enter the number of Puzzles: ");
            int puzzles = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Talking Dolls: ");
            int talkingDolls = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Teddy Bears: ");
            int teddyBears = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Mignons: ");
            int mignons = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Trucks: ");
            int trucks = int.Parse(Console.ReadLine());

            // Toy prices
            double puzzlePrice = 2.60;
            double talkingDollPrice = 3.00;
            double teddyBearPrice = 4.10;
            double mignonPrice = 8.20;
            double truckPrice = 2.00;

            // Calculate the total price before discount
            double totalPrice = puzzles * puzzlePrice +
                                talkingDolls * talkingDollPrice +
                                teddyBears * teddyBearPrice +
                                mignons * mignonPrice +
                                trucks * truckPrice;

            // Apply 25% discount if the total number of toys is 50 or more
            if (puzzles + talkingDolls + teddyBears + mignons + trucks >= 50)
            {
                totalPrice *= 0.75; // 25% discount
            }

            // Calculate the profit after deducting 10% for shop rent
            double profit = totalPrice * 0.90; // 10% deduction for rent

            // Prompt Petya whether she has enough money for the trip
            Console.Write("Enter the cost of the trip: ");
            double tripCost = double.Parse(Console.ReadLine());

            if (profit >= tripCost)
            {
                Console.WriteLine($"Yes! You have enough money left for your trip. Profit: {profit - tripCost:F2} BGN.");
            }
            else
            {
                Console.WriteLine($"No! You need {tripCost - profit:F2} BGN more for your trip.");
            }
        }
    }
}