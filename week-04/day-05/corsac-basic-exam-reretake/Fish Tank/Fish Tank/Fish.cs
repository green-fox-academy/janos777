using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    abstract class Fish
    {
        public string Name;
        public int Weight;
        public string Color;

        public Fish(string name, int weight, string color)
        {
            Name = name;
            Weight = weight;
            Color = color;
        }

        public abstract int Feed();

        public abstract string Status();
    }
}
