using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Ejercicio_N_40
{
    public partial class FormMostrar : Form
    {
        Llamada.TipoLlamada tipollamada;
        Centralita centralita;
        public Llamada.TipoLlamada SetTipoLlamada
        {
            set {
                this.tipollamada = value;
                //this.Mostrar(value);
            }
        }

        public FormMostrar(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        //private void Mostrar(Llamada.TipoLlamada llamada)
        //{
        //    StringBuilder aux = new StringBuilder();
        //    if(llamada == Llamada.TipoLlamada.Local)
        //    {
        //        aux.AppendFormat($"Total de facturación local: {this.centralita.GananciasPorLocal}");
        //    }
        //    else if(llamada == Llamada.TipoLlamada.Provincial)
        //    {
        //        aux.AppendFormat($"Total de facturación provincial: {this.centralita.GananciasPorProvincial}");
        //    }
        //    else
        //    {
        //        aux.AppendFormat($"Total de facturación total: {this.centralita.GananciasPorTotal}");
        //    }
        //    richTxtBox.Text = aux.ToString();
        //}

        public void Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            if (this.tipollamada == Llamada.TipoLlamada.Local)
            {
                aux.AppendFormat($"Total de facturación local: {this.centralita.GananciasPorLocal}");
            }
            else if (this.tipollamada == Llamada.TipoLlamada.Provincial)
            {
                aux.AppendFormat($"Total de facturación provincial: {this.centralita.GananciasPorProvincial}");
            }
            else
            {
                aux.AppendFormat($"Total de facturación total: {this.centralita.GananciasPorTotal}");
            }
            richTxtBox.Text = aux.ToString();
        }

    }
}
