using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Animal
    {
        public int hunger;
        public int thirst;

        public Animal(int hunger = 50, int thirst = 50)
        {
            this.hunger = hunger;
            this.thirst = thirst;
        }

        public string Eat()
        {
            hunger -= 1;
            return $"The animals hunger is: {hunger}, its thirst is: {thirst}.";
        }

        public string Drink()
        {
            thirst -= 1;
            return $"The animals hunger is: {hunger}, its thirst is: {thirst}.";
        }

        public string Play()
        {
            hunger += 1;
            thirst += 1;
            return $"The animals hunger is: {hunger}, its thirst is: {thirst}.";
        }
    }
}
