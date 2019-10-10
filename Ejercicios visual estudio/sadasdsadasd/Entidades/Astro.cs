using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        int duracionOrbita;
        int duracionRotacion;
        protected string nombre;

        public Astro(int duracionOrbita, int duracionRotacion, string nombre)
        {
            this.duracionOrbita = duracionOrbita;
            this.duracionRotacion = duracionRotacion;
            this.nombre = nombre;
        }

        public abstract string Orbitar();

        public virtual string Rotar()
        {
            return $"Rotando. Tiempo de ejecución {this.duracionRotacion}";
        }

        public static explicit operator String(Astro a)
        {
            return a.nombre;
        }

        protected string Mostar()
        {
            return $"Nombre: {this.nombre} - Órbita: {this.duracionOrbita} - Rotación: {this.duracionRotacion}\n";
        }
    }
}
