using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº7";
            DateTime fechaActual = DateTime.Now;
            int diaAcutal, mesActual, añoActual, dia, mes, año, contador = 0;
            string aux;
            diaAcutal = fechaActual.Day;
            mesActual = fechaActual.Month;
            añoActual = fechaActual.Year;
            Console.Write("Ingrese día: ");
            aux = Console.ReadLine();
            while (!int.TryParse(aux, out dia) || dia <= 0 && dia > 31)
            {
                Console.Write("Ingrese un día válido");
                aux = Console.ReadLine();
            }
            Console.Write("Ingrese mes: ");
            aux = Console.ReadLine();
            while (!int.TryParse(aux, out mes) || mes <= 0 && mes > 12)
            {
                Console.Write("Ingrese un mes válido");
                aux = Console.ReadLine();
            }
            Console.Write("Ingrese año: ");
            aux = Console.ReadLine();
            while (!int.TryParse(aux, out año) || año <= 0 && año > 2019)
            {
                Console.Write("Ingrese un año válido");
                aux = Console.ReadLine();
            }
            for (int añoAux = año; añoAux <= añoActual; añoAux++)
            {
                if (añoAux == añoActual)
                {
                    for (int mesAux = 1; mesAux <= mesActual; mesAux++)
                    {
                        for (int diaAux = 1; diaAux <= diaAcutal; diaAux++)
                        {
                            contador++;
                            if (mesAux == 2 && diaAux == 28)
                            {
                                break;
                            }
                            else if ((mesAux == 4 || mesAux == 6 || mesAux == 9 || mesAux == 11) && diaAux == 30)
                            {
                                break;
                            }
                        }
                    }
                }
                else if (añoAux < añoActual)
                {
                    if ((añoAux % 4 == 0 || añoAux % 400 == 0) && añoAux % 100 != 0)
                    {
                        contador += 365;
                    }
                    else
                    {
                        contador += 364;
                    }
                }
            }
            Console.WriteLine("La cantidad de días que vivió fueron {0}", contador);
            Console.ReadKey();
        }
    }
}
