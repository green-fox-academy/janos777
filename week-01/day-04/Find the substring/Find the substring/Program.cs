using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes two strings as a parameter
            //  Returns the starting index where the second one is starting in the first one
            //  Returns `-1` if the second string is not in the first one

            //  Example:
            //Console.WriteLine(Substr("this is what I'm searching in", "searching"));
            //  should print: `17`
            //Console.WriteLine(Substr("this is what I'm searching in", "not"));
            //  should print: `-1`

            string input = "this is what I'm searching in";
            string q1 = "searching";
            string q2 = "not";

            Console.WriteLine(Substr(input, q1));
            Console.WriteLine(Substr(input, q2));

            Console.ReadLine();
        }

        static int Substr(string input, string q)
        {
            int index = input.IndexOf(q);

            if (index >= 1)
            {
                return index;
            }

            return -1;
        }
    }
}