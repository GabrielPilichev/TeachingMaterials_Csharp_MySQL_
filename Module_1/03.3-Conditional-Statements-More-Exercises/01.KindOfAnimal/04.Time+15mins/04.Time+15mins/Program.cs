namespace _04.Time_15mins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads the hour and minutes of a 24 - hour day entered by the user and calculates 
            what the time will be in 15 minutes.Print the result in hours: minutes format. Hours are always between 
            0 and 23 and minutes are always between 0 and 59.Hours are written as one or two digits.
            Minutes are always written as two digits, with a leading zero when necessary.*/

            // Prompt the user to enter the hour and minutes
            Console.Write("Enter the hour (0-23): ");
            int hour = int.Parse(Console.ReadLine());

            Console.Write("Enter the minutes (0-59): ");
            int minutes = int.Parse(Console.ReadLine());

            // Calculate the time after adding 15 minutes
            minutes += 15;

            // Adjust the hour and minutes if minutes exceeds 59
            if (minutes >= 60)
            {
                hour += 1;
                minutes -= 60;
            }

            // Adjust the hour if it exceeds 23 (wrap around for next day)
            if (hour >= 24)
            {
                hour -= 24;
            }

            // Print the result in hours:minutes format
            Console.WriteLine($"{hour:D2}:{minutes:D2}");
        }
    }
}