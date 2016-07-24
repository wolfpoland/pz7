using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
   public class Mana
    {
        public Mana(int aktualne, int maksymalne)
        {
            this.aktualne = aktualne;
            this.maksymalne = maksymalne;
        }
        public int aktualne { get; set; }
        public int maksymalne { get; set; }

    }
}
