using System;
using System.IO;

namespace Count_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            Console.WriteLine("Please provide the path to the file: ");

            string path = Console.ReadLine();

            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content);
            }
            catch (Exception error)
            {
                Console.WriteLine("0");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
