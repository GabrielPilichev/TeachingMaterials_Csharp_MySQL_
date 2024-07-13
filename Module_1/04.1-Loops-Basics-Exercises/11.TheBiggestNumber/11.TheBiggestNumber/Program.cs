namespace _11.TheBiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that, until receiving the "Stop" command, reads integers entered by the user 
        and finds the largest among them. Enter one number per line. */

            int maxNumber = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                    break;

                if (int.TryParse(input, out int number))
                {
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or 'Stop' to finish.");
                }
            }

            Console.WriteLine($"The largest number entered is: {maxNumber}");
        }
    }
}