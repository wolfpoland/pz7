using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    public abstract class Postav : IComparable
    {
        public Postav()
        {
           
        }
        public Postav(string imie)
        {
            this.imie = imie;
           
        }
        public Postav(string imie, int poziom, int doswiadczenie, int sila, int zrecznosc,int inteligencja, Zycie zycie,Mana mana, int obrazenia, Odpornosci odpornosci,int Pancerz)
        {
            this.imie = imie;
            this.poziom = poziom;
            this.doswiadczenie = doswiadczenie;
            this.sila = sila;
            this.zrecznosc = zrecznosc;
            this.inteligencja = inteligencja;
            this.zycie = zycie;
            this.mana = mana;
            this.obrazenia = obrazenia;
            this.odpornosci = odpornosci;
            this.Pancerz = Pancerz;

        }
        public delegate void smierc(Postav p);
        public event smierc Smierc;
        public string imie { get; set; }
        public int poziom { get; set; }
        public int doswiadczenie { get; set; }
        public int sila { get; set; }
        public int zrecznosc { get; set; }
        public int inteligencja { get; set; }
        public Zycie zycie
        {
            get
            {
                return zycie;
            }
            set
            {
                if (value.aktualne <= 0)
                {

                    zycie = value;
                    Smierc(this);
                }
            }
        }
        public Mana mana { get; set; }
        public int obrazenia { get; set; }
        public int Pancerz { get; set; }
        public Odpornosci odpornosci { get; set; }

        public override string ToString()
        {
            string odpo = "";
        /*    foreach (Odpornosci item in odpornosci)
            {
                odpo += "- "+item.ToString() + "\n";
            }*/
            return string.Format("Imie: {0} \n Nazwisko: {1} \n Poziom: {2} \n Dosiwadczenie: {3} \n Sila: {4} \n Zreczonosc: {5} \n Inteligencia: {6}" +
               " \n Zycie Aktualne: {7} \n Zycie Maksymalne: {8} \n Mana Akutalna: {9} \n Mana Maksymalna: {10} \n Obrazenia: {11} \n  Odpornosci: {12} \n Pancerz: {13} ",imie,"nulo",poziom.ToString(),doswiadczenie,sila,zrecznosc,inteligencja,zycie.aktualne,zycie.maksymalne,mana.aktualne,mana.maksymalne,obrazenia,odpornosci,Pancerz);

        }
        public void Uzbrojenie(int oIle)
        {
            obrazenia += oIle;
        }
        public void Pancerzowanie(int oIle)
        {
            Pancerz += oIle;
        }
        public  virtual void obrazeniaOdniesione(int obrazenia,Odpornosci odp)
        { 
          
            if(odp == Odpornosci.Fizyczne)
            {
                obrazenia -= this.Pancerz;
                Console.WriteLine("Obrazenia typu fizycznego obnizam je o wartosc pancerza \n Pancerz: {0}", Pancerz);
                //zycie.aktualne -= obrazenia;

            }
            Console.WriteLine("Zycie przed obrazeniami: " + this.zycie.aktualne);
            Console.WriteLine("Obrazenia: " + obrazenia);
            zycie.aktualne -= obrazenia;
            Console.WriteLine("Po zadanaiu obrazen Zycie: {0}", zycie.aktualne);
            
        }
        public virtual int levelUp()
        {
            poziom++;
            return poziom;
        }

        public int CompareTo(object obj)
        {
            Postav postac = (Postav)obj;
            if(this.poziom > postac.poziom)
            {
                return 1;
            }
            if(this.poziom < postac.poziom)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
