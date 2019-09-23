using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_29
{
    public class Equipo
    {
        short cantidadDeJugadores;
        List<Jugador> jugadores;
        string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;
            int flag = 0;

            if(e.jugadores.Count < e.cantidadDeJugadores)
            {
                for(int i = 0; i < e.jugadores.Count; i++)
                {
                    if(j == e.jugadores[i])
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag  == 0)
                {
                    e.jugadores.Add(j);
                    retorno = true;
                }
            }

            return retorno;
        }

        public string MostrarEquipo()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("\n{0}: ", this.nombre);
            retorno.AppendLine("\n");
            foreach (Jugador aux in this.jugadores)
            {
                retorno.AppendLine(aux.MostrarDatos());
            }
            return retorno.ToString();
        }

    }
}
