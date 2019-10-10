using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        List<Astro> planetas;

        public List<Astro> Planetas
        {
            get
            {
                return this.planetas;
            }
        }

        public SistemaSolar()
        {
            this.planetas = new List<Astro>();
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder rtn = new StringBuilder();
            foreach(Planeta aux in this.planetas)
            {
                rtn.AppendLine(aux.ToString());
                foreach(Satelite auxSatelite in aux.Satelites)
                {
                    rtn.AppendLine(auxSatelite.ToString());
                }
            }
            return rtn.ToString();
        }
    }
}
