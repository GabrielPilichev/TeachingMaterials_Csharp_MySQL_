namespace _03.SumWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that, at the command "Go", collects three words and prints them as one. 
            // With the "End" command, the program ends.

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }
                else if (command == "Go")
                {
                    string word1 = Console.ReadLine();
                    string word2 = Console.ReadLine();
                    string word3 = Console.ReadLine();

                    string combinedWords = word1 + word2 + word3;
                    Console.WriteLine(combinedWords);
                }
            }
        }
    }
}