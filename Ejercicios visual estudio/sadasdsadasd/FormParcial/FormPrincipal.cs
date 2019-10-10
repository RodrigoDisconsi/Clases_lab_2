using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormParcial
{
    public partial class FormPrincipal : Form
    {
        static List<Astro> planetas;
        public FormPrincipal()
        {
            InitializeComponent();
            cmbTipo.DataSource = Enum.GetValues(typeof(Tipo));
            FormPrincipal.planetas = new List<Astro>();
        }

        private void BtnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            int aux;
            if(txtNombrePlaneta.Text != "" && int.TryParse(txtOrbitaPlaneta.Text, out aux)  && numericUpDown1.Value > 0)
            {
                if(aux > 0)
                {
                    Planeta auxPlaneta = new Planeta(aux, (int)numericUpDown1.Value, txtNombrePlaneta.Text, (int)numericUpDown2.Value, (Tipo)cmbTipo.SelectedItem);
                    FormPrincipal.planetas.Add(auxPlaneta);
                    cmbPlanetas.Items.Add(auxPlaneta);
                }
                
            }
            else
            {
                MessageBox.Show("SOS MOGOLICO");
            }
        }

        private void BtnAgregarSatelite_Click(object sender, EventArgs e)
        {
            int aux;
            if(txtNombreSatelite.Text != "" && numericUpDown3.Value > 0 && numericUpDown4.Value > 0 && cmbPlanetas.SelectedIndex >= 0)
            {
                foreach(Planeta p in FormPrincipal.planetas)
                {
                    if(p == (Planeta)cmbPlanetas.SelectedItem)
                    {
                        p.Satelites.Add(new Satelite((int)numericUpDown3.Value, (int)numericUpDown4.Value, txtNombreSatelite.Text));
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Sos mogolico");
            }
        }
    }
}
