using static System.Reflection.Metadata.BlobBuilder;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System;

namespace _09.WorldRecordInSwimming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ivan decides to improve the world record for long - distance swimming.
            Enter the record in seconds that Ivan needs to beat, the distance in meters that he needs to swim,
            and the time in seconds that Ivan needs to swim 1 m on the console.
            Write a program that calculates whether he has completed the task, 
            considering that water resistance slows it down every 15 m by 12.5 seconds.
            When calculating how many times Ivancho will slow down due to water resistance, 
            the result must be rounded down to the nearest whole number.

            To calculate the time in seconds that Ivancho will take to swim the distance 
            and the difference to the world record.*/

            // Prompt the user to enter the required data
            Console.Write("Enter the world record Ivan needs to beat (in seconds): ");
            int worldRecord = int.Parse(Console.ReadLine());

            Console.Write("Enter the distance Ivan needs to swim (in meters): ");
            int distance = int.Parse(Console.ReadLine());

            Console.Write("Enter Ivan's swimming speed per meter (in seconds): ");
            double speedPerMeter = double.Parse(Console.ReadLine());

            // Calculate the time Ivan will take without considering water resistance
            double timeWithoutResistance = distance * speedPerMeter;

            // Calculate how many times Ivan will slow down due to water resistance
            int slowdowns = distance / 15;

            // Calculate the total time with water resistance slowing him down
            double timeWithResistance = timeWithoutResistance + (slowdowns * 12.5);

            // Calculate the difference from the world record
            double difference = timeWithResistance - worldRecord;

            // Output the results
            Console.WriteLine($"Time to swim the distance: {timeWithResistance:F2} seconds");
            Console.WriteLine($"Difference to the world record: {difference:F2} seconds");

            // Check if Ivan beats the world record
            if (timeWithResistance < worldRecord)
            {
                Console.WriteLine("Ivan beats the world record!");
            }
            else
            {
                Console.WriteLine("Ivan does not beat the world record.");
            }
        }
    }
}