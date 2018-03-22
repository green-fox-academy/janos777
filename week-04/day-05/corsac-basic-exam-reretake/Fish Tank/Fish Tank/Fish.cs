using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    abstract class Fish
    {
        private string Name;
        public int Weight { get; private set; }
        private string Color;
        private int FoodAmount;

        public Fish(string name, int weight, string color, int foodAmount)
        {
            Name = name;
            Weight = weight;
            Color = color;
            FoodAmount = foodAmount;
        }

        public void Feed()
        {
            Weight += FoodAmount;
        }


        public virtual string Status()
        {
            return $"{Name}, weight: {Weight}, color {Color}";
        }
    }
}
