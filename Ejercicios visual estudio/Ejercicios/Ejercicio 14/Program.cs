using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            double areaCuadrado, areaTriangulo, areaCirculo;
            double x, y;
            Console.Write("Ingrese el lado del cuadrado: ");
            aux = Console.ReadLine();
            while(!double.TryParse(aux, out x))
            {
                Console.Write("Error. Reingrese el lado del cuadrado: ");
                aux = Console.ReadLine();
            }
            areaCuadrado = CalculoDeArea.CalcularCuadrado(x);
            Console.Write("Ingrese el base del triangulo: ");
            aux = Console.ReadLine();
            while (!double.TryParse(aux, out x))
            {
                Console.Write("Error. Reingrese la base del triangulo: ");
                aux = Console.ReadLine();
            }
            Console.Write("Ingrese el altura del triangulo: ");
            aux = Console.ReadLine();
            while (!double.TryParse(aux, out y))
            {
                Console.Write("Error. Reingrese la altura del triangulo: ");
                aux = Console.ReadLine();
            }
            areaTriangulo = CalculoDeArea.CalcularTriangulo(x, y);
            Console.Write("Ingrese el radio del circulo: ");
            aux = Console.ReadLine();
            while (!double.TryParse(aux, out x))
            {
                Console.Write("Error. Reingrese el radio del circulo: ");
                aux = Console.ReadLine();
            }
            areaCirculo = CalculoDeArea.CalcularCirculo(x);
            Console.WriteLine("Area del cuadrado: {0: #.00}", areaCuadrado);
            Console.WriteLine("Area del triangulo: {0: #.00}", areaTriangulo);
            Console.WriteLine("Area del circulo: {0: #.00}", areaCirculo);
            Console.ReadKey();
        }
    }
}
