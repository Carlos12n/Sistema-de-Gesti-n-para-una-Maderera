namespace inicio.Administrador
{
    partial class Inicio3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.lVariable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lTitulo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnListar = new InicioSistema.Controles.botonPersonalizado();
            this.btnEliminar = new InicioSistema.Controles.botonPersonalizado();
            this.botonVolver = new InicioSistema.Controles.botonPersonalizado();
            this.textBox6 = new inicio.Controles.textBoxPersozalizado();
            this.botonPersonalizado2 = new InicioSistema.Controles.botonPersonalizado();
            this.botonPersonalizado1 = new InicioSistema.Controles.botonPersonalizado();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.radioButton3);
            this.panelBusqueda.Controls.Add(this.radioButton2);
            this.panelBusqueda.Controls.Add(this.radioButton1);
            this.panelBusqueda.Controls.Add(this.textBox6);
            this.panelBusqueda.Controls.Add(this.botonPersonalizado2);
            this.panelBusqueda.Controls.Add(this.botonPersonalizado1);
            this.panelBusqueda.Controls.Add(this.label2);
            this.panelBusqueda.Location = new System.Drawing.Point(498, 12);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(427, 122);
            this.panelBusqueda.TabIndex = 47;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(301, 75);
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
            this.radioButton2.Location = new System.Drawing.Point(301, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nombre";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(301, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DNI";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar por Nombre o Apellido";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView.Location = new System.Drawing.Point(3, 140);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Size = new System.Drawing.Size(955, 253);
            this.dataGridView.TabIndex = 57;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
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
            // lVariable
            // 
            this.lVariable.AutoSize = true;
            this.lVariable.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVariable.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lVariable.Location = new System.Drawing.Point(81, 87);
            this.lVariable.Name = "lVariable";
            this.lVariable.Size = new System.Drawing.Size(175, 23);
            this.lVariable.TabIndex = 61;
            this.lVariable.Text = "Activos/Inactivos";
            this.lVariable.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(-2, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "Usuarios";
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.SlateBlue;
            this.lTitulo.Location = new System.Drawing.Point(0, 119);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(366, 18);
            this.lTitulo.TabIndex = 62;
            this.lTitulo.Text = "Seleccione una fila para Dar de Alta a un Usuario";
            this.lTitulo.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnListar
            // 
            this.BtnListar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnListar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnListar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnListar.BorderRadius = 40;
            this.BtnListar.BorderSize = 0;
            this.BtnListar.FlatAppearance.BorderSize = 0;
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.ForeColor = System.Drawing.Color.White;
            this.BtnListar.Location = new System.Drawing.Point(95, 7);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(161, 40);
            this.BtnListar.TabIndex = 60;
            this.BtnListar.Text = "Usuarios Activos";
            this.BtnListar.textColor = System.Drawing.Color.White;
            this.BtnListar.UseVisualStyleBackColor = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 40;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(321, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 40);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = " Usuarios Inactivos";
            this.btnEliminar.textColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonVolver.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonVolver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonVolver.BorderRadius = 40;
            this.botonVolver.BorderSize = 0;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.White;
            this.botonVolver.Location = new System.Drawing.Point(376, 511);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(150, 40);
            this.botonVolver.TabIndex = 55;
            this.botonVolver.Text = "Volver";
            this.botonVolver.textColor = System.Drawing.Color.White;
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox6.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBox6.BorderSize = 2;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.DimGray;
            this.textBox6.Location = new System.Drawing.Point(15, 29);
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
            this.botonPersonalizado2.Location = new System.Drawing.Point(142, 67);
            this.botonPersonalizado2.Name = "botonPersonalizado2";
            this.botonPersonalizado2.Size = new System.Drawing.Size(100, 40);
            this.botonPersonalizado2.TabIndex = 9;
            this.botonPersonalizado2.Text = "Cancelar";
            this.botonPersonalizado2.textColor = System.Drawing.Color.White;
            this.botonPersonalizado2.UseVisualStyleBackColor = false;
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
            this.botonPersonalizado1.Location = new System.Drawing.Point(26, 67);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(100, 40);
            this.botonPersonalizado1.TabIndex = 8;
            this.botonPersonalizado1.Text = "Buscar";
            this.botonPersonalizado1.textColor = System.Drawing.Color.White;
            this.botonPersonalizado1.UseVisualStyleBackColor = false;
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click);
            // 
            // Inicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1001, 527);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.lVariable);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.panelBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio3";
            this.Text = "Inicio3";
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelBusqueda;
        private Controles.textBoxPersozalizado textBox6;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado2;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado1;
        private System.Windows.Forms.Label label2;
        private InicioSistema.Controles.botonPersonalizado botonVolver;
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
        private System.Windows.Forms.Label lVariable;
        private InicioSistema.Controles.botonPersonalizado BtnListar;
        private System.Windows.Forms.Label label3;
        private InicioSistema.Controles.botonPersonalizado btnEliminar;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}