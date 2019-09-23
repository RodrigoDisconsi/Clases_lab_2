using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        int cantidadSumas;
        
        public Sumador()
        {
            cantidadSumas = 0;
        }
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            long aux;
            aux = a + b;
            return aux;
        }
        
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            string aux = "";
            aux = a + b;
            return aux;
        }

        public int GetCantidadSumas()
        {
            return this.cantidadSumas;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long aux;
            aux = s1.cantidadSumas + s2.cantidadSumas;
            return aux;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
