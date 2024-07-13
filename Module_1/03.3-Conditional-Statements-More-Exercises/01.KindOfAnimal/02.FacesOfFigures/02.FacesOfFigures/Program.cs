using System.Text;

namespace _02.FacesOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in which the user enters the type and dimensions of a geometric figure and calculates its face.
            There are four types of figures: square, rectangle, circle and triangle.The type of figure
            (square, rectangle, circle or triangle) is read on the first line of the input.
                - If the figure is a square, one number is read on the next line - the length of its side
                - If the figure is a rectangle, two numbers are read on the next two lines - the lengths of its sides
                - If the figure is a circle, one number is read on the next line - the radius of the circle
                - If the figure is a triangle, on the next two lines they read two numbers - 
                the length of its side and the length of the height to it
            Round the result to 3 digits after the decimal point.*/

            // Prompt the user to enter the type of geometric figure
            Console.Write("Enter the type of geometric figure (square, rectangle, circle, triangle): ");
            string figureType = Console.ReadLine().ToLower();

            // Variable to store the area of the figure
            double area = 0;

            // Calculate area based on figure type
            switch (figureType)
            {
                case "square":
                    Console.Write("Enter the side length: ");
                    double sideLength = double.Parse(Console.ReadLine());
                    area = sideLength * sideLength;
                    break;
                case "rectangle":
                    Console.Write("Enter the length of the rectangle: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    double width = double.Parse(Console.ReadLine());
                    area = length * width;
                    break;
                case "circle":
                    Console.Write("Enter the radius of the circle: ");
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
                case "triangle":
                    Console.Write("Enter the length of the base of the triangle: ");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    double height = double.Parse(Console.ReadLine());
                    area = 0.5 * baseLength * height;
                    break;
                default:
                    Console.WriteLine("Unknown figure type.");
                    return;
            }

            // Print the calculated area rounded to 3 decimal places
            Console.WriteLine($"The area of the {figureType} is: {area:F3}");
        }
    }
}