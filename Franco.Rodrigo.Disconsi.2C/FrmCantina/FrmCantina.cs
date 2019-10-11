using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Entidades;

namespace FrmCantina
{
    public partial class FrmCantina : Form
    {

        public FrmCantina()
        {
            InitializeComponent();
            this.barra1.SetCantina = Cantina.GetCantina(10);
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Botella botella;
            if(Enum.TryParse<Botella.Tipo>(cmbTipo.SelectedValue.ToString(), out tipo) && txtMarca.Text != "")
            {
                if(rbCerveza.Checked)
                {      
                   this.barra1.AgregarBotella(new Cerveza((int)numericCapacidad.Value, txtMarca.Text, tipo, (int)numericContenido.Value));
                }
                else if(rbAgua.Checked)
                {
                   this.barra1.AgregarBotella(new Agua((int)numericCapacidad.Value, txtMarca.Text, (int)numericContenido.Value));
                }
            }
        }
    }
}
