using System;
using System.IO;

namespace Print_each_line
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            string path = @"..\my-file.txt";

            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content[0]);
            }
            catch (Exception error)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            Console.ReadLine();
        }
    }
}
