using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        public static int Ordenar(int numero1, int numero2)
        {
            if (numero1 > 0 && numero2 > 0)
            {
                return -numero1.CompareTo(numero2);
            }
            else
            {
                return numero1.CompareTo(numero2);
            }            
        }
        static void Main(string[] args)
        {
            #region Lista
            List<int> numeros = new List<int>();
            Random numero = new Random();
            int aux;

            for (int i = 0; i < 20; i++)
            {
                aux = numero.Next(-1000, 1000);
                if (aux == 0)
                {
                    i--;
                    break;
                }
                numeros.Add(aux);
            }

            Console.WriteLine("A:\n");

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("\nB:\n");
            numeros.Sort(Ordenar);

            foreach (int x in numeros)
            {
                if (x > 0)
                    Console.WriteLine(x);
            }

            Console.WriteLine("\n\nC:\n");

            foreach (int x in numeros)
            {
                if (x < 0)
                    Console.WriteLine(x);
            }
            #endregion

            #region Cola

            Queue<int> numerosCola = new Queue<int>();

            for (int i = 0; i < 20; i++)
            {
                aux = numero.Next(-1000, 1000);
                if (aux == 0)
                {
                    i--;
                    break;
                }
                numerosCola.Enqueue(aux);
            }

            Console.WriteLine("\n\nQUEUE:\n");

            //while (numerosCola.Count > 0)
            //{
            //    Console.WriteLine(numerosCola.Dequeue());
            //}
            foreach(int x in numerosCola)
            {
                Console.WriteLine(x);
            }

            
            #endregion

            #region Pila


            Stack<int> numerosPila = new Stack<int>();
            Console.WriteLine("\n\nSTACK:\n");
            for (int i = 0; i<20; i++)
            {
                aux = numero.Next(-1000, 1000);
                if (aux == 0)
                {
                    i--;
                    break;
                }
                numerosPila.Push(aux);
            }

            while(numerosPila.Count > 0)
            {
                Console.WriteLine(numerosPila.Pop());
            }

            #endregion

            Console.ReadKey();
        }
    }
}
