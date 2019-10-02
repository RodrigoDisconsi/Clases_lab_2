using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            StringBuilder rtn = new StringBuilder();
            rtn.AppendLine(base.ToString());
            rtn.AppendLine($"Autor: {this.autor}");
            rtn.AppendLine($"Tipo de comic: {this.tipoComic}");
            return rtn.ToString();
        }

        public enum TipoComic
        {
            Occidental,
            Oriental
        }
    }
}
