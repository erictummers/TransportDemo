using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voertuig
{
    public class Auto
    {
        public Auto()
        {
            Verplaatsing = new Stilstand();
            Bestuurder = "John Do";
        }

        public void Vooruit()
        {
            Verplaatsing.Vooruit(this);
        }

        public Verplaatsing Verplaatsing { get; set; }

        public void Achteruit()
        {
            Verplaatsing.Achteruit(this);
        }

        public void Stop()
        {
            Verplaatsing.Stop(this);
        }

        public string Bestuurder { get; set; }
    }
}
