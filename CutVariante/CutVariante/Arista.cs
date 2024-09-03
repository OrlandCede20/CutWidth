using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutVariante
{
    public class Arista
    {
        public int Nodo1 { get; set; }
        public int Nodo2 { get; set; }

        public Arista(int nodo1, int nodo2)
        {
            Nodo1 = nodo1;
            Nodo2 = nodo2;
        }
        public override string ToString()
        {
            return Nodo1 + " - " + Nodo2;
        }
    }

}
