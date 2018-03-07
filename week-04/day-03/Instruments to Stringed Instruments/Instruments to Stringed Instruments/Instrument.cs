using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments_to_Stringed_Instruments
{
    public abstract class Instrument
    {
        protected string name;

        public abstract string Play();
    }
}
