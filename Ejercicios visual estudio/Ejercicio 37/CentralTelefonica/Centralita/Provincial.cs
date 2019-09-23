using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }

        #region Propiedades
        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        #endregion

        #region Constructores
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        #endregion

        private float CalcularCosto()
        {
            float aux = (float) this.franjaHoraria / 100;
            return aux * base.Duracion;
        }


        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            float aux = (float) this.franjaHoraria / 100;
            retorno.AppendFormat(base.Mostrar() + $"\nCosto de llamada: {this.CostoLlamada}\nFranja Horaria: {aux}\n\n");
            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }




    }
}
