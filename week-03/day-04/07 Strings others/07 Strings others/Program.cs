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
            char[] chars = text.ToCharArray();
            if (Array.IndexOf(chars, 'x') >= 0)
            {
                chars[Array.IndexOf(chars, 'x')] = 'y';
                text = new string(chars);
                return Change(text);
            }
            else
            {
                return text;
            }
        }
    }
}