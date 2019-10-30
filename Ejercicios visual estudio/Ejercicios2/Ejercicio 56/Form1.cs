using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_56
{
    public partial class Form1 : Form
    {

        string auxArchivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Text Files | *.txt";
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                this.auxArchivo = abrir.FileName;
                using(StreamReader archivo = new StreamReader(this.auxArchivo))
                {
                    richTextBox1.Text = archivo.ReadToEnd();
                }
            }
            
            
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "\\Texto.txt";
            if(this.auxArchivo != null)
            {
                using (StreamWriter archivo = new StreamWriter(this.auxArchivo, false))
                {
                    archivo.WriteLine(richTextBox1.Text);
                }
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path, false))
                {
                    archivo.WriteLine(richTextBox1.Text);
                    this.auxArchivo = path;
                }
            }
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Text Files | *.txt";
            guardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo = new StreamWriter(guardar.FileName))
                {
                    archivo.WriteLine(richTextBox1.Text);
                    this.auxArchivo = guardar.FileName;
                }   
            }
        }
    }
}
