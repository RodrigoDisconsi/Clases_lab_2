using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        string codigoDeBarra;
        string marca;
        float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static string MostrarProducto(Producto p)
        {
            string auxB = "";
            if(!(p is null))
            {
                StringBuilder aux = new StringBuilder();
                aux.AppendFormat("Marca: {0}. \bPrecio: {1}.\b Codigo: {2}\n", p.marca, p.precio, p.codigoDeBarra);
                return aux.ToString();
            }
            return auxB;
        }

        public static bool operator != (Producto p, string marca)
        {
            bool aux = false;
            if (!(p == marca))
            {
                aux = true;
            }
            return aux;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool aux = false;
            if(!(p is null))
            {
                if (p.marca == marca)
                {
                    aux = true;
                }
            }          
            return aux;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool aux = false;
            if (!(p1 == p2))
            {
                aux = true;
            }
            return aux;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool aux = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if ((p1.GetMarca() == p2.GetMarca()) && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    aux = true;
                }
            }           
            return aux;
        }
    }
}
