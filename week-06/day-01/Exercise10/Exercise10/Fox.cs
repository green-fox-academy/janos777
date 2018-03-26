using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    class Fox
    {
        public string Name;
        public string Type;
        public string Color;

        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }

        public string Status()
        {
            return $"{Name}, {Type}, {Color}";
        }
    }
}
