using System;

namespace Divide_by_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("fail"); Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
