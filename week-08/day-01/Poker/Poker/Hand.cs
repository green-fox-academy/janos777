using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand
    {
        public List<Card> hand;

        public Hand()
        {
            hand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public bool CheckOneHand()
        {
            int result = 0;

            for (int i = 0; i < hand.Count; i++)
            {
                for (int j = 0; j < hand.Count; j++)
                {
                    if (hand[i] == hand[j])
                    {
                        result++;
                    }
                }
            }

            return (result == hand.Count);
        }

        public static bool CheckTwoHands(Hand hand1, Hand hand2)
        {
            int result = 0;

            for (int i = 0; i < hand1.hand.Count; i++)
            {
                for (int j = 0; j < hand2.hand.Count; j++)
                {
                    if (hand1.hand[i] == hand2.hand[j])
                    {
                        result++;
                    }
                }
            }

            return (result == 0);
        }

        public 
    }
}
