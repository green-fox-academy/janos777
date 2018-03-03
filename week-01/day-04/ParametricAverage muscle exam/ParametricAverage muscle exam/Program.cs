using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("How many numbers do you want to calculate with?");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please provide a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            SumAve(numbers);

            Console.ReadLine();
        }

        public static void SumAve(int[] numbers)
        {
            int sum = 0;
            double average;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            average = sum / numbers.Length;

            Console.WriteLine("Sum of the numbers is: {0}, their average is: {1}", sum, average);
        }
    }
}