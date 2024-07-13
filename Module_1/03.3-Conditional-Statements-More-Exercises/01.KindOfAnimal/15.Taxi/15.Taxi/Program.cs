namespace _15.Taxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            In one of the most popular taxi companies, the prices per kilometer depending on the month and time of day are as follows:
              January to April   May to August   September to December
            Day: 0.81 BGN/km    0.91 BGN/km     0.85 BGN/km
            Night: 1.00 BGN/km  1.05 BGN/km     1.03 BGN/km

            Write a program that calculates the cost of a trip based on the kilometers traveled.
            */

            // Read input from the user
            int kilometers = int.Parse(Console.ReadLine());
            string month = Console.ReadLine(); // Example input: "January"
            string timeOfDay = Console.ReadLine(); // Example input: "Day" or "Night"

            // Declare variables for prices per kilometer
            double dayPrice = 0, nightPrice = 0;

            // Determine prices based on the month
            if (month == "January" || month == "February" || month == "March" || month == "April")
            {
                dayPrice = 0.81;
                nightPrice = 1.00;
            }
            else if (month == "May" || month == "June" || month == "July" || month == "August")
            {
                dayPrice = 0.91;
                nightPrice = 1.05;
            }
            else if (month == "September" || month == "October" || month == "November" || month == "December")
            {
                dayPrice = 0.85;
                nightPrice = 1.03;
            }
            else
            {
                Console.WriteLine("Invalid month input.");
                return;
            }

            // Calculate cost of the trip
            double cost;
            if (timeOfDay == "Day")
            {
                cost = kilometers * dayPrice;
            }
            else if (timeOfDay == "Night")
            {
                cost = kilometers * nightPrice;
            }
            else
            {
                Console.WriteLine("Invalid time of day input.");
                return;
            }

            // Output the result
            Console.WriteLine($"The cost of the trip is {cost:F2} BGN.");
        }
    }
}