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
    public partial class VentasForm : Form
    {
        Producto producto;
        Comiqueria comiqueria;
        //Venta venta;

        //public Venta GetVenta
        //{
        //    get { return this.venta; }
        //}

        public VentasForm(Producto p, Comiqueria comiqueria)
        {
            InitializeComponent();
            this.producto = p;
            this.comiqueria = comiqueria;
            double valorActual = Venta.CalcularPrecioFinal(this.producto.Precio, (int)numericUpDownCantidad.Value);
            string aux = $"Precio final: ${valorActual:#.00}";
            lblPrecioFinal.Text = aux;
            lblDescripcion.Text = this.producto.Descripcion;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            double valorActual = Venta.CalcularPrecioFinal(this.producto.Precio, (int)numericUpDownCantidad.Value);
            string aux = $"Precio final: ${valorActual:#.00}";
            lblPrecioFinal.Text = aux;
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            if(numericUpDownCantidad.Value <= this.producto.Stock)
            {
                this.comiqueria.Vender(this.producto, (int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Superó el stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (this.producto.Stock == 0)
                    numericUpDownCantidad.Value = 1;
                else
                    numericUpDownCantidad.Value = this.producto.Stock;
            }
        }
    }
}
