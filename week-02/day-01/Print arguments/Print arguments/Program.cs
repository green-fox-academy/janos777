using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...

            Printer("apple");
            Printer("pear", "banana");

            Console.ReadLine();
        }

        static void Printer(params string[] messages)
        {
            foreach (var message in messages)
            {
                Console.Write(message + ", ");
            }
        }
    }
}