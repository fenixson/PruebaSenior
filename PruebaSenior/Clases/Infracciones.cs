using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSenior.Clases
{
    
    class Infracciones
    {
        #region ATRIBUTOS
        private List<Infraccion> attListaInfracciones;
        #endregion
        #region PROPIEDADES
        public List<Infraccion> ListaInfracciones
        {
            get { return attListaInfracciones; }
            set { attListaInfracciones = value; }
        }
        #endregion
        #region CONSTRUCTOR
        public Infracciones()
        {
            attListaInfracciones = new List<Infraccion>();
        }
        #endregion
        #region METODOS PUBLICOS
        public void NuevaInfraccion(string descripcion, string nombre, int puntos)
        {
            if (existeInfraccion(descripcion, nombre, puntos)) throw new Exception("Ya existe la infracción.");
            Infraccion i = new Infraccion(descripcion, nombre, puntos);                
            ListaInfracciones.Add(i);                  
        }
        public Infraccion getInfraccion(int id)
        {
            foreach (Infraccion i in ListaInfracciones)
            {
                if (i.Identificador  == id) return i;
            }
            return null;
        }
        #endregion
        #region METODOS PRIVADOS
        private bool existeInfraccion(string descripcion, string nombre, int puntos)
        {
            foreach (Infraccion i in ListaInfracciones){
                if (i.Descripcion == descripcion && i.Puntos == puntos && i.Nombre == nombre) return true;
            }
            return false;
        }
        #endregion
    }
}
