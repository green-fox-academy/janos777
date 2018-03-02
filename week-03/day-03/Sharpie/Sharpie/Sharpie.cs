using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    class Sharpie
    {
        public string Color;
        public float Width;
        public float InkAmount;

        public Sharpie(string Color, float Width, float InkAmount = 100)
        {
            this.Color = Color;
            this.Width = Width;
            this.InkAmount = InkAmount;
        }

        public float Use()
        {
            return InkAmount -= 1;
        }
    }
}
