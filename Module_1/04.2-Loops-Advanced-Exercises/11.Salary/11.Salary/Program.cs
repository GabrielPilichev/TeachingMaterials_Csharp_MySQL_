using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace _11.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A company boss notices that more and more employees are spending time on distracting sites.
            To prevent this, surprise checks are implemented on employees' open browser tabs.
            Different fines are imposed based on the open site:
                -"Facebook" → BGN 150
                - "Instagram" → BGN 100
                - "Reddit" → BGN 50
            Write a program that parses the list of open tabs for an employee and calculates the fines.
            Based on the employee's starting salary and the fines imposed, calculate the remaining salary.*/

        // Input
        int startingSalary = int.Parse(Console.ReadLine());
            string openTabs = Console.ReadLine();

            // Initialize variables for fines
            int facebookFine = 150;
            int instagramFine = 100;
            int redditFine = 50;
            int totalFine = 0;

            // Parse the list of open tabs
            while (openTabs != "End")
            {
                switch (openTabs)
                {
                    case "Facebook":
                        totalFine += facebookFine;
                        break;
                    case "Instagram":
                        totalFine += instagramFine;
                        break;
                    case "Reddit":
                        totalFine += redditFine;
                        break;
                }

                openTabs = Console.ReadLine();
            }

            // Calculate remaining salary after fines
            int remainingSalary = startingSalary - totalFine;

            // Output the remaining salary
            Console.WriteLine(remainingSalary);
        }
    }
}