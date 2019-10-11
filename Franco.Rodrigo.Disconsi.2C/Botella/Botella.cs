using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public enum Tipo
        {
            Plastico,
            Vidrio
        }

        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        public int PorcentajeContenido
        {
            get
            {
                return (this.contenidoML * 100) / this.capacidadML;
            }
        }

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            if(capacidadML < contenidoML)
            {
                this.capacidadML = capacidadML;
                this.contenidoML = capacidadML;
            }
            else
            {
                this.capacidadML = capacidadML;
                this.contenidoML = contenidoML;
            }
        }

        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.AppendLine($"Marca: {this.marca}");
            rtn.AppendLine($"Capacidad: {this.capacidadML} ml");
            rtn.AppendLine($"Contenido: {this.contenidoML} ml");

            return rtn.ToString();
        }

        public override string ToString()
        {
            return this.GenerarInforme();
        }
    }
}
