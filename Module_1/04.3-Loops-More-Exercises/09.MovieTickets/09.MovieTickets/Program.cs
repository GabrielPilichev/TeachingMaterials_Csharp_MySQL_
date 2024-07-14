using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Net.Sockets;
using System.Security.Cryptography;
using System;

namespace _09.MovieTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Your task is to write a program that calculates the percentage of tickets for each type of ticket sold: 
            student, standard, and kid for all screenings. 
            You should also calculate what percentage of the hall is filled for each screening.

            Input:
            -Each movie's name is read until "Finish".
            - For each movie, read the number of free seats in the theater.
            - For each movie, read the type of purchased ticket("student", "standard", "kid") until "End".

            Output:
            -After each movie, print the percentage of the theater that is filled.
            - After all movies are processed, print:
              -Total number of tickets sold.
              - Percentage of student tickets sold.
              - Percentage of standard tickets sold.
              - Percentage of kid tickets sold.*/

            string movieName;
            int totalTickets = 0;
            int totalStudentTickets = 0;
            int totalStandardTickets = 0;
            int totalKidTickets = 0;

            while (true)
            {
                // Read movie name or "Finish" to end
                movieName = Console.ReadLine();
                if (movieName == "Finish")
                    break;

                // Read total seats in the theater
                int totalSeats = int.Parse(Console.ReadLine());
                int currentOccupancy = 0;

                // Read ticket sales until "End"
                while (true)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                        break;

                    switch (ticketType)
                    {
                        case "student":
                            totalStudentTickets++;
                            break;
                        case "standard":
                            totalStandardTickets++;
                            break;
                        case "kid":
                            totalKidTickets++;
                            break;
                        default:
                            break;
                    }

                    currentOccupancy++;
                    totalTickets++;
                }

                // Calculate percentage occupancy
                double occupancyPercentage = (double)currentOccupancy / totalSeats * 100;

                // Output percentage of theater filled for the movie
                Console.WriteLine($"{movieName} - {occupancyPercentage:F2}% full.");
            }

            // Output total statistics after all movies
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)totalStudentTickets / totalTickets * 100:F2}% student tickets.");
            Console.WriteLine($"{(double)totalStandardTickets / totalTickets * 100:F2}% standard tickets.");
            Console.WriteLine($"{(double)totalKidTickets / totalTickets * 100:F2}% kids tickets.");

        }
    }
}