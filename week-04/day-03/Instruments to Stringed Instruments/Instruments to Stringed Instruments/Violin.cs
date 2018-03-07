using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments_to_Stringed_Instruments
{
    public class Violin : StringedInstrument
    {
        public Violin() : base(4)
        {
            name = "Violin";
        }

        public Violin(int numberOfStrings) : base(numberOfStrings)
        {
            name = "Violin";
        }

        public override string Play()
        {
            return $"{name}, a {numberOfStrings}-stringed instrument that {Sound()}.";
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}