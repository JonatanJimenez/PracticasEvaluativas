using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvaluativa02
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Cuantos numeros quiere ingresar: ");
            int tamañoArreglo = int.Parse(Console.ReadLine());
            int[] Arreglo = new int[tamañoArreglo];
            for (int i = 0; i < tamañoArreglo; i++)
            {
                Console.Write("Ingrese un numero: ");
                Arreglo[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Los numeros invertidos quedan asi: ");
            Array.Reverse(Arreglo);           
            for (int j = 0; j < tamañoArreglo; j++)
            {
                Console.Write("{0}\n",Arreglo[j]);
            }
            Console.ReadKey();
        }
    }
}
