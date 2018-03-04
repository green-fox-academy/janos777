using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            //Console.WriteLine(Unique({ 1, 11, 34, 11, 52, 61, 1, 34 }));
            //  should print: `[1, 11, 34, 52, 61]`

            var originalList = new List<int>() { 1, 11, 34, 11, 52, 61, 1, 34 };

            foreach (var item in Unique(originalList))
            {
                Console.Write(item + ", ");
            }

            Console.ReadLine();
        }

        static List<int> Unique(List<int> originalList)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < originalList.Count; i++)
            {
                if (resultList.Contains(originalList[i]) == false)
                {
                    resultList.Add(originalList[i]);
                }
            }

            return resultList;
        }
    }
}