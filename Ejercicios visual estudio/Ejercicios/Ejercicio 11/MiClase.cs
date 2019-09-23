using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public static class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool aux = false;
            if (valor >= min && valor <= max)
            {
                aux = true;
            }
            return aux;
        }
    }
}
