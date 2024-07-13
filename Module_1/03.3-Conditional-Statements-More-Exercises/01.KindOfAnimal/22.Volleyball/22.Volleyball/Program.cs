namespace _22.Volleyball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Vladi is a student, lives in Sofia and goes to his hometown from time to time. 
           He plays volleyball in Sofia every Saturday when he is not at work and traveling to his hometown,
           as well as on 2/3 of the holidays. Vladi travels to his hometown h times a year,
           where he plays volleyball with his old friends on Sundays.
           Vladi is not at work 3/4 of the weekends he is in Sofia. Separately, during leap years,
           Vladi plays 15% more volleyball than normal.
           We assume that there are exactly 48 weekends suitable for volleyball in the year.
           Write a program that calculates how many times Vladi has played volleyball during the year.
           Round the result down to the nearest whole number (eg 2.15 -> 2; 9.95 -> 9).
           
           Input data is entered by the user in the following form:
           - The first line contains the word "leap" or "normal".
           - The second line contains the integer p - number of holidays in the year (which are not Saturdays and Sundays).
           - The third line contains the integer h - number of weekends in which Vladi travels to his hometown.
        */

            // Reading input
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            // Calculate volleyball playing days
            int normalWeekends = 48 - h; // Normal weekends in Sofia
            double normalVolleyballDays = normalWeekends * (3.0 / 4) + p * (2.0 / 3);

            if (yearType == "leap")
            {
                normalVolleyballDays *= 1.15; // Increase by 15% for leap year
            }

            // Calculate total volleyball playing days
            int totalVolleyballDays = (int)Math.Floor(normalVolleyballDays + h);

            // Output the result
            Console.WriteLine(totalVolleyballDays);
        }
    }
}