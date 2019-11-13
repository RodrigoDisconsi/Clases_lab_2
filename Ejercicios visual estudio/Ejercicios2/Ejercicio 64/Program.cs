using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);
            Thread hiloCaja1 = new Thread(caja1.AtenderClientes);
            Thread hiloCaja2 = new Thread(caja2.AtenderClientes);
            //Thread hiloNegocio = new Thread(negocio.AsignarCaja);
            hiloCaja1.Name = "Caja 1";
            hiloCaja2.Name = "Caja 2";
            //List<Thread> hilos = new List<Thread>();
            //hilos.Add(new Thread(negocio.AsignarCaja));
            //hilos.Add(new Thread(caja1.AtenderClientes));
            //hilos[1].Name = "Caja 1";
            //hilos.Add(new Thread(caja2.AtenderClientes));
            //hilos[2].Name = "Caja 2";

            string[] array = new string[10];

            array[0] = "Bruno";
            array[1] = "Ruben";
            array[2] = "Marian";
            array[3] = "Rodrigo";
            array[4] = "Juan";
            array[5] = "Pepe";
            array[6] = "Maria";
            array[7] = "Marina";
            array[8] = "Juan";
            array[9] = "Federico";
            foreach (string item in array)
            {
                negocio.Clientes.Add(item);
            }

            //for(int i = 0; i < hilos.Count; i++)
            //{
            //    hilos[i].Start();
            //    if (i == 0)
            //        hilos[i].Join();
            //}

            //hiloNegocio.Start();
            //hiloNegocio.Join();
            negocio.AsignarCaja();
            hiloCaja1.Start();
            hiloCaja2.Start();

            Console.ReadKey();

        }
    }
}
