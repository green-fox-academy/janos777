using System;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequency = from number in n
                            group number by number into frequencyNum
                            orderby frequencyNum.Key
                            select frequencyNum;

            var frequency2 = n.GroupBy(number => number).OrderBy(number => number.Key);

            foreach (var item in frequency)
            {
                Console.WriteLine($"The number {item.Key} appears {item.Count()} times in the array.");
            }

            Console.WriteLine();

            foreach (var item in frequency2)
            {
                Console.WriteLine($"The number {item.Key} appears {item.Count()} times in the array.");
            }

            Console.ReadLine();
        }
    }
}
