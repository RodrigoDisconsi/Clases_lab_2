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

        private void SetNumeros(string numero)
        {
            if (this.textBoxActual.Text == "Nro Destino")
            {
                this.textBoxActual.Text = numero;
            }
            else
            {
                this.textBoxActual.Text += numero;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetNumeros(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetNumeros(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetNumeros(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetNumeros(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetNumeros(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetNumeros(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetNumeros(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetNumeros(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetNumeros(button9.Text);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            SetNumeros(buttonX.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            SetNumeros(button0.Text);
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            SetNumeros(buttonNumeral.Text);
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(isProvincial())
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
            Local auxLocal;
            Provincial auxProvincial;
            Random numero = new Random();
            Provincial.Franja franja;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
            if (isProvincial())
            {
                auxProvincial = new Provincial(txtNroOrigen.Text, franja, numero.Next(1, 50), txtNroDestino.Text);
                this.centralita.Llamadas.Add(auxProvincial);
            }
            else
            {
                auxLocal = new Local(txtNroOrigen.Text, numero.Next(1, 50) , txtNroDestino.Text, (float)numero.NextDouble());
                this.centralita.Llamadas.Add(auxLocal);
            }          
            MessageBox.Show("Llamada agregada con éxito!");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
            cmbFranja.Enabled = false;
        }

        private void TxtNroOrigen_Click(object sender, EventArgs e)
        {
            txtNroOrigen.Clear();
        }
    }
}
