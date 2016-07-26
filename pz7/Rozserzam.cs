using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            p.poziom = p.doswiadczenie / 1000;
        //    Console.WriteLine("Obecny poziom: {0} ",poziom);
        }
        public static void RegeneracjaMany(this Czarownik cz, int procent)
        {
            double procento = (procent / 100.00) * Convert.ToDouble(cz.mana.maksymalne);
            Console.WriteLine("Procent: " + procento);
            while (cz.mana.aktualne < cz.mana.maksymalne)
            {
                int dodanie = Convert.ToInt32(cz.mana.aktualne + procento);
                if (dodanie > cz.mana.maksymalne)
                {
                    cz.mana.aktualne = cz.mana.maksymalne;
                }
                else
                {
                    cz.mana.aktualne += Convert.ToInt32(procento);
                }
                Console.WriteLine("Podnosze mane o: " + procento);
                Console.WriteLine("Po podniesieniu: {0}", cz.mana.aktualne);
                Stopwatch stoper = new Stopwatch();
                TimeSpan czas = new TimeSpan(0, 0, 30);
                TimeSpan leci=new TimeSpan();
                while (leci.Seconds < czas.Seconds)
                {
                    stoper.Start();
                    
                    leci = stoper.Elapsed;
                }
            }
            Console.WriteLine("Czarownik po regeneracji: \n {0}",cz.ToString());
        }
        public static void Rozbrajanie(this Postav p, int ile)
        {
            p.obrazenia -= ile;
        }
        public static void ZdejmowaniePancerze(this Postav p, int ile)
        {
            p.Pancerz -= ile;
        }
    }
}
