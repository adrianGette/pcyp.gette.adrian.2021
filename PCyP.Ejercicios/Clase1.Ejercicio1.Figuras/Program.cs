using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// Realizar un programa capaz de calcular el área
/// y perímetro de un cuadrado, rectángulo y triángulo.
/// Todos los datos necesarios para su funcionamiento
/// se ingresan por teclado.
/// 
/// </summary>

namespace Clase1.Ejercicio1.Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("\t\t**************************************************");
                Console.WriteLine();
                Console.WriteLine("\t\t\t1. Área y Perímetro de un Cuadrado");
                Console.WriteLine();
                Console.WriteLine("\t\t\t2. Área y Perímetro de un Rectángulo");
                Console.WriteLine();
                Console.WriteLine("\t\t\t3. Área y Perímetro de un Triángulo");
                Console.WriteLine();
                Console.WriteLine("\t\t\t4. Salir");
                Console.WriteLine();
                Console.WriteLine("\t\t**************************************************");
                Console.WriteLine();

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        Cuadrado cuadrado = new Cuadrado();
                        Console.Write("\t\t\tÁrea y Perímetro de un Cuadrado \n");
                        Console.Write("\n\t\t\t=> Ingresar longitud de los lados: ");
                        cuadrado.setLado(double.Parse(Console.ReadLine()));
                        Console.WriteLine("\n\n\t\t\t* El área es: {0}\n", cuadrado.calcularArea());
                        Console.WriteLine("\t\t\t* El perímetro es: {0}\n", cuadrado.calcularPerimetro());
                        break;

                    case 2:
                        Console.WriteLine();
                        Rectangulo rectangulo = new Rectangulo();
                        Console.Write("\t\t\tÁrea y Perímetro de un Rectángulo \n");
                        Console.Write("\n\t\t\t=> Ingresar longitud de la base: ");
                        rectangulo.setBase(double.Parse(Console.ReadLine()));
                        Console.Write("\n\t\t\t=> Ingresar altura: ");
                        rectangulo.setAltura(double.Parse(Console.ReadLine()));
                        Console.WriteLine("\n\n\t\t\t* El área es: {0}\n", rectangulo.calcularArea());
                        Console.WriteLine("\t\t\t* El perímetro es: {0}\n", rectangulo.calcularPerimetro());
                        break;

                    case 3:
                        Console.WriteLine();
                        Triangulo triangulo = new Triangulo();
                        Console.Write("\t\t\tÁrea y Perímetro de un Triángulo \n");
                        Console.Write("\n\t\t\t=> Ingresar base: ");
                        triangulo.setBase(double.Parse(Console.ReadLine()));
                        Console.Write("\n\t\t\t=> Ingresar altura: ");
                        triangulo.setAltura(double.Parse(Console.ReadLine()));
                        Console.Write("\n\t\t\t=> Ingresar longitud de los lados: ");
                        triangulo.setLado(double.Parse(Console.ReadLine()));
                        Console.WriteLine("\n\n\t\t\t* El área es: {0}\n", triangulo.calcularArea());
                        Console.WriteLine("\t\t\t* El perímetro es: {0}\n", triangulo.calcularPerimetro());
                        break;

                    case 4: break;
                }

                Console.ReadLine();
                Console.Clear();
            }
            while (opcion != 4);
        }
    }
}
