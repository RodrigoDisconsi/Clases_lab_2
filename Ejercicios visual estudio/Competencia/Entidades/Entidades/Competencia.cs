using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<VehiculoDeCarrera> competidores;
        TipoCompetencia tipo;
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.AppendLine("  ***COMPETENCIA***");
            rtn.AppendLine($"   Cantidad de competidores: {this.cantidadCompetidores} --- Vueltas: {this.cantidadVueltas}");
            rtn.AppendLine("  ***COMPETIDORES***");
            foreach(VehiculoDeCarrera aux in this.competidores)
            {
                rtn.AppendLine(aux.MostrarDatos());
            }
            return rtn.ToString();
        }

        #region Operadores

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            foreach (VehiculoDeCarrera aux in c.competidores)
            {
                if (aux == a && a.GetType() == aux.GetType())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            Random numero = new Random();
            if(c != a && c.cantidadCompetidores > c.competidores.Count)
            {
                if(c.competidores.Count == 0)
                {
                    if (a is AutoF1)
                    {
                        c.tipo = TipoCompetencia.F1;
                    }
                    else
                    {
                        c.tipo = TipoCompetencia.MotoCross;
                    }
                    c.competidores.Add(a);
                    a.Activo = true;
                    a.Combustible = (short)numero.Next(15, 100);
                    a.Vueltas = c.cantidadVueltas;
                    return true;
                }
                if(c.competidores[0].GetType() == a.GetType())
                {
                    c.competidores.Add(a);
                    a.Activo = true;
                    a.Combustible = (short)numero.Next(15, 100);
                    a.Vueltas = c.cantidadVueltas;
                    return true;
                }    
            }
            return false;       
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            bool rtn = false;
            if (c == a)
            {
                c.competidores.Remove(a);
                rtn = true;
            }
            return rtn;
        }
        #endregion
    }
}
