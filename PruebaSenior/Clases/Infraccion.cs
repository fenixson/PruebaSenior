using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSenior.Clases
{
    class Infraccion
    {
        #region ATRIBUTOS
        private static int ContadorIdentificador = 1;
        private int attIdentificador;
        private string attNombre;
        private string attDescripcion;
        private int attPuntos;
        private int vecesUsado = 0;
        #endregion
        #region PROPIEDADES
        public int Identificador
        {
            get { return attIdentificador; }
        }
        public string Nombre
        {
            get { return attNombre; }
            set { attNombre = value; }
        }
        public string Descripcion
        {
            get { return attDescripcion; }
            set { attDescripcion = value; }
        }
        public int Puntos
        {
            get { return attPuntos; }
            set { attPuntos = value; }
        }
        public int incrVeces{
            get { vecesUsado += 1; return vecesUsado; }
        }
        public int Veces
        {
            get { return vecesUsado; }
        }
        #endregion
        #region CONSTRUCTOR
        public Infraccion(string Descripcion, string Nombre, int Puntos)
        {
            if (string.IsNullOrEmpty(Descripcion)) throw new Exception("La infracción no tiene descripción.");
            this.attIdentificador = ContadorIdentificador;
            ContadorIdentificador++;
            this.attNombre = Nombre;
            this.attDescripcion = Descripcion;
            this.attPuntos = Puntos;
        }
        #endregion
        #region METODOS PUBLICOS

        #endregion
        #region METODOS PRIVADOS

        #endregion
    }
}
