using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Please provide the first number: ");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the second number: ");
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the third number: ");
            double third = double.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the fourth number: ");
            double fourth = double.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the fifth number: ");
            double fifth = double.Parse(Console.ReadLine());

            double sum;
            double average;

            sum = first + second + third + fourth + fifth;
            average = sum / 5;

            Console.WriteLine("Sum of the numbers is: {0}, their average is: {1}", sum, average);

            Console.ReadLine();
        }
    }
}