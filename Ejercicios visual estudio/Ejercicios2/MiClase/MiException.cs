using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClaseExcepcion
{
    public class MiException : Exception
    {
        public MiException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
