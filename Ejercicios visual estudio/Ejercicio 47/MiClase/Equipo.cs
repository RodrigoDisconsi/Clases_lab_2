using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    public abstract class Equipo
    {
        string nombre;
        DateTime fecha;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fecha = fecha;
        }

        public static bool operator ==(Equipo e, Equipo e2)
        {
            bool rtn = false;
            if ((e.fecha == e2.fecha) && (e.nombre == e2.nombre))
                rtn = true;
            return rtn;
        }

        public static bool operator !=(Equipo e, Equipo e2)
        {
            return !(e == e2);
        }

        public string Ficha()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.AppendLine($"{this.nombre} fundado el {this.fecha}");
            return rtn.ToString();
        }
    }
}
