using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvaluativa06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas palabras desea ingresar: ");
            int tamañoArreglo = int.Parse(Console.ReadLine());
            string[] Arreglo = new string[tamañoArreglo];
            bool comparacion = false;
            for (int i = 0; i < tamañoArreglo; i++)
            {
                Console.Write("Ingrese una palabra: ");
                Arreglo[i] = Console.ReadLine();
            }

            for (int i = 0; i < tamañoArreglo; i++)
            {
                if (i >= 1)
                {
                    if (Arreglo[i].Length > Arreglo[i - 1].Length)
                    {
                        Console.WriteLine("El índice del primer elemento que es mayor que su predecesor : {0}", i + 1);
                        i = Arreglo.Length;
                        comparacion = true;

                    }
                    if ((i == Arreglo.Length - 1 ) && (comparacion == false))
                    {
                        Console.WriteLine("El orden no es decreciente, el indice el 0");
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
