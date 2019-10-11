using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        const int medida = 330;
        Tipo tipo;

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) :base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        public Cerveza(int capacidadML, string marca, int contenidoML) :this(capacidadML, marca, Tipo.Plastico, contenidoML)
        {

        }

        public override int ServirMedida()
        {
            int rtn;
            int servir = (medida * 80) / 100;
            if(this.contenidoML >= medida)
            {
                this.contenidoML -= servir;
                rtn = servir;
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
            rtn.AppendLine($"Tipo: {this.tipo}");
            return rtn.ToString();
        }

        public static implicit operator Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
