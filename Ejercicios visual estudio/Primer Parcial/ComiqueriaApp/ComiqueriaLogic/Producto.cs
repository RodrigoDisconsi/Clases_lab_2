using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid code;
        private string description;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get {
                return this.description;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        public int Stock
        {
            set
            {
                if (value >= 0)
                    this.stock = value;
            }
            get
            {
                return this.stock;
            }
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.code = new Guid();
            this.description = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public static explicit operator Guid(Producto p)
        {
            return p.code;
        }

        public override string ToString()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.AppendLine($"Descripción: {this.description}");
            rtn.AppendLine($"Código: {this.code}");
            rtn.AppendLine($"Precio: {this.precio}");
            rtn.AppendLine($"Stock: {this.stock}");
            return rtn.ToString();
        }


    }
}
