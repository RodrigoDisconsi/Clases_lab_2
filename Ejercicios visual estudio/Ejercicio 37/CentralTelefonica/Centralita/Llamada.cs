using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrignen;



        #region Propiedades
        public abstract float CostoLlamada { get; }
        public float Duracion
        {
            get { return this.duracion; }
        }

        

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrignen; }
        }

        #endregion

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        #region Constructores
        public Llamada (float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrignen = nroOrigen;
        }

        #endregion


        #region Métodos

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }

        protected virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat($"{this.NroOrigen}. ----> {this.NroDestino}." +
                $"\nDuración: {this.Duracion}.");
            return retorno.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.Equals(l2) && l1.Duracion == l2.Duracion && l1.NroDestino == l2.NroDestino &&
                l1.NroOrigen == l2.NroOrigen);
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }


        #endregion

    }
}
