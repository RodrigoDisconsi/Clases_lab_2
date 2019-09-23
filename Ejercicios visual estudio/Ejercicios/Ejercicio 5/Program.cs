using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº5";

            Console.Write("Ingrese un número: ");
            string aux = Console.ReadLine();
            int numero;

            if (int.TryParse(aux, out numero))
            {
                for (int centro = 1; centro <= numero; centro++)
                {
                    int suma = 0;
                    int acum = centro + 1;
                    for (int i = 1; i < centro; i++)
                    {
                        suma += i;
                    }
                    do
                    {
                        suma -= acum;
                        acum++;
                    } while (suma > 0);
                    if (suma == 0)
                        Console.WriteLine("{0} Es un centro númerico", centro);
                    //else
                       // Console.WriteLine("{0} No es un centro númerico", centro);
                }
            }
            else
                Console.Write("No es un número");

            Console.ReadKey();
        }
    }
}

