using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        List<Botella> botellas;
        int espacioTotales;
        static Cantina singleton;

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            this.espacioTotales = espacios;
        }

        public static Cantina GetCantina(int espacios)
        {
            if(singleton == null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espacioTotales = espacios;
            }
            return singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {
            bool rtn = false;

            if(c.espacioTotales > c.botellas.Count)
            {
                c.botellas.Add(b);
                rtn = true;
            }

            return rtn;
        }
    }
}
