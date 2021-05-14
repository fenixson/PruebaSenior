using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSenior.Clases
{
    class Vehiculo
    {
        #region ATRIBUTOS
        private string attMatricula;
        private string attMarca;
        private string attModelo;
        private string attDniConductorHabitual;
        #endregion
        #region PROPIEDADES
        public string Matricula
        {
            get { return attMatricula; }
            set { attMatricula = value; }
        }
        public string Marca
        {
            get { return attMarca; }
            set { attMarca = value; }
        }
        public string Modelo
        {
            get { return attModelo; }
            set { attModelo = value; }
        }
        public string DniConductorHabitual
        {
            get { return attDniConductorHabitual; }
            set { attDniConductorHabitual = value; }
        }
        #endregion
        #region CONSTRUCTOR
        public Vehiculo(string Matricula, string Marca, string Modelo, string DniConductorHabitual)
        {
            this.attMatricula = Matricula;
            this.attMarca = Marca;
            this.attModelo = Modelo;
            this.attDniConductorHabitual = DniConductorHabitual;
        }
        #endregion
        #region METODOS PUBLICOS

        #endregion
        #region METODOS PRIVADOS

        #endregion

    }
}
