using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get { return this.fecha; }
        }


        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto p, int cantidad)
        {
            this.producto = p;
            Vender(cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioSinIva = precioUnidad * cantidad;
            double precioIva = (double) precioSinIva * 0.21;
            return precioSinIva + precioIva;
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock = this.producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public string ObtenerDescripcionBreve()
        {
            //StringBuilder rtn = new StringBuilder();
            //rtn.AppendFormat("{0} --- {1} --- ${2: #.00}", this.fecha, this.producto.Descripcion, this.precioFinal);
            //return rtn.ToString();
            return $"{this.fecha} --- {this.producto.Descripcion} --- {this.precioFinal: #.00}";
        }

    }
}
