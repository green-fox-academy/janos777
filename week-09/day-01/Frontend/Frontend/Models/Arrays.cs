using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class Arrays
    {
        public string What { get; set; }
        public int[] Numbers { get; set; }

        public Arrays(string what, int[] numbers)
        {
            What = what;
            Numbers = numbers;
        }

        public int Sum(int[] numbers)
        {
            int resultSum = 0;

            foreach (var n in numbers)
            {
                resultSum += n;
            }

            return resultSum;
        }

        public int Multiply(int[] numbers)
        {
            int resultMultiply = 1;

            foreach (var n in numbers)
            {
                resultMultiply *= n;
            }

            return resultMultiply;
        }

        public int[] Double(int[] numbers)
        {
            var resultDouble = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                resultDouble[i] = numbers[i] * 2;
            }

            return resultDouble;
        }
    }
}
