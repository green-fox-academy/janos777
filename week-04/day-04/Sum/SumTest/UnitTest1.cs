using NUnit.Framework;
using Sum;
using System;
using System.Collections.Generic;

namespace SumTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestListEmpty()
        {
            var summa = new Summary();
            var empty = new List<int>();

            Assert.AreEqual(0, summa.Summed(empty));
        }
        
        [TestCase]
        public void TestListOneElement()
        {
            var summa = new Summary();
            var oneElement = new List<int> { 7 };

            Assert.AreEqual(7, summa.Summed(oneElement));
        }

        [TestCase]
        public void TestListMultiple()
        {
            var summa = new Summary();
            var multiple = new List<int> { 1, 2, 3, 4, 5 };

            Assert.AreEqual(15, summa.Summed(multiple));
        }

        [TestCase]
        public void TestListNull()
        {
            var summa = new Summary();
            var nullList = new List<int>();
            nullList = null;

            Assert.Throws<NullReferenceException>(() => summa.Summed(nullList));
        }
    }
}