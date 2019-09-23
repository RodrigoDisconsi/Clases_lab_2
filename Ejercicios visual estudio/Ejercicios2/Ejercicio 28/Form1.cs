using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public static int Ordenar(KeyValuePair<string, int> valor1, KeyValuePair<string, int> valor2)
        {
            return -valor1.Value.CompareTo(valor2.Value);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> palabras = new Dictionary<string, int>();
            List<KeyValuePair<string, int>> listaAux;
            string aux;
            string aux2 = "";
            int top = 1;
            aux = txtLectura.Text;
            for(int i = 0; i < aux.Length; i++)
            {
                if (aux[i] != ' ' && aux[i] != '.' && aux[i] != ',')
                {
                    aux2 += aux[i];
                }
                else if (aux2 != "")
                {
                    if (palabras.ContainsKey(aux2))
                    {
                        palabras[aux2] ++;
                    }
                    else
                    {
                        palabras.Add(aux2, 1);
                    }
                    aux2 = "";
                }
            }

            listaAux = palabras.ToList();
            listaAux.Sort(Ordenar);

            aux2 = "";
            foreach(KeyValuePair<string, int> x in listaAux)
            {
                if (top == 4)
                    break;
                aux2 += "TOP " + top + ": " + x.Key+ "\n";
                top++;
            }

            MessageBox.Show(aux2);
            


    }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
