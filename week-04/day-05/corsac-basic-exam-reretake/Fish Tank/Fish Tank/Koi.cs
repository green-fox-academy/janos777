using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Koi : Fish
    {
        public Koi(string name, int weight, string color) : base(name, weight, color, 2)
        {

        }

        public override string Status()
        {
            return base.Status();
        }
    }
}
