using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Cuadrado : Figura
    {
        private double lado;

        public Cuadrado()
        {
            this.lado = 0;
        }

        public double getLado() => this.lado;

        public void setLado( double l ) => this.lado = l;

        public double calcularArea() => lado * lado;

        public double calcularPerimetro() => lado * 4;
     }
}
