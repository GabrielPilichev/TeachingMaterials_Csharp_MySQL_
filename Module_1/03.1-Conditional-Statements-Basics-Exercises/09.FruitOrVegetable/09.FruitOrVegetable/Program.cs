using System.ComponentModel;
using System;

namespace _09.FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a product name entered by the user and checks whether it is a fruit or a vegetable.
                - "fruit" has the following possible values: banana, apple, kiwi, cherry, lemon and grapes
                - Vegetables have the following possible values: tomato, cucumber, pepper and carrot
                - All others are "unknown"
            Display "fruit", "vegetable" or "unknown" according to the product entered.*/

            // Prompt the user to enter a product name
            Console.Write("Enter a product name: ");

            // Read the input from the user
            string productName = Console.ReadLine().ToLower(); // ToLower converts all letters to lower case

            // Check the product name and classify it
            switch (productName)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}