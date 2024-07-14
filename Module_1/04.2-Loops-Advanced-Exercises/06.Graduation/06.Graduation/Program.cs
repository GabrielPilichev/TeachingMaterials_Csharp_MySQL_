using System.Collections.Generic;
using System.ComponentModel;

namespace _06.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates the grade point average of a student over his entire course.
            On the first line, you will get the student's name, and on each subsequent line, his annual grades. 
            The student advances to the next grade if his annual grade is greater than or equal to 4.00.
            If a student is interrupted more than once, they are expelled and the cycle ends by 
            printing the name of the student and the grade in which they were expelled.

            Upon successful completion of 12th grade print:
            "{student name} graduated. Average grade: {the average grade of the entire study}"

            In case the student is expelled from school, print:
            "{student name} has been excluded at {grade in which he was excluded} grade"
            The value must be formatted to the second decimal place.*/

            string studentName = Console.ReadLine();
            int grade = 1;
            double totalGrades = 0.0;
            int failCount = 0;

            while (grade <= 12)
            {
                double annualGrade = double.Parse(Console.ReadLine());

                if (annualGrade >= 4.00)
                {
                    totalGrades += annualGrade;
                    grade++;
                }
                else
                {
                    failCount++;
                    if (failCount > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grade} grade");
                        return;
                    }
                }
            }

            double averageGrade = totalGrades / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
        }
    }
}