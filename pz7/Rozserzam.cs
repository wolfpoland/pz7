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
        public static void Zyje(this Postav p)
        {
            if (p.zycie.aktualne <= 0)
            {
                Console.WriteLine("{0} nie zyje", p.imie);
            }
        }
        public static void dowiadczenieOIle(this Postav p,int ile)
        {
            int iloesc = 1000*p.poziom;
            p.doswiadczenie += ile;
            int poziom = p.doswiadczenie / 1000;
            Console.WriteLine("Obecny poziom: {0} ",poziom);
        }
    }
}
