using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "San Lorenzo");
            Jugador j = new Jugador(41835622, "Disconsi Rodrigo", 10, 10);
            Jugador j2 = new Jugador(41865257, "Goffredo Bruno", 10, 15);
            Jugador j3 = new Jugador(41835622, "Frank Alejandro", 10, 7);

            if (equipo + j)
            {
                Console.WriteLine("Pudo agregarse el primer jugador");
            }
            else
            {
                Console.WriteLine("No pudo agregar el primer jugador");
            }

            if (equipo + j2)
            {
                Console.WriteLine("Pudo agregarse el segundo jugador");
            }
            else
            {
                Console.WriteLine("No pudo agregar el segundo jugador");
            }

            if (equipo + j3)
            {
                Console.WriteLine("Pudo agregarse el tercer jugador");
            }
            else
            {
                Console.WriteLine("No pudo agregar el tercer jugador");
            }

            Console.WriteLine(equipo.MostrarEquipo());

            Console.ReadKey();

        }
    }
    
}
