using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {

        }

        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }

        public int ServirMedida(int MEDIDA)
        {
            int rtn;
            if (MEDIDA <= this.contenidoML)
            {
                this.contenidoML -= MEDIDA;
                rtn = MEDIDA;
            }
            else
            {
                rtn = this.contenidoML;
                this.contenidoML -= this.contenidoML;
            }
            return rtn;
        }

        protected override string GenerarInforme()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.AppendLine(base.GenerarInforme());
            rtn.AppendLine($"Medida: {MEDIDA}");
            rtn.AppendLine($"Porcentaje: {this.PorcentajeContenido}%");
            return rtn.ToString();
        }
    }
}
