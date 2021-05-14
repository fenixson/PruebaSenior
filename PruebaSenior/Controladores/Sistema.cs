using PruebaSenior.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSenior.Controladores
{
    class Sistema
    {
        #region ATRIBUTOS
        private Vehiculos vehiculos;
        private Conductores conductores;
        private Infracciones infracciones;
        #endregion
        #region PROPIEDADES

        #endregion
        #region CONSTRUCTOR
        public Sistema()
        {
            vehiculos = new Vehiculos();
            conductores = new Conductores();
            infracciones = new Infracciones();
        }
        #endregion
        #region Propiedades
        public Dictionary<string,Vehiculo> ListaVehiculos
        {
            get { return vehiculos.ListaVehiculos; }
        }
        public Dictionary<string, Conductor> ListaConductores
        {
            get { return conductores.ListaConductores; }
        }
        public List<Infraccion> ListaInfracciones
        {
            get { return infracciones.ListaInfracciones; }
        }
        #endregion
        #region METODOS PUBLICOS
        public void nuevoConductor(string DNI, string Nombre, string Apellidos)
        {
            try
            {
                conductores.NuevoConductor(DNI, Nombre, Apellidos);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void nuevoVehiculo(string Matricula, string Marca, string Modelo, string DniConductorHabitual)
        {
            try
            {
                Conductor c = conductores.getConductor(DniConductorHabitual);
                if (c == null) throw new Exception("No existe el conductor;");
                if(c.vehiculos >= 10) throw new Exception("El conductor es habitual de mas de 10 vehiculos");
                vehiculos.NuevoVehiculo(Matricula, Marca, Modelo, DniConductorHabitual);
                c.vehiculos = c.vehiculos + 1;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void nuevaInfraccion(string Descripcion, string nombre, int puntos)
        {
            try
            {
                infracciones.NuevaInfraccion(Descripcion, nombre, puntos);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void RegistrarInfraccion(string matricula, int idInfraccion)
        {
            Vehiculo v = vehiculos.getVehiculo(matricula);
            Infraccion i = infracciones.getInfraccion(idInfraccion);
            try
            {
                if (v == null) throw new Exception("El vehículo no existe.");
                if (i == null) throw new Exception("La infracción no existe.");

                Conductor c = conductores.getConductor(v.DniConductorHabitual);
                c.addInfraccion(i);
                int act = i.incrVeces;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Infraccion getInfraccion(int id)
        {
            return infracciones.getInfraccion(id);
        }
        public Conductor getConductor(string dni)
        {
            return conductores.getConductor(dni);
        }
        public Vehiculo getVehiculo(string matricula)
        {
            return vehiculos.getVehiculo(matricula);
        }

        //List<KeyValuePair> lista = sistema.Top5Infracciones();
        public List<Infraccion> Top5Infracciones()
        {
            List<Infraccion> result = new List<Infraccion>();

            foreach (Infraccion i in ListaInfracciones)
            {
                if(result.Count < 5)
                {
                    result.Add(i);
                }
                else
                {
                    foreach(Infraccion ii in result)
                    {
                        if(ii.Veces < i.Veces)
                        {
                            result.Remove(ii);
                            result.Add(i);
                            break;
                        }
                    }
                }
            }

            return result;
        }
        public List<Conductor> TopNconductores(int limite)
        {
            List<Conductor> result = new List<Conductor>();
            foreach (Conductor c in ListaConductores.Values)
            {
                if(result.Count < limite)
                {
                    result.Add(c);
                }
                else
                {
                    foreach(Conductor cc in result)
                    {
                        if(cc.Puntos < c.Puntos)
                        {
                            result.Remove(cc);
                            result.Add(c);
                            break;
                        }
                    }
                }
            }
            return result;
        }
        #endregion
        #region METODOS PRIVADOS

        #endregion

    }
}
