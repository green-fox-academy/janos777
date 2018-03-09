using NUnit.Framework;
using Anagram;
using System;

namespace TestAnagram
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void stringsIdentic()
        {
            string first = "first";
            string second = "first";
            var checkanagram = new AnagramCheck();

            Assert.AreEqual(false, checkanagram.IsAnagram(first, second));
        }

        [TestCase]
        public void stringsNotSameLength()
        {
            string first = "first";
            string second = "second";
            var checkanagram = new AnagramCheck();

            Assert.AreEqual(false, checkanagram.IsAnagram(first, second));
        }

        [TestCase]
        public void stringsOneEmpty()
        {
            string first = "first";
            string second = "";
            var checkanagram = new AnagramCheck();

            Assert.AreEqual(false, checkanagram.IsAnagram(first, second));
        }

        [TestCase]
        public void stringsBothEmpty()
        {
            string first = "";
            string second = "";
            var checkanagram = new AnagramCheck();

            Assert.AreEqual(false, checkanagram.IsAnagram(first, second));
        }

        [TestCase]
        public void stringsAnagram()
        {
            string first = "god";
            string second = "dog";
            var checkanagram = new AnagramCheck();

            Assert.AreEqual(true, checkanagram.IsAnagram(first, second));
        }

        [TestCase]
        public void stringsWithUpperCase()
        {
            string first = "God";
            string second = "dog";
            var checkanagram = new AnagramCheck();

            Assert.AreEqual(true, checkanagram.IsAnagram(first, second));
        }

        [TestCase]
        public void stringsWithDifferentAmountOfSameLetters()
        {
            string first = "fiirst";
            string second = "firrst";
            var checkanagram = new AnagramCheck();

            Assert.AreEqual(false, checkanagram.IsAnagram(first, second));
        }

        [TestCase]
        public void stringsWithSpaces()
        {
            string first = "first ";
            string second = "fir st";
            var checkanagram = new AnagramCheck();

            Assert.AreEqual(true, checkanagram.IsAnagram(first, second));
        }

        [TestCase]
        public void stringsWithNumbers()
        {
            string first = "first1";
            string second = "2first";
            var checkanagram = new AnagramCheck();

            Assert.AreEqual(false, checkanagram.IsAnagram(first, second));
        }
    }
}