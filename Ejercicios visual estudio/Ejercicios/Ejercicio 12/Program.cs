using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, suma = 0;
            string aux;
            char respuesta = 's';
            do
            {
                Console.Write("Ingrese un número: ");
                aux = Console.ReadLine();
                if(int.TryParse(aux, out numero))
                {
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("Error ingrese solo números.");
                    continue;
                }
                Console.Write("¿Continuar? (S/N): ");
                aux = Console.ReadLine();
                char.TryParse(aux, out respuesta);
            } while (ValidarRespuesta.ValidarS_N(respuesta));
            Console.WriteLine("La suma total es: {0}", suma);
            Console.ReadKey();
        }
    }
}
