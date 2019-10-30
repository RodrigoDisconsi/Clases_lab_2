using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52Entidades
{
     public class Cartuchera1
    {
        List<IAcciones> cartuchera;

        public List<IAcciones> Cartuchera
        {
            get
            {
                return this.cartuchera;
            }
        }

        public Cartuchera1()
        {
            this.cartuchera = new List<IAcciones>();
        }

        public static Cartuchera1 operator +(Cartuchera1 c, IAcciones util)
        {
            c.cartuchera.Add(util);
            return c;
        }

        public bool ProbarElementos()
        {
            bool rtn = false;
            foreach(IAcciones aux in this.cartuchera)
            {
                if (aux is Boligrafo)
                {
                    if (aux.UnidadesDeEscritura <= 0)
                    {
                        aux.Recargar(100);
                        return rtn;
                    }
                    aux.UnidadesDeEscritura -= 1;
                }
            }
            rtn = true;
            return rtn;
        }
        
    }
}
