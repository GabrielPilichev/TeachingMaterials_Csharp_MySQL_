using static System.Net.Mime.MediaTypeNames;

namespace _03.WorkingTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*To write a program that reads the time of day(integer) and day of the week(text) entered by the user 
            and checks whether a company's office is open, with office hours being 10am to 6pm, Monday to Saturday inclusive.*/

            // Prompt the user to enter the time of day and day of the week
            Console.Write("Enter the time of day (in 24-hour format, e.g., 1000 for 10:00 AM): ");
            int timeOfDay = int.Parse(Console.ReadLine());

            Console.Write("Enter the day of the week (Monday, Tuesday, ..., Saturday): ");
            string dayOfWeek = Console.ReadLine().Trim().ToLower();

            // Check if the office is open based on the time and day
            bool isOpen = false;

            // Check if it's within office hours (10am to 6pm) and valid day
            if (timeOfDay >= 1000 && timeOfDay <= 1800 && (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" ||
                                                           dayOfWeek == "thursday" || dayOfWeek == "friday" || dayOfWeek == "saturday"))
            {
                isOpen = true;
            }

            // Print the result
            if (isOpen)
            {
                Console.WriteLine("The office is open.");
            }
            else
            {
                Console.WriteLine("The office is closed.");
            }
        }
    }
}