using System;
using System.IO;

namespace Write_single_line
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            string path = @"...\Write single line\my-file.txt";
            string pathIncorrect = @"..\my-file.txt";

            try
            {
                StreamWriter name = new StreamWriter(pathIncorrect);
                name.WriteLine("myName");
                name.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
