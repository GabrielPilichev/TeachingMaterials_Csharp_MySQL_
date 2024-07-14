using Microsoft.VisualBasic;
using System.IO;
using System.Text;
using System;

namespace _07.Relocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*On his eighteenth birthday, Jose decided that he was going to move out and live in a boarding house.
            He packed his luggage in boxes and found a suitable ad for an apartment for rent.
            He begins to carry his luggage in parts because he cannot carry it all at once.
            He has limited free space in his new home where he can arrange things so that the place is livable.
            Write a program that calculates the free volume of Jose's apartment that remains after he has moved his luggage.
            Note: One carton is exact dimensions: 1m.x 1m.x 1m.*/

            // Read the dimensions of the apartment
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            // Calculate the total volume of the apartment
            int totalVolume = width * length * height;

            // Initialize the variable to keep track of used volume
            int usedVolume = 0;

            // Loop to read boxes until "Done" is entered
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                // Parse the input to get the number of boxes
                int boxes = int.Parse(input);

                // Add the volume of the boxes to the used volume
                usedVolume += boxes;

                // Check if the used volume exceeds the total volume
                if (usedVolume > totalVolume)
                {
                    Console.WriteLine($"No more free space! You need {usedVolume - totalVolume} Cubic meters more.");
                    return;
                }
            }

            // Calculate the remaining free volume
            int freeVolume = totalVolume - usedVolume;

            // Print the remaining free volume
            Console.WriteLine($"{freeVolume} Cubic meters left.");
        }
    }
}