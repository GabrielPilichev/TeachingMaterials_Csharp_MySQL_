namespace _07.WordReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads text (string) from the console
            // and prints it until it receives the "Stop" command.

            while (true)
            {
                Console.Write("Enter text (type 'Stop' to end): ");
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                Console.WriteLine(input);
            }
        }
    }
}