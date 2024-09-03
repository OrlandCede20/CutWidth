
using CutVariante;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Ingresar la ruta del archivo manualmente
        string ruta = ("C:/Users/ORLAND/Desktop/cutwi.txt");

        CrearGrafo grafo = Archivo.LeerGrafoDesdeArchivo(ruta);

        Console.WriteLine("Ingrese la cantidad de iteraciones:");
        int iteraciones = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de poblaciones aleatorias por iteración:");
        int tamanoPoblacion = int.Parse(Console.ReadLine());

        CalculoCutWidth calculo = new CalculoCutWidth(grafo);

        int minimoGlobalAnchoDeCorte = int.MaxValue;

        // Realizar las iteraciones
        for (int i = 0; i < iteraciones; i++)
        {
            Console.WriteLine($"\n--- Iteración {i + 1} ---");

            List<List<int>> poblacion = calculo.GenerarPermutacionesAleatorias(tamanoPoblacion);
            int maximoLocalAnchoDeCorte = 0;
            Console.WriteLine("Poblaciones:");

            foreach (var permutacion in poblacion)
            {
                // Mostrar la permutación actual
                Console.WriteLine(" " + string.Join(", ", permutacion));
                int anchoDeCorte = calculo.CalcularAnchoDeCorte(permutacion);
                // Mostrar el ancho de corte
                Console.WriteLine($"Valor Corte: {anchoDeCorte}");

                if (anchoDeCorte > maximoLocalAnchoDeCorte)
                {
                    maximoLocalAnchoDeCorte = anchoDeCorte;
                }
            }
            Console.WriteLine($"Máximo de la Iteración {i + 1}: {maximoLocalAnchoDeCorte}");
            minimoGlobalAnchoDeCorte = Math.Min(minimoGlobalAnchoDeCorte, maximoLocalAnchoDeCorte);
        }

        // Mostrar el resultado final
        Console.WriteLine($"\nEl ancho de corte mínimo global es: {minimoGlobalAnchoDeCorte}");
    }
}