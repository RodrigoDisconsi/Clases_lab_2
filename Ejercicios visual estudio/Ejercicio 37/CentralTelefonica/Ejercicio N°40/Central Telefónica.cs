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
    }
}
