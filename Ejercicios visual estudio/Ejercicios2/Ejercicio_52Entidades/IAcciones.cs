using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52Entidades
{
    public interface IAcciones
    {
        ConsoleColor Color { get; set; }
        float UnidadesDeEscritura { get; set; }

        EscrituraWrapper Escribir(string text);
        bool Recargar(int unidades);
    }
}
