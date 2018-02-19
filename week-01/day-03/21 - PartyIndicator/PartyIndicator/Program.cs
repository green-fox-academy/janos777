using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people



            Console.WriteLine("How many girls will come to the party?");
            int girls = int.Parse(Console.ReadLine());

            Console.WriteLine("How many boys will come to the party?");
            int boys = int.Parse(Console.ReadLine());

            if (girls == 0)
            {
                if (boys == 0)
                {
                    Console.WriteLine("There will be no party...");
                }
                if (boys != 0)
                {
                    Console.WriteLine("Sausage party");
                }
            }
            if ((girls + boys) > 20)
            {
                if (girls == boys)
                {
                    Console.WriteLine("The party is exellent!");
                }
                if ((girls != boys) && ((girls * boys) != 0))
                {
                    Console.WriteLine("Quite cool party!");
                }
                if (boys == 0)
                {
                    Console.WriteLine("Ladies' night");
                }
            }
            if (((girls + boys) <= 20) && (girls != 0))
            {
                if (boys == 0)
                {
                    Console.WriteLine("Ladies' night");
                }
                else
                {
                    Console.WriteLine("Average party...");
                }
            }
            Console.ReadLine();
        }
    }
}