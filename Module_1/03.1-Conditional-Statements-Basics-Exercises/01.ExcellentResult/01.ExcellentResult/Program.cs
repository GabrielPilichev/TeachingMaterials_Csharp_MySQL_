using System.Diagnostics;
using System.Threading.Tasks;

namespace _01.ExcellentResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*The first task of this topic is to write a console program 
                that reads a grade(decimal number) entered by the user and 
                prints "Excellent!" if the grade is 5.50 or higher.*/

            // Prompt the user to enter a grade
            Console.Write("Enter the grade: ");

            // Read the input from the user and convert it to a double
            // This assumes that the user will enter a valid decimal number
            double grade = double.Parse(Console.ReadLine());

            // Check if the grade is 5.50 or higher
            if (grade >= 5.50)
            {
                // Print "Excellent!" if the condition is met
                Console.WriteLine("Excellent!");
            }
        }
    }
}