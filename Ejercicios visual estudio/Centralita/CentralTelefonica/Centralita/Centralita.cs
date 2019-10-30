using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
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

        public string RutaDeArchivo
        {
            get
            {
                return "D:\\Centralita.txt";
            }
            set
            {
                throw new NotImplementedException();
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

        public bool Guardar()
        {
            DateTime fecha = new DateTime();
            fecha = DateTime.Now;
            StreamWriter archivo = new StreamWriter(this.RutaDeArchivo, true);
            //archivo.WriteLine($"{fecha.DayOfWeek} {fecha.Day} de {fecha.Month} de {fecha.Year} {fecha.Hour} - Se realizó una llamada");
            archivo.WriteLine(fecha.ToString() + "- Se realizó una llamada");
            archivo.Close();
            return true;
        }

        public string Leer()
        {
            StreamReader archivo = new StreamReader(this.RutaDeArchivo);
            string rtn = archivo.ReadToEnd();
            archivo.Close();
            return rtn;
        }
        #region Operadores

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
                    c.Guardar();
                }
                else
                {
                    throw new CentralitaException("Error la llamada ya se encuentra en el sistema", "Centralita", "Operador +");
                }
                return c;
            }
        #endregion

    }
}
