namespace inicio.Vendedor
{
    partial class Factura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelProductoDetalle = new System.Windows.Forms.Panel();
            this.btnBuscaProd = new InicioSistema.Controles.botonPersonalizado();
            this.lCantidad = new System.Windows.Forms.Label();
            this.textBoxCantidad = new inicio.Controles.textBoxPersozalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new InicioSistema.Controles.botonPersonalizado();
            this.btnAgregar = new InicioSistema.Controles.botonPersonalizado();
            this.textBoxDatoProducto = new inicio.Controles.textBoxPersozalizado();
            this.lTitulo = new System.Windows.Forms.Label();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.lNombreVendFac = new System.Windows.Forms.Label();
            this.lNombreVend = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lClienteNomb = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblTipoFac = new System.Windows.Forms.Label();
            this.lblCantFacNueva = new System.Windows.Forms.Label();
            this.lNumeroFactura = new System.Windows.Forms.Label();
            this.lFormaPago = new System.Windows.Forms.Label();
            this.lTipoFactura = new System.Windows.Forms.Label();
            this.lTipoCliente = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.lFechaFactura = new System.Windows.Forms.Label();
            this.GridDetalle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lPrecioTotal = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lPrecioSubTotal = new System.Windows.Forms.Label();
            this.lSubTotal = new System.Windows.Forms.Label();
            this.panelDatosCab = new System.Windows.Forms.Panel();
            this.lDNICliente = new System.Windows.Forms.Label();
            this.textBoxDni = new inicio.Controles.textBoxPersozalizado();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTipoCliente = new inicio.Controles.textBoxPersozalizado();
            this.comboxTipoFactura = new inicio.Controles.ComboxPersonalizado();
            this.lTipoFac = new System.Windows.Forms.Label();
            this.comboxFormaPago = new inicio.Controles.ComboxPersonalizado();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new InicioSistema.Controles.botonPersonalizado();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCliente = new inicio.Controles.textBoxPersozalizado();
            this.botonConfirmarDatos = new InicioSistema.Controles.botonPersonalizado();
            this.btnVolver = new InicioSistema.Controles.botonPersonalizado();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new InicioSistema.Controles.botonPersonalizado();
            this.btnCancelarFac = new InicioSistema.Controles.botonPersonalizado();
            this.btnQuitarDet = new InicioSistema.Controles.botonPersonalizado();
            this.panelProductoDetalle.SuspendLayout();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalle)).BeginInit();
            this.panelDatosCab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProductoDetalle
            // 
            this.panelProductoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductoDetalle.Controls.Add(this.btnBuscaProd);
            this.panelProductoDetalle.Controls.Add(this.lCantidad);
            this.panelProductoDetalle.Controls.Add(this.textBoxCantidad);
            this.panelProductoDetalle.Controls.Add(this.label1);
            this.panelProductoDetalle.Controls.Add(this.btnCancelar);
            this.panelProductoDetalle.Controls.Add(this.btnAgregar);
            this.panelProductoDetalle.Controls.Add(this.textBoxDatoProducto);
            this.panelProductoDetalle.Controls.Add(this.lTitulo);
            this.panelProductoDetalle.Location = new System.Drawing.Point(694, 3);
            this.panelProductoDetalle.Name = "panelProductoDetalle";
            this.panelProductoDetalle.Size = new System.Drawing.Size(304, 258);
            this.panelProductoDetalle.TabIndex = 22;
            this.panelProductoDetalle.Visible = false;
            // 
            // btnBuscaProd
            // 
            this.btnBuscaProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscaProd.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscaProd.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscaProd.BorderRadius = 40;
            this.btnBuscaProd.BorderSize = 0;
            this.btnBuscaProd.FlatAppearance.BorderSize = 0;
            this.btnBuscaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaProd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaProd.ForeColor = System.Drawing.Color.White;
            this.btnBuscaProd.Location = new System.Drawing.Point(95, 129);
            this.btnBuscaProd.Name = "btnBuscaProd";
            this.btnBuscaProd.Size = new System.Drawing.Size(112, 44);
            this.btnBuscaProd.TabIndex = 36;
            this.btnBuscaProd.Text = "Buscar";
            this.btnBuscaProd.textColor = System.Drawing.Color.White;
            this.btnBuscaProd.UseVisualStyleBackColor = false;
            this.btnBuscaProd.Click += new System.EventHandler(this.btnBuscaProd_Click);
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidad.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lCantidad.Location = new System.Drawing.Point(11, 117);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(174, 19);
            this.lCantidad.TabIndex = 13;
            this.lCantidad.Text = "Cantidad Por Metros";
            this.lCantidad.Visible = false;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.Color.Wheat;
            this.textBoxCantidad.BorderColor = System.Drawing.Color.SaddleBrown;
            this.textBoxCantidad.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBoxCantidad.BorderSize = 1;
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCantidad.Location = new System.Drawing.Point(13, 142);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantidad.Multilinie = false;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCantidad.PassWordChar = false;
            this.textBoxCantidad.Size = new System.Drawing.Size(250, 31);
            this.textBoxCantidad.TabIndex = 12;
            this.textBoxCantidad.Texts = "";
            this.textBoxCantidad.UnderLineStyle = false;
            this.textBoxCantidad.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo o Nombre Producto";
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
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(158, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.textColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(34, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 40);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.textColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textBoxDatoProducto
            // 
            this.textBoxDatoProducto.BackColor = System.Drawing.Color.Wheat;
            this.textBoxDatoProducto.BorderColor = System.Drawing.Color.SaddleBrown;
            this.textBoxDatoProducto.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBoxDatoProducto.BorderSize = 1;
            this.textBoxDatoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDatoProducto.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDatoProducto.Location = new System.Drawing.Point(13, 74);
            this.textBoxDatoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDatoProducto.Multilinie = false;
            this.textBoxDatoProducto.Name = "textBoxDatoProducto";
            this.textBoxDatoProducto.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxDatoProducto.PassWordChar = false;
            this.textBoxDatoProducto.Size = new System.Drawing.Size(250, 31);
            this.textBoxDatoProducto.TabIndex = 8;
            this.textBoxDatoProducto.Texts = "";
            this.textBoxDatoProducto.UnderLineStyle = false;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lTitulo.Location = new System.Drawing.Point(35, 8);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(214, 28);
            this.lTitulo.TabIndex = 7;
            this.lTitulo.Text = "Ingrese Producto";
            // 
            // panelCabecera
            // 
            this.panelCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecera.Controls.Add(this.lNombreVendFac);
            this.panelCabecera.Controls.Add(this.lNombreVend);
            this.panelCabecera.Controls.Add(this.label12);
            this.panelCabecera.Controls.Add(this.lClienteNomb);
            this.panelCabecera.Controls.Add(this.lblFecha);
            this.panelCabecera.Controls.Add(this.lblFormaPago);
            this.panelCabecera.Controls.Add(this.lblTipoFac);
            this.panelCabecera.Controls.Add(this.lblCantFacNueva);
            this.panelCabecera.Controls.Add(this.lNumeroFactura);
            this.panelCabecera.Controls.Add(this.lFormaPago);
            this.panelCabecera.Controls.Add(this.lTipoFactura);
            this.panelCabecera.Controls.Add(this.lTipoCliente);
            this.panelCabecera.Controls.Add(this.lCliente);
            this.panelCabecera.Controls.Add(this.lFechaFactura);
            this.panelCabecera.Location = new System.Drawing.Point(4, 5);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(685, 83);
            this.panelCabecera.TabIndex = 23;
            this.panelCabecera.Visible = false;
            // 
            // lNombreVendFac
            // 
            this.lNombreVendFac.AutoSize = true;
            this.lNombreVendFac.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreVendFac.ForeColor = System.Drawing.Color.SlateBlue;
            this.lNombreVendFac.Location = new System.Drawing.Point(620, 9);
            this.lNombreVendFac.Name = "lNombreVendFac";
            this.lNombreVendFac.Size = new System.Drawing.Size(46, 16);
            this.lNombreVendFac.TabIndex = 13;
            this.lNombreVendFac.Text = "label2";
            // 
            // lNombreVend
            // 
            this.lNombreVend.AutoSize = true;
            this.lNombreVend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreVend.ForeColor = System.Drawing.Color.Sienna;
            this.lNombreVend.Location = new System.Drawing.Point(528, 6);
            this.lNombreVend.Name = "lNombreVend";
            this.lNombreVend.Size = new System.Drawing.Size(92, 21);
            this.lNombreVend.TabIndex = 12;
            this.lNombreVend.Text = "Vendedor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SlateBlue;
            this.label12.Location = new System.Drawing.Point(450, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // lClienteNomb
            // 
            this.lClienteNomb.AutoSize = true;
            this.lClienteNomb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClienteNomb.ForeColor = System.Drawing.Color.SlateBlue;
            this.lClienteNomb.Location = new System.Drawing.Point(391, 34);
            this.lClienteNomb.Name = "lClienteNomb";
            this.lClienteNomb.Size = new System.Drawing.Size(54, 16);
            this.lClienteNomb.TabIndex = 10;
            this.lClienteNomb.Text = "label11";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblFecha.Location = new System.Drawing.Point(382, 10);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 16);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "label10";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblFormaPago.Location = new System.Drawing.Point(153, 59);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(46, 16);
            this.lblFormaPago.TabIndex = 8;
            this.lblFormaPago.Text = "label9";
            // 
            // lblTipoFac
            // 
            this.lblTipoFac.AutoSize = true;
            this.lblTipoFac.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFac.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTipoFac.Location = new System.Drawing.Point(157, 35);
            this.lblTipoFac.Name = "lblTipoFac";
            this.lblTipoFac.Size = new System.Drawing.Size(46, 16);
            this.lblTipoFac.TabIndex = 7;
            this.lblTipoFac.Text = "label8";
            // 
            // lblCantFacNueva
            // 
            this.lblCantFacNueva.AutoSize = true;
            this.lblCantFacNueva.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantFacNueva.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblCantFacNueva.Location = new System.Drawing.Point(155, 7);
            this.lblCantFacNueva.Name = "lblCantFacNueva";
            this.lblCantFacNueva.Size = new System.Drawing.Size(46, 16);
            this.lblCantFacNueva.TabIndex = 6;
            this.lblCantFacNueva.Text = "label7";
            // 
            // lNumeroFactura
            // 
            this.lNumeroFactura.AutoSize = true;
            this.lNumeroFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumeroFactura.ForeColor = System.Drawing.Color.Sienna;
            this.lNumeroFactura.Location = new System.Drawing.Point(6, 6);
            this.lNumeroFactura.Name = "lNumeroFactura";
            this.lNumeroFactura.Size = new System.Drawing.Size(142, 21);
            this.lNumeroFactura.TabIndex = 5;
            this.lNumeroFactura.Text = "Numero Factura:";
            // 
            // lFormaPago
            // 
            this.lFormaPago.AutoSize = true;
            this.lFormaPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFormaPago.ForeColor = System.Drawing.Color.Sienna;
            this.lFormaPago.Location = new System.Drawing.Point(10, 55);
            this.lFormaPago.Name = "lFormaPago";
            this.lFormaPago.Size = new System.Drawing.Size(133, 21);
            this.lFormaPago.TabIndex = 4;
            this.lFormaPago.Text = "Forma de Pago:";
            // 
            // lTipoFactura
            // 
            this.lTipoFactura.AutoSize = true;
            this.lTipoFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoFactura.ForeColor = System.Drawing.Color.Sienna;
            this.lTipoFactura.Location = new System.Drawing.Point(6, 31);
            this.lTipoFactura.Name = "lTipoFactura";
            this.lTipoFactura.Size = new System.Drawing.Size(137, 21);
            this.lTipoFactura.TabIndex = 3;
            this.lTipoFactura.Text = "Tipo de Factura:";
            // 
            // lTipoCliente
            // 
            this.lTipoCliente.AutoSize = true;
            this.lTipoCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoCliente.ForeColor = System.Drawing.Color.Sienna;
            this.lTipoCliente.Location = new System.Drawing.Point(316, 58);
            this.lTipoCliente.Name = "lTipoCliente";
            this.lTipoCliente.Size = new System.Drawing.Size(131, 21);
            this.lTipoCliente.TabIndex = 2;
            this.lTipoCliente.Text = "Tipo de Cliente:";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.ForeColor = System.Drawing.Color.Sienna;
            this.lCliente.Location = new System.Drawing.Point(316, 31);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(70, 21);
            this.lCliente.TabIndex = 1;
            this.lCliente.Text = "Cliente:";
            // 
            // lFechaFactura
            // 
            this.lFechaFactura.AutoSize = true;
            this.lFechaFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaFactura.ForeColor = System.Drawing.Color.Sienna;
            this.lFechaFactura.Location = new System.Drawing.Point(317, 6);
            this.lFechaFactura.Name = "lFechaFactura";
            this.lFechaFactura.Size = new System.Drawing.Size(63, 21);
            this.lFechaFactura.TabIndex = 0;
            this.lFechaFactura.Text = "Fecha:";
            // 
            // GridDetalle
            // 
            this.GridDetalle.AllowUserToAddRows = false;
            this.GridDetalle.BackgroundColor = System.Drawing.Color.Wheat;
            this.GridDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GridDetalle.EnableHeadersVisualStyles = false;
            this.GridDetalle.GridColor = System.Drawing.Color.PeachPuff;
            this.GridDetalle.Location = new System.Drawing.Point(3, 97);
            this.GridDetalle.Name = "GridDetalle";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.GridDetalle.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridDetalle.Size = new System.Drawing.Size(686, 279);
            this.GridDetalle.TabIndex = 21;
            this.GridDetalle.Visible = false;
            this.GridDetalle.Click += new System.EventHandler(this.GridDetalle_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 210;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio Unitario por Metro";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad en Metros";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // lPrecioTotal
            // 
            this.lPrecioTotal.AutoSize = true;
            this.lPrecioTotal.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecioTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lPrecioTotal.Location = new System.Drawing.Point(873, 403);
            this.lPrecioTotal.Name = "lPrecioTotal";
            this.lPrecioTotal.Size = new System.Drawing.Size(41, 44);
            this.lPrecioTotal.TabIndex = 34;
            this.lPrecioTotal.Text = "0";
            this.lPrecioTotal.Visible = false;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lTotal.Location = new System.Drawing.Point(751, 404);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(125, 39);
            this.lTotal.TabIndex = 33;
            this.lTotal.Text = "Total: $";
            this.lTotal.Visible = false;
            // 
            // lPrecioSubTotal
            // 
            this.lPrecioSubTotal.AutoSize = true;
            this.lPrecioSubTotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecioSubTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lPrecioSubTotal.Location = new System.Drawing.Point(439, 441);
            this.lPrecioSubTotal.Name = "lPrecioSubTotal";
            this.lPrecioSubTotal.Size = new System.Drawing.Size(30, 33);
            this.lPrecioSubTotal.TabIndex = 32;
            this.lPrecioSubTotal.Text = "0";
            this.lPrecioSubTotal.Visible = false;
            // 
            // lSubTotal
            // 
            this.lSubTotal.AutoSize = true;
            this.lSubTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lSubTotal.Location = new System.Drawing.Point(295, 443);
            this.lSubTotal.Name = "lSubTotal";
            this.lSubTotal.Size = new System.Drawing.Size(147, 30);
            this.lSubTotal.TabIndex = 31;
            this.lSubTotal.Text = "Sub Total: $";
            this.lSubTotal.Visible = false;
            // 
            // panelDatosCab
            // 
            this.panelDatosCab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosCab.Controls.Add(this.lDNICliente);
            this.panelDatosCab.Controls.Add(this.textBoxDni);
            this.panelDatosCab.Controls.Add(this.label3);
            this.panelDatosCab.Controls.Add(this.textBoxTipoCliente);
            this.panelDatosCab.Controls.Add(this.comboxTipoFactura);
            this.panelDatosCab.Controls.Add(this.lTipoFac);
            this.panelDatosCab.Controls.Add(this.comboxFormaPago);
            this.panelDatosCab.Controls.Add(this.label4);
            this.panelDatosCab.Controls.Add(this.btnBuscar);
            this.panelDatosCab.Controls.Add(this.label5);
            this.panelDatosCab.Controls.Add(this.textBoxCliente);
            this.panelDatosCab.Controls.Add(this.botonConfirmarDatos);
            this.panelDatosCab.Controls.Add(this.btnVolver);
            this.panelDatosCab.Controls.Add(this.label6);
            this.panelDatosCab.Location = new System.Drawing.Point(286, 67);
            this.panelDatosCab.Name = "panelDatosCab";
            this.panelDatosCab.Size = new System.Drawing.Size(378, 449);
            this.panelDatosCab.TabIndex = 35;
            // 
            // lDNICliente
            // 
            this.lDNICliente.AutoSize = true;
            this.lDNICliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNICliente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lDNICliente.Location = new System.Drawing.Point(7, 238);
            this.lDNICliente.Name = "lDNICliente";
            this.lDNICliente.Size = new System.Drawing.Size(99, 21);
            this.lDNICliente.TabIndex = 43;
            this.lDNICliente.Text = "DNI Cliente";
            this.lDNICliente.Visible = false;
            // 
            // textBoxDni
            // 
            this.textBoxDni.BackColor = System.Drawing.Color.Wheat;
            this.textBoxDni.BorderColor = System.Drawing.Color.SaddleBrown;
            this.textBoxDni.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBoxDni.BorderSize = 0;
            this.textBoxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDni.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDni.Location = new System.Drawing.Point(17, 263);
            this.textBoxDni.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDni.Multilinie = false;
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxDni.PassWordChar = false;
            this.textBoxDni.Size = new System.Drawing.Size(253, 31);
            this.textBoxDni.TabIndex = 42;
            this.textBoxDni.Texts = "";
            this.textBoxDni.UnderLineStyle = false;
            this.textBoxDni.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(4, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tipo de Cliente";
            this.label3.Visible = false;
            // 
            // textBoxTipoCliente
            // 
            this.textBoxTipoCliente.BackColor = System.Drawing.Color.Wheat;
            this.textBoxTipoCliente.BorderColor = System.Drawing.Color.SaddleBrown;
            this.textBoxTipoCliente.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBoxTipoCliente.BorderSize = 0;
            this.textBoxTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTipoCliente.Location = new System.Drawing.Point(14, 325);
            this.textBoxTipoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTipoCliente.Multilinie = false;
            this.textBoxTipoCliente.Name = "textBoxTipoCliente";
            this.textBoxTipoCliente.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxTipoCliente.PassWordChar = false;
            this.textBoxTipoCliente.Size = new System.Drawing.Size(253, 31);
            this.textBoxTipoCliente.TabIndex = 40;
            this.textBoxTipoCliente.Texts = "";
            this.textBoxTipoCliente.UnderLineStyle = false;
            this.textBoxTipoCliente.Visible = false;
            // 
            // comboxTipoFactura
            // 
            this.comboxTipoFactura.BackColor = System.Drawing.Color.Wheat;
            this.comboxTipoFactura.BorderColor = System.Drawing.Color.SaddleBrown;
            this.comboxTipoFactura.BorderSize = 1;
            this.comboxTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboxTipoFactura.ForeColor = System.Drawing.Color.DimGray;
            this.comboxTipoFactura.IconColor = System.Drawing.Color.SaddleBrown;
            this.comboxTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboxTipoFactura.ListBackColor = System.Drawing.Color.PapayaWhip;
            this.comboxTipoFactura.ListTextColor = System.Drawing.Color.DimGray;
            this.comboxTipoFactura.Location = new System.Drawing.Point(14, 89);
            this.comboxTipoFactura.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboxTipoFactura.Name = "comboxTipoFactura";
            this.comboxTipoFactura.Padding = new System.Windows.Forms.Padding(1);
            this.comboxTipoFactura.Size = new System.Drawing.Size(249, 30);
            this.comboxTipoFactura.TabIndex = 39;
            this.comboxTipoFactura.Texts = "";
            // 
            // lTipoFac
            // 
            this.lTipoFac.AutoSize = true;
            this.lTipoFac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoFac.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lTipoFac.Location = new System.Drawing.Point(5, 65);
            this.lTipoFac.Name = "lTipoFac";
            this.lTipoFac.Size = new System.Drawing.Size(133, 21);
            this.lTipoFac.TabIndex = 38;
            this.lTipoFac.Text = "Tipo de Factura";
            // 
            // comboxFormaPago
            // 
            this.comboxFormaPago.BackColor = System.Drawing.Color.Wheat;
            this.comboxFormaPago.BorderColor = System.Drawing.Color.SaddleBrown;
            this.comboxFormaPago.BorderSize = 1;
            this.comboxFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboxFormaPago.ForeColor = System.Drawing.Color.DimGray;
            this.comboxFormaPago.IconColor = System.Drawing.Color.SaddleBrown;
            this.comboxFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Debito",
            "Tarjeta de Credito"});
            this.comboxFormaPago.ListBackColor = System.Drawing.Color.PapayaWhip;
            this.comboxFormaPago.ListTextColor = System.Drawing.Color.DimGray;
            this.comboxFormaPago.Location = new System.Drawing.Point(13, 144);
            this.comboxFormaPago.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboxFormaPago.Name = "comboxFormaPago";
            this.comboxFormaPago.Padding = new System.Windows.Forms.Padding(1);
            this.comboxFormaPago.Size = new System.Drawing.Size(249, 30);
            this.comboxFormaPago.TabIndex = 37;
            this.comboxFormaPago.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(4, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Forma de Pago";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.BorderRadius = 40;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(274, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 37);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.textColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(3, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "DNI o Nombre o Apellido del Cliente";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.BackColor = System.Drawing.Color.Wheat;
            this.textBoxCliente.BorderColor = System.Drawing.Color.SaddleBrown;
            this.textBoxCliente.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBoxCliente.BorderSize = 0;
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCliente.Location = new System.Drawing.Point(13, 207);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente.Multilinie = false;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCliente.PassWordChar = false;
            this.textBoxCliente.Size = new System.Drawing.Size(253, 31);
            this.textBoxCliente.TabIndex = 33;
            this.textBoxCliente.Texts = "";
            this.textBoxCliente.UnderLineStyle = false;
            // 
            // botonConfirmarDatos
            // 
            this.botonConfirmarDatos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonConfirmarDatos.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonConfirmarDatos.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.botonConfirmarDatos.BorderRadius = 40;
            this.botonConfirmarDatos.BorderSize = 0;
            this.botonConfirmarDatos.FlatAppearance.BorderSize = 0;
            this.botonConfirmarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConfirmarDatos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmarDatos.ForeColor = System.Drawing.Color.White;
            this.botonConfirmarDatos.Location = new System.Drawing.Point(198, 362);
            this.botonConfirmarDatos.Name = "botonConfirmarDatos";
            this.botonConfirmarDatos.Size = new System.Drawing.Size(126, 40);
            this.botonConfirmarDatos.TabIndex = 32;
            this.botonConfirmarDatos.Text = "Confirmar Datos";
            this.botonConfirmarDatos.textColor = System.Drawing.Color.White;
            this.botonConfirmarDatos.UseVisualStyleBackColor = false;
            this.botonConfirmarDatos.Click += new System.EventHandler(this.botonConfirmarDatos_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolver.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolver.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.BorderRadius = 40;
            this.btnVolver.BorderSize = 0;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(56, 362);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 40);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.textColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(38, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 36);
            this.label6.TabIndex = 30;
            this.label6.Text = "Datos de la Factura";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegistrar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegistrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrar.BorderRadius = 40;
            this.btnRegistrar.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(779, 486);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrar.TabIndex = 29;
            this.btnRegistrar.Text = "Registrar Factura";
            this.btnRegistrar.textColor = System.Drawing.Color.White;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelarFac
            // 
            this.btnCancelarFac.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelarFac.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelarFac.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelarFac.BorderRadius = 40;
            this.btnCancelarFac.BorderSize = 0;
            this.btnCancelarFac.FlatAppearance.BorderSize = 0;
            this.btnCancelarFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFac.ForeColor = System.Drawing.Color.White;
            this.btnCancelarFac.Location = new System.Drawing.Point(573, 486);
            this.btnCancelarFac.Name = "btnCancelarFac";
            this.btnCancelarFac.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarFac.TabIndex = 28;
            this.btnCancelarFac.Text = "Cancelar Factura";
            this.btnCancelarFac.textColor = System.Drawing.Color.White;
            this.btnCancelarFac.UseVisualStyleBackColor = false;
            this.btnCancelarFac.Visible = false;
            this.btnCancelarFac.Click += new System.EventHandler(this.btnCancelarFac_Click);
            // 
            // btnQuitarDet
            // 
            this.btnQuitarDet.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuitarDet.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuitarDet.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuitarDet.BorderRadius = 40;
            this.btnQuitarDet.BorderSize = 0;
            this.btnQuitarDet.FlatAppearance.BorderSize = 0;
            this.btnQuitarDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarDet.ForeColor = System.Drawing.Color.White;
            this.btnQuitarDet.Location = new System.Drawing.Point(695, 289);
            this.btnQuitarDet.Name = "btnQuitarDet";
            this.btnQuitarDet.Size = new System.Drawing.Size(98, 40);
            this.btnQuitarDet.TabIndex = 30;
            this.btnQuitarDet.Text = "Quitar Producto";
            this.btnQuitarDet.textColor = System.Drawing.Color.White;
            this.btnQuitarDet.UseVisualStyleBackColor = false;
            this.btnQuitarDet.Visible = false;
            this.btnQuitarDet.Click += new System.EventHandler(this.btnQuitarDet_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1001, 527);
            this.Controls.Add(this.panelDatosCab);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelarFac);
            this.Controls.Add(this.lPrecioTotal);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lPrecioSubTotal);
            this.Controls.Add(this.lSubTotal);
            this.Controls.Add(this.btnQuitarDet);
            this.Controls.Add(this.panelProductoDetalle);
            this.Controls.Add(this.panelCabecera);
            this.Controls.Add(this.GridDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Factura";
            this.panelProductoDetalle.ResumeLayout(false);
            this.panelProductoDetalle.PerformLayout();
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalle)).EndInit();
            this.panelDatosCab.ResumeLayout(false);
            this.panelDatosCab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProductoDetalle;
        private System.Windows.Forms.Label lCantidad;
        private Controles.textBoxPersozalizado textBoxCantidad;
        private System.Windows.Forms.Label label1;
        private InicioSistema.Controles.botonPersonalizado btnCancelar;
        private InicioSistema.Controles.botonPersonalizado btnAgregar;
        private Controles.textBoxPersozalizado textBoxDatoProducto;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Label lNumeroFactura;
        private System.Windows.Forms.Label lFormaPago;
        private System.Windows.Forms.Label lTipoFactura;
        private System.Windows.Forms.Label lTipoCliente;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Label lFechaFactura;
        private System.Windows.Forms.DataGridView GridDetalle;
        private InicioSistema.Controles.botonPersonalizado btnRegistrar;
        private InicioSistema.Controles.botonPersonalizado btnCancelarFac;
        private System.Windows.Forms.Label lPrecioTotal;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lPrecioSubTotal;
        private System.Windows.Forms.Label lSubTotal;
        private InicioSistema.Controles.botonPersonalizado btnQuitarDet;
        private System.Windows.Forms.Panel panelDatosCab;
        private System.Windows.Forms.Label label3;
        private Controles.textBoxPersozalizado textBoxTipoCliente;
        private Controles.ComboxPersonalizado comboxTipoFactura;
        private System.Windows.Forms.Label lTipoFac;
        private Controles.ComboxPersonalizado comboxFormaPago;
        private System.Windows.Forms.Label label4;
        private InicioSistema.Controles.botonPersonalizado btnBuscar;
        private System.Windows.Forms.Label label5;
        private Controles.textBoxPersozalizado textBoxCliente;
        private InicioSistema.Controles.botonPersonalizado botonConfirmarDatos;
        private InicioSistema.Controles.botonPersonalizado btnVolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lClienteNomb;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblTipoFac;
        private System.Windows.Forms.Label lblCantFacNueva;
        private InicioSistema.Controles.botonPersonalizado btnBuscaProd;
        private System.Windows.Forms.Label lDNICliente;
        private Controles.textBoxPersozalizado textBoxDni;
        private System.Windows.Forms.Label lNombreVendFac;
        private System.Windows.Forms.Label lNombreVend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}