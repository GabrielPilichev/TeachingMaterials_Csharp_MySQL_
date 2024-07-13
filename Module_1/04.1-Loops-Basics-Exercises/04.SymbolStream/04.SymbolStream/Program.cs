namespace _04.SymbolStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads text (string) entered by the user
            // and prints each character of the text on a separate line.

            // Read the text from the user
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            // Print each character of the text on a separate line
            foreach (char character in text)
            {
                Console.WriteLine(character);
            }
        }
    }
}