using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contabilidad;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            ContabilidadGen<Factura, Recibo> list = new ContabilidadGen<Factura, Recibo>();
            Factura f = new Factura(3);
            Factura f2 = new Factura(1);
            Recibo r = new Recibo(2);
            Recibo r2 = new Recibo(1);
            list += f;
            list += f2;
            list += r;
            list += r2;
            Console.WriteLine(list.Mostar());
            Console.ReadKey();
        }
    }
}
