using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace _08.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Atanas decides to spend his vacation in Bansko and go skiing. Before he goes, however, he needs to book a hotel
            and calculate how much the stay will cost him.There are the following types of rooms with the following prices for a stay:
                -"room for one person" – BGN 18.00 per night
                - "apartment" – BGN 25.00 per night
                - "president apartment" – BGN 35.00 per night
            Depending on the number of days he will stay in the hotel(example: 11 days = 10 nights) and the type of room
            he will choose, he can use a different discount.The reductions are as follows:

                (type of premises)      (less than 10 days)         (between 10 and 15 days)  (more than 15 days)

                (room for one person)   (does not use a discount)   (does not use a discount) (does not use a discount)
                (apartment)             (30 % of the final price)   (35 % of the final price) (50 % of the final price)
                (president apartment)   (10 % of the final price)   (15 % of the final price) (20 % of the final price)

            After the stay, Atanas' assessment of the hotel's services may be positive or negative.
            If his assessment is positive, Atanas adds 25 % of it to the price with the discount already deducted.
            If his assessment is negative, 10 % is deducted from the price.*/

            // Constants for room prices per night
            const double RoomForOnePersonPrice = 18.00;
            const double ApartmentPrice = 25.00;
            const double PresidentApartmentPrice = 35.00;

            // Prompt the user to enter the type of room and number of days
            Console.WriteLine("Types of rooms: ");
            Console.WriteLine("1. Room for one person");
            Console.WriteLine("2. Apartment");
            Console.WriteLine("3. President apartment");
            Console.Write("Enter your choice (1, 2, or 3): ");
            int roomChoice = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of days you will stay: ");
            int days = int.Parse(Console.ReadLine());

            // Calculate the number of nights (assuming each day includes an overnight stay)
            int nights = days - 1;

            // Calculate the total cost based on the chosen room and duration
            double totalPrice = 0;

            switch (roomChoice)
            {
                case 1: // Room for one person
                    totalPrice = nights * RoomForOnePersonPrice;
                    break;
                case 2: // Apartment
                    totalPrice = nights * ApartmentPrice;
                    if (days > 15)
                    {
                        totalPrice *= 0.50; // 50% discount
                    }
                    else if (days >= 10)
                    {
                        totalPrice *= 0.65; // 35% discount
                    }
                    else
                    {
                        totalPrice *= 0.70; // 30% discount
                    }
                    break;
                case 3: // President apartment
                    totalPrice = nights * PresidentApartmentPrice;
                    if (days > 15)
                    {
                        totalPrice *= 0.80; // 20% discount
                    }
                    else if (days >= 10)
                    {
                        totalPrice *= 0.85; // 15% discount
                    }
                    else
                    {
                        totalPrice *= 0.90; // 10% discount
                    }
                    break;
                default:
                    Console.WriteLine("Invalid room choice.");
                    return;
            }

            // Prompt the user for Atanas's assessment
            Console.Write("Enter your assessment (positive or negative): ");
            string assessment = Console.ReadLine().ToLower();

            // Calculate the final price based on the assessment
            if (assessment == "positive")
            {
                totalPrice *= 1.25; // Add 25% to the price
            }
            else if (assessment == "negative")
            {
                totalPrice *= 0.90; // Subtract 10% from the price
            }
            else
            {
                Console.WriteLine("Invalid assessment.");
                return;
            }

            // Print the total cost rounded to 2 decimal places
            Console.WriteLine($"Total cost of stay: {totalPrice:F2} BGN");


        }
    }
}