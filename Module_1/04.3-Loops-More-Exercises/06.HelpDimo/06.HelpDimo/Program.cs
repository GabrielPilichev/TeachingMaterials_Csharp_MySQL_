using System.Collections.Generic;
using System.Threading;

namespace _06.HelpDimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dimo is a professional track and field athlete. To monitor his progress and whether he has achieved 
            the desired results, he needs a program.Write the program to help Dimo. 
            First, the length of the jump that Dimo ​​must perform is read - it is his goal. 
            Initially, he tries to perform a jump 30 cm short of the target. Dimo can only make three jump attempts 
            for each current target length, with his attempt succeeding if the attempt's jump length is greater than 
            the current target length. When the athlete succeeds in jumping the current target length, 
            it increases by 5 centimeters. If Dimo ​​fails to jump over the current target length 3 times, 
            he has no more attempts and his training is considered a failure. If the target length is reached 
            and Dimo ​​jumps over that length, the training is successful.*/

            // Reading the initial target length from the user
            int targetLength = int.Parse(Console.ReadLine());

            // Initial jump length is 30 cm short of the target
            int jumpLength = targetLength - 30;

            // Number of attempts allowed
            int attemptsLeft = 3;

            // Training progress loop
            while (attemptsLeft > 0)
            {
                // Dimo attempts to jump
                int jumpAttempt = int.Parse(Console.ReadLine());

                // Check if the jump attempt is successful
                if (jumpAttempt > targetLength)
                {
                    Console.WriteLine($"Jump successful! Target increased to {targetLength + 5} cm.");
                    targetLength += 5;
                    jumpLength = targetLength - 30; // Reset jump length to new target - 30 cm
                }
                else
                {
                    attemptsLeft--;
                    Console.WriteLine($"Jump failed! Attempts left: {attemptsLeft}");

                    // Check if no attempts left
                    if (attemptsLeft == 0)
                    {
                        Console.WriteLine($"Training failed. Target length: {targetLength} cm.");
                        break;
                    }
                }
            }
        }
    }
}