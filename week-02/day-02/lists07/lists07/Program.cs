using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(QuoteSwap2(list));
            // Expected output: "What I cannot create I do not understand." 

            Console.ReadLine();
        }

        public static string QuoteSwap2(List<string> input)
        {
            string[] inputArray = input.ToArray();

            string temp;

            temp = inputArray[2];
            inputArray[2] = inputArray[5];
            inputArray[5] = temp;

            string outputString = string.Join(" ", inputArray);

            return outputString;
        }
    }
}