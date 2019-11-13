using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        Temporizador temp;
        public Form1()
        {
            InitializeComponent();
            temp = new Temporizador();
            temp.EventoTiempo += this.AsignarHora;
            temp.Activo = true;
        }

        public void AsignarHora()
        {
            if(this.label1.InvokeRequired)
            {
                encargatoTiempo d = new encargatoTiempo(this.AsignarHora);
                this.Invoke(d);
            }
            else
            {
                this.label1.Text = DateTime.Now.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.temp.Activo = false;
        }
    }
}
