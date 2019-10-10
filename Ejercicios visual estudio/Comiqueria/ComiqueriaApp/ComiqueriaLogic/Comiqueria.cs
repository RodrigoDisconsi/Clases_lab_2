using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComprobanteLogic;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;
        private static Stack<Comprobante> comprobantes;

        public Producto this[Guid codigo]
        {
            get
            {
                Producto rtn = null;
                foreach(Producto aux in this.productos)
                {
                    if((Guid)aux == codigo)
                    {
                        rtn = aux;
                    }
                }
                return rtn;
            }
        }

        public List<Comprobante> this[Producto producto, bool ordenar]
        {
            get
            {
                List<Comprobante> rtn = new List<Comprobante>();
                foreach(Comprobante c in comprobantes)
                {
                    if( ((Guid)((Producto)c.GetVenta)) == (Guid)producto)
                    {
                        rtn.Add(c);
                    }
                }
                if (ordenar)
                    rtn.Sort(OrdenarFecha);
                return rtn;
            }
        }

        static Comiqueria()
        {
            comprobantes = new Stack<Comprobante>();
        }

        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool rtn = false;
            foreach(Producto aux in comiqueria.productos)
            {
                if (aux.Descripcion == producto.Descripcion)
                {
                    rtn = true;
                    break;
                }
            }
            return rtn;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static bool operator ==(Comiqueria comiqueria, Comprobante comprobante)
        {
            bool rtn = false;

            foreach(Comprobante c in Comiqueria.comprobantes)
            {
                if (c.Equals(comprobante))
                {
                    rtn = true;
                    break;
                }
            }

            return rtn;
        }

        public static bool operator !=(Comiqueria comiqueria, Comprobante comprobante)
        {
            return !(comiqueria == comprobante);
        }

        public bool AgregarComprobante(Comprobante comprobante)
        {
            bool rtn = false;

            if(this != comprobante)
            {
                comprobantes.Push(comprobante);
                rtn = true;
            }

            return rtn;
        }

        private bool AgregarComprobante(Venta venta)
        {
            Factura f = new Factura(venta, Factura.TipoFactura.E);

            return AgregarComprobante(f);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
                comiqueria.productos.Add(producto);
            return comiqueria;
        }

        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public static int OrdenarFecha(Venta venta1, Venta venta2)
        {
            return venta1.Fecha.CompareTo(venta2.Fecha);
        }

        public static int OrdenarFecha(Comprobante c1, Comprobante c2)
        {
            return c1.GetVenta.Fecha.CompareTo(c2.GetVenta.Fecha);
        }

        public string ListarVentas()
        {
            this.ventas.Sort(OrdenarFecha);
            StringBuilder rtn = new StringBuilder();
            foreach(Venta aux in this.ventas)
            {
                rtn.AppendLine(aux.ObtenerDescripcionBreve());
            }
            return rtn.ToString();
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> rtn = new Dictionary<Guid, string>();
            foreach(Producto aux in this.productos)
            {
                if(!rtn.ContainsKey((Guid)aux))
                   rtn.Add((Guid)aux, aux.Descripcion);
            }
            return rtn;
        }


    }
}
