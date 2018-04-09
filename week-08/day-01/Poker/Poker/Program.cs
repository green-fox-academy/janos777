using System;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

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

            foreach (var card in hands)
            {
                Console.WriteLine(card);
            }

            Console.ReadLine();
        }
    }
}
