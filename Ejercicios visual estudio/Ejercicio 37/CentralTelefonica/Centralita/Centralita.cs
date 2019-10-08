using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades
        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        #endregion


        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion



        private string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(this.razonSocial.ToUpper()+":");
            retorno.AppendFormat($"Ganancia total: {this.GananciasPorTotal}, Ganancia locales: " +
                $"{this.GananciasPorLocal}, Ganancias provinciales: {this.GananciasPorProvincial}\n\n");
            foreach (Llamada aux in this.Llamadas)
            {
                //if (aux is Local)
                //{
                //    retorno.Append(((Local)aux).ToString());
                //}
                //if (aux is Provincial)
                //{
                //    retorno.Append(((Provincial)aux).ToString());
                //}
                retorno.Append(aux.ToString());
            }
            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


        private void AgregarLlamada(Llamada l)
        {
            this.Llamadas.Add(l);
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;
            foreach (Llamada aux in this.listaDeLlamadas)
            {
                if ((tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas) && aux is Local)
                {
                    retorno += ((Local)aux).CostoLlamada;
                }
                else if ((tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas) && aux is Provincial)
                {
                    retorno +=((Provincial)aux).CostoLlamada;
                }
            }
            return retorno;
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool retorno = false;
            foreach(Llamada aux in c.Llamadas)
            {
                if(aux == l)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if (c != l)
            {
                c.AgregarLlamada(l);
            }
            return c;
        }
    }
}
