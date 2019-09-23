using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class PuestoAtencion
    {
        static int numeroActual;
        Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) 
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get { return ++numeroActual; }
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        public bool Atender (Cliente l)
        {
<<<<<<< HEAD
=======
            Console.WriteLine($"El cliente {l.Nombre} esta siendo atendido...");
>>>>>>> 7cdcfca0f14ce85f213428910ffdb1ec40f46b81
            System.Threading.Thread.Sleep(3000);
            return true;
        }

        

    }
}
