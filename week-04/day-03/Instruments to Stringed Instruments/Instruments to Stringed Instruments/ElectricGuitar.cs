using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments_to_Stringed_Instruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar() : base(6)
        {
            name = "Electric Guitar";
        }

        public ElectricGuitar(int numberOfStrings) : base(numberOfStrings)
        {
            name = "Electric Guitar";
        }

        public override string Play()
        {
            return $"{name}, a {numberOfStrings}-stringed instrument that {Sound()}.";
        }

        public override string Sound()
        {
            return "Twang";
        }
    }
}