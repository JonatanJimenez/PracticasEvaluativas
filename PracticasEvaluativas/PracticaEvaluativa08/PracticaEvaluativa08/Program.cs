using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvaluativa08
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int numeroDigitos = 0;
            do
            {
                try
                {
                    Console.Write("Ingrese un entero de 5 digitos: ");
                    numero = int.Parse(Console.ReadLine());
                    numeroDigitos = numero.ToString().Length;
                    if (numeroDigitos != 5)
                    {
                        throw new Exception("No son 5 digitos");
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (numero.ToString().Length != 5);

            if (numero.ToString()[0] == numero.ToString()[4] && numero.ToString()[1] == numero.ToString()[3])
            {
                Console.WriteLine("El numero es palindromo");
            }
            else
            {
                Console.WriteLine("El numero no es palindromo");
            }

            Console.ReadKey();
        }
    }
}
