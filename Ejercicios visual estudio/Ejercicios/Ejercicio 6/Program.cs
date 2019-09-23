using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº6";
            int desde, hasta;
            string aux;
            Console.Write("Inidique desde que año: ");
            aux = Console.ReadLine();
            while (!int.TryParse(aux, out desde))
            {
                Console.Write("Ingrese un número válido: ");
                aux = Console.ReadLine();
            }
            Console.Write("Inidique hasta que año: ");
            aux = Console.ReadLine();
            while (!int.TryParse(aux, out hasta))
            {
                Console.Write("Ingrese un número válido: ");
                aux = Console.ReadLine();
            }
            for (int i = desde; i <= hasta; i++)
            {
                if ((i % 4 == 0 || i%400 == 0) && i%100 != 0)
                {
                    Console.WriteLine("{0} Es un año bisiesto.", i);
                }
            }



            Console.ReadKey();
        }
    }
}
