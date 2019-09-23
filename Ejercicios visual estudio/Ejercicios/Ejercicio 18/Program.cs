using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometría;

namespace PruebaGeometria
{
    //ctrl k + d ordena, +u descomenta, +c comenta
    class Program
    {
        static void Main(string[] args)
        {
            void MostrarRectangulo(Rectangulo rectangulo)
            {
                Console.WriteLine("El área del rectangulo es: {0}", rectangulo.GetArea());
                Console.WriteLine("El perímetro del rectangulo es: {0}", rectangulo.GetPerimetro());
            }

            Punto puntoA = new Punto(-2, -2);
            Punto puntoB = new Punto(-9, 2);
            Rectangulo nuevoRectangulo = new Rectangulo(puntoA, puntoB);

            MostrarRectangulo(nuevoRectangulo);

            Console.ReadKey();
           
        }
    }
}
