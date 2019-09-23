using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public static class Calculadora
    {
        static bool Validar (double numero)
        {
            bool aux = false;
            if (numero != 0)
                aux = true;
            return aux;
        }
        public static double Calcular (double x, double y, char operacion)
        {
            double resultado = 0;
            if (operacion == '/')
            {
                if (Validar(y))
                {
                    resultado = x / y;
                }
            }
            else if (operacion == '*')
            {
                resultado = x * y;
            }
            else if (operacion == '+')
            {
                resultado = x + y;
            }
            else if (operacion == '-')
            {
                resultado = x - y;
            }
                return resultado;
        }
        public static bool ValidarS_N(char c)
        {
            bool aux = false;
            if (char.ToUpper(c) == 'S')
                aux = true;
            return aux;
        }
    }
}
