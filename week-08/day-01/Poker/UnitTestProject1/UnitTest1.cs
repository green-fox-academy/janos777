using System;
using NUnit.Framework;
using Poker;

namespace TestPoker
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestCardsInHands1()
        {
            string input = "Black 2H 3D 5S 9C KD White 2C 3H 4S 8C AH";

            var hand1 = new Hand();
            var hand2 = new Hand();

            string[] hands = input.Split(" ");

            string player1 = hands[0];

            for (int i = 1; i <= 6; i++)
            {
                hand1.AddCard(Card.ReadCard(hands[i].ToCharArray()));
            }

            string player2 = hands[6];

            for (int j = 7; j <= 11; j++)
            {
                hand2.AddCard(Card.ReadCard(hands[j].ToCharArray()));
            }

            Assert.AreEqual(true, hand1.CheckOneHand());
        }

        [TestCase]
        public void TestCardsInHands2()
        {
            string input = "Black 2H 3D 5S 9C KD White 2C 3H 4S 8C AH";

            var hand1 = new Hand();
            var hand2 = new Hand();

            string[] hands = input.Split(" ");

            string player1 = hands[0];

            for (int i = 1; i <= 6; i++)
            {
                hand1.AddCard(Card.ReadCard(hands[i].ToCharArray()));
            }

            string player2 = hands[6];

            for (int j = 7; j <= 11; j++)
            {
                hand2.AddCard(Card.ReadCard(hands[j].ToCharArray()));
            }

            Assert.AreEqual(true, hand2.CheckOneHand());
        }

        [TestCase]
        public void TestCardsInTwoHands()
        {
            string input = "Black 2H 3D 5S 9C KD White 2C 3H 4S 8C AH";

            var hand1 = new Hand();
            var hand2 = new Hand();

            string[] hands = input.Split(" ");

            string player1 = hands[0];

            for (int i = 1; i <= 6; i++)
            {
                hand1.AddCard(Card.ReadCard(hands[i].ToCharArray()));
            }

            string player2 = hands[6];

            for (int j = 7; j <= 11; j++)
            {
                hand2.AddCard(Card.ReadCard(hands[j].ToCharArray()));
            }

            Assert.AreEqual(true, Hand.CheckTwoHands(hand1, hand2));
        }
    }
}