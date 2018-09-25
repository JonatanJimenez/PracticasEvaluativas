using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvaluativa05
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Cuantos numeros desea ingresar: ");
            int tamañoArreglo = int.Parse(Console.ReadLine());
            int[] Arreglo = new int[tamañoArreglo];
            for (int i = 0; i < tamañoArreglo; i++)
            {
                Console.Write("Ingrese un numero: ");
                Arreglo[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El índice de la primera ocurrencia del elemento más grande es: {0}", Arreglo.ToList().IndexOf(Arreglo.Max()) + 1);
            Console.ReadKey();
        }
    }
}
