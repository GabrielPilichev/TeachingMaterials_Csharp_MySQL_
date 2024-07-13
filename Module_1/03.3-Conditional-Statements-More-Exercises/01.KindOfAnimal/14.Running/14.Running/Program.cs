namespace _14.Running
{
    internal class Program
    {
        static void Main(string[] args)
        {
                /*
                Mimi loves to run outside and strictly adheres to her daily running schedule. 
                However, she has the strength to run actively for 40,000 minutes a year. The rest 
                of the time she needs rest to regain her strength. Mimi's running time depends on 
                the number of "hard" and "light" days in her training schedule:
                • On "hard" days, she runs 115 minutes a day.
                • On "light" days, she runs 55 minutes a day.
                Write a program that reads the number of off days from the console and prints 
                whether Mimi has taken enough rest and the difference from the norm for the current year, 
                assuming that the year has 365 days.
                Example: 20 light days -> heavy days are 345 (365 – 20 = 345). The actual time she ran 
                for the entire year was 40,775 minutes (345 * 115 + 20 * 55). The difference is 775 minutes 
                over the norm (40,775 - 40,000 = 775) or 12 hours and 55 minutes.
                */

                // Read input from the user
                int offDays = int.Parse(Console.ReadLine());

                // Calculate the number of hard and light days
                int hardDays = 365 - offDays;
                int lightDays = offDays;

                // Calculate total running minutes for the year
                int totalRunningMinutes = hardDays * 115 + lightDays * 55;

                // Calculate the difference from the norm
                int difference = totalRunningMinutes - 40000;

                // Calculate hours and minutes from the difference
                int hoursDifference = difference / 60;
                int minutesDifference = difference % 60;

                // Output the result
                Console.WriteLine($"Mimi has run {totalRunningMinutes} minutes this year.");
                if (difference > 0)
                {
                    Console.WriteLine($"The difference is {difference} minutes over the norm ({hoursDifference} hours and {minutesDifference} minutes).");
                }
                else if (difference < 0)
                {
                    Console.WriteLine($"The difference is {-difference} minutes under the norm.");
                }
                else
                {
                    Console.WriteLine("Mimi has run exactly as planned!");
                }
            }
        }
    }
