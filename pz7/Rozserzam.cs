using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
   public static class Rozserzam
    {
        public static void ReJunevation(this Postav p)
        {
            p.zycie.aktualne = p.zycie.maksymalne;
            p.mana.aktualne = p.mana.maksymalne;
        }
    }
}
