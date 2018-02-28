using System;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            string tTTPath = @"...\Tic-Tac-Toe\tic-tac-toe.txt";
            string tTTPathIncorrect = @"..\tic-tac-toe.txt";

            string[] ticTacToe = { "O", "X", "draw" };

            Random random = new Random();

            string tTT = ticTacToe[random.Next(0, ticTacToe.Length)];

            File.WriteAllText(tTTPathIncorrect, tTT);

            Result(tTTPathIncorrect);

            Console.ReadLine();
        }

        static void Result(string text)
        {
            string[] gameResult = File.ReadAllLines(text);

            if (gameResult[0] == "O")
            {
                Console.WriteLine("... O wins!");
            }
            if (gameResult[0] == "X")
            {
                Console.WriteLine("... X wins!");
            }
            if (gameResult[0] == "draw")
            {
                Console.WriteLine("... it is a draw");
            }
        }
    }
}