namespace inicio.Vendedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.textBox6 = new inicio.Controles.textBoxPersozalizado();
            this.botonPersonalizado2 = new InicioSistema.Controles.botonPersonalizado();
            this.botonPersonalizado1 = new InicioSistema.Controles.botonPersonalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_tipo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lVariable = new System.Windows.Forms.Label();
            this.lTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new InicioSistema.Controles.botonPersonalizado();
            this.BtnListar = new InicioSistema.Controles.botonPersonalizado();
            this.btnEliminar = new InicioSistema.Controles.botonPersonalizado();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panelBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBusqueda.Location = new System.Drawing.Point(649, 1);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(324, 122);
            this.panelBusqueda.TabIndex = 47;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderColor = System.Drawing.Color.SlateBlue;
            this.textBox6.BorderFocusColor = System.Drawing.Color.Sienna;
            this.textBox6.BorderSize = 2;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.DimGray;
            this.textBox6.Location = new System.Drawing.Point(17, 33);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multilinie = false;
            this.textBox6.Name = "textBox6";
            this.textBox6.Padding = new System.Windows.Forms.Padding(7);
            this.textBox6.PassWordChar = false;
            this.textBox6.Size = new System.Drawing.Size(206, 31);
            this.textBox6.TabIndex = 10;
            this.textBox6.Texts = "";
            this.textBox6.UnderLineStyle = false;
            this.textBox6._textChanged += new System.EventHandler(this.textBox6__textChanged);
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
            this.botonPersonalizado2.Location = new System.Drawing.Point(135, 71);
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
            this.botonPersonalizado1.Location = new System.Drawing.Point(19, 71);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(100, 40);
            this.botonPersonalizado1.TabIndex = 8;
            this.botonPersonalizado1.Text = "Buscar";
            this.botonPersonalizado1.textColor = System.Drawing.Color.White;
            this.botonPersonalizado1.UseVisualStyleBackColor = false;
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(32, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.Id_tipo_cliente,
            this.dni,
            this.apellido,
            this.nombre,
            this.sexo,
            this.estado_civil,
            this.telefono,
            this.domicilio,
            this.correo,
            this.fecha_Nacimiento,
            this.estado_vigencia});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.Location = new System.Drawing.Point(33, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Size = new System.Drawing.Size(924, 253);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.DataPropertyName = "Id_Cliente";
            this.Id_Cliente.HeaderText = "Id_Cliente";
            this.Id_Cliente.Name = "Id_Cliente";
            // 
            // Id_tipo_cliente
            // 
            this.Id_tipo_cliente.DataPropertyName = "Id_tipo_cliente";
            this.Id_tipo_cliente.HeaderText = "Id_tipo_cliente";
            this.Id_tipo_cliente.Name = "Id_tipo_cliente";
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "SExo";
            this.sexo.Name = "sexo";
            // 
            // estado_civil
            // 
            this.estado_civil.DataPropertyName = "estado_civil";
            this.estado_civil.HeaderText = "Estado Civil";
            this.estado_civil.Name = "estado_civil";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Tel";
            this.telefono.Name = "telefono";
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // fecha_Nacimiento
            // 
            this.fecha_Nacimiento.DataPropertyName = "fecha_Nacimiento";
            this.fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            this.fecha_Nacimiento.Name = "fecha_Nacimiento";
            // 
            // estado_vigencia
            // 
            this.estado_vigencia.DataPropertyName = "estado_vigencia";
            this.estado_vigencia.HeaderText = "EStado Vigencia";
            this.estado_vigencia.Name = "estado_vigencia";
            // 
            // lVariable
            // 
            this.lVariable.AutoSize = true;
            this.lVariable.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVariable.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lVariable.Location = new System.Drawing.Point(115, 125);
            this.lVariable.Name = "lVariable";
            this.lVariable.Size = new System.Drawing.Size(175, 23);
            this.lVariable.TabIndex = 56;
            this.lVariable.Text = "Activos/Inactivos";
            this.lVariable.Visible = false;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.SlateBlue;
            this.lTitulo.Location = new System.Drawing.Point(32, 162);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(360, 18);
            this.lTitulo.TabIndex = 57;
            this.lTitulo.Text = "Seleccione una fila para Dar de Alta a un Cliente";
            this.lTitulo.Visible = false;
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
            this.btnVolver.Location = new System.Drawing.Point(425, 485);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 40);
            this.btnVolver.TabIndex = 58;
            this.btnVolver.Text = "Volver";
            this.btnVolver.textColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.BtnListar.Location = new System.Drawing.Point(197, 32);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(131, 40);
            this.BtnListar.TabIndex = 54;
            this.BtnListar.Text = "Clientes Activos";
            this.BtnListar.textColor = System.Drawing.Color.White;
            this.BtnListar.UseVisualStyleBackColor = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(423, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 40);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = " Clientes Inactivos";
            this.btnEliminar.textColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(242, 9);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Apellido";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nombre";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DNI";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Inicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1001, 527);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.lVariable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panelBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio3";
            this.Text = "Inicio3";
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private InicioSistema.Controles.botonPersonalizado btnEliminar;
        private System.Windows.Forms.Label label1;
        private InicioSistema.Controles.botonPersonalizado BtnListar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lVariable;
        private System.Windows.Forms.Label lTitulo;
        private InicioSistema.Controles.botonPersonalizado btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_tipo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_vigencia;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}