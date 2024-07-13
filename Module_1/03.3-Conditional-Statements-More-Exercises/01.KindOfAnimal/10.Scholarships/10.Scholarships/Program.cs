using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace _10.Scholarships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Students can apply for a social scholarship or a merit scholarship.Requirement for social scholarship 
            -family member's income less than minimum wage and GPA above 4.50. 
            Amount of the social stipend - 35% of the minimum wage. 
            Honors Scholarship Requirement - GPA above 5.50 inclusive. 
            Scholarship amount for excellent performance - the student's performance multiplied by a factor of 25.

            Write a program that, given income, GPA, and minimum wage, returns information about whether a student
            is eligible for a scholarship and the value of the scholarship that is higher for him.*/

            // Input from the user
            Console.Write("Enter the family member's income: ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Enter the student's GPA: ");
            double gpa = double.Parse(Console.ReadLine());

            Console.Write("Enter the minimum wage: ");
            double minimumWage = double.Parse(Console.ReadLine());

            // Calculate the social scholarship amount (35% of the minimum wage)
            double socialScholarshipAmount = 0.35 * minimumWage;

            // Determine eligibility and scholarship amounts
            double socialScholarship = 0;
            double honorsScholarship = 0;

            // Check eligibility for Social Scholarship
            if (income < minimumWage && gpa > 4.50)
            {
                socialScholarship = socialScholarshipAmount;
            }

            // Check eligibility for Honors Scholarship
            if (gpa >= 5.50)
            {
                honorsScholarship = gpa * 25.0; // Honors scholarship is GPA multiplied by 25
            }

            // Determine the higher scholarship amount
            double highestScholarship = Math.Max(socialScholarship, honorsScholarship);

            // Output the results
            if (socialScholarship > 0 || honorsScholarship > 0)
            {
                Console.WriteLine("Congratulations! You are eligible for a scholarship.");
                Console.WriteLine($"Social Scholarship: {socialScholarship:F2} BGN");
                Console.WriteLine($"Honors Scholarship: {honorsScholarship:F2} BGN");
                Console.WriteLine($"Higher Scholarship: {highestScholarship:F2} BGN");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible for any scholarship.");
            }
        }
    }
}