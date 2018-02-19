using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.

            int number1 = 3;
            int number2 = 5;

            for (int i = 1; i <= 100; i++)
            {
                if (i % (number1 * number2) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % number1 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % number2 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}