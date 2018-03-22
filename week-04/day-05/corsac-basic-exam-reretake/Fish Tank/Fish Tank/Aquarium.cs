using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Aquarium
    {
        public List<Fish> Fishes;

        public Aquarium()
        {
            Fishes = new List<Fish>();
        }

        public string Status()
        {
            List<string> aquariumStatus = new List<string>();

            foreach (var fish in Fishes)
            {
                aquariumStatus.Add(fish.Status());
            }

            return string.Join("\n", aquariumStatus);
        }

        public void Feed()
        {
            foreach (var fish in Fishes)
            {
                fish.Feed();
            }
        }

        public void Add(Fish fish)
        {
            Fishes.Add(fish);
        }

        public void RemoveOversizedFishes()
        {
            for (int i = 0; i < Fishes.Count; i++)
            {
                if (Fishes[i].Weight >= 11)
                {
                    Fishes.Remove(Fishes[i]);
                }
            }
        }
    }
}
