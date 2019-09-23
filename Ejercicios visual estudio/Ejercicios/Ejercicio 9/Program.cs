using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int altura;
            Console.Write("Ingrese el tamaño de la piramide: ");
            aux = Console.ReadLine();
            while(!int.TryParse(aux, out altura))
            {
                Console.Write("Error. Reingrese el tamaño de la piramide: ");
                aux = Console.ReadLine();
            }
            altura = altura * 2; 
            for(int i = altura; i >= 0; i--)
            {
                if((altura-i ) % 2 != 0)
                {
                    for(int j = 0; j<altura-i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();

        }
    }
}
