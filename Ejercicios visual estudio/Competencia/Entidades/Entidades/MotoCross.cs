using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        short cilindrada;

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        public MotoCross(short numero, string escuderia) : this(numero, escuderia, 100)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.Append(base.MostrarDatos());
            rtn.AppendLine($"Cilindrada: {this.cilindrada}");
            return rtn.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is MotoCross;
        }

        public static bool operator ==(MotoCross c1, MotoCross c2)
        {
            if ((VehiculoDeCarrera)c1 == (VehiculoDeCarrera)c2 && c1.cilindrada == c2.cilindrada)
                return true;
            return false;
        }

        public static bool operator !=(MotoCross c1, MotoCross c2)
        {
            return !(c1 == c2);
        }
    }
}
