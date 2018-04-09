using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Card
    {
        //private object[] Values;

        private char suit;
        private int value;

        List<char> suites = new List<char> { 'C', 'D', 'H', 'S' };
        List<int> values = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

        public Card(char suit, int value)
        {
            this.suit = suit;
            this.value = value;

            //Values = new object[] { suit, value };
        }

        public static Card ReadCard(char[] input)
        {
            return new Card (input[0], Convert.ToInt32(input[1]));
        }
    }
}
