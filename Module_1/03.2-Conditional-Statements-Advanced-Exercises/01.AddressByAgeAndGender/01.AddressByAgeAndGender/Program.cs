using System.ComponentModel;
using System.Runtime.InteropServices;
using System;

namespace _01.AddressByAgeAndGender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a console program that reads the age(real number) and gender('m' or 'f') 
            entered by the user and prints an address from among the following:
                - "Mr." – male(gender 'm') aged 16 or over
                - "Master" – boy(gender 'm') under 16 years old
                - "Ms." – female(gender 'f') aged 16 or over
                - "Miss" – girl(gender 'f') under 16 years old*/

            // Prompt the user to enter their age
            Console.Write("Enter your age: ");
            double age = double.Parse(Console.ReadLine());

            // Prompt the user to enter their gender
            Console.Write("Enter your gender (m or f): ");
            char gender = char.Parse(Console.ReadLine().ToLower());

            // Determine the appropriate address based on age and gender
            if (gender == 'm')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if (gender == 'f')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                Console.WriteLine("Invalid gender entered.");
            }
        }
    }
}