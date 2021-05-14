using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSenior.Clases
{
    class Vehiculos
    {
        #region ATRIBUTOS
        private Dictionary<string, Vehiculo> attListaVehiculos;
        #endregion
        #region PROPIEDADES
        public Dictionary<string, Vehiculo> ListaVehiculos
        {
            get { return attListaVehiculos; }
            set { attListaVehiculos = value; }
        }
        #endregion
        #region CONSTRUCTOR
        public Vehiculos()
        {
            attListaVehiculos = new Dictionary<string, Vehiculo>();
        }
        #endregion
        #region METODOS PUBLICOS
        public void NuevoVehiculo(string Matricula, string Marca, string Modelo, string DniConductorHabitual)
        {
            if (string.IsNullOrEmpty(Matricula) || string.IsNullOrEmpty(Marca) || string.IsNullOrEmpty(Modelo) || string.IsNullOrEmpty(DniConductorHabitual))
                throw new Exception("Datos del vehículo incorrectos.");
            if (ListaVehiculos.ContainsKey(Matricula)) throw new Exception("Ya existe el vehículo.");
            ListaVehiculos.Add(Matricula, new Vehiculo(Matricula, Marca, Modelo, DniConductorHabitual));
        }
        public Vehiculo getVehiculo(string matricula)
        {
            if (ListaVehiculos.ContainsKey(matricula)) return ListaVehiculos[matricula];
            return null;
        }
        #endregion
        #region METODOS PRIVADOS

        #endregion
    }
}
