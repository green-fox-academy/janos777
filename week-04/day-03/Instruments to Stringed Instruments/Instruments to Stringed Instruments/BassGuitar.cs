using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments_to_Stringed_Instruments
{
    public class BassGuitar : StringedInstrument
    {
        public BassGuitar() : base(4)
        {
            name = "Bass Guitar";
        }

        public BassGuitar(int numberOfStrings) : base(numberOfStrings)
        {
            name = "Bass Guitar";
        }

        public override string Play()
        {
            return $"{name}, a {numberOfStrings}-stringed instrument that {Sound()}.";
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}