using System;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.

            int n = 10;

            Count(n);

            Console.ReadLine();
        }

        static void Count(int n)
        {
            if (n == 1)
            {
                Console.Write(n + " ");
            }
            else
            {
                Console.Write(n + " ");
                Count(n - 1);
            }
        }
    }
}
