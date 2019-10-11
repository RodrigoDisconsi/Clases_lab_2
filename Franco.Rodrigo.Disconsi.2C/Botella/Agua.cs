using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        const int medida = 400;

        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {

        }

        public override int ServirMedida()
        {
            return this.ServirMedida(medida);
        }

        public int ServirMedida(int medida)
        {
            int rtn;
            if (medida <= this.contenidoML)
            {
                this.contenidoML -= medida;
                rtn = medida;
            }
            else
            {
                this.contenidoML -= this.contenidoML;
                rtn = this.contenidoML;
            }
            return rtn;
        }

        protected override string GenerarInforme()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.AppendLine(base.GenerarInforme());
            rtn.AppendLine($"Medida: {medida}");
            return rtn.ToString();
        }
    }
}
