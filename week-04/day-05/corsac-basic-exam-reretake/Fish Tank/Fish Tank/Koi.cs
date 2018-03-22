using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Koi : Fish
    {
        public Koi(string name, int weight, string color) : base(name, weight, color)
        {

        }

        public override int Feed()
        {
            return Weight += 2;
        }

        public override string Status()
        {
            return $"{Name}, weight: {Weight}, color {Color}";
        }
    }
}
