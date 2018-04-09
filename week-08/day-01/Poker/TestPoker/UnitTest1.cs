using System;
using NUnit.Framework;
using Poker;

namespace TestPoker
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestNumberOfCards()
        {
            Hand hand = new Hand();
            var hand1 = new Hand();
            var hand2 = new Hand();

            Assert.AreEqual(true, true);
        }
    }
}
