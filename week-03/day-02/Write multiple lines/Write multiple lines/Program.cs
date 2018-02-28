using System;
using System.IO;

namespace Write_multiple_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number parameter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.

            string path = @"...\Write multiple lines\multiple-lines.txt";
            string pathIncorrect = @"..\my-file.txt";
            string Word = "tomato";
            int lines = 7;

            try
            {
                Write(pathIncorrect, Word, lines);
            }
            catch (Exception error)
            {
                Console.WriteLine("");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static void Write(string pathToWrite, string wordToWrite, int numberOfLines)
        {
            StreamWriter multipleLines = new StreamWriter(pathToWrite);

            for (int i = 0; i < numberOfLines; i++)
            {
                multipleLines.WriteLine(wordToWrite);
            }
            multipleLines.Close();
        }
    }
}
