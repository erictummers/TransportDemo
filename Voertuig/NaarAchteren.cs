using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voertuig
{
    public class NaarAchteren : Verplaatsing
    {
        public override void Vooruit(Auto auto)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(auto.Bestuurder, "the stig"))
            {
                base.Vooruit(auto);
            }
            else
            {
                throw new Ongeluk();
            }
        }
    }
}
