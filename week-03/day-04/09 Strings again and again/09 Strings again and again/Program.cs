using System;

namespace _09_Strings_again_and_again
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".

            string text = "IhXxxbgxXP2Kxjx";

            Console.WriteLine(Change(text));

            Console.ReadLine();
        }

        static string Change(string text)
        {
            if (text.Length == 1)
            {
                return text;
            }
            else
            {
                return text[0] + "*" + Change(text.Substring(1));
            }
        }
    }
}