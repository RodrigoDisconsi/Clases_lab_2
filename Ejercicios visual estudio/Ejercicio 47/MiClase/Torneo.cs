using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    public class Torneo<T> where T : Equipo
    {
        string nombre;
        List<T> equipos;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        public static bool operator ==(Torneo<T> torneo, Equipo e)
        {
            bool rtn = false;
            foreach(Equipo aux in torneo.equipos)
            {
                if (aux == e)
                {
                    rtn = true;
                    break;
                }
            }
            return rtn;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo e)
        {
            return !(torneo == e);   
        }

        public static Torneo<T> operator +(Torneo<T> torneo, Equipo e)
        {
            if(torneo != e)
            {
                torneo.equipos.Add((T)e);                                              
            }
            return torneo;
        }

        private string CalcularPartido<T>(T e1, T e2) where T : Equipo
        {
            StringBuilder rtn = new StringBuilder();
            Random resultado1 = new Random();
            rtn.AppendLine($"{e1.Nombre} {resultado1.Next(0, 10)} - {resultado1.Next(0, 10)} {e2.Nombre}");
            return rtn.ToString();
        }

        public string JugarPartido()
        {
            Random r1 = new Random();
            int indiceEquipoA;
            int indiceEquipoB;
            indiceEquipoA = r1.Next(0, this.equipos.Count);
            do
            {
                indiceEquipoB = r1.Next(0, this.equipos.Count);
            } while (indiceEquipoB == indiceEquipoA);
            return this.CalcularPartido<Equipo>(this.equipos[indiceEquipoA], this.equipos[indiceEquipoB]);
        }

        public string Mostrar()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.AppendLine($"{this.nombre}:");
            foreach(Equipo aux in this.equipos)
            {
                rtn.AppendLine(aux.Ficha());
            }
            return rtn.ToString();
        }
    }
}
