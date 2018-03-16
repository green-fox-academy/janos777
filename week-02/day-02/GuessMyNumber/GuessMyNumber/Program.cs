using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program where the program chooses a number between 1 and 100. The player is then asked to enter a guess.If the player guesses wrong, then the program gives feedback and ask to enter an other guess until the guess is correct.

            //Make the range customizable (ask for it before starting the guessing).
            //You can add lives. (optional)

            int startLives = 5;

            Console.WriteLine("Please provide a minimum number for the range: ");
            int rangeMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide a maximum number for the range: ");
            int rangeMax = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int myGuessedNumber = rnd.Next(rangeMin, rangeMax + 1);

            Console.WriteLine($"I've a number between {rangeMin} - {rangeMax} (including these two numbers). You have {startLives} lives.");

            for (int i = 1; i <= startLives + 1; i++)
            {
                if (i <= startLives)
                {
                    int guessedNumber = int.Parse(Console.ReadLine());

                    if (guessedNumber > myGuessedNumber)
                    {
                        Console.WriteLine($"Too high. You have {startLives - i} lives left.");
                    }

                    else if (guessedNumber < myGuessedNumber)
                    {
                        Console.WriteLine($"Too low. You have {startLives - i} lives left.");
                    }

                    else
                    {
                        Console.WriteLine("Congratulations. You guessed correctly!");
                        break;
                    }
                }

                if (i == startLives + 1)
                {
                    Console.WriteLine($"Unfortunately you have 0 lives left, you cannot guess anymore. /n The number I have guessed is the {myGuessedNumber}.");
                }
            }

            Console.ReadLine();
        }
    }
}
