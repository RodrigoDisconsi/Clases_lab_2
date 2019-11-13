using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    public class Caja
    {
        List<String> filaClientes;
        
        public List<String> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach (string aux in filaClientes)
            {

                Console.WriteLine(Thread.CurrentThread.Name + " = " + aux);
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
