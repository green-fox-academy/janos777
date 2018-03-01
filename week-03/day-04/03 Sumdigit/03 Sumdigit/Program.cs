using System;

namespace _03_Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

            Console.WriteLine("Please provide a non-negative number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(SumDigit(n));

            Console.ReadLine();
        }

        static int SumDigit(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n % 10 + SumDigit(n / 10);
            }
        }
    }
}
