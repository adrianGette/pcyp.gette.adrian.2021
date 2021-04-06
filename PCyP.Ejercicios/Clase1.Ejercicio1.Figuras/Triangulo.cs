using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Triangulo : Figura
    {
        private double bas, altura, lado;

        public Triangulo()
        {
            bas = 0;
            altura = 0;
            lado = 0;
        }

        public double getBase() => bas;

        public void setBase( double b ) => this.bas = b;

        public double getAltura() => altura;

        public void setAltura( double a ) => this.altura = a;

        public double getLado() => lado;

        public void setLado( double l ) => this.lado = l;

        public double calcularArea() => (bas * altura) / 2;

        public double calcularPerimetro() => bas + (lado * 2);
        
    }
}
