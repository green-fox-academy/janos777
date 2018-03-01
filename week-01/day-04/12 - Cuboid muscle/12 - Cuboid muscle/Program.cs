using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            Console.WriteLine("First side length of the cuboid: ");
            double firstLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Second side length of the cuboid: ");
            double secondLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Third side length of the cuboid: ");
            double thirdLength = double.Parse(Console.ReadLine());

            double surface;
            double volume;

            surface = 2 * (firstLength * secondLength + secondLength * thirdLength + thirdLength * firstLength);
            volume = firstLength * secondLength * thirdLength;

            Console.WriteLine("The surface of the cuboid is: {0}, the volume is: {1}.", surface, volume);

            Console.ReadLine();
        }
    }
}