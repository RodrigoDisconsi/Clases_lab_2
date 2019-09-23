using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_29
{
    public class Jugador
    {
        int dni;
        string nombre;
        int partidosJugados;
        float promedioGoles;
        int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat($"DNI: {this.dni}, Nombre: {this.nombre}\nPartidos Jugados: {this.partidosJugados}" +
                $" - Total goles: {this.totalGoles} - Promedio goles: {this.promedioGoles}\n");
            return retorno.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (j1.dni == j2.dni)
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (!(j1 == j2))
                retorno = true;
            return retorno;
        }
    }
}
