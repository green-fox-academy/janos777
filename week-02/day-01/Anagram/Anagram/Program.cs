using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function named is anagram following your current language's style guide. It should take two strings and return a boolean value depending on whether its an anagram or not.

            //Examples
            //input 1	input 2	output
            //"dog"	"god"	true
            //"green"	"fox"	false

            Console.WriteLine("Please enter two words to check whether they are anagrams: ");
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            Console.WriteLine(IsAnagram(first, second));

            Console.ReadLine();
        }

        static bool IsAnagram(string first, string second)
        {
            int countOfXinFirstArray = 0;
            int countOfYinSecondArray = 0;

            char[] firstArray = first.ToCharArray();
            char[] secondArray = second.ToCharArray();

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        firstArray[i] = 'x';
                        secondArray[j] = 'y';
                    }
                }
            }

            for (int k = 0; k < firstArray.Length; k++)
            {
                if (firstArray[k] == 'x')
                {
                    countOfXinFirstArray += 1;
                }
            }

            for (int k = 0; k < secondArray.Length; k++)
            {
                if (secondArray[k] == 'y')
                {
                    countOfYinSecondArray += 1;
                }
            }

            if (countOfXinFirstArray == countOfYinSecondArray && countOfXinFirstArray == firstArray.Length && countOfYinSecondArray == secondArray.Length)
            {
                return true;
            }

            return false;
        }
    }
}