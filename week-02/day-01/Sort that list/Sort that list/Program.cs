using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as parameter
            //  Returns a list where the elements are sorted in ascending numerical order
            //  Make a second boolean parameter, if it's `True` sort that list descending

            //  Example:
            //Console.WriteLine(Bubble(new int[] { 34, 12, 24, 9, 5 }));
            //  should print [5, 9, 12, 24, 34]
            //Console.WriteLine(AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true));
            //  should print [34, 24, 12, 9, 5]

            List<int> bubble = new List<int> { 34, 12, 24, 9, 5 };

            foreach (var item in Sort(bubble, false))
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            foreach (var item in Sort(bubble, true))
            {
                Console.Write(item + ", ");
            }

            Console.ReadLine();
        }

        static List<int> Sort(List<int> numberList, bool trueFalse)
        {
            if (trueFalse == false)
            {
                numberList.Sort();

                return numberList;
            }

            numberList.Reverse();
            return numberList;
        }
    }
}