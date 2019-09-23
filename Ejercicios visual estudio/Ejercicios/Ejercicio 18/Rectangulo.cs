using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometría
{
    public class Rectangulo
    {
        float area;
        float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;


        public Rectangulo (Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            Punto aux = new Punto(vertice1.GetX(), vertice3.GetY());
            Punto aux2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice2 = aux;
            this.vertice4 = aux;
            this.area = 0;
            this.perimetro = 0;
        }

        public float Area()
        {
            float resultado, basee, altura;
            basee = (float) Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            altura = (float)Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            resultado = basee * altura;
            return resultado;
        }

        public float Perimetro()
        {
            float resultado, basee, altura;
            basee = (float)Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            altura = (float)Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            resultado = (basee + altura)*2;
            return resultado;
        }

        public float GetArea()
        {
            float aux = 0;
            if(this.area == 0)
            {
               aux = this.Area();
            }
            return aux;
        }

        public float GetPerimetro()
        {
            float aux = 0;
            if (this.perimetro == 0)
            {
                aux = this.Perimetro();
            }
            return aux;
        }

    }
}
