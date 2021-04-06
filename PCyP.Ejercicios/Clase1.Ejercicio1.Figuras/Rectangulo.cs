using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Rectangulo : Figura
    {
        private double bas, altura;

        public Rectangulo()
        {
            this.bas = 0;
            this.altura = 0;
        }

        public double getBase() => bas;
        
        public void setBase( double b ) => this.bas = b;

        public double getAltura() => this.altura;

        public void setAltura( double a ) => this.altura = a;
        
        public double calcularArea() => bas * altura;
        
        public double calcularPerimetro() => (bas * 2) + (altura * 2);   
    }
}
