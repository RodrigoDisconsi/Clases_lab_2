using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16a
{
    public class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }
        public void CalcularFinal()
        {
            System.Threading.Thread.Sleep(150);
            Random final = new Random();
            if (nota1 >= 4 && nota2 >= 4)
            {
                notaFinal = final.Next(10);
            }
            else
            {
                notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            string retorno = "";
            if (notaFinal != -1)
            {
                retorno = "Legajo: " + legajo + "\n" + "Apellido: " + apellido + "\n" + "Nombre: " + nombre + "\n" + "Nota 1: " + nota1 + "\n" + "Nota 2: " + nota2 + "\n" + "Final: " + notaFinal;
            }
            else
            {
                retorno = "Alumno desaprobado";
            }
            return retorno;
        }

    }
}
