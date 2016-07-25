using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    class Wojownik : Postav
    {
        public Wojownik()
        {


        }
        
        public int iloscAtakow { get; set; }
        public Wojownik(string imie,int poziom, int doswiadczenie, int sila, int zrecznosc, int inteligencja, Zycie zycie, Mana mana, int obrazenia, Odpornosci odpornosci,int Pancerz, int iloscAtakow) :base(imie,poziom,doswiadczenie,sila,zrecznosc,inteligencja,zycie,mana,obrazenia,odpornosci,Pancerz)
        {
            this.iloscAtakow = iloscAtakow;
        }
        public Wojownik(string imie) :base(imie)
        {
            base.doswiadczenie = 0;
            base.inteligencja = 2;
            base.obrazenia = 5;
            base.odpornosci = Odpornosci.Fizyczne;
            base.poziom = 0;
            base.sila = 10;
            base.zrecznosc = 1;
            base.zycie.maksymalne = 20;
            base.zycie.aktualne = 20;
            base.mana.maksymalne = 5;
            base.mana.aktualne = 5;

        }
        public Wojownik(Wojownik w)
        {
            this.imie = w.imie;
            this.doswiadczenie = w.doswiadczenie;
            this.inteligencja = w.inteligencja;
            this.obrazenia = w.obrazenia;
            this.poziom = w.poziom;
            this.sila = w.sila;
            this.zrecznosc = w.zrecznosc;
         //   this.zycie.maksymalne = w.zycie.maksymalne;
           // this.zycie.aktualne = w.zycie.aktualne;
            this.zycie = new Zycie { maksymalne = w.zycie.maksymalne, aktualne = w.zycie.aktualne };
         //   this.mana.maksymalne = w.mana.maksymalne;
        //    this.mana.aktualne = w.mana.aktualne;
            this.mana = new Mana(w.mana.aktualne, w.mana.maksymalne);
            
        }
        public override string ToString()
        {
            String tmp = base.ToString();
            Console.WriteLine(tmp);
            return base.ToString();
        }
        public override int levelUp()
        {
            poziom = base.levelUp();
            if (poziom < 20)
            {
                sila += 7;
            }
            else
            {
                sila += poziom / 2;
            }

            zycie.maksymalne += 20;
            mana.maksymalne += 5;
            obrazenia += 8;
            inteligencja += 1;
            zrecznosc += 1;
            return poziom;
        }
    }
}
