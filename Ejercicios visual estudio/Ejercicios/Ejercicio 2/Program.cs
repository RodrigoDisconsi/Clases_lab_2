using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº2";
            int numero;
            Console.Write("Ingrese un número positivo: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                do
                {
                    Console.Write("Error ingrese un numero positivo: ");
                    while (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.Write("Error ingrese solo numeros: ");
                    }
                } while (numero <= 0);
                Console.Write("El cuadrado del numero es {0} y el cubo es {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
            }
            else
            {
                Console.Write("Error");
            }
            Console.ReadKey();

        }
    }
}
