using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        #region Propiedades
        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        #endregion

        #region Constructores

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        #endregion

        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat(base.Mostrar() + $"\nCosto: {this.CostoLlamada}\n\n");
            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

    }
}
