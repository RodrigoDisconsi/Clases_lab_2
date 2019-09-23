using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 28;
            Console.WriteLine("{0}", Conversor.DecimalBinario(numero));           
            string numeroBinario = "11100";
            Console.WriteLine("{0}", Conversor.BinarioDecimal(numeroBinario));
            Console.ReadKey();
        }
    }
}
