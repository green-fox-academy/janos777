using System;
using System.Collections.Generic;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"

            Console.WriteLine(CheckNums(list));

            Console.ReadLine();
        }

        public static bool CheckNums(List<int> input)
        {
            int[] inputArray = input.ToArray();

            bool four = false;
            bool eight = false;
            bool twelve = false;
            bool sixteen = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 4)
                {
                    four = true;
                }
                if (inputArray[i] == 8)
                {
                    eight = true;
                }
                if (inputArray[i] == 12)
                {
                    twelve = true;
                }
                if (inputArray[i] == 16)
                {
                    sixteen = true;
                }
            }
            if (four && eight && twelve && sixteen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}