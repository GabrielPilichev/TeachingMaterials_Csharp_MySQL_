namespace _18.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Strange, but most people plan their vacation early. A young programmer has a certain budget and free time in a given season.
           Write a program that accepts as input the budget and the season, and outputs where the programmer will rest and how much he will spend.
           The budget determines the destination and the season determines how much of the budget will be spent. If it's summer, they will go camping,
           and if it's winter - they will stay in a hotel. If the destination is in Europe, regardless of the season, they will stay in a hotel.
           Each camping or hotel, according to the destination, has its own price, which corresponds to a certain percentage of the budget:
           • At BGN 100 or less - somewhere in Bulgaria
             - Summer -> 30% of the budget
             - Winter -> 70% of the budget
           • At BGN 1000 or less - somewhere in the Balkans
             - Summer -> 40% of the budget
             - Winter -> 80% of the budget
           • For more than BGN 1000 - somewhere in Europe
             - In Europe, regardless of the season, they will spend 90% of the budget. */

            // Input values
            double budget = double.Parse(Console.ReadLine()); // Example input: 800 (budget in BGN)
            string season = Console.ReadLine().ToLower(); // Example input: "summer" or "winter"

            // Determine destination and calculate expenses
            string destination = "";
            double expenses = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    expenses = budget * 0.30;
                }
                else if (season == "winter")
                {
                    expenses = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    expenses = budget * 0.40;
                }
                else if (season == "winter")
                {
                    expenses = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                expenses = budget * 0.90; // In Europe, regardless of season, 90% of the budget is spent
            }

            // Output result
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"Budget spent: {expenses:F2} BGN");
        }
    }
}