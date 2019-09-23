using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        Producto[] productos;
        int ubicacionEstante;

        Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            string auxB = "";
            if(!(e is null))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Ubicacion: {0}\n", e.ubicacionEstante);
                foreach (Producto p in e.productos)
                {
                    if(!(p is null))
                    {
                        sb.AppendFormat("Producto: {0}\n", Producto.MostrarProducto(p));
                    }              
                }
                return sb.ToString();
            }
            return auxB;
            
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool aux = false;
            if(!(e is null) && !(p is null))
            {
                foreach(Producto pAux in e.productos)
                {
                    if(pAux == p)
                    {
                        aux = true;
                    }
                }
            }
            return aux;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool aux = false;
            if(!(e == p))
            {
                aux = true;
            }
            return aux;
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool aux = false;
            //int i = 0;
            if(!(e is null) && !(p is null))
            {
                //foreach (Producto pAux in e.productos)
                //{
                //    if (pAux is null)
                //        break;
                //    i++;
                //}
                //if (i < e.productos.Length && e != p)
                //{
                //    e.productos[i] = p;
                //    aux = true;
                //}
                if(e != p)
                {
                    for (int i = 0; i < e.productos.Length; i++)
                    {
                        if (e.productos[i] is null)
                        {
                            e.productos[i] = p;
                            aux = true;
                            break;
                        }
                    }
                }
                
            }
            return aux;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            int i = 0;
            if(!(e is null) && !(p is null))
            {
                foreach (Producto pAux in e.productos)
                {
                    if (pAux == p)
                    {
                        break;
                    }
                    i++;
                }
                if (i < e.productos.Length)
                {
                    e.productos[i] = null;
                }
                //for (int i = 0; i < e.productos.Length; i++)
                //{
                //    if (e.productos[i] == p)
                //    {
                //        e.productos[i] = null;
                //        break;
                //    }
                //}
            }
            return e;
        }
    }
}
