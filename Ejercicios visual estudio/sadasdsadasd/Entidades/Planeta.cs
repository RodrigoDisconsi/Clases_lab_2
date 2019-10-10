using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        int cantidadSatelites;
        Tipo tipo;
        List<Astro> satelites;

        public List<Astro> Satelites
        {
            get
            {
                return this.satelites;
            }
        }

        public Planeta (int duraOrbita, int duraRotacion, string nombre) : base(duraOrbita, duraRotacion, nombre)
        {
            this.satelites = new List<Astro>();
        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre, int cantSatelites, Tipo tipo) : this(duraOrbita, duraRotacion, nombre)
        {
            this.cantidadSatelites = cantidadSatelites;
            this.tipo = tipo;
        }

        public override string Orbitar()
        {
            return $"Orbita el planeta: {this.nombre}\n";
        }

        public new string Rotar()
        {
            return this.Orbitar();
        }

        public override string ToString()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.Append(this.Mostar());
            rtn.AppendLine($"Cantidad de satélites: {this.cantidadSatelites} -- Tipo: {this.tipo}");
            return rtn.ToString();
        }

        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            bool rtn = false;

            foreach(Satelite aux in planeta.Satelites)
            {
                if(satelite.Nombre == aux.Nombre)
                {
                    rtn = true;
                    break;
                }
            }
            return rtn;
        }
        
        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }

        public static bool operator ==(Planeta planeta1, Planeta planeta2)
        {
            return (planeta1.nombre == planeta2.nombre);
        }

        public static bool operator !=(Planeta planeta1, Planeta planeta2)
        {
            return !(planeta1 == planeta2);
        }

        public static bool operator +(Planeta planeta, Satelite satelite)
        {
            bool rtn = false;

            if (satelite is Satelite && planeta != satelite)
            {
                planeta.Satelites.Add(satelite);
                rtn = true;
            }
            return false;
        }

    }
}
