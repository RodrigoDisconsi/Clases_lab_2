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
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        TextBox textBoxActual;

        public Centralita GetCentralita
        {
            get { return this.centralita; }
        }


        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.textBoxActual = txtNroDestino;
            cmbFranja.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isProvincial()
        {
            bool retorno = false;
            if(txtNroDestino.Text[0] == '#')
            {
                retorno = true;
            }
            return retorno;
        }

        private void SetNumeros(TextBox textBox, string numero)
        {
            if (textBox.Text == "Nro Destino" && textBox.Text == "Nro Origen")
            {
                textBox.Text = numero;
            }
            else
            {
                textBox.Text += numero;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button9.Text);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, buttonX.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, button0.Text);
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            SetNumeros(textBoxActual, buttonNumeral.Text);
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtNroDestino.Text[0] == '#')
            {
                cmbFranja.Enabled = true;
                if(txtNroDestino.Text.Length == 5)
                {
                    txtNroDestino.Text += "-";
                }
            }
            else if(txtNroDestino.Text.Length == 4)
            {
                txtNroDestino.Text += "-";
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            //Local auxLocal;
            //Provincial auxProvincial;
            //if(txtNroDestino.Text[0] == '#')
            //{
            //    auxProvincial
            //}
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
            cmbFranja.Enabled = false;
        }
    }
}
