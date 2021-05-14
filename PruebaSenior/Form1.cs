using PruebaSenior.Clases;
using PruebaSenior.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSenior
{
    public partial class Form1 : Form
    {
        #region Atributos
        private Sistema sistema;
        #endregion


        public Form1()
        {
            sistema = new Sistema();
            InitializeComponent();
            cargarCombos();
            tbConductorPuntos.ReadOnly = true;
            tbVehiculoConductor.Visible = false;
        }
        #region Metodos privados

        private void cargarCombos()
        {
            cargarComboInfraccion();
            cargarComboConductores();
            cargarComboVehiculos();
        }
        private void cargarComboInfraccion()
        {
            cbInfraccion.Items.Clear();
            cbVehiculoInfraccion.Items.Clear();
            cbInfraccion.Items.Add("0 - Nuevo");            
            foreach (Infraccion i in sistema.ListaInfracciones)
            {
                cbInfraccion.Items.Add(i.Identificador + " - " + i.Nombre);
                cbVehiculoInfraccion.Items.Add(i.Identificador + " - " + i.Nombre);
            }
            cbInfraccion.SelectedIndex = 0;
        }
        private void cargarComboConductores()
        {
            string conductorvehiculoSeleccionado = cbVehiculoConductor.Text;

            cbVehiculoConductor.Items.Clear();
            cbConductores.Items.Clear();
            cbConductores.Items.Add("0 - Nuevo");
            foreach (string dni in sistema.ListaConductores.Keys)
            {
                cbConductores.Items.Add(dni);
                cbVehiculoConductor.Items.Add(dni);
            }
            cbConductores.SelectedIndex = 0;
            cbVehiculoConductor.Text = conductorvehiculoSeleccionado;
        }
        public void cargarComboVehiculos()
        {
            cbVehiculoMatricula.Items.Clear();
            cbVehiculoMatricula.Items.Add("0 - Nuevo");
            foreach (string matricula in sistema.ListaVehiculos.Keys)
            {
                cbVehiculoMatricula.Items.Add(matricula);
            }
            cbVehiculoMatricula.SelectedIndex = 0;
        }
        private void LlenarDatosPruebas(object sender, ToolStripItemClickedEventArgs e)
        {
            sistema = new Sistema();
            //infracciones
            for (int i = 1; i <= 10; i++)
            {
                sistema.nuevaInfraccion("Descripccion Infraccion " + i, "Infraccion " + i, i);
            }
            cargarComboInfraccion();
            //conductores
            for (int i = 1; i <= 20; i++)
            {
                sistema.nuevoConductor("dni " + i, "nombre " + i, "apellido " + i);
            }
            cargarComboConductores();
            //vehiculos
            for (int i = 1; i <= 20; i++)
            {
                sistema.nuevoVehiculo("matricula " + i, "marca " + i, "modelo " + i, "dni " + i);
            }
            cargarComboVehiculos();

            sistema.RegistrarInfraccion("matricula " + 1, 1);
            sistema.RegistrarInfraccion("matricula " + 1, 2);
            sistema.RegistrarInfraccion("matricula " + 1, 3);
            sistema.RegistrarInfraccion("matricula " + 2, 1);
            sistema.RegistrarInfraccion("matricula " + 2, 3);

        }
        #endregion


        #region Infracciones
        private void GuardarInfraccion_Click(object sender, EventArgs e)
        {
            if (cbInfraccion.Text == "0 - Nuevo")
            {
                //nueva infraccion
                string Nombre = tbInfraccionNombre.Text;
                int puntos = int.Parse(nudInfraccionPuntos.Text);
                string descripcion = rtbInfraccionDescripcion.Text;

                try
                {
                    sistema.nuevaInfraccion(descripcion, Nombre, puntos);
                    cargarComboInfraccion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sidInfraccion(object sender, EventArgs e)
        {
            int identificador = int.Parse(cbInfraccion.Text.Split("-")[0].Replace(" ", ""));
            if (identificador == 0)
            {
                tbInfraccionNombre.Text = "";
                nudInfraccionPuntos.Text = "0";
                rtbInfraccionDescripcion.Text = "";
                tbInfraccionNombre.ReadOnly = false;
                nudInfraccionPuntos.ReadOnly = false;
                rtbInfraccionDescripcion.ReadOnly = false;
            }
            else
            {
                Infraccion i = sistema.getInfraccion(identificador);
                if (i != null)
                {
                    tbInfraccionNombre.Text = i.Nombre;
                    nudInfraccionPuntos.Text = i.Puntos.ToString();
                    rtbInfraccionDescripcion.Text = i.Descripcion;
                    tbInfraccionNombre.ReadOnly = true;
                    nudInfraccionPuntos.ReadOnly = true;
                    rtbInfraccionDescripcion.ReadOnly = true;
                }
            }
        }
        #endregion

        #region Conductores
        private void GuardarConductor_Click(object sender, EventArgs e)
        {
            if (cbConductores.Text == "0 - Nuevo")
            {
                string dni = tbConductorDNI.Text;
                string nombre = tbConductorNombre.Text;
                string apellidos = tbConductorApellidos.Text;

                try
                {
                    sistema.nuevoConductor(dni, nombre, apellidos);
                    cargarComboConductores();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void sidConductores(object sender, EventArgs e)
        {
            string dni= cbConductores.Text;
            if (dni.Contains("Nuevo"))
            {
                tbConductorDNI.Text = "";
                tbConductorNombre.Text = "";
                tbConductorApellidos.Text = "";
                tbConductorPuntos.Text = "";
                tbConductorDNI.ReadOnly = false;
                tbConductorNombre.ReadOnly = false;
                tbConductorApellidos.ReadOnly = false;
                tbConductorPuntos.Visible = false;
                lblPuntos.Visible = false;
                lvInfracciones.Visible = false;
            }
            else
            {
                Conductor c = sistema.getConductor(dni);
                tbConductorPuntos.Visible = true;
                lblPuntos.Visible = true;
                tbConductorDNI.ReadOnly = true;
                tbConductorNombre.ReadOnly = true;
                tbConductorApellidos.ReadOnly = true;
                tbConductorDNI.Text = c.DNI;
                tbConductorNombre.Text = c.Nombre;
                tbConductorApellidos.Text = c.Apellidos;
                tbConductorPuntos.Text = c.Puntos.ToString();

                
                lvInfracciones.Items.Clear();
                foreach (DateTime d in c.infracciones.Keys)
                {
                    string fecha = d.ToString("dd/MM/yyyy");
                    string hora = d.ToString("HH:mm");
                    string detalles = c.infracciones[d].Descripcion;

                    ListViewItem lvi = new ListViewItem(fecha);
                    lvi.SubItems.Add(hora);
                    lvi.SubItems.Add(detalles);

                    lvInfracciones.Items.Add(lvi);
                }
                lvInfracciones.Visible = true;
            }
        }

        #endregion

        #region Vehiculos
        private void GuardarVehiculo_Click(object sender, EventArgs e)
        {
            if (cbVehiculoMatricula.Text == "0 - Nuevo")
            {
                string matricula = tbVehiculoMatricula.Text;
                string marca = tbVehiculoMarca.Text;
                string modelo = tbVehiculoModelo.Text;
                string Conductor = cbVehiculoConductor.Text;

                try
                {
                    sistema.nuevoVehiculo(matricula, marca,modelo,Conductor);
                    cargarComboVehiculos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void sidVehiculo(object sender, EventArgs e)
        {
            string matricula = cbVehiculoMatricula.Text;
            if (matricula.Contains("Nuevo"))
            {
                tbVehiculoMatricula.Text = "";
                tbVehiculoMarca.Text = "";
                tbVehiculoModelo.Text = "";
                cbVehiculoConductor.Text = "";
                tbVehiculoMatricula.ReadOnly = false;
                tbVehiculoMarca.ReadOnly = false;
                tbVehiculoModelo.ReadOnly = false;
                cbVehiculoConductor.Visible = true;
                tbVehiculoConductor.Visible = false;

                RegistrarInfraccion.Visible = false;
                cbVehiculoInfraccion.Visible = false;
            }
            else
            {
                Vehiculo v = sistema.getVehiculo(matricula);
                tbVehiculoMatricula.Text = v.Matricula;
                tbVehiculoMarca.Text = v.Marca;
                tbVehiculoModelo.Text = v.Modelo;
                cbVehiculoConductor.Text = "";
                cbVehiculoConductor.Visible = false;
                tbVehiculoConductor.Visible = true;
                tbVehiculoConductor.Text = v.DniConductorHabitual;


                RegistrarInfraccion.Visible = true;
                cbVehiculoInfraccion.Text = "";
                cbVehiculoInfraccion.Visible = true;
            }
        }
        private void RegistrarInfraccion_Click(object sender, EventArgs e)
        {
            string matricula = tbVehiculoMatricula.Text;
            int idInfraccion = int.Parse(cbVehiculoInfraccion.Text.Split("-")[0].Replace(" ", ""));
            try
            {
                sistema.RegistrarInfraccion(matricula, idInfraccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void CargarTopInfraciones_Click(object sender, EventArgs e)
        {
            List<Infraccion> lista = sistema.Top5Infracciones();
            lvTopInfracciones.Items.Clear();
            foreach(Infraccion i in lista)
            {
                ListViewItem lvi = new ListViewItem(i.Identificador.ToString());
                lvi.SubItems.Add(i.Nombre);
                lvi.SubItems.Add(i.Veces.ToString());
                lvTopInfracciones.Items.Add(lvi);
            }
        }

        private void cargarTopConductores_Click(object sender, EventArgs e)
        {
            int n = int.Parse(nudTopConductores.Text);
            List<Conductor> lista = sistema.TopNconductores(n);
            lvTopConductores.Items.Clear();
            foreach(Conductor c in lista)
            {
                ListViewItem lvi = new ListViewItem(c.DNI);
                lvi.SubItems.Add(c.Nombre);
                lvi.SubItems.Add(c.Apellidos);
                lvi.SubItems.Add(c.Puntos.ToString());
                lvTopConductores.Items.Add(lvi);
            }
        }
    }
}
