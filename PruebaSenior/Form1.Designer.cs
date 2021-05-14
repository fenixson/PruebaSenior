
namespace PruebaSenior
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LlenarDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvInfracciones = new System.Windows.Forms.ListView();
            this.Fecha = new System.Windows.Forms.ColumnHeader();
            this.Hora = new System.Windows.Forms.ColumnHeader();
            this.Detalles = new System.Windows.Forms.ColumnHeader();
            this.label11 = new System.Windows.Forms.Label();
            this.tbConductorPuntos = new System.Windows.Forms.TextBox();
            this.tbConductorApellidos = new System.Windows.Forms.TextBox();
            this.tbConductorDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbConductorNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbConductores = new System.Windows.Forms.ComboBox();
            this.GuardarConductor = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbVehiculoInfraccion = new System.Windows.Forms.ComboBox();
            this.RegistrarInfraccion = new System.Windows.Forms.Button();
            this.tbVehiculoConductor = new System.Windows.Forms.TextBox();
            this.cbVehiculoConductor = new System.Windows.Forms.ComboBox();
            this.tbVehiculoModelo = new System.Windows.Forms.TextBox();
            this.tbVehiculoMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVehiculoMarca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbVehiculoMatricula = new System.Windows.Forms.ComboBox();
            this.GuardarVehiculo = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nudInfraccionPuntos = new System.Windows.Forms.NumericUpDown();
            this.rtbInfraccionDescripcion = new System.Windows.Forms.RichTextBox();
            this.tbInfraccionNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInfraccion = new System.Windows.Forms.ComboBox();
            this.GuardarInfraccion = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvTopInfracciones = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Veces = new System.Windows.Forms.ColumnHeader();
            this.CargarTopInfraciones = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.nudTopConductores = new System.Windows.Forms.NumericUpDown();
            this.lvTopConductores = new System.Windows.Forms.ListView();
            this.Dni = new System.Windows.Forms.ColumnHeader();
            this.Nombree = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.cargarTopConductores = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInfraccionPuntos)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopConductores)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDown = this.contextMenuStrip1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Inicio";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LlenarDatos});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.OwnerItem = this.toolStripMenuItem1;
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.LlenarDatosPruebas);
            // 
            // LlenarDatos
            // 
            this.LlenarDatos.Name = "LlenarDatos";
            this.LlenarDatos.Size = new System.Drawing.Size(138, 22);
            this.LlenarDatos.Text = "Llenar datos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 499);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.sidConductores);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvInfracciones);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tbConductorPuntos);
            this.tabPage1.Controls.Add(this.tbConductorApellidos);
            this.tabPage1.Controls.Add(this.tbConductorDNI);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbConductorNombre);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblPuntos);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbConductores);
            this.tabPage1.Controls.Add(this.GuardarConductor);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conductores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvInfracciones
            // 
            this.lvInfracciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Fecha,
            this.Hora,
            this.Detalles});
            this.lvInfracciones.HideSelection = false;
            this.lvInfracciones.Location = new System.Drawing.Point(26, 231);
            this.lvInfracciones.Name = "lvInfracciones";
            this.lvInfracciones.Size = new System.Drawing.Size(570, 232);
            this.lvInfracciones.TabIndex = 23;
            this.lvInfracciones.UseCompatibleStateImageBehavior = false;
            this.lvInfracciones.View = System.Windows.Forms.View.Details;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.Width = 100;
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            this.Hora.Width = 100;
            // 
            // Detalles
            // 
            this.Detalles.Text = "Detalles";
            this.Detalles.Width = 360;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Infracciones: ";
            // 
            // tbConductorPuntos
            // 
            this.tbConductorPuntos.Location = new System.Drawing.Point(107, 171);
            this.tbConductorPuntos.Name = "tbConductorPuntos";
            this.tbConductorPuntos.Size = new System.Drawing.Size(489, 23);
            this.tbConductorPuntos.TabIndex = 20;
            // 
            // tbConductorApellidos
            // 
            this.tbConductorApellidos.Location = new System.Drawing.Point(107, 138);
            this.tbConductorApellidos.Name = "tbConductorApellidos";
            this.tbConductorApellidos.Size = new System.Drawing.Size(489, 23);
            this.tbConductorApellidos.TabIndex = 19;
            // 
            // tbConductorDNI
            // 
            this.tbConductorDNI.Location = new System.Drawing.Point(107, 68);
            this.tbConductorDNI.Name = "tbConductorDNI";
            this.tbConductorDNI.Size = new System.Drawing.Size(489, 23);
            this.tbConductorDNI.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "DNI/NIF: ";
            // 
            // tbConductorNombre
            // 
            this.tbConductorNombre.Location = new System.Drawing.Point(107, 106);
            this.tbConductorNombre.Name = "tbConductorNombre";
            this.tbConductorNombre.Size = new System.Drawing.Size(489, 23);
            this.tbConductorNombre.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellidos: ";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(51, 174);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(50, 15);
            this.lblPuntos.TabIndex = 12;
            this.lblPuntos.Text = "Puntos: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre: ";
            // 
            // cbConductores
            // 
            this.cbConductores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConductores.FormattingEnabled = true;
            this.cbConductores.Items.AddRange(new object[] {
            "Nuevo"});
            this.cbConductores.Location = new System.Drawing.Point(107, 28);
            this.cbConductores.Name = "cbConductores";
            this.cbConductores.Size = new System.Drawing.Size(489, 23);
            this.cbConductores.TabIndex = 10;
            this.cbConductores.SelectedIndexChanged += new System.EventHandler(this.sidConductores);
            // 
            // GuardarConductor
            // 
            this.GuardarConductor.Location = new System.Drawing.Point(26, 27);
            this.GuardarConductor.Name = "GuardarConductor";
            this.GuardarConductor.Size = new System.Drawing.Size(75, 23);
            this.GuardarConductor.TabIndex = 9;
            this.GuardarConductor.Text = "Aceptar";
            this.GuardarConductor.UseVisualStyleBackColor = true;
            this.GuardarConductor.Click += new System.EventHandler(this.GuardarConductor_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbVehiculoInfraccion);
            this.tabPage2.Controls.Add(this.RegistrarInfraccion);
            this.tabPage2.Controls.Add(this.tbVehiculoConductor);
            this.tabPage2.Controls.Add(this.cbVehiculoConductor);
            this.tabPage2.Controls.Add(this.tbVehiculoModelo);
            this.tabPage2.Controls.Add(this.tbVehiculoMatricula);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbVehiculoMarca);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cbVehiculoMatricula);
            this.tabPage2.Controls.Add(this.GuardarVehiculo);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehículos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbVehiculoInfraccion
            // 
            this.cbVehiculoInfraccion.FormattingEnabled = true;
            this.cbVehiculoInfraccion.Location = new System.Drawing.Point(152, 261);
            this.cbVehiculoInfraccion.Name = "cbVehiculoInfraccion";
            this.cbVehiculoInfraccion.Size = new System.Drawing.Size(442, 23);
            this.cbVehiculoInfraccion.TabIndex = 33;
            // 
            // RegistrarInfraccion
            // 
            this.RegistrarInfraccion.Location = new System.Drawing.Point(24, 257);
            this.RegistrarInfraccion.Name = "RegistrarInfraccion";
            this.RegistrarInfraccion.Size = new System.Drawing.Size(122, 29);
            this.RegistrarInfraccion.TabIndex = 32;
            this.RegistrarInfraccion.Text = "Registrar Infraccion";
            this.RegistrarInfraccion.UseVisualStyleBackColor = true;
            this.RegistrarInfraccion.Click += new System.EventHandler(this.RegistrarInfraccion_Click);
            // 
            // tbVehiculoConductor
            // 
            this.tbVehiculoConductor.Location = new System.Drawing.Point(105, 174);
            this.tbVehiculoConductor.Name = "tbVehiculoConductor";
            this.tbVehiculoConductor.Size = new System.Drawing.Size(489, 23);
            this.tbVehiculoConductor.TabIndex = 31;
            // 
            // cbVehiculoConductor
            // 
            this.cbVehiculoConductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculoConductor.FormattingEnabled = true;
            this.cbVehiculoConductor.Location = new System.Drawing.Point(105, 174);
            this.cbVehiculoConductor.Name = "cbVehiculoConductor";
            this.cbVehiculoConductor.Size = new System.Drawing.Size(489, 23);
            this.cbVehiculoConductor.TabIndex = 30;
            // 
            // tbVehiculoModelo
            // 
            this.tbVehiculoModelo.Location = new System.Drawing.Point(105, 141);
            this.tbVehiculoModelo.Name = "tbVehiculoModelo";
            this.tbVehiculoModelo.Size = new System.Drawing.Size(489, 23);
            this.tbVehiculoModelo.TabIndex = 29;
            // 
            // tbVehiculoMatricula
            // 
            this.tbVehiculoMatricula.Location = new System.Drawing.Point(105, 71);
            this.tbVehiculoMatricula.Name = "tbVehiculoMatricula";
            this.tbVehiculoMatricula.Size = new System.Drawing.Size(489, 23);
            this.tbVehiculoMatricula.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Matricula: ";
            // 
            // tbVehiculoMarca
            // 
            this.tbVehiculoMarca.Location = new System.Drawing.Point(105, 109);
            this.tbVehiculoMarca.Name = "tbVehiculoMarca";
            this.tbVehiculoMarca.Size = new System.Drawing.Size(489, 23);
            this.tbVehiculoMarca.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Modelo: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Conductor: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Marca: ";
            // 
            // cbVehiculoMatricula
            // 
            this.cbVehiculoMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculoMatricula.FormattingEnabled = true;
            this.cbVehiculoMatricula.Items.AddRange(new object[] {
            "Nuevo"});
            this.cbVehiculoMatricula.Location = new System.Drawing.Point(105, 31);
            this.cbVehiculoMatricula.Name = "cbVehiculoMatricula";
            this.cbVehiculoMatricula.Size = new System.Drawing.Size(489, 23);
            this.cbVehiculoMatricula.TabIndex = 22;
            this.cbVehiculoMatricula.SelectedIndexChanged += new System.EventHandler(this.sidVehiculo);
            // 
            // GuardarVehiculo
            // 
            this.GuardarVehiculo.Location = new System.Drawing.Point(24, 30);
            this.GuardarVehiculo.Name = "GuardarVehiculo";
            this.GuardarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.GuardarVehiculo.TabIndex = 21;
            this.GuardarVehiculo.Text = "Aceptar";
            this.GuardarVehiculo.UseVisualStyleBackColor = true;
            this.GuardarVehiculo.Click += new System.EventHandler(this.GuardarVehiculo_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nudInfraccionPuntos);
            this.tabPage3.Controls.Add(this.rtbInfraccionDescripcion);
            this.tabPage3.Controls.Add(this.tbInfraccionNombre);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.cbInfraccion);
            this.tabPage3.Controls.Add(this.GuardarInfraccion);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(625, 471);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Infracciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nudInfraccionPuntos
            // 
            this.nudInfraccionPuntos.Location = new System.Drawing.Point(105, 106);
            this.nudInfraccionPuntos.Name = "nudInfraccionPuntos";
            this.nudInfraccionPuntos.Size = new System.Drawing.Size(489, 23);
            this.nudInfraccionPuntos.TabIndex = 8;
            // 
            // rtbInfraccionDescripcion
            // 
            this.rtbInfraccionDescripcion.Location = new System.Drawing.Point(105, 137);
            this.rtbInfraccionDescripcion.Name = "rtbInfraccionDescripcion";
            this.rtbInfraccionDescripcion.Size = new System.Drawing.Size(489, 146);
            this.rtbInfraccionDescripcion.TabIndex = 7;
            this.rtbInfraccionDescripcion.Text = "";
            // 
            // tbInfraccionNombre
            // 
            this.tbInfraccionNombre.Location = new System.Drawing.Point(105, 74);
            this.tbInfraccionNombre.Name = "tbInfraccionNombre";
            this.tbInfraccionNombre.Size = new System.Drawing.Size(489, 23);
            this.tbInfraccionNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puntos: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre: ";
            // 
            // cbInfraccion
            // 
            this.cbInfraccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInfraccion.FormattingEnabled = true;
            this.cbInfraccion.Items.AddRange(new object[] {
            "Nuevo"});
            this.cbInfraccion.Location = new System.Drawing.Point(105, 27);
            this.cbInfraccion.Name = "cbInfraccion";
            this.cbInfraccion.Size = new System.Drawing.Size(489, 23);
            this.cbInfraccion.TabIndex = 1;
            this.cbInfraccion.SelectedIndexChanged += new System.EventHandler(this.sidInfraccion);
            // 
            // GuardarInfraccion
            // 
            this.GuardarInfraccion.Location = new System.Drawing.Point(24, 26);
            this.GuardarInfraccion.Name = "GuardarInfraccion";
            this.GuardarInfraccion.Size = new System.Drawing.Size(75, 23);
            this.GuardarInfraccion.TabIndex = 0;
            this.GuardarInfraccion.Text = "Aceptar";
            this.GuardarInfraccion.UseVisualStyleBackColor = true;
            this.GuardarInfraccion.Click += new System.EventHandler(this.GuardarInfraccion_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvTopInfracciones);
            this.tabPage4.Controls.Add(this.CargarTopInfraciones);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(625, 471);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Top 5 Infracciones";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvTopInfracciones
            // 
            this.lvTopInfracciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre,
            this.Veces});
            this.lvTopInfracciones.HideSelection = false;
            this.lvTopInfracciones.Location = new System.Drawing.Point(8, 48);
            this.lvTopInfracciones.Name = "lvTopInfracciones";
            this.lvTopInfracciones.Size = new System.Drawing.Size(609, 415);
            this.lvTopInfracciones.TabIndex = 1;
            this.lvTopInfracciones.UseCompatibleStateImageBehavior = false;
            this.lvTopInfracciones.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 100;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 400;
            // 
            // Veces
            // 
            this.Veces.Text = "Veces";
            this.Veces.Width = 100;
            // 
            // CargarTopInfraciones
            // 
            this.CargarTopInfraciones.Location = new System.Drawing.Point(8, 19);
            this.CargarTopInfraciones.Name = "CargarTopInfraciones";
            this.CargarTopInfraciones.Size = new System.Drawing.Size(75, 23);
            this.CargarTopInfraciones.TabIndex = 0;
            this.CargarTopInfraciones.Text = "Cargar";
            this.CargarTopInfraciones.UseVisualStyleBackColor = true;
            this.CargarTopInfraciones.Click += new System.EventHandler(this.CargarTopInfraciones_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.nudTopConductores);
            this.tabPage5.Controls.Add(this.lvTopConductores);
            this.tabPage5.Controls.Add(this.cargarTopConductores);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(625, 471);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Top N conductores";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // nudTopConductores
            // 
            this.nudTopConductores.Location = new System.Drawing.Point(89, 12);
            this.nudTopConductores.Name = "nudTopConductores";
            this.nudTopConductores.Size = new System.Drawing.Size(528, 23);
            this.nudTopConductores.TabIndex = 4;
            // 
            // lvTopConductores
            // 
            this.lvTopConductores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dni,
            this.Nombree,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTopConductores.HideSelection = false;
            this.lvTopConductores.Location = new System.Drawing.Point(8, 42);
            this.lvTopConductores.Name = "lvTopConductores";
            this.lvTopConductores.Size = new System.Drawing.Size(609, 415);
            this.lvTopConductores.TabIndex = 3;
            this.lvTopConductores.UseCompatibleStateImageBehavior = false;
            this.lvTopConductores.View = System.Windows.Forms.View.Details;
            // 
            // Dni
            // 
            this.Dni.Text = "Dni/Nif";
            this.Dni.Width = 150;
            // 
            // Nombree
            // 
            this.Nombree.Text = "Nombre";
            this.Nombree.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellidos";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "puntos";
            this.columnHeader4.Width = 100;
            // 
            // cargarTopConductores
            // 
            this.cargarTopConductores.Location = new System.Drawing.Point(8, 12);
            this.cargarTopConductores.Name = "cargarTopConductores";
            this.cargarTopConductores.Size = new System.Drawing.Size(75, 24);
            this.cargarTopConductores.TabIndex = 2;
            this.cargarTopConductores.Text = "Cargar";
            this.cargarTopConductores.UseVisualStyleBackColor = true;
            this.cargarTopConductores.Click += new System.EventHandler(this.cargarTopConductores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 523);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInfraccionPuntos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTopConductores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LlenarDatos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbInfraccion;
        private System.Windows.Forms.Button GuardarInfraccion;
        private System.Windows.Forms.RichTextBox rtbInfraccionDescripcion;
        private System.Windows.Forms.TextBox tbInfraccionNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudInfraccionPuntos;
        private System.Windows.Forms.TextBox tbConductorNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbConductores;
        private System.Windows.Forms.Button GuardarConductor;
        private System.Windows.Forms.TextBox tbConductorPuntos;
        private System.Windows.Forms.TextBox tbConductorApellidos;
        private System.Windows.Forms.TextBox tbConductorDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbVehiculoConductor;
        private System.Windows.Forms.TextBox tbVehiculoModelo;
        private System.Windows.Forms.TextBox tbVehiculoMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVehiculoMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbVehiculoMatricula;
        private System.Windows.Forms.Button GuardarVehiculo;
        private System.Windows.Forms.TextBox tbVehiculoConductor;
        private System.Windows.Forms.ComboBox cbVehiculoInfraccion;
        private System.Windows.Forms.Button RegistrarInfraccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvInfracciones;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ColumnHeader Detalles;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvTopInfracciones;
        private System.Windows.Forms.Button CargarTopInfraciones;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.NumericUpDown nudTopConductores;
        private System.Windows.Forms.ListView lvTopConductores;
        private System.Windows.Forms.Button cargarTopConductores;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Veces;
        private System.Windows.Forms.ColumnHeader Dni;
        private System.Windows.Forms.ColumnHeader Nombree;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

