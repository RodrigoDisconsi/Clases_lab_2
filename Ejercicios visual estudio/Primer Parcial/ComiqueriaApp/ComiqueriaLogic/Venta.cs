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

        static Venta()
        {
            porcentajeIva = 21;
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioSinIva = precioUnidad * cantidad;
            double precioIva = precioSinIva * 21 / 100;
            return precioSinIva + precioIva;
        }

        private void Vender(int cantidad)
        {

        }

    }
}
