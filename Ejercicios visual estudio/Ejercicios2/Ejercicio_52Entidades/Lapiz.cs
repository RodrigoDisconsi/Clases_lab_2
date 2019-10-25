using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52Entidades
{
    public class Lapiz : IAcciones
    {
        float tamanioMina;

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            int aux = texto.Length;
            string auxTexto = "";
            for(int i = 0; i < aux; i++)
            {
                if (this.tamanioMina == 0)
                    break;
                this.tamanioMina -= (float)0.1;
                auxTexto += texto[i];
            }
            return new EscrituraWrapper(auxTexto, ConsoleColor.Gray);
        }

        public override string ToString()
        {
            return $"Lapiz --- Tinta: {this.tamanioMina} --- Color: gris";
        }
    }
}
