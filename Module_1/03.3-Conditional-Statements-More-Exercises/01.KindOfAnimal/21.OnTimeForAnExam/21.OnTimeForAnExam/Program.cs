namespace _21.OnTimeForAnExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A student must go to an exam at a specific time (for example, 9:30 a.m.).
           He comes to the exam hall at a given arrival time (e.g., 9:40).
           The student is considered to have arrived on time if he arrived at the time of the exam or up to half an hour earlier.
           If he arrived more than 30 minutes early, he was early. If he came after the exam time, he is late.
           Write a program that reads an exam time and an arrival time and prints whether the student was on time, early, or late,
           and by how many hours or minutes he was early or late.
        */

            // Example input times
            string examTimeInput = Console.ReadLine(); // Example input: "9:30"
            string arrivalTimeInput = Console.ReadLine(); // Example input: "9:40"

            // Parse exam time
            string[] examTimeParts = examTimeInput.Split(':');
            int examHour = int.Parse(examTimeParts[0]);
            int examMinute = int.Parse(examTimeParts[1]);

            // Parse arrival time
            string[] arrivalTimeParts = arrivalTimeInput.Split(':');
            int arrivalHour = int.Parse(arrivalTimeParts[0]);
            int arrivalMinute = int.Parse(arrivalTimeParts[1]);

            // Convert times to total minutes from midnight
            int examTotalMinutes = examHour * 60 + examMinute;
            int arrivalTotalMinutes = arrivalHour * 60 + arrivalMinute;

            // Calculate difference in minutes
            int differenceMinutes = arrivalTotalMinutes - examTotalMinutes;

            // Determine if the student is on time, early, or late
            if (differenceMinutes == 0 || (differenceMinutes >= -30 && differenceMinutes <= 0))
            {
                Console.WriteLine("On time");
            }
            else if (differenceMinutes > 0 && differenceMinutes <= 30)
            {
                Console.WriteLine($"Early by {differenceMinutes} minutes");
            }
            else if (differenceMinutes > 30)
            {
                int hours = differenceMinutes / 60;
                int minutes = differenceMinutes % 60;
                Console.WriteLine($"Early by {hours}:{minutes:D2} hours");
            }
            else if (differenceMinutes < 0 && differenceMinutes >= -59)
            {
                Console.WriteLine($"Late by {Math.Abs(differenceMinutes)} minutes");
            }
            else if (differenceMinutes < -59)
            {
                int hours = Math.Abs(differenceMinutes) / 60;
                int minutes = Math.Abs(differenceMinutes) % 60;
                Console.WriteLine($"Late by {hours}:{minutes:D2} hours");
            }
        }
    }
}