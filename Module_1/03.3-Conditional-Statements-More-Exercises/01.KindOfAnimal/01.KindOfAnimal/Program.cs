using System.ComponentModel;
using System.Xml.Linq;

namespace _01.KindOfAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that prints the species of the animal according to its name entered by the user.
                1.dog->mammal
                2.crocodile, tortoise, snake->reptile
                3.others->unknown*/

            // Prompt the user to enter the animal name
            Console.Write("Enter the animal name: ");
            string animalName = Console.ReadLine().ToLower();

            // Determine the species based on the animal name
            string species = "";

            switch (animalName)
            {
                case "dog":
                    species = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    species = "reptile";
                    break;
                default:
                    species = "unknown";
                    break;
            }

            // Output the species
            Console.WriteLine($"The species of {animalName} is {species}");
        }
    }
}