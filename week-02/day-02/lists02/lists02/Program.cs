using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new STRING
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...



            Console.WriteLine(MakingMatches(girls, boys));

            Console.ReadLine();
        }

        public static string MakingMatches(List<string> input1, List<string> input2)
        {
            string outputString;
            List<string> output = new List<string>();
            if (input1.Count >= input2.Count)
            {
                for (int i = 0; i < input1.Count - 1; i++)
                {
                    output.Add("\"" + input1[i] + "\", \"" + input2[i] + "\"");
                }
                output.Add("\"" + input1[input1.Count - 1] + "\"");
                outputString = string.Join(", ", output);
            }
            else
            {
                for (int i = 0; i < input2.Count - 1; i++)
                {
                    output.Add("\"" + input2[i] + "\", \"" + input1[i] + "\"");
                }
                output.Add("\"" + input2[input2.Count-1] + "\"");
                outputString = string.Join(", ", output);
            }
            return outputString;
        }
    }
}