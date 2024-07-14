using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System;

namespace _09.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that schematically visualizes the floors and rooms in a building.
            It prints the room numbers in descending order with the following conditions:
                    -Even - numbered floors contain only offices.
                    -Odd - numbered floors contain only apartments.
                    -Each apartment is designated as A{ floor number}
                        { apartment number}, starting from 0.
                    - Each office is designated as O{ floor number}
                        { office number}, starting from 0.
                    - The top floor always has apartments, and they are larger(designated as L{ floor number}
                        { apartment number}).

             If there is only one floor, there are only large apartments.
             Input: Two integers -number of floors and number of rooms per floor.*/

            // Read input
            int floors = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());

            // Variables for apartment and office counts
            int apartmentCount = 0;
            int officeCount = 0;

            // Iterate through each floor
            for (int floor = floors; floor >= 1; floor--)
            {
                // Determine if the current floor is odd or even
                bool isEvenFloor = (floor % 2 == 0);

                // Iterate through each room on the current floor
                for (int roomNumber = roomsPerFloor - 1; roomNumber >= 0; roomNumber--)
                {
                    if (isEvenFloor)
                    {
                        // Office designation for even floors
                        Console.WriteLine($"O{floor}{officeCount}");
                        officeCount++;
                    }
                    else
                    {
                        // Apartment designation for odd floors
                        if (floor == 1 && roomNumber == roomsPerFloor - 1)
                        {
                            // Large apartment designation for top floor
                            Console.WriteLine($"L{floor}{apartmentCount}");
                        }
                        else
                        {
                            // Normal apartment designation
                            Console.WriteLine($"A{floor}{apartmentCount}");
                        }
                        apartmentCount++;
                    }
                }

                // Reset office count for next even floor
                if (isEvenFloor)
                {
                    officeCount = 0;
                }
            }
        }
    }
}