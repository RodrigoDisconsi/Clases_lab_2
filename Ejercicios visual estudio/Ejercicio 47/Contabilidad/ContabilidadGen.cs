using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public class ContabilidadGen<T, U>
        where T : Documento
        where U : Documento, new()
    {
        List<T> egresos;
        List<U> ingresos;

        public ContabilidadGen()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();

        }
        public static ContabilidadGen<T, U> operator +(ContabilidadGen<T, U> list, U ingreso)
        {
            list.ingresos.Add(ingreso);
            return list;
        }

        public static ContabilidadGen<T, U> operator +(ContabilidadGen<T, U> list, T egreso)
        {
            list.egresos.Add(egreso);
            return list;
        }

        public string Mostar()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.AppendLine("     ***RECIBOS***\n");
            int numFactura = 1;
            int numRecibo = 2;
            foreach(U aux in this.ingresos)
            {
                rtn.AppendFormat("       Recibo {0}: ", numRecibo);
                rtn.AppendLine(aux.ToString());
                numRecibo++;
            }
            rtn.AppendLine("\n     ***FACTURAS***\n");
            foreach (T aux in this.egresos)
            {
                rtn.AppendFormat("       Factura {0}: ", numFactura);
                rtn.AppendLine(aux.ToString());
                numFactura++;
            }

            return rtn.ToString();
        }
    }
}
