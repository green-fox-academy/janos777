using System;

namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

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
                return 'y' + Change(text.Substring(1));
            }
            else
            {
                return text[0] + Change(text.Substring(1));
            }
        }
    }
}