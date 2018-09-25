using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvaluativa07
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] Arreglo = new int[100];
            for (int i = 0; i < 100; i++)
            {
                Arreglo[i] = random.Next(1, 101);
            }
            Console.WriteLine("Valores del 1 al 100 sin ordenar: ");
            for (int j = 0; j < 100; j++)
            {
                Console.Write(Arreglo[j] + " ");
            }
            Console.WriteLine("\nValores del 1 al 100 ordenados: ");
            Array.Sort(Arreglo);
            for (int k = 0; k < 100; k++)
            {
                Console.Write(Arreglo[k] + " ");
            }
            Console.ReadKey();
        }
    }
}
