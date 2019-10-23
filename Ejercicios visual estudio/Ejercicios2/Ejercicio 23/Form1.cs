using Moneda;
using System;
using System.Windows.Forms;

namespace Ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionPesos.Text = Pesos.GetCotizacion().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertCotizacion_Click(object sender, EventArgs e)
        {
            if (txtCotizacionEuro.Enabled)
            {
                btnConvertCotizacion.Image = imageList.Images[0];
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPesos.Enabled = false;
            }
            else
            {
                btnConvertCotizacion.Image = imageList.Images[1];
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPesos.Enabled = true;
            }
        }

        private void TxtCotizacionEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnConvertEuro_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtEuro.Text, out aux))
            {
                Euro dinero = aux;
                txtEuroAEuro.Text = (dinero.GetCantidad()).ToString();
                txtEuroADolar.Text = ((Dolar)dinero).GetCantidad().ToString();
                txtEuroAPesos.Text = ((Pesos)dinero).GetCantidad().ToString();
            }
        }

        private void BtnConvertDolar_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtDolar.Text, out aux))
            {
                Dolar dinero = aux;
                txtDolarADolar.Text = dinero.GetCantidad().ToString();
                txtDolarAEuro.Text = ((Euro)dinero).GetCantidad().ToString();
                txtDolarAPesos.Text = ((Pesos)dinero).GetCantidad().ToString();

            }
        }

        private void BtnConvertPesos_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtPesos.Text, out aux))
            {
                Pesos dinero = aux;
                txtPesosAPesos.Text = dinero.GetCantidad().ToString();
                txtPesosADolar.Text = ((Dolar)dinero).GetCantidad().ToString();
                txtPesosAEuro.Text = ((Euro)dinero).GetCantidad().ToString();
            }
        }

        private void TxtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionEuro.Text, out aux))
            {
                Euro.SetCotizacion(aux);
            }
            else
                txtCotizacionEuro.Focus();
        }

        private void TxtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionDolar.Text, out aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
                txtCotizacionDolar.Focus();
        }

        private void TxtCotizacionPesos_Leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionPesos.Text, out aux))
            {
                Pesos.SetCotizacion(aux);
            }
            else
                txtCotizacionPesos.Focus();
        }
    }
}
