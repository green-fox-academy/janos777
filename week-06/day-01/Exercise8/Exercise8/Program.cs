using System;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!

            string givenString = "tesT stRing";

            var uppercase = from character in givenString
                            where char.IsUpper(character)
                            select character;

            var uppercase2 = givenString.Where(character => char.IsUpper(character));

            foreach (var item in uppercase)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in uppercase2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
