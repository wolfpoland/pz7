using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    class Druzyna
    {
        public Druzyna()
        {
            lista = new List<Postav>();
        }
        public Druzyna(List<Postav> lista)
        {
            this.lista = lista;
        }
        public void dodajCalaDruzyne(List<Postav> druzyna)
        {
            lista = druzyna;
        }
        public List<Postav> lista { get; set; }

        public List<Postav> getDruzyna()
        {
            return lista;
        }
    }
}
