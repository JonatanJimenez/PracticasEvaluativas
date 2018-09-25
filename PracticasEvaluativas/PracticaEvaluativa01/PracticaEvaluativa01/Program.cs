using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvaluativa01
{
    class Program
    {
        static void Main(string[] args)
        {                      
            Console.Write("Ingrese cuantos numeros desea ingresar: ");
            int tamañoArreglo = int.Parse(Console.ReadLine());
            int[] Arreglo = new int[tamañoArreglo];
            for(int i = 0; i < tamañoArreglo; i++)
            {
                Console.Write("Ingrese un numero: ");
                Arreglo[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("El valor maximo es: {0}\nEl valor minimo es: {1}", Arreglo.Max(),Arreglo.Min());
            Console.ReadKey();

        }
    }
}
