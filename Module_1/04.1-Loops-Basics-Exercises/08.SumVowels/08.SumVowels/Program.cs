namespace _08.SumVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To write a program that reads text (string) entered by the user
            // and calculates and prints the sum of the vowel values according to the table below:
            // letter a e i o u
            // value  1 2 3 4 5

            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                switch (c)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }

            Console.WriteLine("The sum of the vowel values is: " + sum);

            /*foreach (char c in input)
            {
                switch (c)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }*/
        }
    }
}