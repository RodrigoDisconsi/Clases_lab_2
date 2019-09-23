using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {

            Sumador s1 = new Sumador(10);
            Sumador s2 = new Sumador(10);
            int x;
            Console.WriteLine(s1 + s2);
            if(s1 | s2)
            {
                Console.WriteLine(s1.Sumar("Son", " iguales"));
            }
            Console.WriteLine(s1.Sumar(100, 200));
            x = (int)s1;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
