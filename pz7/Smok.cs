using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    public  partial class Smok : Postav
    {
       partial  void Zioniecie();
        public void Zonij()
        {
            Zioniecie();
        }
    }
     public  partial class Smok: Postav
    {
       partial  void Zioniecie()
        {
            this.mana.aktualne -= 100;
            Console.WriteLine("Intensywne zioniecie smoka");
        }
      
    }
}
