using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Fox class with 3 properties(name, type, color) Fill a list with at least 5 foxes, it's up to you how you name/create them! Write a LINQ Expression to find the foxes with green color! Write a LINQ Expression to find the foxes with green color and pallida type!

            var Foxes = new List<Fox>();

            var listOfColors = new List<string>() { "Black", "Red", "White", "Green" };
            var listOfPallida = new List<string>() { "Pallida", "Non-Pallida" };

            Random random = new Random();

            var stringToBePrintedGreenFoxes = new List<string>();
            var stringToBePrintedGreenFoxes2 = new List<string>();
            var stringToBePrintedGreenPallidaFoxes = new List<string>();
            var stringToBePrintedGreenPallidaFoxes2 = new List<string>();

            for (int i = 1; i < 11; i++)
            {
                Foxes.Add(new Fox($"Fox{i}", $"{listOfPallida[random.Next(0, listOfPallida.Count)]}", $"{listOfColors[random.Next(0, listOfColors.Count)]}"));
            }

            foreach (var fox in Foxes)
            {
                Console.WriteLine(fox.Status());
            }

            var greenFoxes = from fox in Foxes
                             where fox.Color == "Green"
                             select fox;

            var greenFoxes2 = Foxes.Where(fox => fox.Color == "Green");

            var greenPallidaFoxes = from fox in Foxes
                                    where fox.Color == "Green" && fox.Type == "Pallida"
                                    select fox;

            var greenPallidaFoxes2 = Foxes.Where(fox => fox.Color == "Green" && fox.Type == "Pallida");

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in greenFoxes)
            {
                stringToBePrintedGreenFoxes.Add(item.Name);
            }

            foreach (var item in greenFoxes2)
            {
                stringToBePrintedGreenFoxes2.Add(item.Name);
            }

            foreach (var item in greenPallidaFoxes)
            {
                stringToBePrintedGreenPallidaFoxes.Add(item.Name);
            }

            foreach (var item in greenPallidaFoxes2)
            {
                stringToBePrintedGreenPallidaFoxes2.Add(item.Name);
            }

            Console.WriteLine($"The green foxes are: {String.Join(", ", stringToBePrintedGreenFoxes)}");
            Console.WriteLine();
            Console.WriteLine($"The green foxes are: {String.Join(", ", stringToBePrintedGreenFoxes2)}");
            Console.WriteLine();
            Console.WriteLine($"The green Pallida foxes are: {String.Join(", ", stringToBePrintedGreenPallidaFoxes)}");
            Console.WriteLine();
            Console.WriteLine($"The green Pallida foxes are: {String.Join(", ", stringToBePrintedGreenPallidaFoxes2)}");

            Console.ReadLine();
        }
    }
}
