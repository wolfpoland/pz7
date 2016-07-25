using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    class Program
    {
        static void Main(string[] args)
        {
            Czarownik cz = new Czarownik {imie="Gandalf",doswiadczenie=15, inteligencja=5,mana=new Mana(20,20),obrazenia=10,odpornosci=Odpornosci.Ogien,Pancerz=5,sila=5,poziom=5,zrecznosc=2,zycie=new Zycie {aktualne=35, maksymalne=35 } };
            Console.WriteLine(cz.ToString());
            cz.obrazeniaOdniesione(10,Odpornosci.Fizyczne);
            Console.WriteLine("Wojownik: ");
            Wojownik woj = new Wojownik { imie = "Kratos", doswiadczenie = 12, iloscAtakow = 5, inteligencja = 2, mana = new Mana(20, 20), obrazenia = 20, odpornosci = Odpornosci.Fizyczne, Pancerz = 20, poziom = 10, sila = 12, zrecznosc = 3, zycie = new Zycie { aktualne = 50, maksymalne = 50 } };
            Console.WriteLine(woj.ToString());
            woj.obrazeniaOdniesione(50, Odpornosci.Fizyczne);
            Console.WriteLine("Teraz Luczniko");
            Lucznik legolas = new Lucznik("Legolas", 20, 100, 4, 25, 5, new Zycie { aktualne = 60, maksymalne = 60 }, new Mana(20, 20), 40, Odpornosci.Woda, 20, 30);
            Console.WriteLine(legolas.ToString());
            legolas.obrazeniaOdniesione(30, Odpornosci.Ogien);
            Console.WriteLine("Zaczynamy przygode");
            List<Postav> druzyna = new List<Postav>
            {
                new Wojownik("Aragorn"),
                new Lucznik("Legolas"),
                new Czarownik("Gandalf")
            };
            Smok smok = new Smok { imie="Wawelski", doswiadczenie=99, inteligencja=90, mana=new Mana(500,500),obrazenia=100, odpornosci=Odpornosci.Ogien, Pancerz=500, poziom=99, sila=99, zrecznosc=50, zycie=new Zycie { aktualne=500, maksymalne=500} };
            Console.WriteLine("Smok, atakuje aragorna");
            var w= druzyna.Select(k=>k).Where(k => k.imie.Equals("Aragorn")).ToArray();
            Wojownik w1 =(Wojownik) druzyna.Single(k => k.imie.Equals("Aragorn"));
            Console.WriteLine("w1: "+w1.ToString());
            Wojownik wo =new Wojownik((Wojownik)w[0]);
            
            wo.obrazeniaOdniesione(100, Odpornosci.Fizyczne);
            Console.WriteLine(wo.ToString());
            Console.WriteLine("Aragorn uzywa potiona");
            wo.ReJunevation();
            Console.WriteLine("Aragorn po uzyciu: ");
            Console.WriteLine(wo.ToString());
            Console.ReadKey();
        }
    }
}
