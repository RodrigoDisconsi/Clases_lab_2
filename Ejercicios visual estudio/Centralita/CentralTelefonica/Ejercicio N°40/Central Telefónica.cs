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
    public partial class FormMenu : Form
    {
        Centralita centralita;
        public FormMenu()
        {
            InitializeComponent();
            this.centralita = new Centralita("Centralita Form");
        }

        private void BtnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador aux = new FrmLlamador(this.centralita);
            aux.ShowDialog();
            this.centralita = aux.GetCentralita;
            btnProvincial.Enabled = true;
            btnLocal.Enabled = true;
            btnTotal.Enabled = true;
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            FormMostrar ganancias = new FormMostrar(this.centralita);
            //ganancias.SetTipoLlamada = Llamada.TipoLlamada.Todas;
            ganancias.SetTipoLlamada = Llamada.TipoLlamada.Todas;
            ganancias.Mostrar();
            ganancias.Show();
        }

        private void BtnLocal_Click(object sender, EventArgs e)
        {
            FormMostrar ganancias = new FormMostrar(this.centralita);
            //ganancias.SetTipoLlamada = Llamada.TipoLlamada.Local;
            ganancias.SetTipoLlamada = Llamada.TipoLlamada.Local;
            ganancias.Mostrar();
            ganancias.Show();
        }

        private void BtnProvincial_Click(object sender, EventArgs e)
        {
            FormMostrar ganancias = new FormMostrar(this.centralita);
            //ganancias.SetTipoLlamada = Llamada.TipoLlamada.Provincial;
            ganancias.SetTipoLlamada = Llamada.TipoLlamada.Provincial;
            ganancias.Mostrar();
            ganancias.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
