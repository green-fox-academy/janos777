using System;

namespace _05_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

            Console.WriteLine("Number of bunnies (number >=1): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Ears(n));

            Console.ReadLine();
        }

        static int Ears(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            else
            {
                return 2 + (Ears(n - 1));
            }
        }
    }
}
