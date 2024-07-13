namespace _17.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tony and friends really like to go fishing. They are so passionate about fishing that they decide to go fishing by boat.
          The price for renting the vessel depends on the season and the number of fishermen.
          The price depends on the season:
          • The price for renting the ship in spring is BGN 3,000.
          • The price for renting the ship in summer and autumn is BGN 4,200.
          • The price for renting the ship in winter is BGN 2,600.
          Depending on their number, the group benefits from a discount:
          • If the group is up to 6 people inclusive - 10% discount.
          • If the group is from 7 to 11 people inclusive - 15% discount.
          • If the group is 12 or more - 25% discount.
          Fishermen enjoy an additional 5% discount if they are an even number unless it is autumn - then they do not have an additional discount,
          which is charged after deducting the discount according to the above criteria.
          Write a program to calculate whether the fishermen will collect enough money. */

            // Input values
            string season = Console.ReadLine(); // Example input: "spring", "summer", "autumn", "winter"
            int fishermenCount = int.Parse(Console.ReadLine()); // Example input: 8 (number of fishermen)

            // Constants for prices
            int springPrice = 3000;
            int summerAutumnPrice = 4200;
            int winterPrice = 2600;

            // Determine the base price based on the season
            int basePrice = 0;
            switch (season)
            {
                case "spring":
                    basePrice = springPrice;
                    break;
                case "summer":
                case "autumn":
                    basePrice = summerAutumnPrice;
                    break;
                case "winter":
                    basePrice = winterPrice;
                    break;
            }

            // Calculate initial price based on the season
            double totalPrice = basePrice;

            // Apply discounts based on the number of fishermen
            if (fishermenCount <= 6)
            {
                totalPrice *= 0.90; // 10% discount for up to 6 fishermen
            }
            else if (fishermenCount >= 7 && fishermenCount <= 11)
            {
                totalPrice *= 0.85; // 15% discount for 7 to 11 fishermen
            }
            else if (fishermenCount >= 12)
            {
                totalPrice *= 0.75; // 25% discount for 12 or more fishermen
            }

            // Check additional 5% discount condition
            if (fishermenCount % 2 == 0 && season != "autumn")
            {
                totalPrice *= 0.95; // Additional 5% discount for even number of fishermen, except in autumn
            }

            // Output result
            Console.WriteLine($"The total price for the fishing trip is: {totalPrice:F2} BGN");

            // Check if they have enough money
            double moneyCollected = double.Parse(Console.ReadLine()); // Example input: 3500 (money collected)
            if (moneyCollected >= totalPrice)
            {
                Console.WriteLine("Yes, there is enough money for the fishing trip.");
            }
            else
            {
                Console.WriteLine($"No, there is not enough money. They need {totalPrice - moneyCollected:F2} BGN more.");
            }
        }
    }
}