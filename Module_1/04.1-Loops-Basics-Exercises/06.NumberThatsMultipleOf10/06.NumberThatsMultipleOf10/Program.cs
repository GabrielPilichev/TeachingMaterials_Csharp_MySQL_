namespace _06.NumberThatsMultipleOf10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads an integer n entered by the user.
            // When entering a number that is not divisible by 10 without a remainder,
            // print an error message and prompt the user to enter a new number until an appropriate number is entered.

            int n;

            while (true)
            {
                Console.Write("Enter a number divisible by 10: ");
                n = int.Parse(Console.ReadLine());

                if (n % 10 == 0)
                {
                    break;
                }

                Console.WriteLine("Error: The number is not divisible by 10. Please try again.");
            }

            Console.WriteLine("You entered a valid number: " + n);
        }
    }
}