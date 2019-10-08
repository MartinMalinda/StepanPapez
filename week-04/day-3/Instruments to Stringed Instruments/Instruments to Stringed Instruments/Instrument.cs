using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentToStringedInstruments
{
    public abstract class Instrument
    {
        protected string name;
        public virtual void Play();
    }
}
