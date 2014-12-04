using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voertuig
{
    public abstract class Verplaatsing
    {
        public virtual void Vooruit(Auto auto)
        {
            auto.Verplaatsing = new NaarVoren();
        }

        public virtual void Achteruit(Auto auto)
        {
            auto.Verplaatsing = new NaarAchteren();
        }

        public virtual void Stop(Auto auto)
        {
            auto.Verplaatsing = new Stilstand();
        }
    }
}
