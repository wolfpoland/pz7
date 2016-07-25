using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    class Lucznik :Postav
    {
        public Lucznik()
        {

        }
        public int unik { get; set; }
        public Lucznik(string imie, int poziom, int doswiadczenie, int sila, int zrecznosc, int inteligencja, Zycie zycie, Mana mana, int obrazenia, Odpornosci odpornosci,int Pancerz, int unik) :base(imie,poziom,doswiadczenie,sila,zrecznosc,inteligencja,zycie,mana,obrazenia,odpornosci,Pancerz)
        {
            this.unik = unik;
        }
        public Lucznik(string imie) :base(imie)
        {
            base.doswiadczenie = 0;
            base.inteligencja = 5;
            base.obrazenia = 3;
            base.odpornosci=Odpornosci.Woda;
            base.poziom = 0;
            base.sila = 2;
            base.zrecznosc = 6;
            base.zycie.maksymalne = 15;
            base.zycie.aktualne = 15;
            base.mana.maksymalne = 5;
            base.mana.aktualne = 5;

        }
        public delegate void Unik(Lucznik l);
        public event Unik dodage;
        public override void obrazeniaOdniesione(int obrazenia, Odpornosci odp)
        {
            Random r = new Random();
            int prawdo = r.Next(0, 101);
            Console.WriteLine("Prawdopodobienstwo: {0}",prawdo);
            if (prawdo <= this.unik)
            {
                Console.WriteLine("Zaszedl unik ");
               // dodage(this);

            }
            else
            {
                zycie.aktualne -= obrazenia;
            } 

        }
        public override string ToString()
        {
            string tmp=base.ToString();
            return string.Format("{0} \n Unik: {1} ",tmp, unik);
        }
        public override int levelUp()
        {
            poziom = base.levelUp();
            if (poziom < 20)
            {
                zrecznosc += 7;
            }
            else
            {
                zrecznosc += poziom / 2;
            }
           
            zycie.maksymalne += 10;
            mana.maksymalne += 5;
            obrazenia += 8;
            inteligencja += 1;
            sila += 1;
            return poziom;
        }
    }
}
