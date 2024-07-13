using System.ComponentModel;

namespace _10.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A company gives the following commissions to its salespeople according to 
            the city in which they work and the volume of sales:
                City    (0 ≤ s ≤ 500) (500 < s ≤ 1,000) (1,000 < s ≤ 10,000) (s > 10,000)
                Sofia    5 %           7 %                  8 %                 12 %
                Varna    4.5 %         7.5 %                10 %                13 %
                Plovdiv  5.5 %         8 %                  12 %                14.5 %
            Write a console program that reads city name(string) and sales volume(real number) entered by the user,
            calculates and outputs the trade commission amount according to the above table.Output the result 
            formatted to 2 decimal places. Invalid city or sales volume(negative number) to print "error".*/

            // Prompt the user to enter the city name and sales volume
            Console.Write("Enter the city name (Sofia, Varna, Plovdiv): ");
            string city = Console.ReadLine().Trim().ToLower();

            Console.Write("Enter the sales volume: ");
            double salesVolume = double.Parse(Console.ReadLine());

            // Validate the sales volume
            if (salesVolume < 0)
            {
                Console.WriteLine("error");
                return;
            }

            // Calculate the commission based on the city and sales volume
            double commissionRate = 0;

            switch (city)
            {
                case "sofia":
                    if (salesVolume <= 500)
                        commissionRate = 0.05;
                    else if (salesVolume > 500 && salesVolume <= 1000)
                        commissionRate = 0.07;
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                        commissionRate = 0.08;
                    else if (salesVolume > 10000)
                        commissionRate = 0.12;
                    break;

                case "varna":
                    if (salesVolume <= 500)
                        commissionRate = 0.045;
                    else if (salesVolume > 500 && salesVolume <= 1000)
                        commissionRate = 0.075;
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                        commissionRate = 0.10;
                    else if (salesVolume > 10000)
                        commissionRate = 0.13;
                    break;

                case "plovdiv":
                    if (salesVolume <= 500)
                        commissionRate = 0.055;
                    else if (salesVolume > 500 && salesVolume <= 1000)
                        commissionRate = 0.08;
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                        commissionRate = 0.12;
                    else if (salesVolume > 10000)
                        commissionRate = 0.145;
                    break;

                default:
                    Console.WriteLine("error");
                    return;
            }

            // Calculate the commission amount
            double commissionAmount = salesVolume * commissionRate;

            // Output the result formatted to 2 decimal places
            Console.WriteLine($"{commissionAmount:F2}");
        }
    }
}