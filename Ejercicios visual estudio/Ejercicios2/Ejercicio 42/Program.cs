using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiClaseExcepcion;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase excepcion = new MiClase("hola");
            try
            {
                excepcion.MiMetodo();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.InnerException.Message);
            }
            Console.ReadKey();
        }
    }
}
