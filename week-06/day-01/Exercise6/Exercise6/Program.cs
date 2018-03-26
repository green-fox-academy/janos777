using System;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!

            string givenString = "test string";

            var frequency = from character in givenString
                            group character by character;

            var frequency2 = givenString.GroupBy(character => character);

            foreach (var item in frequency)
            {
                Console.WriteLine($"The character {item.Key} appears {item.Count()} times in the string.");
            }

            Console.WriteLine();

            foreach (var item in frequency2)
            {
                Console.WriteLine($"The character {item.Key} appears {item.Count()} times in the string.");
            }

            Console.ReadLine();
        }
    }
}
