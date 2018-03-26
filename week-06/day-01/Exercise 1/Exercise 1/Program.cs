using System;
using System.Linq;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = from number in n
                                where number % 2 == 0
                                orderby number ascending
                                select number;

            var evenNumbers2 = n.Where(x => (x % 2 == 0)).OrderBy(x => x);

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in evenNumbers2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
