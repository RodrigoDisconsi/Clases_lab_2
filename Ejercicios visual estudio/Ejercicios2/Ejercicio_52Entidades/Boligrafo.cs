using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52Entidades
{
    public class Boligrafo : IAcciones
    {
        ConsoleColor colorTinta;
        float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            int aux = texto.Length;
            string auxTexto = "";
            for (int i = 0; i < aux; i++)
            {
                if (this.tinta == 0)
                    break;
                this.tinta -= (float)0.3;
                auxTexto += texto[i];
            }
            return new EscrituraWrapper(auxTexto, this.colorTinta);
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        public override string ToString()
        {
            return $"Boligrafo --- Tinta: {this.tinta} --- Color: {this.colorTinta}";
        }
    }
}
