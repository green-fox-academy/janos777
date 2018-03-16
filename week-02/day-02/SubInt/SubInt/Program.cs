using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a number and a list of numbers as a parameter
            //  Returns the indeces of the numbers in the list where the first number is part of
            //  Returns an empty list if the number is not part any of the numbers in the list

            //  Example:
            //Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            //Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            int numberSearchedFor1 = 1;
            int numberSearchedFor2 = 9;

            List<int> numbers = new List<int> { 1, 11, 34, 52, 61 };

            Console.WriteLine($"[ {String.Join(", ", SubInt(numberSearchedFor1, numbers))} ]");
            Console.WriteLine($"[ {String.Join(", ", SubInt(numberSearchedFor2, numbers))} ]");

            Console.ReadLine();
        }

        public static List<int> SubInt(int numberSearchedFor, List<int> numbers)
        {
            List<int> indecesWhereNumberIsPartOf = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (MoreDigitNumberToArray(numbers[i]).Contains(numberSearchedFor))
                {
                    indecesWhereNumberIsPartOf.Add(i);
                }
            }

            return indecesWhereNumberIsPartOf;
        }

        public static List<int> MoreDigitNumberToArray(int number)
        {
            var digits = new List<int>();

            while (number > 0)
            {
                digits.Add(number % 10);
                number /= 10;
            }

            digits.Reverse();

            return digits;
        }
    }
}
