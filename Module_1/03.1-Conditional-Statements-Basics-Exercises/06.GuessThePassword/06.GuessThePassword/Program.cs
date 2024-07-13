using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System;

namespace _06.GuessThePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a password(one line of random text) entered by the user and checks
            that what is entered matches the phrase "s3cr3t!P@ssw0rd".If there is a match, display "Welcome".
            In case of mismatch, display "Wrong password!".*/

            // Prompt the user to enter the password
            Console.Write("Enter the password: ");

            // Read the input from the user
            string enteredPassword = Console.ReadLine();

            // Define the correct password
            string correctPassword = "s3cr3t!P@ssw0rd";

            // Check if the entered password matches the correct password
            if (enteredPassword == correctPassword)
            {
                // If the passwords match, print "Welcome"
                Console.WriteLine("Welcome");
            }
            else
            {
                // If the passwords do not match, print "Wrong password!"
                Console.WriteLine("Wrong password!");
            }
        }
    }
}