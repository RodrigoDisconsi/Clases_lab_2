using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16a
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] alumno = new Alumno[3];
            for (int i = 0; i < 3; i++)
                alumno[i] = new Alumno();
            Console.Title = "Ejercicio Nº16";
            string nombre, apellido, aux;
            byte nota1, nota2;
            int legajo = 1;
            for(int i = 0; i < 3; i++)
            {
                alumno[i].legajo = legajo;
                Console.Write("\nIngrese el apellido del alumno: ");
                apellido = Console.ReadLine();
                Console.Write("\nIngrese el nombre del alumno: ");
                nombre = Console.ReadLine();
                Console.Write("\nIngrese la nota 1: ");
                aux = Console.ReadLine();
                while(!byte.TryParse(aux, out nota1))
                {
                    Console.Write("\nError. Reingrese la nota 1: ");
                    aux = Console.ReadLine();
                }
                Console.Write("\nIngrese la nota 2: ");
                aux = Console.ReadLine();
                while (!byte.TryParse(aux, out nota2))
                {
                    Console.Write("\nError. Reingrese la nota 2: ");
                    aux = Console.ReadLine();
                }
                alumno[i].apellido = apellido;
                alumno[i].nombre = nombre;
                alumno[i].Estudiar(nota1, nota2);
                alumno[i].CalcularFinal();
                legajo++;
            }
            Console.Clear();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(alumno[i].Mostrar());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
