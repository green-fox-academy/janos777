using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var searchedCities = from c in cities
                                where c.ToCharArray()[0] == 'A' && c.ToCharArray()[c.Length - 1] == 'I'
                                orderby c
                                select c;

            var searchedCities2 = cities.Where(c => c.ToCharArray()[0] == 'A' && c.ToCharArray()[c.Length - 1] == 'I');

            foreach (var item in searchedCities)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in searchedCities2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
