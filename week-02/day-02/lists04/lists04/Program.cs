using System;
using System.Collections.Generic;
using System.Text;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Console.WriteLine(Sweets(list));
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"

            Console.ReadLine();

        }

        public static string Sweets(List<object> input)
        {
            input[1] = "Croissant";
            input[3] = "Ice cream";

            string outputString;
            List<string> stringList = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                stringList.Add((string)input[i]);
            }

            string[] inputArray = stringList.ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = $"\"{inputArray[i]}\"";
            }
            outputString = String.Join(", ", inputArray);

            return outputString;
        }
    }
}