using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            Console.WriteLine("Please provide a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorio(number));
            Console.ReadLine();
        }

        static int Factorio(int number)
        {
            int numberFactorial = 1;
            for (int i = 1; i <= number; i++)
            {
                numberFactorial = numberFactorial * i;
            }
            return numberFactorial;
        }
    }
}