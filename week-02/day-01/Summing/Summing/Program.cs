using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer

            Console.WriteLine("Please provide a number: ");
            int number = int.Parse(Console.ReadLine());


            Console.WriteLine(Sum(number));
            Console.ReadLine();
        }

        static int Sum(int number)
        {
            int numberSummed = 0;
            for (int i = 1; i <= number; i++)
            {
                numberSummed = numberSummed + i;
            }
            return numberSummed;
        }
    }
}