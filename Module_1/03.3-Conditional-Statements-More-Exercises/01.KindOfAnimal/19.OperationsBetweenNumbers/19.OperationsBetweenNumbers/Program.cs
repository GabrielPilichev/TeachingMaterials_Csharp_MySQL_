namespace _19.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads two integers (N1 and N2) and an operator to perform a given mathematical operation on them.
           Possible operations are: addition (+), subtraction (-), multiplication (*), division (/) and modular division (%).
           Addition, subtraction and multiplication should print the result and whether it is even or odd.
           In division, print the result. In the case of modular division, print the remainder.
           Handle division by zero with a special message. */

            // Input values
            int N1 = int.Parse(Console.ReadLine()); // Example input: 10
            int N2 = int.Parse(Console.ReadLine()); // Example input: 3
            char operation = char.Parse(Console.ReadLine()); // Example input: '+'

            // Perform operation based on the operator
            switch (operation)
            {
                case '+':
                    int sum = N1 + N2;
                    Console.WriteLine($"{sum} is {(sum % 2 == 0 ? "even" : "odd")}");
                    break;
                case '-':
                    int difference = N1 - N2;
                    Console.WriteLine($"{difference} is {(difference % 2 == 0 ? "even" : "odd")}");
                    break;
                case '*':
                    int product = N1 * N2;
                    Console.WriteLine($"{product} is {(product % 2 == 0 ? "even" : "odd")}");
                    break;
                case '/':
                    if (N2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    else
                    {
                        double quotient = (double)N1 / N2;
                        Console.WriteLine($"{quotient:F2}");
                    }
                    break;
                case '%':
                    if (N2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    else
                    {
                        int remainder = N1 % N2;
                        Console.WriteLine($"{remainder}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }
        }
    }
}