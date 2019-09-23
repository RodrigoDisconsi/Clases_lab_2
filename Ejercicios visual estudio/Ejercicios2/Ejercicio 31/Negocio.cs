using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        public Cliente Cliente
        {
            get { return this.clientes.Dequeue(); }
            set { this.clientes.Enqueue(value); }
        }

<<<<<<< HEAD
=======
        public int ClientesPendiendes
        {
            get { return clientes.Count; }
        }

>>>>>>> 7cdcfca0f14ce85f213428910ffdb1ec40f46b81
        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

<<<<<<< HEAD
        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = true;
            foreach(Cliente aux in n.clientes)
            {
                if (aux == c)
                    retorno = false;
            }
            if(retorno = true)
            {
                n.Cliente = c;
            }
=======
        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if(n != c)
            {
                n.Cliente = c;
                retorno = true;
            }
            
>>>>>>> 7cdcfca0f14ce85f213428910ffdb1ec40f46b81
            return retorno;
        }

        public static bool operator == (Negocio n, Cliente c)
        {
<<<<<<< HEAD

=======
            bool retorno = false;
            foreach(Cliente aux in n.clientes)
            {
                if (aux == c)
                    retorno = true;
            }
            return retorno;
>>>>>>> 7cdcfca0f14ce85f213428910ffdb1ec40f46b81
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
<<<<<<< HEAD

=======
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if(n.ClientesPendiendes > 0)
            {
                retorno = n.caja.Atender(n.Cliente);
            }
            return retorno;
>>>>>>> 7cdcfca0f14ce85f213428910ffdb1ec40f46b81
        }

    }
}
