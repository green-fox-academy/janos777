using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"

            int a = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("I won't cheat on the exam!");
            }
            Console.ReadLine();
        }
    }
}