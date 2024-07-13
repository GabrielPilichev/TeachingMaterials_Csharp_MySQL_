namespace _10.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that initially reads a user profile name and password. It then reads a login password, 
            prompting the user to enter a new password if a wrong password is entered. */

            // Initialize the user's profile name and password
            string profileName = "user";
            string profilePassword = "password123";

            // Prompt the user to enter their profile name and password
            Console.Write("Enter profile name: ");
            string enteredName = Console.ReadLine();

            Console.Write("Enter password: ");
            string enteredPassword = Console.ReadLine();

            // Check if the entered profile name and password match
            while (enteredName != profileName || enteredPassword != profilePassword)
            {
                Console.WriteLine("Invalid profile name or password.");

                // Prompt the user to enter the profile name and password again
                Console.Write("Enter profile name: ");
                enteredName = Console.ReadLine();

                Console.Write("Enter password: ");
                enteredPassword = Console.ReadLine();
            }

            Console.WriteLine("Logged in successfully!");

            // Proceed with additional operations after successful login
            // For example, prompting the user to change their password
            Console.WriteLine("Please enter a new password:");
            string newPassword = Console.ReadLine();

            // Update the profile password
            profilePassword = newPassword;

            Console.WriteLine("Password updated successfully!");
        }
    }
}