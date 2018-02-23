using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;
            int c;

            c = a;
            a = b;
            b = c;
            

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadLine();

        }
    }
}