﻿using System;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `af`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `af`

            int[] af = { 4, 5, 6, 7 };

            foreach (var number in af)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}