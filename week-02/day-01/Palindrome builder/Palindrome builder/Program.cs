using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function named create palindrome following your current language's style guide. It should take a string, create a palindrome from it and then return it.

            //Examples
            //input   output
            //""	""
            //"greenfox"	"greenfoxxofneerg"
            //"123"	"123321"


            Console.WriteLine("Please enter a string to create a palindrome from it: ");
            string word = Console.ReadLine();

            Console.WriteLine(Palindrome(word));

            Console.ReadLine();
        }

        static string Palindrome(string word)
        {
            char[] wordArray = word.ToCharArray();

            char[] result = new char[2 * wordArray.Length];
            
            for (int i = 0; i < wordArray.Length; i++)
            {
                result[i] = wordArray[i];
            }

            for (int j = 0; j < wordArray.Length; j++)
            {
                result[2 * wordArray.Length - 1 - j] = wordArray[j];
            }

            string resultString = new string(result);

            return resultString;
        }
    }
}