using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutVariante
{
    public class CalculoCutWidth
    {
        private CrearGrafo _grafo;

        public CalculoCutWidth(CrearGrafo grafo)
        {
            _grafo = grafo;
        }
        public int CalcularAnchoDeCorte(List<int> permutacion)
        {
            int maximoCorte = 0;

            for (int i = 1; i < permutacion.Count; i++)
            {
                int cortes = 0;

                for (int j = 0; j < i; j++)
                {
                    for (int k = i; k < permutacion.Count; k++)
                    {
                        foreach (var arista in _grafo.Aristas)
                        {
                            if ((arista.Nodo1 == permutacion[j] && arista.Nodo2 == permutacion[k]) ||
                                (arista.Nodo1 == permutacion[k] && arista.Nodo2 == permutacion[j]))
                            {
                                cortes++;
                            }
                        }
                    }
                }
                if (cortes > maximoCorte)
                    maximoCorte = cortes;
            }
            return maximoCorte;
        }

        public List<List<int>> GenerarPermutacionesAleatorias(int tamanoPoblacion)
        {
            List<List<int>> poblacion = new List<List<int>>();

            int[] elementos = new int[_grafo.Nodos];
            for (int i = 0; i < _grafo.Nodos; i++)
            {
                elementos[i] = i + 1;
            }
            Random aleatorio = new Random();
            for (int i = 0; i < tamanoPoblacion; i++)
            {
                List<int> permutacion = elementos.OrderBy(x => aleatorio.Next()).ToList();
                poblacion.Add(permutacion);
            }
            return poblacion;
        }
    }
}
