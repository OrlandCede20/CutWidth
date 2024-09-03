using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutVariante
{
    public class Archivo
    {
        public static CrearGrafo LeerGrafoDesdeArchivo(string ruta)
        {
            CrearGrafo grafo = new CrearGrafo();
            using (StreamReader lector = new StreamReader(ruta))
            {
                string primeraLinea = lector.ReadLine();
                string[] partesPrimeraLinea = primeraLinea.Split(' ');
                grafo.Nodos = int.Parse(partesPrimeraLinea[0]);

                string linea;
                while ((linea = lector.ReadLine()) != null)
                {
                    string[] partesLinea = linea.Split(' ');
                    int nodo1 = int.Parse(partesLinea[0]);
                    int nodo2 = int.Parse(partesLinea[1]);
                    grafo.AgregarArista(nodo1, nodo2);
                }
            }
            return grafo;
        }
    }
}
