using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int number = 8;
            int guessedNumber;

            do
            {
                Console.WriteLine("Guess a number: ");
                guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber > 8)
                {
                    Console.WriteLine("The stored number is lower");
                }
                if (guessedNumber < 8)
                {
                    Console.WriteLine("The stored number is higher");
                }
            }
            while (guessedNumber != 8);
            Console.WriteLine("You found the number: 8");

            Console.ReadLine();
        }
    }
}