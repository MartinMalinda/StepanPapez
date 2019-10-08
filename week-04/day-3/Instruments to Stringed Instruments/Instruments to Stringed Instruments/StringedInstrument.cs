using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    public abstract class StringedInstrument : Instrument
    {
        public int numberOfStrings;
        public virtual void Sound();
    }
}
