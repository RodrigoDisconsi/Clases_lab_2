using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        public Satelite(int duraOrbita, int duraRotacion, string nombre) : base(duraOrbita, duraRotacion, nombre)
        {
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public override string Orbitar()
        {
            return $"Orbitar el satelite: {this.nombre}\n";
        }

        public override string ToString()
        {
            return this.Mostar();
        }
    }
}
