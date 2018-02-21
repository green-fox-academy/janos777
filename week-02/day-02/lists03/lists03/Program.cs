using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"

            Console.ReadLine();
        }

        public static string AppendA(List<string> input)
        {
            string outputString;
            string[] inputArray = input.ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = "\"" + inputArray[i] + "a\"";
            }
            outputString = string.Join(", ", inputArray);

            return outputString;
        }
    }
}