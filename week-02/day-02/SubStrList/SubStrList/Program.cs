using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a string and a list of string as a parameter
            //  Returns the index of the string in the list where the first string is part of
            //  Only need to find the first occurence and return the index of that
            //  Returns `-1` if the string is not part any of the strings in the list

            //  Example
            //string[] searchArr = { "this", "is", "what", "I'm", "searching", "in" };

            //Console.WriteLine(Substrlist("ching", searchArr));
            //  should print: `4`
            //Console.WriteLine(Substrlist("not", searchArr));
            //  should print: `-1`  

            List<string> searchIn = new List<string> { "this", "is", "what", "I'm", "searching", "in" };

            string searchFor1 = "ching";
            string searchFor2 = "not";

            Console.WriteLine(Substrlist(searchFor1, searchIn));
            Console.WriteLine(Substrlist(searchFor2, searchIn));

            Console.ReadLine();
        }

        public static int Substrlist(string searchFor, List<string> searchIn)
        {
            for (int i = 0; i < searchIn.Count; i++)
            {
                if (searchIn[i].Contains(searchFor))
                {
                    return i;
                }  
            }

            return -1;
        }
    }
}
