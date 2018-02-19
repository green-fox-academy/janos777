using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("What is the distance in kilometers?");
            int distKm = int.Parse(Console.ReadLine());
            Console.WriteLine("The distance in miles is: " + (distKm * 1.6));
            Console.ReadLine();


        }
    }
}