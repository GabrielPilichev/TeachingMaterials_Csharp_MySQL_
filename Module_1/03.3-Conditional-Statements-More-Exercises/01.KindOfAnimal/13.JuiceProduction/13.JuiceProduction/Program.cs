namespace _13.JuiceProduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise description:
            // A food company has an orchard of A square meters in area, with 40% of the harvest set aside for the production of apple juice.
            // B kilograms of apples are obtained from 1 square meter of orchard. 
            // 2.3 kg of apples are needed to fill 1 can of juice.
            // The number of cases of juice to be produced is C.
            //
            // Write a program that calculates how much juice can be produced and whether this amount is sufficient.

            // Constants for the exercise
            const double KilogramsPerCan = 2.3;
            const double JuicePercentage = 0.4; // 40% of the harvest goes to juice production

            // Read input from the user
            double A = double.Parse(Console.ReadLine()); // Area of the orchard in square meters
            double B = double.Parse(Console.ReadLine()); // Kilograms of apples obtained per square meter
            int C = int.Parse(Console.ReadLine()); // Number of cases of juice to be produced

            // Calculate the total kilograms of apples harvested
            double totalApples = A * B;

            // Calculate the kilograms of apples reserved for juice production
            double applesForJuice = totalApples * JuicePercentage;

            // Calculate the number of cans of juice that can be produced
            double cansOfJuice = applesForJuice / KilogramsPerCan;

            // Calculate if the amount of juice is sufficient
            bool isSufficient = cansOfJuice >= C;

            // Output the result
            Console.WriteLine($"Total cans of juice: {cansOfJuice:F2}");
            Console.WriteLine($"Is the amount sufficient? {isSufficient}");
        }
    }
}