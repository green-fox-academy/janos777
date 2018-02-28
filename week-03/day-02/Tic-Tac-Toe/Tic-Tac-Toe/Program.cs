using System;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // open and read it. The file data represents a tic-tac-toe
            // game result. Return 'X'/'O'/'draw' based on which player
            // has winning situation.

            //Console.Write(ticTacResult("win-o.txt"))
            // should print O

            //Console.Write(ticTacResult("win-x.txt"))
            // should print X

            //Console.Write(ticTacResult("draw.txt"))
            // should print draw

            string tTTPath = @"C:\Users\garayt\greenfox\janos777\week-03\day-02\Tic-Tac-Toe\tic-tac-toe.txt";

            Random random = new Random();
            string[] ticTacToe = { "O", "X", " " };

            string[] fileLine1Array = { ticTacToe[random.Next(0, 3)], ticTacToe[random.Next(0, 3)], ticTacToe[random.Next(0, 3)] };
            string[] fileLine2Array = { ticTacToe[random.Next(0, 3)], ticTacToe[random.Next(0, 3)], ticTacToe[random.Next(0, 3)] };
            string[] fileLine3Array = { ticTacToe[random.Next(0, 3)], ticTacToe[random.Next(0, 3)], ticTacToe[random.Next(0, 3)] };

            string fileLine1 = String.Join("", fileLine1Array);
            string fileLine2 = String.Join("", fileLine2Array);
            string fileLine3 = String.Join("", fileLine3Array);

            StreamWriter sw = new StreamWriter(tTTPath);
            sw.WriteLine(fileLine1);
            sw.WriteLine(fileLine2);
            sw.WriteLine(fileLine3);
            sw.Close();

            string[] readText = File.ReadAllLines(tTTPath);
            foreach (string r in readText)
            {
                Console.WriteLine(r);
            }


            string[][] matrix = new[] { fileLine1Array, fileLine2Array, fileLine3Array };

            string z;

            for (int i = 0; i < 2; i++)

                if (z == "X" || z == "O")

                    if (z == matrix[i][i])
                    {






                    }
                }
            }









            if (fileLine1Array[0] != " ")
            {
                for (int i = 0; i < fileLine1Array.Length; i++)
                {
                    if (fileLine1Array
                }




                if ((fileLine1Array[0] == "X") && (fileLine1Array[1] == "X") && (fileLine1Array[2] == "X"))
                {
                    Console.WriteLine("... X wins!");
                }
                if ((fileLine1Array[0] == "X") && (fileLine2Array[0] == "X") && (fileLine3Array[0] == "X"))
                {
                    Console.WriteLine("... X wins!");
                }
                if((fileLine1Array[0] == "X") && (fileLine2Array[1] == "X") && (fileLine3Array[2] == "X"))
                {
                    Console.WriteLine("... X wins!");
                }
                if((fileLine1Array[1] == "X") && (fileLine2Array[1] == "X") && (fileLine3Array[0] == "X"))
                {
                    Console.WriteLine("... X wins!");
                }




            }








            Console.ReadLine();
        }
    }
}