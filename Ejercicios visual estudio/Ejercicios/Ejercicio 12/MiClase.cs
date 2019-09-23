using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public static class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
            {
                bool aux = false;
                if (char.ToUpper(c) == 'S')
                    aux = true;
                return aux;
            }
    }
}
