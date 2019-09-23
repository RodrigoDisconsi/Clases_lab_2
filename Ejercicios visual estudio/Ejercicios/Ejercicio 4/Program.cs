using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, contador = 0, suma;
            for (int j = 1; j <= int.MaxValue; j++)
            {
                suma = 0;
                for (i = 1; i < j; i++)
                {
                    if ((j % i) == 0)
                    {
                        suma += i;
                    }
                }
                if (suma == j)
                {
                    Console.WriteLine("{0} es un numero primo", suma);
                    contador++;
                }
                if (contador == 4)
                {
                    break;
                }
            }
            Console.ReadKey();
        }


    }
}
