using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("Please provide a number >= 1: ");
            int n = int.Parse(Console.ReadLine());

            char star = '*';
            char space = ' ';

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(space);
                }

                for (int k = 1; k < 2 * i; k++)
                {
                    Console.Write(star);
                }

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(space);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}