// The crash-incidents.csv file contains data of road crash-incidents.
// (id; location; surface type; surface condition; light condition; weather condition; crash date; year)
// Your task will be to count how many crash-incidents happened at good/bad
// weather conditions.
// Good weather conditions are CLOUDY and CLEAR.
// Bad weather conditions are RAIN, FREEZING RAIN, SNOW, FOG and SEVERE CROSSWINDS.
// So create the necessary method(s) that returns with the amount of crash-incidents.
// And print the return value to the console:
// The amount of crashes at good weather conditions: {amount}
// The amount of crashes at bad weather conditions: {amount}

using System;
using System.Collections.Generic;
using System.IO;

namespace Crashes
{
    public class Crashes
    {
        public static void Main(string[] args)
        {
            int crashesAtGoodWeatherWithContains = 0;
            int crashesAtBadWeatherWithContains = 0;

            int crashesAtGoodWeatherWithSplit = 0;
            int crashesAtBadWeatherWithSplit = 0;

            var goodConditions = new List<string> { "CLOUDY", "CLEAR" };
            var badConditions = new List<string> { "RAIN", "FREEZING RAIN", "SNOW", "FOG", "SEVERE CROSSWINDS" };

            string path = @"..\..\..\crash-incidents.csv";

            string[] crashIncidents = File.ReadAllLines(path);

            foreach (var line in crashIncidents)
            {
                for (int i = 0; i < goodConditions.Count; i++)
                {
                    if (line.Contains(goodConditions[i]))
                    {
                        crashesAtGoodWeatherWithContains++;
                    }
                }

                for (int j = 0; j < badConditions.Count; j++)
                {
                    if (line.Contains(badConditions[j]))
                    {
                        crashesAtBadWeatherWithContains++;
                    }
                }
            }

            foreach (var line in crashIncidents)
            {
                string weatherCondition = line.Split(';')[5];

                for (int i = 0; i < goodConditions.Count; i++)
                {
                    if (weatherCondition == goodConditions[i])
                    {
                        crashesAtGoodWeatherWithSplit++;
                    }
                }

                for (int j = 0; j < badConditions.Count; j++)
                {
                    if (weatherCondition == badConditions[j])
                    {
                        crashesAtBadWeatherWithSplit++;
                    }
                }
            }

            Console.WriteLine($"The amount of crashes at good weather conditions (with 'contains'): {crashesAtGoodWeatherWithContains}");
            Console.WriteLine($"The amount of crashes at bad weather conditions (with 'contains'): {crashesAtBadWeatherWithContains}");
            Console.WriteLine();
            Console.WriteLine($"The amount of crashes at good weather conditions (with 'split'): {crashesAtGoodWeatherWithSplit}");
            Console.WriteLine($"The amount of crashes at bad weather conditions (with 'split'): {crashesAtBadWeatherWithSplit}");

            Console.ReadLine();
        }
    }
}
