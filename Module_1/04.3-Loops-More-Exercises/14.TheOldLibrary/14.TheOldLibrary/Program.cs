using System.Diagnostics.Metrics;
using System.Reflection;

namespace _14.TheOldLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Annie goes to her hometown after a very long period outside the country.On her way home, she sees her grandmother's old library and remembers her favorite book. Help Annie by writing a program in which she enters the book (text) she is looking for. Until Annie finds her favorite book or checks all in the library, the program must read the name of each subsequent book (text) on a new line each time. The books in the library are gone as soon as you receive a "No More Books" command.
                - If it does not find the requested book to be printed on two lines:
                    - "The book you are looking for is not here!"
                    - "You checked {number} books."
                - If he finds his book, one line is printed:
                    - "You checked {number} books and found it."*/

            // Annie's favorite book
            string favoriteBook = Console.ReadLine();

            // Book search counter
            int checkedBooks = 0;

            // Loop to check each book in the library
            while (true)
            {
                // Read the name of the current book
                string currentBook = Console.ReadLine();

                // If the command is "No More Books", stop the search
                if (currentBook == "No More Books")
                {
                    Console.WriteLine("The book you are looking for is not here!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                    break;
                }

                // Increment the checked books counter
                checkedBooks++;

                // If the current book is the favorite book, stop the search and print the result
                if (currentBook == favoriteBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
            }
        }
    }
}