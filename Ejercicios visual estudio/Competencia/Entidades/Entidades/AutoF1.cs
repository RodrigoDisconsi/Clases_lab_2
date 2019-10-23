using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        public AutoF1(short numero, string escuderia) : this(numero, escuderia, 100)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public override string MostrarDatos()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.Append(base.MostrarDatos());
            rtn.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}");
            return rtn.ToString();
        }


        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.CaballosDeFuerza == a2.CaballosDeFuerza)
                return true;
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
