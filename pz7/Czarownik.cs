using pz7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    public class Czarownik : Postav, IMagiczny<Czarownik>
    {
        public int Manaakt
        {
            get
            {
                return mana.aktualne;
            }

            set
            {
                mana.aktualne = value;
            }
        }

        public int Manamax
        {
            get
            {
                return mana.maksymalne;
            }

            set
            {
                mana.maksymalne = value;
            }
        }

        public Czarownik()
        {

        }
        public Czarownik(string imie, int poziom, int doswiadczenie, int sila, int zrecznosc, int inteligencja, Zycie zycie, Mana mana, int obrazenia, Odpornosci odpornosci,int Pancerz) :base(imie,poziom,doswiadczenie,sila,zrecznosc,inteligencja,zycie,mana,obrazenia,odpornosci,Pancerz)
        {
           this.odpornosci=Odpornosci.Ogien; 
        }
        public Czarownik(string imie) :base(imie)
        {
            base.doswiadczenie = 0;
            base.inteligencja = 10;
            base.obrazenia = 2;
            base.odpornosci = Odpornosci.Ogien;
            base.poziom = 0;
            base.sila = 1;
            base.zrecznosc = 1;
            base.zycie.maksymalne = 10;
            base.zycie.aktualne = 10;
            base.mana.maksymalne = 20;
            base.mana.aktualne = 20;

        }
        public override void obrazeniaOdniesione(int obrazenia,Odpornosci odp)
        {
            
            
            Console.WriteLine("Obrazenia na wejsciu: {0}", obrazenia);
            if(odp== Odpornosci.Ogien)
            {
               // double x = 0.25;
                Console.WriteLine("Zaszedl if");
                double procent = 50.0/100.0  * obrazenia ;
                 Console.WriteLine("Odpornosc na obrazenia ognia, zmniejszam otrzymane obrazenia o polowe \n Z obrazen zdejme: {0}", procent);
                obrazenia = obrazenia - Convert.ToInt32(procent);
                this.zycie.aktualne -= obrazenia;

            }else
            {
              base.obrazeniaOdniesione(obrazenia, odp);
                
            }
            Console.WriteLine("Obrazenia {0}", obrazenia);
            Console.WriteLine("Zycie po zadaniu obrazen: {0}",this.zycie.aktualne);
            
            
        }
        public override int levelUp()
        {
            poziom = base.levelUp();
            if (poziom < 20)
            {
                inteligencja += 7;
            }
            else
            {
                inteligencja += poziom / 2;
            }

            zycie.maksymalne += 5;
            mana.maksymalne += 15;
            obrazenia += 15;
            zrecznosc += 1;
            sila += 1;
            return poziom;
        }

        public void RzucCzar(Czary cz, [Optional] Postav atak)
        {
          TypyCzarow typ = new TypyCzarow(cz);
            if (cz == Czary.Uzdrawiajacy)
            {
                typ.CzarUzdrawiajacy(this);
            }else if(cz == Czary.Ofensywny)
            {
                typ.CzarOfensywny(this,atak);
            }else if(cz == Czary.Defensywny)
            {
                typ.CzarDefensywny(this);
            }

        }

        
    }
}
