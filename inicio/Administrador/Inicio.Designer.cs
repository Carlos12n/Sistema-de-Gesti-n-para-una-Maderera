namespace inicio.Administrador
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4EstadoCivil = new System.Windows.Forms.ComboBox();
            this.comboBox3Estado = new System.Windows.Forms.ComboBox();
            this.comboBox2Rol = new System.Windows.Forms.ComboBox();
            this.comboBox1Genero = new System.Windows.Forms.ComboBox();
            this.textBox10DNI = new System.Windows.Forms.TextBox();
            this.textBox8Telefono = new System.Windows.Forms.TextBox();
            this.textBox6Direccion = new System.Windows.Forms.TextBox();
            this.textBox5Correo = new System.Windows.Forms.TextBox();
            this.textBox4Pass = new System.Windows.Forms.TextBox();
            this.textBox3NombreUsuario = new System.Windows.Forms.TextBox();
            this.textBox2Apellido = new System.Windows.Forms.TextBox();
            this.textBox1Nombre = new System.Windows.Forms.TextBox();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelEstadoCivil = new System.Windows.Forms.Label();
            this.labelEstadoVigencia = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelApelido = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_rol_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new inicio.Controles.textBoxPersozalizado();
            this.botonPersonalizado2 = new InicioSistema.Controles.botonPersonalizado();
            this.botonPersonalizado1 = new InicioSistema.Controles.botonPersonalizado();
            this.btnEliminaar = new InicioSistema.Controles.botonPersonalizado();
            this.btnGuardar = new InicioSistema.Controles.botonPersonalizado();
            this.botonPersonalizado3 = new InicioSistema.Controles.botonPersonalizado();
            this.btnVolver = new InicioSistema.Controles.botonPersonalizado();
            this.panelDatos.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panelDatos
            // 
            this.panelDatos.CausesValidation = false;
            this.panelDatos.Controls.Add(this.panelBusqueda);
            this.panelDatos.Controls.Add(this.dateTimePicker1);
            this.panelDatos.Controls.Add(this.btnEliminaar);
            this.panelDatos.Controls.Add(this.btnGuardar);
            this.panelDatos.Controls.Add(this.comboBox4EstadoCivil);
            this.panelDatos.Controls.Add(this.comboBox3Estado);
            this.panelDatos.Controls.Add(this.comboBox2Rol);
            this.panelDatos.Controls.Add(this.comboBox1Genero);
            this.panelDatos.Controls.Add(this.textBox10DNI);
            this.panelDatos.Controls.Add(this.textBox8Telefono);
            this.panelDatos.Controls.Add(this.textBox6Direccion);
            this.panelDatos.Controls.Add(this.textBox5Correo);
            this.panelDatos.Controls.Add(this.textBox4Pass);
            this.panelDatos.Controls.Add(this.textBox3NombreUsuario);
            this.panelDatos.Controls.Add(this.textBox2Apellido);
            this.panelDatos.Controls.Add(this.textBox1Nombre);
            this.panelDatos.Controls.Add(this.labelFechaNacimiento);
            this.panelDatos.Controls.Add(this.labelEstadoCivil);
            this.panelDatos.Controls.Add(this.labelEstadoVigencia);
            this.panelDatos.Controls.Add(this.labelGenero);
            this.panelDatos.Controls.Add(this.labelDNI);
            this.panelDatos.Controls.Add(this.botonPersonalizado3);
            this.panelDatos.Controls.Add(this.labelDireccion);
            this.panelDatos.Controls.Add(this.labelCorreo);
            this.panelDatos.Controls.Add(this.labelTel);
            this.panelDatos.Controls.Add(this.labelPass);
            this.panelDatos.Controls.Add(this.labelNombreUsuario);
            this.panelDatos.Controls.Add(this.labelApelido);
            this.panelDatos.Controls.Add(this.labelRol);
            this.panelDatos.Controls.Add(this.labelNombre);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatos.Location = new System.Drawing.Point(0, 0);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1001, 285);
            this.panelDatos.TabIndex = 49;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.radioButton3);
            this.panelBusqueda.Controls.Add(this.radioButton2);
            this.panelBusqueda.Controls.Add(this.radioButton1);
            this.panelBusqueda.Controls.Add(this.textBox6);
            this.panelBusqueda.Controls.Add(this.botonPersonalizado2);
            this.panelBusqueda.Controls.Add(this.botonPersonalizado1);
            this.panelBusqueda.Controls.Add(this.label3);
            this.panelBusqueda.Location = new System.Drawing.Point(648, 3);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(344, 178);
            this.panelBusqueda.TabIndex = 89;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(239, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Apellido";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(171, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nombre";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(121, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DNI";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar por:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 88;
            this.dateTimePicker1.Value = new System.DateTime(2000, 10, 27, 16, 22, 0, 0);
            // 
            // comboBox4EstadoCivil
            // 
            this.comboBox4EstadoCivil.FormattingEnabled = true;
            this.comboBox4EstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.comboBox4EstadoCivil.Location = new System.Drawing.Point(519, 90);
            this.comboBox4EstadoCivil.Name = "comboBox4EstadoCivil";
            this.comboBox4EstadoCivil.Size = new System.Drawing.Size(109, 21);
            this.comboBox4EstadoCivil.TabIndex = 85;
            this.comboBox4EstadoCivil.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox4EstadoCivil_Validating);
            // 
            // comboBox3Estado
            // 
            this.comboBox3Estado.FormattingEnabled = true;
            this.comboBox3Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox3Estado.Location = new System.Drawing.Point(190, 148);
            this.comboBox3Estado.Name = "comboBox3Estado";
            this.comboBox3Estado.Size = new System.Drawing.Size(133, 21);
            this.comboBox3Estado.TabIndex = 84;
            this.comboBox3Estado.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox3Estado_Validating);
            // 
            // comboBox2Rol
            // 
            this.comboBox2Rol.FormattingEnabled = true;
            this.comboBox2Rol.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Vendedor"});
            this.comboBox2Rol.Location = new System.Drawing.Point(519, 30);
            this.comboBox2Rol.Name = "comboBox2Rol";
            this.comboBox2Rol.Size = new System.Drawing.Size(123, 21);
            this.comboBox2Rol.TabIndex = 83;
            this.comboBox2Rol.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox2Rol_Validating);
            // 
            // comboBox1Genero
            // 
            this.comboBox1Genero.FormattingEnabled = true;
            this.comboBox1Genero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.comboBox1Genero.Location = new System.Drawing.Point(192, 204);
            this.comboBox1Genero.Name = "comboBox1Genero";
            this.comboBox1Genero.Size = new System.Drawing.Size(108, 21);
            this.comboBox1Genero.TabIndex = 82;
            this.comboBox1Genero.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1Genero_Validating);
            // 
            // textBox10DNI
            // 
            this.textBox10DNI.Location = new System.Drawing.Point(369, 31);
            this.textBox10DNI.MaxLength = 8;
            this.textBox10DNI.Name = "textBox10DNI";
            this.textBox10DNI.Size = new System.Drawing.Size(126, 20);
            this.textBox10DNI.TabIndex = 81;
            this.textBox10DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10DNI_KeyPress);
            this.textBox10DNI.Validating += new System.ComponentModel.CancelEventHandler(this.textBox10DNI_Validating);
            // 
            // textBox8Telefono
            // 
            this.textBox8Telefono.Location = new System.Drawing.Point(15, 90);
            this.textBox8Telefono.Name = "textBox8Telefono";
            this.textBox8Telefono.Size = new System.Drawing.Size(160, 20);
            this.textBox8Telefono.TabIndex = 79;
            this.textBox8Telefono.Text = "Ej:3644472830";
            this.textBox8Telefono.Validating += new System.ComponentModel.CancelEventHandler(this.textBox8Telefono_Validating);
            // 
            // textBox6Direccion
            // 
            this.textBox6Direccion.Location = new System.Drawing.Point(15, 204);
            this.textBox6Direccion.Name = "textBox6Direccion";
            this.textBox6Direccion.Size = new System.Drawing.Size(160, 20);
            this.textBox6Direccion.TabIndex = 77;
            this.textBox6Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6Direccion_KeyPress);
            this.textBox6Direccion.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6Direccion_Validating);
            // 
            // textBox5Correo
            // 
            this.textBox5Correo.Location = new System.Drawing.Point(15, 148);
            this.textBox5Correo.Name = "textBox5Correo";
            this.textBox5Correo.Size = new System.Drawing.Size(160, 20);
            this.textBox5Correo.TabIndex = 76;
            this.textBox5Correo.Leave += new System.EventHandler(this.textCorreo);
            this.textBox5Correo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5Correo_Validating);
            // 
            // textBox4Pass
            // 
            this.textBox4Pass.Location = new System.Drawing.Point(369, 90);
            this.textBox4Pass.Name = "textBox4Pass";
            this.textBox4Pass.Size = new System.Drawing.Size(131, 20);
            this.textBox4Pass.TabIndex = 75;
            this.textBox4Pass.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4Pass_Validating);
            // 
            // textBox3NombreUsuario
            // 
            this.textBox3NombreUsuario.Location = new System.Drawing.Point(190, 90);
            this.textBox3NombreUsuario.Name = "textBox3NombreUsuario";
            this.textBox3NombreUsuario.Size = new System.Drawing.Size(143, 20);
            this.textBox3NombreUsuario.TabIndex = 74;
            this.textBox3NombreUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3NombreUsuario_Validating);
            // 
            // textBox2Apellido
            // 
            this.textBox2Apellido.Location = new System.Drawing.Point(191, 35);
            this.textBox2Apellido.Name = "textBox2Apellido";
            this.textBox2Apellido.Size = new System.Drawing.Size(160, 20);
            this.textBox2Apellido.TabIndex = 73;
            this.textBox2Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Apellido_KeyPress);
            this.textBox2Apellido.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2Apellido_Validating);
            // 
            // textBox1Nombre
            // 
            this.textBox1Nombre.Location = new System.Drawing.Point(15, 34);
            this.textBox1Nombre.Name = "textBox1Nombre";
            this.textBox1Nombre.Size = new System.Drawing.Size(160, 20);
            this.textBox1Nombre.TabIndex = 72;
            this.textBox1Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Nombre_KeyPress);
            this.textBox1Nombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1Nombre_Validating);
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNacimiento.Location = new System.Drawing.Point(366, 127);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(160, 18);
            this.labelFechaNacimiento.TabIndex = 71;
            this.labelFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // labelEstadoCivil
            // 
            this.labelEstadoCivil.AutoSize = true;
            this.labelEstadoCivil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoCivil.Location = new System.Drawing.Point(516, 69);
            this.labelEstadoCivil.Name = "labelEstadoCivil";
            this.labelEstadoCivil.Size = new System.Drawing.Size(112, 18);
            this.labelEstadoCivil.TabIndex = 69;
            this.labelEstadoCivil.Text = "Estado Civil:";
            // 
            // labelEstadoVigencia
            // 
            this.labelEstadoVigencia.AutoSize = true;
            this.labelEstadoVigencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoVigencia.Location = new System.Drawing.Point(187, 127);
            this.labelEstadoVigencia.Name = "labelEstadoVigencia";
            this.labelEstadoVigencia.Size = new System.Drawing.Size(71, 18);
            this.labelEstadoVigencia.TabIndex = 66;
            this.labelEstadoVigencia.Text = "Estado:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(189, 183);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(73, 18);
            this.labelGenero.TabIndex = 64;
            this.labelGenero.Text = "Genero:";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.Location = new System.Drawing.Point(366, 9);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(46, 18);
            this.labelDNI.TabIndex = 60;
            this.labelDNI.Text = "DNI:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(12, 183);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(89, 18);
            this.labelDireccion.TabIndex = 57;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(12, 127);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(163, 18);
            this.labelCorreo.TabIndex = 55;
            this.labelCorreo.Text = "Correo Electronico:";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(12, 69);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(84, 18);
            this.labelTel.TabIndex = 53;
            this.labelTel.Text = "Telefono:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(366, 69);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(101, 18);
            this.labelPass.TabIndex = 51;
            this.labelPass.Text = "Contraseña";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.Location = new System.Drawing.Point(187, 69);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(146, 18);
            this.labelNombreUsuario.TabIndex = 50;
            this.labelNombreUsuario.Text = "Nombre Usuario:";
            // 
            // labelApelido
            // 
            this.labelApelido.AutoSize = true;
            this.labelApelido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApelido.Location = new System.Drawing.Point(188, 13);
            this.labelApelido.Name = "labelApelido";
            this.labelApelido.Size = new System.Drawing.Size(74, 18);
            this.labelApelido.TabIndex = 49;
            this.labelApelido.Text = "Apellido";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(516, 9);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(41, 18);
            this.labelRol.TabIndex = 48;
            this.labelRol.Text = "Rol:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(12, 13);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(78, 18);
            this.labelNombre.TabIndex = 47;
            this.labelNombre.Text = "Nombre:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Seleccione una fila para Modificar o Eliminar";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_usuario,
            this.Id_rol_usuario,
            this.apellido,
            this.nombre,
            this.nombre_usuario,
            this.pass,
            this.estado_vigencia,
            this.sexo,
            this.estado_civil,
            this.telefono,
            this.domicilio,
            this.correo,
            this.dni,
            this.fecha_Nacimiento});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView.Location = new System.Drawing.Point(15, 307);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumPurple;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView.Size = new System.Drawing.Size(955, 198);
            this.dataGridView.TabIndex = 56;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // Id_usuario
            // 
            this.Id_usuario.DataPropertyName = "Id_usuario";
            this.Id_usuario.HeaderText = "ID Usuario";
            this.Id_usuario.Name = "Id_usuario";
            this.Id_usuario.ReadOnly = true;
            // 
            // Id_rol_usuario
            // 
            this.Id_rol_usuario.DataPropertyName = "Id_rol_usuario";
            this.Id_rol_usuario.HeaderText = "ID Rol Usuario";
            this.Id_rol_usuario.Name = "Id_rol_usuario";
            this.Id_rol_usuario.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.DataPropertyName = "nombre_usuario";
            this.nombre_usuario.HeaderText = "Nombre Usuario";
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Contraseña";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            // 
            // estado_vigencia
            // 
            this.estado_vigencia.DataPropertyName = "estado_vigencia";
            this.estado_vigencia.HeaderText = "Estado Vigencia";
            this.estado_vigencia.Name = "estado_vigencia";
            this.estado_vigencia.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // estado_civil
            // 
            this.estado_civil.DataPropertyName = "estado_civil";
            this.estado_civil.HeaderText = "Estado Civil";
            this.estado_civil.Name = "estado_civil";
            this.estado_civil.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "pass";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // fecha_Nacimiento
            // 
            this.fecha_Nacimiento.DataPropertyName = "fecha_Nacimiento";
            this.fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            this.fecha_Nacimiento.Name = "fecha_Nacimiento";
            this.fecha_Nacimiento.ReadOnly = true;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox6.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBox6.BorderSize = 2;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.DimGray;
            this.textBox6.Location = new System.Drawing.Point(28, 41);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multilinie = false;
            this.textBox6.Name = "textBox6";
            this.textBox6.Padding = new System.Windows.Forms.Padding(7);
            this.textBox6.PassWordChar = false;
            this.textBox6.Size = new System.Drawing.Size(250, 31);
            this.textBox6.TabIndex = 10;
            this.textBox6.Texts = "";
            this.textBox6.UnderLineStyle = false;
            this.textBox6.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);
            // 
            // botonPersonalizado2
            // 
            this.botonPersonalizado2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado2.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPersonalizado2.BorderRadius = 40;
            this.botonPersonalizado2.BorderSize = 0;
            this.botonPersonalizado2.FlatAppearance.BorderSize = 0;
            this.botonPersonalizado2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalizado2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalizado2.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado2.Location = new System.Drawing.Point(144, 79);
            this.botonPersonalizado2.Name = "botonPersonalizado2";
            this.botonPersonalizado2.Size = new System.Drawing.Size(100, 40);
            this.botonPersonalizado2.TabIndex = 9;
            this.botonPersonalizado2.Text = "Cancelar";
            this.botonPersonalizado2.textColor = System.Drawing.Color.White;
            this.botonPersonalizado2.UseVisualStyleBackColor = false;
            this.botonPersonalizado2.Click += new System.EventHandler(this.botonPersonalizado2_Click);
            // 
            // botonPersonalizado1
            // 
            this.botonPersonalizado1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado1.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPersonalizado1.BorderRadius = 40;
            this.botonPersonalizado1.BorderSize = 0;
            this.botonPersonalizado1.FlatAppearance.BorderSize = 0;
            this.botonPersonalizado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalizado1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalizado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado1.Location = new System.Drawing.Point(28, 79);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(100, 40);
            this.botonPersonalizado1.TabIndex = 8;
            this.botonPersonalizado1.Text = "Buscar";
            this.botonPersonalizado1.textColor = System.Drawing.Color.White;
            this.botonPersonalizado1.UseVisualStyleBackColor = false;
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click);
            // 
            // btnEliminaar
            // 
            this.btnEliminaar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminaar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminaar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminaar.BorderRadius = 40;
            this.btnEliminaar.BorderSize = 0;
            this.btnEliminaar.FlatAppearance.BorderSize = 0;
            this.btnEliminaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaar.ForeColor = System.Drawing.Color.White;
            this.btnEliminaar.Location = new System.Drawing.Point(333, 242);
            this.btnEliminaar.Name = "btnEliminaar";
            this.btnEliminaar.Size = new System.Drawing.Size(134, 40);
            this.btnEliminaar.TabIndex = 87;
            this.btnEliminaar.Text = "Eliminar";
            this.btnEliminaar.textColor = System.Drawing.Color.White;
            this.btnEliminaar.UseVisualStyleBackColor = false;
            this.btnEliminaar.Click += new System.EventHandler(this.btnEliminaar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 40;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(209, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 86;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.textColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // botonPersonalizado3
            // 
            this.botonPersonalizado3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado3.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPersonalizado3.BorderRadius = 40;
            this.botonPersonalizado3.BorderSize = 0;
            this.botonPersonalizado3.FlatAppearance.BorderSize = 0;
            this.botonPersonalizado3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalizado3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalizado3.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado3.Location = new System.Drawing.Point(499, 242);
            this.botonPersonalizado3.Name = "botonPersonalizado3";
            this.botonPersonalizado3.Size = new System.Drawing.Size(100, 40);
            this.botonPersonalizado3.TabIndex = 58;
            this.botonPersonalizado3.Text = "Cancelar";
            this.botonPersonalizado3.textColor = System.Drawing.Color.White;
            this.botonPersonalizado3.UseVisualStyleBackColor = false;
            this.botonPersonalizado3.Click += new System.EventHandler(this.botonPersonalizado3_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolver.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolver.BorderRadius = 40;
            this.btnVolver.BorderSize = 0;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(376, 511);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 40);
            this.btnVolver.TabIndex = 44;
            this.btnVolver.Text = "Volver";
            this.btnVolver.textColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1001, 527);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private InicioSistema.Controles.botonPersonalizado btnVolver;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelApelido;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelNombre;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado3;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelEstadoCivil;
        private System.Windows.Forms.Label labelEstadoVigencia;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox4EstadoCivil;
        private System.Windows.Forms.ComboBox comboBox3Estado;
        private System.Windows.Forms.ComboBox comboBox2Rol;
        private System.Windows.Forms.ComboBox comboBox1Genero;
        private System.Windows.Forms.TextBox textBox10DNI;
        private System.Windows.Forms.TextBox textBox8Telefono;
        private System.Windows.Forms.TextBox textBox6Direccion;
        private System.Windows.Forms.TextBox textBox5Correo;
        private System.Windows.Forms.TextBox textBox4Pass;
        private System.Windows.Forms.TextBox textBox3NombreUsuario;
        private System.Windows.Forms.TextBox textBox2Apellido;
        private System.Windows.Forms.TextBox textBox1Nombre;
        private InicioSistema.Controles.botonPersonalizado btnGuardar;
        private InicioSistema.Controles.botonPersonalizado btnEliminaar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_rol_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_vigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_Nacimiento;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Controles.textBoxPersozalizado textBox6;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado2;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado1;
        private System.Windows.Forms.Label label3;
    }
}