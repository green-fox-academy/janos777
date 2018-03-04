using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function named search palindrome following your current language's style guide. It should take a string, search for palindromes that at least 3 characters long and return a list with the found palindromes.

            //Examples
            //input   output
            //"dog goat dad duck doodle never"	["og go", "g g", " dad ", "dad", "d d", "dood", "eve"]
            //"apple"	[]
            //"racecar"	["racecar", "aceca", "cec"]
            //""	[] 

            string word = "dog goat dad duck doodle never";

            SearchPalindrome(word);

            Console.ReadLine();
        }

        public static string ReverseString(string inputString)
        {
            string reversedString = "";

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString += inputString[i];
            }

            return reversedString;
        }
        
        public static void SearchPalindrome(string word)
        {
            for (int begin = 0; begin < word.Length; begin++)
            {
                for (int minLength = 3; begin + minLength <= word.Length; minLength++)
                {
                    string partOfWord = word.Substring(begin, minLength);

                    if (partOfWord == ReverseString(partOfWord))
                    {
                        Console.Write(partOfWord + ", ");
                    }
                }
            }
        }
    }
}