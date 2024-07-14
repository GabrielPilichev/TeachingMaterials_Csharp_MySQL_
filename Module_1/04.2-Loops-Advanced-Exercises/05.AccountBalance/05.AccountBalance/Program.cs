using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates how much total money is in the account after you make a certain number of deposits. 
            On each line you will receive the amount you need to deposit into the account until you receive a "NoMoreMoney" command.
            For each amount received, "Increase: " + the amount must be displayed on the console and added to the account. 
            If you get a number less than 0, the console should display "Invalid operation!" and the cycle ends. 
            When the loop is finished, it should print "Total: " + the total amount in the account, rounded to the second decimal place.*/

            double totalAmount = 0.0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }

                double deposit = double.Parse(input);

                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {deposit:F2}");
                totalAmount += deposit;
            }

            Console.WriteLine($"Total: {totalAmount:F2}");
        }
    }
}