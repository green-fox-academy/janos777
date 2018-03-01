using System;

namespace _04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            Console.WriteLine("Please provide a base number >= 1: ");
            int bn = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide a number >= 1: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Power(bn, n));

            Console.ReadLine();
        }

        static int Power(int bn, int n)
        {
            if (n == 1)
            {
                return bn;
            }
            else
            {
                return bn * (Power(bn, n - 1));
            }
        }
    }
}
