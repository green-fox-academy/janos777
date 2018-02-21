using System;
using System.Collections.Generic;

namespace ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!

            Console.WriteLine(ContainsSeven1(List));
            Console.WriteLine(ContainsSeven2(List));

            Console.ReadLine();
        }

        public static string ContainsSeven1(List<int> input)
        {
            string outputString;
            int numberOfSevens = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == 7)
                {
                    numberOfSevens++;
                }
                else
                {
                    numberOfSevens = numberOfSevens;
                } 
            }
            if (numberOfSevens == 0)
            {
                return outputString = "Noooooo";
            }
            else
            {
                return outputString = "Hoorray";
            }
        }

        public static string ContainsSeven2(List<int> input)
        {




        }
    }
}