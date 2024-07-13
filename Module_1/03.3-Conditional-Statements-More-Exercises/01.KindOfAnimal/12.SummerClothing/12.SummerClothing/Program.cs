namespace _12.SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Summer has very changeable weather and Victor needs your help. 
            // Write a program that, based on the time of day and degrees, recommends Victor what clothes to wear. 
            // Your friend has different plans for each stage of the day, which also require a different appearance, you can see them from the table.
            // Exactly two lines are read from the console:
            // • Degrees - an integer in the interval [10…42]
            // • Time of day - text - "Morning", "Afternoon" or "Evening"
            //
            // Time of day/degrees     Morning                     Afternoon                   Evening
            // 10 <= degrees <= 18     Outfit = Sweatshirt         Outfit = Shirt              Outfit = Shirt
            //                         Shoes = Sneakers            Shoes = Moccasins           Shoes = Moccasins
            //
            // 18 < degrees <= 24      Outfit = Shirt              Outfit = T-Shirt            Outfit = Shirt
            //                         Shoes = Moccasins           Shoes = Sandals             Shoes = Moccasins
            //
            // degrees >= 25           Outfit = T-Shirt            Outfit = Swim Suit          Outfit = Shirt
            //                         Shoes = Sandals             Shoes = Barefoot            Shoes = Moccasins
            //
            // To print on the console one line: "It's {degrees} degrees, get your {clothes} and {shoes}."

            // Read degrees from the user input
            int degrees = int.Parse(Console.ReadLine());

            // Read time of day from the user input
            string timeOfDay = Console.ReadLine();

            // Initialize variables for clothes and shoes
            string clothes = "";
            string shoes = "";

            // Determine clothes and shoes based on degrees and time of day
            if (timeOfDay == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    clothes = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 24)
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeOfDay == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degrees > 24)
                {
                    clothes = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (timeOfDay == "Evening")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 24)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
            }

            // Output the recommendation
            Console.WriteLine($"It's {degrees} degrees, get your {clothes} and {shoes}.");

        }
    }
}