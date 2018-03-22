using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Clownfish : Fish
    {
        public string StripeColor;

        public Clownfish(string name, int weight, string color, string stripeColor) : base (name, weight, color)
        {
            StripeColor = stripeColor;
        }

        public override int Feed()
        {
            return Weight++;
        }

        public override string Status()
        {
            return $"{Name}, weight: {Weight}, color {Color}, stripe color: {StripeColor}";
        }
    }
}
