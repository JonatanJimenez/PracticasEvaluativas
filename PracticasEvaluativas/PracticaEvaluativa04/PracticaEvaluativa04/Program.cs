using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvaluativa04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[3];
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el valor {0}: ", i + 1);
                Arreglo[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("El valor minimo es: {0}", Arreglo.Min());
            Console.ReadKey();

            
        }
    }
}
