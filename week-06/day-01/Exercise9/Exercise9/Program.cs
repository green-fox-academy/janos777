using System;
using System.Linq;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            char[] givenCharacterArray = { 'a', 'b', 'c', 'd', 'e' };

            var convertToString = String.Join("", givenCharacterArray);

            var convertToString2 = String.Join("", givenCharacterArray);

            Console.WriteLine(convertToString);

            Console.WriteLine();

            Console.WriteLine(convertToString2);

            Console.ReadLine();
        }
    }
}
