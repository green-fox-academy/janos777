using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Please provide an odd number greater than 3: ");
            int number = int.Parse(Console.ReadLine());

            string lineFirst = new string('%', number);
            Console.WriteLine(lineFirst);


            char[] lineMiddle = new char[number];

            for (int i = 1; i <= number - 2; i++)
            {
                lineMiddle[0] = '%';
                lineMiddle[number - 1] = '%';

                Console.WriteLine(lineMiddle);

                lineMiddle[i] = ' ';
            }

            string lineLast = new string('%', number);
            Console.WriteLine(lineLast);

            Console.ReadLine();
        }
    }
}