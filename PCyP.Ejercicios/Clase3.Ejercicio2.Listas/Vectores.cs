using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Listas
{
    class Vectores
    {
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };
        
        public static List<string> colores(List<string> lista1)
        {
            foreach (string color in colors)
            {
                lista1.Add(color);
            }

            return lista1;
        }

        public static List<string> removerColores(List<string> lista2)
        {
            foreach (string color in removeColors)
            {
                lista2.Add(color);
            }

            return lista2;
        }

        public static void remove(List<string> lista3)
        {
            foreach(string color in removeColors)
            {
                lista3.Remove(color);
            }
        }

    }
}
