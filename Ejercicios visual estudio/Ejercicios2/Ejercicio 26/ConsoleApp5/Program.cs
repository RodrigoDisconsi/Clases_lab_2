using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        public static int Ordenar(int numero1, int numero2)
        {
            int retorno = 0;
            if(numero1 > 0 && numero2 > 0)
            {
                return -numero1.CompareTo(numero2);
            }
            else
            {
                return numero1.CompareTo(numero2);
            }

            return retorno;
        }

        static void Main(string[] args)
        {
            Random numero = new Random();
            int[] numeros = new int[20];
            int aux;

            for (int i = 0; i < numeros.Length; i++)
            {
                aux = numero.Next(-1000, 1000);
                if (aux  == 0)
                {
                    i--;
                    break;
                }
                numeros[i] = aux;
            }

           // Array.Sort(numeros, Ordenar);

            Console.WriteLine("A)\n");
            foreach (int x in numeros)
            {
                Console.WriteLine(x);
            }

            //Comparison<int> comparador = new Comparison<int>((numero1, numero2) => numero2.CompareTo(numero2));
            Array.Sort(numeros, Ordenar);
            Console.WriteLine("\n\nNumeros positivos ordenados de forma decreciente:\n");
            //Array.Reverse(numeros);

            foreach (int x in numeros)
            {
                if(x > 0)
                    Console.WriteLine(x);
            }

            Console.WriteLine("\n\nNumeros negativos ordenados de forma creciente:\n");

            foreach (int x in numeros)
            {
                if (x < 0)
                    Console.WriteLine(x);
            }



            Console.ReadKey();

        }
    }
}
