using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº 3";
            int numero;
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                int j = 0;
                for (int i = 2; i <= numero; i++)
                {
                    for (j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            break;
                        }
                    }
                    if (i == j)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
