using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    public class AnagramCheck
    {
        public bool IsAnagram(string word1, string word2)
        {
            int numberOfMatchingCharacters = 0;
            string word1JustLowerCase = word1.ToLower();
            string word2JustLowerCase = word2.ToLower();

            if (word1.Length == word2.Length)
            {
                int wordLength = word1.Length;

                if (wordLength == 0)
                {
                    return false;
                }

                if (word1JustLowerCase == word2JustLowerCase)
                {
                    return false;
                }

                for (int i = 0; i < wordLength; i++)
                {
                    for (int j = 0; j < wordLength; j++)
                    {
                        if (word1JustLowerCase[i] == word2JustLowerCase[j])
                        {
                            numberOfMatchingCharacters++;
                        }
                        numberOfMatchingCharacters += 0;
                    }
                }

                if (wordLength == numberOfMatchingCharacters)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

    }
}