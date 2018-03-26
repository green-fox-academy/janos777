using System;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var averageOfOdd = (from number in n
                               where number % 2 != 0
                               select number)
                               .Average();

            var averageOfOdd2 = n.Where(x => (x % 2 != 0)).Average();


            Console.WriteLine(averageOfOdd);

            Console.WriteLine();

            Console.WriteLine(averageOfOdd2);

            Console.ReadLine();
        }
    }
}
