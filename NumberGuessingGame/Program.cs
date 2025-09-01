using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guessingNumber = random.Next(1, 101);
            int userGuess = 0;
            int attempts = 0;

            Console.WriteLine("==== Welcome To The Number Guessing Game ====");
            Console.WriteLine("I picked a number between 1 and 100. Guess!!");

            while (userGuess != guessingNumber) 
            {
                Console.Write("\nEnter your guess:");
                userGuess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (userGuess < guessingNumber)
                {
                    Console.WriteLine("Try a higher number!");
                }
                else if ( userGuess > guessingNumber)
                {
                    Console.WriteLine("Try a lower number!");
                }
                else
                {
                    Console.WriteLine($"\n Congratulations! You got it right in {attempts} tries!");
                }
            }
            Console.WriteLine("\nGame Over! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
