using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            char operacion;
            double numeroX, numeroY, resultado;
            string aux;
            do
            {
                   Console.Write("Ingrese el primer numero: ");
                   aux = Console.ReadLine();
                   while(!double.TryParse(aux, out numeroX))
                   {
                       Console.Write("Error. Reingrese el primer numero: ");
                       aux = Console.ReadLine();
                   }
                                   Console.Write("Ingrese el operando: ");
                   aux = Console.ReadLine();
                   while (!char.TryParse(aux, out operacion))
                   {
                   Console.Write("Error. Reingrese el operando: ");
                       aux = Console.ReadLine();
                   }
                   Console.Write("Ingrese el segundo numero: ");
                   aux = Console.ReadLine();
                   while (!double.TryParse(aux, out numeroY))
                   {
                       Console.Write("Error. Reingrese el segundo numero: ");
                       aux = Console.ReadLine();
                   }
                   resultado = Calculadora.Calcular(numeroX, numeroY, operacion);
                   Console.WriteLine("El resultado es: {0}", resultado);
                   Console.Write("Desea continuar? (S/N): ");
                   aux = Console.ReadLine();
                   char.TryParse(aux, out continuar);
               } while (Calculadora.ValidarS_N(continuar));
            }
    }
}
