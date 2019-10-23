using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiClase;

namespace TorneoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoDeFutbol> torneoFutbol = new Torneo<EquipoDeFutbol>("Toco y sigo");
            Torneo<EquipoDeBasquet> torneoBasquet = new Torneo<EquipoDeBasquet>("Pivoteo y me voy");
            EquipoDeFutbol independiente = new EquipoDeFutbol("Independiente", DateTime.Now);
            EquipoDeFutbol sanLorenzo = new EquipoDeFutbol("San Lorenzo", DateTime.Now);
            EquipoDeFutbol Boca = new EquipoDeFutbol("Boca", DateTime.Now);
            EquipoDeBasquet lakers = new EquipoDeBasquet("Lakers", DateTime.Now);
            EquipoDeBasquet warrios = new EquipoDeBasquet("Warrios", DateTime.Now);
            EquipoDeBasquet chicago = new EquipoDeBasquet("Chicaco Bulls", DateTime.Now);


            torneoFutbol += independiente;
            torneoFutbol += sanLorenzo;
            torneoFutbol += Boca;
            torneoFutbol += independiente;
            torneoBasquet += lakers;
            torneoBasquet += warrios;
            torneoBasquet += chicago;
            torneoBasquet += lakers;

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.ReadKey();

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.ReadKey();

            Console.WriteLine(torneoBasquet.JugarPartido());
            Console.ReadKey();

            Console.WriteLine(torneoFutbol.JugarPartido());
            Console.ReadKey();

            Console.WriteLine(torneoBasquet.JugarPartido());
            Console.ReadKey();

        }
    }
}
