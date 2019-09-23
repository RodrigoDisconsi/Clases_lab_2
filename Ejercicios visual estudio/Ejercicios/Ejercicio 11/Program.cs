using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        const int cant = 10;
        static void Main(string[] args)
        {
            int i = 0;
            int numero;
            int max = int.MinValue;
            int min = int.MaxValue;
            float promedio = 0;
            string aux;
            while (i < cant)
            {
                Console.Write("Ingrese un número entre -100 y 100: ");
                aux = Console.ReadLine();
                if (int.TryParse(aux, out numero))
                {
                    if (Validacion.Validar(numero, -100, 100))
                    {
                        if (numero > max)
                        {
                            max = numero;
                        }
                        if (numero < min)
                        {
                            min = numero;
                        }
                        promedio += numero;
                    }
                    else
                    {
                        Console.Write("Error. Número inválido!\n");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido!");
                    i--;
                }
                i++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Máximo: {0}", max);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mínimo: {0}", min);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Promedio: {0:#,###.##}", promedio / cant);
            Console.ReadKey();
        }
    }
}
