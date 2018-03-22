using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Clownfish : Fish
    {
        private string StripeColor;

        public Clownfish(string name, int weight, string color, string stripeColor) : base (name, weight, color, 1)
        {
            StripeColor = stripeColor;
        }

        public override string Status()
        {
            return base.Status() + $", stripe color: {StripeColor}";
        }
    }
}
