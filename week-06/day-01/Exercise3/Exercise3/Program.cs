using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squaredPositive = from number in n
                                  where number > 0
                                  select number * number;

            var squaredPositive2 = n.Where(number => number > 0).Select(number => number * number);

            foreach (var item in squaredPositive)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in squaredPositive2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
