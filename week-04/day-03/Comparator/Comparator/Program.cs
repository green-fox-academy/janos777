using System;
using System.Collections;
using System.Collections.Generic;

namespace Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));

            for (int i = 0; i < dominoes.Count; i++)
            {
                Console.WriteLine($"[{dominoes[i].GetValues()[0]}, {dominoes[i].GetValues()[1]}]");
            }

            Console.WriteLine();

            dominoes.Sort();

            for (int i = 0; i < dominoes.Count; i++)
            {
                Console.WriteLine($"[{dominoes[i].GetValues()[0]}, {dominoes[i].GetValues()[1]}]");
            }

            Console.ReadLine();
        }
    }
}