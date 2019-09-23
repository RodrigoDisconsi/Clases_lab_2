using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº 17";

            Bolígrafo LapiceraAzul = new Bolígrafo(ConsoleColor.Blue, 100);
            Bolígrafo LapiceraAmarilla = new Bolígrafo(ConsoleColor.Yellow, 50);
            string auxAzul, auxAmarillo;
            if (LapiceraAzul.Pintar(-30, out auxAzul))
            {
                Console.WriteLine($"{auxAzul}");
            }
            else
                Console.WriteLine("No hay tinta en la lapicera azul");
            if(LapiceraAmarilla.Pintar(-30, out auxAmarillo))
            {
                Console.WriteLine($"{auxAmarillo}");
            }
            else
                Console.WriteLine("No hay tinta en la lapicera azul");

            if(LapiceraAzul.Pintar(-30, out auxAzul))
            {
                Console.WriteLine($"{auxAzul}");
            }
            else
                Console.Write("No hay tinta en la lapicera azul.");



            Console.ReadKey();
        }
    }
}
