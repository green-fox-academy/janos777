using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Please provide a number: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide another one: ");
            int second = int.Parse(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine("The first number is bigger.");
            }
            else if (first < second)
            {
                Console.WriteLine("The second number is bigger.");
            }
            else
            {
                Console.WriteLine("The two numbers are equal.");
            }

            Console.ReadLine();
        }
    }
}