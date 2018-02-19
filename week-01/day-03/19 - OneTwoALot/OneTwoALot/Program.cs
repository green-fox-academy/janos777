﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            Console.WriteLine("Please provide a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <=0)
            {
                Console.WriteLine("Not enough");
            }
            else switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("A lot");
                    break;
            }

            Console.ReadLine();


        }
    }
}