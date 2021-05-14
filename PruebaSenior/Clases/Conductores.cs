using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSenior.Clases
{
    class Conductores
    {
        #region ATRIBUTOS
        private Dictionary<string, Conductor> attListaConductores;
        #endregion
        #region PROPIEDADES
        public Dictionary<string, Conductor> ListaConductores
        {
            get { return attListaConductores; }
            set { attListaConductores = value; }
        }
        #endregion
        #region CONSTRUCTOR
        public Conductores()
        {
            attListaConductores = new Dictionary<string, Conductor>();
        }
        #endregion
        #region METODOS PUBLICOS
        public void NuevoConductor(string DNI, string Nombre, string Apellidos)
        {
            if(string.IsNullOrEmpty(DNI) || string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellidos)) 
                throw new Exception("Datos del conductor incorrectos.");            
            if (ListaConductores.ContainsKey(DNI)) throw new Exception("Ya existe el conductor.");
            ListaConductores.Add(DNI, new Conductor(DNI, Nombre, Apellidos));
        }
        public Conductor getConductor(string dni)
        {
            if (ListaConductores.ContainsKey(dni)) return ListaConductores[dni];
            else return null;
        }
        #endregion
        #region METODOS PRIVADOS

        #endregion
    }
}
