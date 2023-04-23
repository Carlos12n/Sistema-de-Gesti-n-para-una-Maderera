namespace inicio.Administrador
{
    partial class Inicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1Estado = new System.Windows.Forms.ComboBox();
            this.comboBox2TipoMad = new System.Windows.Forms.ComboBox();
            this.textBox1DEscripcion = new System.Windows.Forms.TextBox();
            this.textBox2PrecioVenta = new System.Windows.Forms.TextBox();
            this.textBox3StockActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1StockMinimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1Costo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idMaderas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipoMad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descipcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoVigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelBuscarDescri = new System.Windows.Forms.Label();
            this.textBox6 = new inicio.Controles.textBoxPersozalizado();
            this.botonPersonalizado2 = new InicioSistema.Controles.botonPersonalizado();
            this.botonPersonalizado1 = new InicioSistema.Controles.botonPersonalizado();
            this.btnGuardar = new InicioSistema.Controles.botonPersonalizado();
            this.btnEliminar = new InicioSistema.Controles.botonPersonalizado();
            this.btnCancelar = new InicioSistema.Controles.botonPersonalizado();
            this.btnVolver = new InicioSistema.Controles.botonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 48;
            // 
            // comboBox1Estado
            // 
            this.comboBox1Estado.FormattingEnabled = true;
            this.comboBox1Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox1Estado.Location = new System.Drawing.Point(10, 114);
            this.comboBox1Estado.Name = "comboBox1Estado";
            this.comboBox1Estado.Size = new System.Drawing.Size(150, 21);
            this.comboBox1Estado.TabIndex = 58;
            this.comboBox1Estado.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1Estado_Validating);
            // 
            // comboBox2TipoMad
            // 
            this.comboBox2TipoMad.FormattingEnabled = true;
            this.comboBox2TipoMad.Items.AddRange(new object[] {
            "Tirante",
            "Clavadoras",
            "Tablas",
            "Machimbre",
            "Tablon",
            "Tirantillo",
            "Poste"});
            this.comboBox2TipoMad.Location = new System.Drawing.Point(10, 172);
            this.comboBox2TipoMad.Name = "comboBox2TipoMad";
            this.comboBox2TipoMad.Size = new System.Drawing.Size(150, 21);
            this.comboBox2TipoMad.TabIndex = 59;
            this.comboBox2TipoMad.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox2TipoMad_Validating);
            // 
            // textBox1DEscripcion
            // 
            this.textBox1DEscripcion.Location = new System.Drawing.Point(10, 25);
            this.textBox1DEscripcion.Multiline = true;
            this.textBox1DEscripcion.Name = "textBox1DEscripcion";
            this.textBox1DEscripcion.Size = new System.Drawing.Size(240, 46);
            this.textBox1DEscripcion.TabIndex = 60;
            this.textBox1DEscripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1DEscripcion_KeyPress);
            this.textBox1DEscripcion.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1DEscripcion_Validating);
            // 
            // textBox2PrecioVenta
            // 
            this.textBox2PrecioVenta.Location = new System.Drawing.Point(265, 78);
            this.textBox2PrecioVenta.Name = "textBox2PrecioVenta";
            this.textBox2PrecioVenta.Size = new System.Drawing.Size(113, 20);
            this.textBox2PrecioVenta.TabIndex = 61;
            this.textBox2PrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2PrecioVenta_KeyPress);
            this.textBox2PrecioVenta.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2PrecioVenta_Validating);
            // 
            // textBox3StockActual
            // 
            this.textBox3StockActual.Location = new System.Drawing.Point(265, 122);
            this.textBox3StockActual.Name = "textBox3StockActual";
            this.textBox3StockActual.Size = new System.Drawing.Size(113, 20);
            this.textBox3StockActual.TabIndex = 62;
            this.textBox3StockActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3Stock_KeyPress);
            this.textBox3StockActual.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3Stock_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Estado Vigencia: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tipo Madera:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Precio Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Stock Actual:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 71;
            this.label7.Text = "Stock Mínimo:";
            // 
            // textBox1StockMinimo
            // 
            this.textBox1StockMinimo.Location = new System.Drawing.Point(265, 174);
            this.textBox1StockMinimo.Name = "textBox1StockMinimo";
            this.textBox1StockMinimo.Size = new System.Drawing.Size(113, 20);
            this.textBox1StockMinimo.TabIndex = 70;
            this.textBox1StockMinimo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1StockMinimo_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(262, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 73;
            this.label8.Text = "Precio Costo:";
            // 
            // textBox1Costo
            // 
            this.textBox1Costo.Location = new System.Drawing.Point(265, 26);
            this.textBox1Costo.Name = "textBox1Costo";
            this.textBox1Costo.Size = new System.Drawing.Size(113, 20);
            this.textBox1Costo.TabIndex = 72;
            this.textBox1Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Costo_KeyPress);
            this.textBox1Costo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1Costo_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaderas,
            this.id_tipoMad,
            this.descipcion,
            this.estadoVigencia,
            this.stockActual,
            this.stockMinimo,
            this.precioCosto,
            this.precioVenta});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView.Location = new System.Drawing.Point(1, 280);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumPurple;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.Size = new System.Drawing.Size(988, 210);
            this.dataGridView.TabIndex = 77;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // idMaderas
            // 
            this.idMaderas.DataPropertyName = "idMaderas";
            this.idMaderas.HeaderText = "ID Maderas";
            this.idMaderas.Name = "idMaderas";
            this.idMaderas.ReadOnly = true;
            // 
            // id_tipoMad
            // 
            this.id_tipoMad.DataPropertyName = "id_tipoMad";
            this.id_tipoMad.HeaderText = "ID tipo Madera";
            this.id_tipoMad.Name = "id_tipoMad";
            this.id_tipoMad.ReadOnly = true;
            // 
            // descipcion
            // 
            this.descipcion.DataPropertyName = "descipcion";
            this.descipcion.HeaderText = "Descripción";
            this.descipcion.Name = "descipcion";
            this.descipcion.ReadOnly = true;
            this.descipcion.Width = 200;
            // 
            // estadoVigencia
            // 
            this.estadoVigencia.DataPropertyName = "estadoVigencia";
            this.estadoVigencia.HeaderText = "Estado Vigencia";
            this.estadoVigencia.Name = "estadoVigencia";
            this.estadoVigencia.ReadOnly = true;
            // 
            // stockActual
            // 
            this.stockActual.DataPropertyName = "stockActual";
            this.stockActual.HeaderText = "Stock Actual";
            this.stockActual.Name = "stockActual";
            this.stockActual.ReadOnly = true;
            // 
            // stockMinimo
            // 
            this.stockMinimo.DataPropertyName = "stockMinimo";
            this.stockMinimo.HeaderText = "Stock Minimo";
            this.stockMinimo.Name = "stockMinimo";
            this.stockMinimo.ReadOnly = true;
            // 
            // precioCosto
            // 
            this.precioCosto.DataPropertyName = "precioCosto";
            this.precioCosto.HeaderText = "Precio Costo";
            this.precioCosto.Name = "precioCosto";
            this.precioCosto.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.DataPropertyName = "precioVenta";
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.radioButton1);
            this.panelBusqueda.Controls.Add(this.textBox6);
            this.panelBusqueda.Controls.Add(this.botonPersonalizado2);
            this.panelBusqueda.Controls.Add(this.botonPersonalizado1);
            this.panelBusqueda.Controls.Add(this.labelBuscarDescri);
            this.panelBusqueda.Location = new System.Drawing.Point(690, 7);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(309, 115);
            this.panelBusqueda.TabIndex = 78;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(116, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tipo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelBuscarDescri
            // 
            this.labelBuscarDescri.AutoSize = true;
            this.labelBuscarDescri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarDescri.Location = new System.Drawing.Point(12, 7);
            this.labelBuscarDescri.Name = "labelBuscarDescri";
            this.labelBuscarDescri.Size = new System.Drawing.Size(101, 18);
            this.labelBuscarDescri.TabIndex = 7;
            this.labelBuscarDescri.Text = "Buscar por:";
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
            this.textBox6.Size = new System.Drawing.Size(232, 31);
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
            this.botonPersonalizado2.Location = new System.Drawing.Point(128, 66);
            this.botonPersonalizado2.Name = "botonPersonalizado2";
            this.botonPersonalizado2.Size = new System.Drawing.Size(100, 40);
            this.botonPersonalizado2.TabIndex = 9;
            this.botonPersonalizado2.Text = "Cancelar";
            this.botonPersonalizado2.textColor = System.Drawing.Color.White;
            this.botonPersonalizado2.UseVisualStyleBackColor = false;
            this.botonPersonalizado2.Click += new System.EventHandler(this.botonPersonalizado2_Click_1);
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
            this.botonPersonalizado1.Location = new System.Drawing.Point(12, 66);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(100, 40);
            this.botonPersonalizado1.TabIndex = 8;
            this.botonPersonalizado1.Text = "Buscar";
            this.botonPersonalizado1.textColor = System.Drawing.Color.White;
            this.botonPersonalizado1.UseVisualStyleBackColor = false;
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click_1);
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 33);
            this.btnGuardar.TabIndex = 76;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.textColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(123, 233);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 33);
            this.btnEliminar.TabIndex = 75;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.textColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(247, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 33);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.textColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.botonPersonalizado2_Click);
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
            this.btnVolver.TabIndex = 53;
            this.btnVolver.Text = "Volver";
            this.btnVolver.textColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Inicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1001, 545);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1Costo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1StockMinimo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3StockActual);
            this.Controls.Add(this.textBox2PrecioVenta);
            this.Controls.Add(this.textBox1DEscripcion);
            this.Controls.Add(this.comboBox2TipoMad);
            this.Controls.Add(this.comboBox1Estado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio2";
            this.Text = "Inicio2";
            this.Load += new System.EventHandler(this.Inicio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private InicioSistema.Controles.botonPersonalizado btnVolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1Estado;
        private System.Windows.Forms.ComboBox comboBox2TipoMad;
        private System.Windows.Forms.TextBox textBox1DEscripcion;
        private System.Windows.Forms.TextBox textBox2PrecioVenta;
        private System.Windows.Forms.TextBox textBox3StockActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private InicioSistema.Controles.botonPersonalizado btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1StockMinimo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1Costo;
        private InicioSistema.Controles.botonPersonalizado btnEliminar;
        private InicioSistema.Controles.botonPersonalizado btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelBusqueda;
        private Controles.textBoxPersozalizado textBox6;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado2;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado1;
        private System.Windows.Forms.Label labelBuscarDescri;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaderas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipoMad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descipcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoVigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
    }
}