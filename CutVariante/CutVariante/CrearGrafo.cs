using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutVariante
{
    public class CrearGrafo
    {
        public int Nodos { get; set; }
        public List<Arista> Aristas { get; set; }

        public CrearGrafo()
        {
            Aristas = new List<Arista>();
        }
        public void AgregarArista(int nodo1, int nodo2)
        {
            Aristas.Add(new Arista(nodo1, nodo2));
        }
    }

}
