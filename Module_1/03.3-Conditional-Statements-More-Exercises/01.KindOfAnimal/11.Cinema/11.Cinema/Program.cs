using System.ComponentModel;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Threading;
using System;

namespace _11.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*In a movie theater, the chairs are arranged in a rectangular shape in r rows and c columns.
                There are three types of screenings with tickets at different prices:
                    - Premiere – premiere screening, at a price of BGN 12.00.
                    - Normal – standard projection, at a price of BGN 7.50.
                    - Discount – screening for children, schoolchildren and students at a reduced price of BGN 5.00.

            Write a program that reads the screening type(string), number of rows and number of columns
            in the hall(integers) entered by the user and calculates the total ticket revenue for a full house.
            Print the result in a format like the examples below, with 2 decimal places. (1440.00 leva)*/

            // Input from the user
            Console.Write("Enter the screening type (Premiere/Normal/Discount): ");
            string screeningType = Console.ReadLine();

            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            // Constants for ticket prices
            const double PremierePrice = 12.00;
            const double NormalPrice = 7.50;
            const double DiscountPrice = 5.00;

            // Calculate total number of seats in the theater
            int totalSeats = rows * columns;

            // Calculate total revenue based on screening type
            double totalRevenue = 0;

            switch (screeningType.ToLower())
            {
                case "premiere":
                    totalRevenue = totalSeats * PremierePrice;
                    break;
                case "normal":
                    totalRevenue = totalSeats * NormalPrice;
                    break;
                case "discount":
                    totalRevenue = totalSeats * DiscountPrice;
                    break;
                default:
                    Console.WriteLine("Invalid screening type.");
                    return;
            }

            // Output the total revenue formatted to 2 decimal places
            Console.WriteLine($"Total revenue: {totalRevenue:F2} BGN");
        }
    }
}