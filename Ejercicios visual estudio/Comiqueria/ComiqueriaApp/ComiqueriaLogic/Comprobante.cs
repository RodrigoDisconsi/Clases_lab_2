using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobanteLogic
{
    public abstract class Comprobante
    {
        protected DateTime fechaEmision;
        Venta venta;

        internal Venta GetVenta
        {
            get
            {
                return this.venta;
            }
        }

        public Comprobante(Venta v)
        {
            this.venta = v;
            this.fechaEmision = v.Fecha;
        }

        public abstract string GenerarComprobante();

        public override bool Equals(object obj)
        {
            return (obj is Comprobante && ((Comprobante)obj).fechaEmision == this.fechaEmision);
        }
    }
}
