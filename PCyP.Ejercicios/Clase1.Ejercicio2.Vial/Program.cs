using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2.Vial
{

    /// <summary>
    /// Recorrer el archivo vial.csv, tomar cada linea, 
    /// separar los campos y mostrarlos por pantalla. 
    /// Instanciar un objeto por cada linea  que pueda 
    /// registrar los campos necesarios y que exponga un 
    /// método imprimir() donde muestre esos valores.
    /// 
    //  Los campos del archivo CSV son: 
    //  número-de-hoja,tipo-objeto,identificador-tramo,tipo-camino,longitud
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            string[] archivo = File.ReadAllLines("C:/Users/weird/Desktop/vial.csv");

            Archivo doc = new Archivo();

            int cantidadRegistros = 0;

            foreach (var linea in archivo)
            {
                var campo = linea.Split(',');

                doc = new Archivo(int.Parse(campo[0]),
                                  campo[1], int.Parse(campo[2]),
                                  campo[3], int.Parse(campo[4]));

                doc.imprimir();

                cantidadRegistros++;
            }

            Console.WriteLine("\n=> Se leyeron: " + cantidadRegistros + " registros.");

            Console.ReadLine();
        }
    }
}
