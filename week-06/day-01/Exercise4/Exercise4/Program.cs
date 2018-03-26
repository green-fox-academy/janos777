using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var searchedNumber = from number in n
                                 where number * number > 20
                                 select number;

            var searchedNumber2 = n.Where(number => number * number > 20);

            foreach (var item in searchedNumber)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in searchedNumber2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
