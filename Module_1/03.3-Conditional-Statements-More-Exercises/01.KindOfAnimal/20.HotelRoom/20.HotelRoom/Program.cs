namespace _20.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hotel offers 2 types of rooms: studio and apartment. 
               Write a program that calculates the total stay price for a studio and apartment.
            Prices depend on the month of stay:
            May and October
            - Studio: BGN 50/night
            - Apartment: BGN 65/night
            June and September
            - Studio: BGN 75.20/night
            - Apartment: BGN 68.70/night
            July and August
            - Studio: BGN 76/night
            - Apartment: BGN 77/night

            The following discounts are also available:
            - For studio, for more than 7 nights in May and October ➡ 5% discount.
            - For studio, for more than 14 nights in May and October ➡ 30% discount.
            - For studio, for more than 14 nights in June and September ➡ 20% discount.
            - For an apartment, for more than 14 nights, regardless of the month ➡ 10% discount.
         */

            // Input values
            string month = Console.ReadLine(); // Example input: "May"
            int nights = int.Parse(Console.ReadLine()); // Example input: 15

            // Prices per night based on the month and type of room
            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                if (nights > 14)
                {
                    studioPrice *= 0.7; // Apply 30% discount for more than 14 nights
                }
                else if (nights > 7)
                {
                    studioPrice *= 0.95; // Apply 5% discount for more than 7 nights
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (nights > 14)
                {
                    studioPrice *= 0.8; // Apply 20% discount for more than 14 nights
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }
            else
            {
                Console.WriteLine("Invalid month!");
                return;
            }

            // Calculate total price for the stay
            double studioTotalPrice = studioPrice * nights;
            double apartmentTotalPrice = apartmentPrice * nights;

            // Output the result
            Console.WriteLine($"Studio: {studioTotalPrice:F2} lv.");
            Console.WriteLine($"Apartment: {apartmentTotalPrice:F2} lv.");
        }
    }
}