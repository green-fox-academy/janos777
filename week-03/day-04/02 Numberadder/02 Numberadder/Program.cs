using System;

namespace _02_Numberadder
{
    class Program
    {
        // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.

        static void Main(string[] args)
        {
            int n = 100;
            
            AddString(n);

            Console.ReadLine();
        }

        static void AddString(int num)
        {
            int Add(int n)
            {
                if (n == 1)
                {
                    return n;
                }
                else
                {
                    return n + Add(n - 1);
                }
            }

            Console.WriteLine(Add(num));
        }
    }
}
