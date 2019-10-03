using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

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
