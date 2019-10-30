using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_52Entidades;

namespace Ejercicio_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(5, ConsoleColor.Green);
            Cartuchera1 cartuchera = new Cartuchera1();
            bool aux;
            cartuchera += miLapiz;
            cartuchera += miBoligrafo;
            aux = cartuchera.ProbarElementos();
            Console.WriteLine(aux);
            while(aux == true)
            {
                aux = cartuchera.ProbarElementos();
                Console.WriteLine(aux);
            }
            Console.ReadKey();
        }
    }
}
