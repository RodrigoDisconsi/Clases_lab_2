using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Bolígrafo
    {
        public const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Bolígrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }
        public ConsoleColor GetColor()
        {
            ConsoleColor aux;
            aux = this.color;
            return aux;
        }
        public short GetTinta()
        {
            short aux;
            aux = this.tinta;
            return aux;
        }
        void SetTinta(short tinta)
        {
            int aux;
            aux = this.tinta + tinta;
            if(aux <= 0)
            {
                this.tinta = 0;
            }
            else if(aux >= 100)
            {
                this.tinta = 100;
            }
            else
            {
                this.tinta += tinta;
            }
            
        }


        public void Recargar()
        {
            SetTinta(100);
        }


        public bool Pintar(short gasto, out string dibujo)
        {
            bool aux = false;
            int auxTinta;
            auxTinta = GetTinta();
            dibujo = "";
            if (GetTinta() > 0)
            {
                SetTinta(gasto);
                auxTinta -= GetTinta();
                for (int i = 0; i <= auxTinta; i++)
                {

                    dibujo += "*";
                }
                Console.ForegroundColor = this.color;
                aux = true;
            }
            else
                Console.ForegroundColor = ConsoleColor.White;

            return aux;
        }

    }
}
