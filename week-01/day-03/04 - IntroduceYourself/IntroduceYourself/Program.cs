using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87

            string name = "Janos";
            int age = 37;
            double height = 1.80;


            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am " + age);
            Console.WriteLine("I am " + height + " meter height");
            Console.ReadLine();
        }
    }
}