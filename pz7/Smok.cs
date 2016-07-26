using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    public  partial class Smok : Postav
    {
        //  public delegate void Atak(Klaska k);
        public Smok()
        {
            atakuj += new EventHandler<Klaska>(Zioniecie);
        }

        

        public event EventHandler<Klaska> atakuj;
        partial  void Zioniecie(object sender, Klaska e);
        public void Zonij()
        {
            atakuj(this, new Klaska { intensywnosc = 50 });
 //           atakuj.Invoke(this, new Klaska { intensywnosc = 100 });
            //Zioniecie(this,new Klaska { intensywnosc=200});
        }

    }
     public  partial class Smok: Postav
    {
       partial  void Zioniecie(object sender, Klaska e)
        {
            this.mana.aktualne -= 100;
            Console.WriteLine("Intensywne zioniecie smoka");
        }
      
    }
}
