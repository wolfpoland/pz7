using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    public interface IMagiczny<T> where T: Czarownik
    {
       void RzucCzar(Czary cz, [Optional] Postav atak);

         int Manaakt { get; set; }
         int Manamax { get; set; }
    }
}
