using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments_to_Stringed_Instruments
{
    public abstract class StringedInstrument : Instrument
    {      
        protected int numberOfStrings;

        public StringedInstrument(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public abstract string Sound();
    }
}
