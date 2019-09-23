using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_13
{
    public static class Conversor
    {
        public static string DecimalBinario(double entero)
        {
            string aux = string.Empty;
            do
            {           
                if (entero % 2 == 0)
                {
                    aux = "0" + aux;
                }
                else
                {
                    aux = "1" + aux;
                }
                entero = entero / 2;
            } while (entero > 1);
            return aux;
        }

        public static double BinarioDecimal (string binario)
        {
            double entero = 0;
            char aux;
            int len = binario.Length;
            int elevado = len-1;
            for(int i = 0; i < len; i++)
            {
                aux = binario[i];
                if(aux == '1')
                {
                    entero += Math.Pow(2, elevado);
                }
                elevado--;
            }

            return entero;
        }
    }
}
