using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobanteLogic
{
    public class Factura : Comprobante
    {
        DateTime fechaVencimiento;
        TipoFactura tipoFactura;
        public enum TipoFactura
        {
            A,
            B,
            C,
            E
        }

        public Factura(Venta v, int diasParaVencimiento, TipoFactura tipoFactura) : base(v)
        {
            this.fechaVencimiento = DateTime.Now.AddDays((double)diasParaVencimiento);
            this.tipoFactura = tipoFactura;
        }
        
        public Factura(Venta v, TipoFactura tipoFactura) : this(v, 15, tipoFactura)
        {

        }

        public override string GenerarComprobante()
        {
            StringBuilder comprobante = new StringBuilder($"Factura {this.tipoFactura}");

            comprobante.AppendLine($"\nFecha emision: {this.fechaEmision}\nFecha vencimiento: {this.fechaVencimiento}\n");
            comprobante.AppendLine($"Producto: {((Producto)this.GetVenta).Descripcion}\n" +
                $"Cantidad:{base.GetVenta.GetCantidad}\nPrecio unitario: ${((Producto)this.GetVenta).Precio:#.00}");
            comprobante.AppendLine($"Subtotal: ${((Producto)this.GetVenta).Precio* this.GetVenta.GetCantidad}\n" +
                "Importe IVA: 21");
            comprobante.AppendLine($"Importe total:{Venta.CalcularPrecioFinal(((Producto)this.GetVenta).Precio, this.GetVenta.GetCantidad)}");
            return comprobante.ToString(); 
        }

        public override bool Equals(object obj)
        {
            return (base.Equals(obj) && ((Factura)obj).tipoFactura == this.tipoFactura);
        }
    }
}
