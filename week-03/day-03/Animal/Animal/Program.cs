﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Animal class
            //Every animal has a hunger value, which is a whole number
            //Every animal has a thirst value, which is a whole number
            //when creating a new animal object these values are created with the default 50 value
            //Every animal can eat() which decreases their hunger by one
            //Every animal can drink() which decreases their thirst by one
            //Every animal can play() which increases both by one

            Animal dog = new Animal();
            Animal cat = new Animal();

            Console.WriteLine(dog.Drink());

            Console.ReadLine();
        }
    }
}
