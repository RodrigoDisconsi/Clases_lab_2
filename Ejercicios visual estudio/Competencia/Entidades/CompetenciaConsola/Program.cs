using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CompetenciaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 30";

            Competencia comp = new Competencia(20, 5);
            Competencia comp2 = new Competencia(15, 3);
            AutoF1 a1 = new AutoF1(70, "Mercedes", 200);
            AutoF1 a2 = new AutoF1(99, "Ferrari", 220);
            AutoF1 a3 = new AutoF1(40, "McLaren", 250);
            AutoF1 a4 = new AutoF1(70, "Mercedes", 100);
            MotoCross m1 = new MotoCross(33, "Honda", 150);
            MotoCross m2 = new MotoCross(44, "Yamaha", 125);
            MotoCross m3 = new MotoCross(99, "Suzuki", 150);
            MotoCross m4 = new MotoCross(33, "Honda", 150);


            ///Agrego autos.
            if (comp + a1)
            {
                Console.WriteLine("Auto 1 agregado");
            }
            else
            {
                Console.WriteLine("El auto ya se encuentra en la competencia");
            }

            if (comp + a2)
            {
                Console.WriteLine("Auto 2 agregado");
            }
            else
            {
                Console.WriteLine("El auto ya se encuentra en la competencia");
            }

            if (comp + a4)
            {
                Console.WriteLine("Auto 1 agregado");
            }
            else
            {
                Console.WriteLine("El auto ya se encuentra en la competencia");
            }

            if (comp + a3)
            {
                Console.WriteLine("Auto 3 agregado correctamente");
            }
            else
            {
                Console.WriteLine("El auto ya se encuentra en la competencia");
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(comp.MostrarDatos());
            Console.ReadKey();
            Console.Clear();

            ///Agrego motos a comp2.
            if (comp2 + m1)
            {
                Console.WriteLine("Moto 1 agregado");
            }
            else
            {
                Console.WriteLine("El Moto ya se encuentra en la competencia");
            }

            if (comp2 + m2)
            {
                Console.WriteLine("Moto 2 agregado");
            }
            else
            {
                Console.WriteLine("La Moto ya se encuentra en la competencia");
            }

            if (comp2 + m4)
            {
                Console.WriteLine("Moto 1 agregado");
            }
            else
            {
                Console.WriteLine("La Moto ya se encuentra en la competencia");
            }

            if (comp2 + m3)
            {
                Console.WriteLine("Moto 3 agregado correctamente");
            }
            else
            {
                Console.WriteLine("La Moto ya se encuentra en la competencia");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(comp2.MostrarDatos());
            Console.ReadKey();

        }
    }
}
