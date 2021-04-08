using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Listas
{

    /// <summary>
    /// 2. Manejo básico de listas
    /// 
    /// Dado dos vectores:
    /// 
    /// private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
    /// private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };
    /// 
    /// Realice las siguientes operaciones:
    /// 
    /// a.Armar dos listas, una con los valores del vector “colors” y otra con los valores del
    /// vector “removeColors”.
    /// 
    /// b.Mostrar la lista de colores por pantalla.
    /// 
    /// c.De la lista de colores eliminar los colores listados en la otra lista(removeColors).
    /// 
    /// d.Volver a mostrar la lista de colores por pantalla.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Punto A
            List<string> colors = new List<string>();
            List<string> removeColors = new List<string>();

            Vectores.colores(colors);
            Vectores.removerColores(removeColors);

            // Punto B
            foreach (string col in colors)
            {
                Console.WriteLine(col);
            }
            

            Console.ReadLine();
        }
    }
}
