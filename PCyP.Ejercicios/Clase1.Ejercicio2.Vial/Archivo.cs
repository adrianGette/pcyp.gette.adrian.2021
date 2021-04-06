using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2.Vial
{
    class Archivo
    {
        private int numeroDeHoja;
        private string tipoObjeto;
        private int identificadorTramo;
        private string tipoCamino;
        private int longitud;

        public Archivo()
        {
            this.numeroDeHoja = 0;
            this.tipoObjeto = null;
            this.identificadorTramo = 0;
            this.tipoCamino = null;
            this.longitud = 0;
        }

        public Archivo(int numeroDeHoja,
                       string tipoObjeto,
                       int identificadorTramo,
                       string tipoCamino,
                       int longitud)
        {
            this.numeroDeHoja = numeroDeHoja;
            this.tipoObjeto = tipoObjeto;
            this.identificadorTramo = identificadorTramo;
            this.tipoCamino = tipoCamino;
            this.longitud = longitud;
        }

        public void setNumeroDeHoja(int numeroDeHoja) => this.numeroDeHoja = numeroDeHoja;
        
        public int getNumeroDeHoja() => numeroDeHoja;

        public void setTipoObjeto(String tipoObjeto) => this.tipoObjeto = tipoObjeto;

        public String getTipoObjeto() => tipoObjeto;

        public void setIdentificadorTramo(int identificadorTramo) => this.identificadorTramo = identificadorTramo;

        public int getIdentificadorTramo() => identificadorTramo;

        public void setTipoCamino(String tipoCamino) => this.tipoCamino = tipoCamino;

        public String getTipoCamino() => tipoCamino;

        public void setLongitud(int longitud) => this.longitud = longitud;

        public int getLongitud() => longitud;

        public void imprimir() => Console.WriteLine("\n* Numero de Hoja: {0}\n* Tipo de Objeto: {1} \n* Identificador de Tramo: {2}\n* Tipo de Camino: {3}\n* Longitud: {4}", 
                                                    numeroDeHoja,           
                                                    tipoObjeto,            
                                                    identificadorTramo,         
                                                    tipoCamino,           
                                                    longitud);
    }
}
