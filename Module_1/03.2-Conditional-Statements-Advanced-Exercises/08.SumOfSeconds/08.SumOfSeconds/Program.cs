using System.Threading;

namespace _08.SumOfSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Three sports competitors finish in some number of seconds(between 1 and 50). 
             To write a program that reads the times of the competitors in seconds entered by the user and calculates
             their total time in "minutes:seconds" format.The seconds should be displayed 
             with a leading zero(2 - "02", 7 - "07", 35 - "35").*/

            // Prompt the user to enter the times of the competitors
            Console.Write("Enter the time of the first competitor (in seconds): ");
            int time1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the time of the second competitor (in seconds): ");
            int time2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the time of the third competitor (in seconds): ");
            int time3 = int.Parse(Console.ReadLine());

            // Calculate the total time in seconds
            int totalTime = time1 + time2 + time3;

            // Convert total time to minutes and seconds
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            // Display the result in "minutes:seconds" format with leading zero for seconds
            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}