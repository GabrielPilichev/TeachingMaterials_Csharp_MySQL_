namespace _16.Candy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program to calculate the bill of a customer who bought a certain number of different boxes of candy.
            Small   Medium   Large
            Red     BGN 1.50/pc.  BGN 2.20/pc.  BGN 3.70/pc.
            Blue    BGN 1.30/pc.  BGN 1.80/pc.  BGN 2.10/pc.
            Green   BGN 2.50/pc.  BGN 3.60/pc.  BGN 5.20/pc.

            Since it's a holiday, the candy boxes have the following discounts:
            • On any medium box selected ➡ 5% discount
            • When choosing a large box of greens and buying at least 5 pieces ➡ 25% discount
            • For an amount exceeding BGN 30 ➡ 10% discount
            Discounts apply in the order they are described.
            */

            // Input values
            string candyType = Console.ReadLine(); // Example input: "Red", "Blue", "Green"
            string boxSize = Console.ReadLine(); // Example input: "Small", "Medium", "Large"
            int quantity = int.Parse(Console.ReadLine());

            // Declare variables for prices
            double pricePerPiece = 0;

            // Determine price per piece based on candy type and box size
            if (candyType == "Red")
            {
                if (boxSize == "Small")
                    pricePerPiece = 1.50;
                else if (boxSize == "Medium")
                    pricePerPiece = 2.20;
                else if (boxSize == "Large")
                    pricePerPiece = 3.70;
            }
            else if (candyType == "Blue")
            {
                if (boxSize == "Small")
                    pricePerPiece = 1.30;
                else if (boxSize == "Medium")
                    pricePerPiece = 1.80;
                else if (boxSize == "Large")
                    pricePerPiece = 2.10;
            }
            else if (candyType == "Green")
            {
                if (boxSize == "Small")
                    pricePerPiece = 2.50;
                else if (boxSize == "Medium")
                    pricePerPiece = 3.60;
                else if (boxSize == "Large")
                    pricePerPiece = 5.20;
            }

            // Calculate total price before discounts
            double totalPrice = quantity * pricePerPiece;

            // Apply discounts in order
            if (boxSize == "Medium")
            {
                totalPrice *= 0.95; // 5% discount on medium boxes
            }
            else if (candyType == "Green" && boxSize == "Large" && quantity >= 5)
            {
                totalPrice *= 0.75; // 25% discount on large green boxes with 5 or more pieces
            }

            if (totalPrice > 30)
            {
                totalPrice *= 0.90; // 10% discount for total price exceeding BGN 30
            }

            // Print the result formatted to 2 decimal places
            Console.WriteLine($"The bill is: {totalPrice:F2} BGN");
        }
    }
}