using System;
using System.IO;
using System.Text;

namespace Copy_file
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string pathRead = @"...\Copy file\oldfile.txt";
            string pathReadIncorrect = @"..\oldfile.txt";
            string newFile = @"...\Copy file\newfile.txt";
            string newFileIncorrect = @"..\newfile.txt";

            try
            {
                Copy(pathRead, newFile);
            }
            catch (Exception error)
            {
                Console.WriteLine("");
            }
            finally
            {
                Console.WriteLine(true);
                Console.ReadLine();
            }
        }

        static bool Copy(string fileToRead, string fileToWrite)
        {
            string[] text = File.ReadAllLines(fileToRead);

            File.WriteAllLines(fileToWrite, text);
            return true;
        }
    }
}
