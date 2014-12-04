using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voertuig
{
    public class NaarVoren : Verplaatsing
    {
        public override void Achteruit(Auto auto)
        {
            throw new Ongeluk();
        }
    }
}
