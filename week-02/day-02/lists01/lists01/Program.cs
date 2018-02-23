using System;
using System.Collections.Generic;


namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct STRING.



            Console.WriteLine(PutSaturn(planetList));
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"

            Console.ReadLine();
        }

        public static string PutSaturn(List<string> planets)
        {
            planets.Add("Saturn");

            for (int i = 0; i < planets.Count; i++)
            {
                planets[i] = $"\"{planets[i]}\"";
            }

            string output = String.Join(", ", planets);

            return output;
        }
    }
}