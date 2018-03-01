using System;

namespace _08_Strings_again
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            string text = "IhXxxbgxXP2Kxjx";

            Console.WriteLine(Change(text));

            Console.ReadLine();
        }

        static string Change(string text)
        {
            if (text.Length == 0)
            {
                return text;
            }
            else if (text[0] == 'x')
            {
                return text.Remove(0) + Change(text.Substring(1));
            }
            else
            {
                return text[0] + Change(text.Substring(1));
            }
        }
    }
}