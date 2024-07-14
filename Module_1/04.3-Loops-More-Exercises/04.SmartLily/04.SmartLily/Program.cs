using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;

namespace _04.SmartLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Lily is now N years old. For every birthday she gets a present.
            For odd birthdays(1, 3, 5...n) she gets toys, and for even(2, 4, 6...n) she gets money.
            For the second birthday, she receives BGN 10.00, and the amount increases by BGN 10.00 
            for each subsequent even birthday(2-> 10, 4-> 20, 6-> 30...etc.).
            In the years in which she receives money, her brother takes BGN 1.00 from it.
            Lily sold the toys received over the years for BGN 5 each and added the amount to the money saved.
            With the money, she wanted to buy a washing machine for BGN X. 
                            
            Write a program to calculate how much money she has collected and whether 
            she has enough to buy a washing machine.*/

            int age = int.Parse(Console.ReadLine());
            decimal washingMachinePrice = decimal.Parse(Console.ReadLine());

            decimal moneySaved = 0;
            decimal toyMoney = 0;
            decimal moneyReceived = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)  // Odd birthday - receives toys
                {
                    toyMoney += 5;
                }
                else  // Even birthday - receives money
                {
                    moneyReceived += 10 * (i / 2);
                    moneySaved += moneyReceived - (i / 2);
                }
            }

            moneySaved += toyMoney;

            if (moneySaved >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {moneySaved - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - moneySaved:F2}");
            }
        }
    }
}