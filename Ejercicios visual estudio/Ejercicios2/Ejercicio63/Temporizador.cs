using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio63
{
    public delegate void encargatoTiempo();
    public class Temporizador
    {
        Thread hilo;
        int intervalo;
        bool activo;

        public bool Activo
        {
            get
            {
                return this.activo;
            }
            set
            {
                this.activo = value;
                if (value == true && this.hilo.IsAlive == false)
                {
                    this.hilo.Start();
                }
                else
                {
                    this.hilo.Abort();
                }
            }
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        public Temporizador()
        {
            this.hilo = new Thread(Corriendo);
            this.intervalo = 1000;
        }

        public event encargatoTiempo EventoTiempo;

        private void Corriendo()
        {
            do
            {
                this.EventoTiempo.Invoke();
                System.Threading.Thread.Sleep(this.intervalo);
            } while (true);
        }

    }
}
