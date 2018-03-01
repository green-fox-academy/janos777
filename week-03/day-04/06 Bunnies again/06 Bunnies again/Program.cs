using System;

namespace _06_Bunnies_again
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

            Console.WriteLine("Please provide the number of the bunnies (number >= 1): ");
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
                return 2 + ((n + 1) % 2) + Ears(n-1);
            }
        }
    }
}
