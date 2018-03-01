using System;

namespace _11_Refactorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a recursive function called `refactorio`
            // that returns it's input's factorial

            Console.WriteLine("Please provide a number >= 1: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Refactorio(n));

            Console.ReadLine();
        }

        static int Refactorio(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * (Refactorio(n - 1));
            }
        }
    }
}
