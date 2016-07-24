using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
   public class TypyCzarow
    {
        public TypyCzarow(Czary TypCzaru)
        {
            this.TypCzaru = TypCzaru;
            if(TypCzaru == Czary.Uzdrawiajacy)
            {
                Mana = 10;

            }
            if (TypCzaru == Czary.Ofensywny)
            {
                Mana = 20;
            }
            if(TypCzaru== Czary.Defensywny)
            {
                Mana = 10;
            }
        }
        public Czary TypCzaru { get; set; }
        public int Mana { get; set; }

        public void CzarOfensywny(Postav p, Postav atak)
        {
            int tmp = p.mana.aktualne;

            p.mana.aktualne -= Mana;
            if (p.mana.aktualne < 0)
            {
                throw new Exception("No nie masz many !");
                p.mana.aktualne = tmp;
            }
            atak.obrazeniaOdniesione(50, Odpornosci.Fizyczne);
        }
        public void CzarUzdrawiajacy(Postav p)
        {
           
            int tmp = p.mana.aktualne;

            p.mana.aktualne -= Mana;
            if (p.mana.aktualne < 0)
            {
                throw new Exception("No nie masz many !");
                p.mana.aktualne = tmp;
            }
            int maxo = p.zycie.aktualne+50;
            if(maxo > p.zycie.aktualne)
            {
                p.zycie.aktualne = p.zycie.maksymalne;
            }else
            {
                p.zycie.aktualne = maxo;
            }
        }
        public void CzarDefensywny(Postav p)
        {
            int tmp = p.mana.aktualne;

            p.mana.aktualne -= Mana;
            if (p.mana.aktualne < 0)
            {
                throw new Exception("No nie masz many !");
                p.mana.aktualne = tmp;
            }
            p.Pancerz += 50;

        }
      

    }
}
