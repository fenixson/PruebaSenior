using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSenior.Clases
{
    class Conductor
    {
        #region ATRIBUTOS
        private string attDNI;
        private string attNombre;
        private string attApellidos;
        private int attPuntos;
        private int attVehiculosAsociados;

        private Dictionary<DateTime, Infraccion> attInfracciones;
        #endregion
        #region PROPIEDADES
        public string DNI
        {
            get { return attDNI; }
            set { attDNI = value; }
        }
        public string Nombre
        {
            get { return attNombre; }
            set { attNombre = value; }
        }
        public string Apellidos
        {
            get { return attApellidos; }
            set { attApellidos = value; }
        }
        public int Puntos
        {
            get { return attPuntos; }
            set { attPuntos = value; }
        }
        public int vehiculos
        {
            get { return attVehiculosAsociados; }
            set { attVehiculosAsociados = value; }
        }
        public Dictionary<DateTime, Infraccion> infracciones
        {
            get { return attInfracciones; }
            set { attInfracciones = value; }
        }
        #endregion
        #region CONSTRUCTOR
        public Conductor(string DNI, string Nombre, string Apellidos)
        {
            this.attDNI = DNI;
            this.attNombre = Nombre;
            this.attApellidos = Apellidos;
            this.attPuntos = 15;
            this.attVehiculosAsociados = 0;
            attInfracciones = new Dictionary<DateTime, Infraccion>();
        }
        #endregion
        #region METODOS PUBLICOS
        public void addInfraccion(Infraccion i)
        {
            attInfracciones.Add(DateTime.Now, i);
            Puntos = Puntos - i.Puntos;
        }
        #endregion
        #region METODOS PRIVADOS

        #endregion
    }
}
