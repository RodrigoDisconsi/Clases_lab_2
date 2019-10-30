using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiClaseExcepcion;
using IO;
using System.IO;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase excepcion = new MiClase("hola");
            //try
            //{
            //    excepcion.MiMetodo();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.InnerException.Message);
            //    Console.WriteLine(e.InnerException.InnerException.Message);
            //}
            try
            {
                Console.WriteLine(ArchivoTexto.Leer("D:\\asdasdasd.txt"));
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("EL archivo no existe");
            }
            Console.ReadKey();
        }
    }
}
