using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado (double lado)
        {
            double resultado;
            resultado = lado * lado;
            return resultado;
        }
        public static double CalcularTriangulo(double x, double y)
        {
            double resultado;
            resultado = (x * y) / 2; 
            return resultado;
        }
        public static double CalcularCirculo(double radio)
        {
            double resultado;
            resultado = Math.PI * (Math.Pow(radio, 2));
            return resultado;
        }

    }
}
