using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class ModificarProductoForm : Form
    {
        private Producto producto;
        public ModificarProductoForm(Producto p)
        {
            InitializeComponent();
            this.producto = p;
            lblDescripcion.Text = p.Descripcion;
            txtPrecioActual.Text = $"{p.Precio:#.00}";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            double aux;
            DialogResult result;
            if(double.TryParse(txtNuevoPrecio.Text, out aux))
            {
               result = MessageBox.Show("Seguro que quiere cambiar?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               if(result == DialogResult.Yes)
                {
                    this.producto.Precio = aux;
                    this.Close();
                }
            }
            else
            {
                lblError.Text = "Error. Debe ingresar un precio válido";
            }
        }

        private void TxtNuevoPrecio_TextChanged(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtNuevoPrecio.Text, out aux))
                lblError.Text = "";
        }
    }
}
