namespace inicio.Gerente
{
    partial class MenuGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGerente));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lminizar = new System.Windows.Forms.Label();
            this.lMenuGere = new System.Windows.Forms.Label();
            this.panelVertical = new System.Windows.Forms.Panel();
            this.panelSubMenuReportVent = new System.Windows.Forms.Panel();
            this.btnRePMV = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRVentas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReporteSt = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReporteG = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReportVenta = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lHora = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.lGerente = new System.Windows.Forms.Label();
            this.nombreGerente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesdeHasta = new System.Windows.Forms.Panel();
            this.lHasta = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lDesde = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lreporteNombre = new System.Windows.Forms.Label();
            this.GridCompras = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMasVendido = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new InicioSistema.Controles.botonPersonalizado();
            this.btnVolver = new InicioSistema.Controles.botonPersonalizado();
            this.panelTop.SuspendLayout();
            this.panelVertical.SuspendLayout();
            this.panelSubMenuReportVent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesdeHasta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMasVendido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Tan;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lminizar);
            this.panelTop.Controls.Add(this.lMenuGere);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1240, 30);
            this.panelTop.TabIndex = 0;
            // 
            // lminizar
            // 
            this.lminizar.AutoSize = true;
            this.lminizar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lminizar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lminizar.Location = new System.Drawing.Point(858, -12);
            this.lminizar.Name = "lminizar";
            this.lminizar.Size = new System.Drawing.Size(28, 37);
            this.lminizar.TabIndex = 9;
            this.lminizar.Text = "_";
            this.lminizar.Click += new System.EventHandler(this.lminizar_Click);
            // 
            // lMenuGere
            // 
            this.lMenuGere.AutoSize = true;
            this.lMenuGere.BackColor = System.Drawing.Color.Transparent;
            this.lMenuGere.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMenuGere.ForeColor = System.Drawing.Color.Maroon;
            this.lMenuGere.Location = new System.Drawing.Point(12, 6);
            this.lMenuGere.Name = "lMenuGere";
            this.lMenuGere.Size = new System.Drawing.Size(125, 21);
            this.lMenuGere.TabIndex = 8;
            this.lMenuGere.Text = "Menu Gerente";
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.Tan;
            this.panelVertical.Controls.Add(this.panelSubMenuReportVent);
            this.panelVertical.Controls.Add(this.btnReporteSt);
            this.panelVertical.Controls.Add(this.panel6);
            this.panelVertical.Controls.Add(this.btnReporteG);
            this.panelVertical.Controls.Add(this.panel5);
            this.panelVertical.Controls.Add(this.btnReportVenta);
            this.panelVertical.Controls.Add(this.panel3);
            this.panelVertical.Controls.Add(this.btnCerrarSesion);
            this.panelVertical.Controls.Add(this.lHora);
            this.panelVertical.Controls.Add(this.lFecha);
            this.panelVertical.Controls.Add(this.lGerente);
            this.panelVertical.Controls.Add(this.nombreGerente);
            this.panelVertical.Controls.Add(this.pictureBox1);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 30);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(205, 560);
            this.panelVertical.TabIndex = 2;
            // 
            // panelSubMenuReportVent
            // 
            this.panelSubMenuReportVent.Controls.Add(this.btnRePMV);
            this.panelSubMenuReportVent.Controls.Add(this.panel4);
            this.panelSubMenuReportVent.Controls.Add(this.btnRVentas);
            this.panelSubMenuReportVent.Controls.Add(this.panel2);
            this.panelSubMenuReportVent.Location = new System.Drawing.Point(5, 433);
            this.panelSubMenuReportVent.Name = "panelSubMenuReportVent";
            this.panelSubMenuReportVent.Size = new System.Drawing.Size(196, 85);
            this.panelSubMenuReportVent.TabIndex = 24;
            this.panelSubMenuReportVent.Visible = false;
            // 
            // btnRePMV
            // 
            this.btnRePMV.FlatAppearance.BorderSize = 0;
            this.btnRePMV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnRePMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRePMV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePMV.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRePMV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRePMV.Location = new System.Drawing.Point(8, 37);
            this.btnRePMV.Name = "btnRePMV";
            this.btnRePMV.Size = new System.Drawing.Size(211, 35);
            this.btnRePMV.TabIndex = 27;
            this.btnRePMV.Text = "Productos Mas Vendidos";
            this.btnRePMV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRePMV.UseVisualStyleBackColor = true;
            this.btnRePMV.Click += new System.EventHandler(this.btnRePMV_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 35);
            this.panel4.TabIndex = 26;
            // 
            // btnRVentas
            // 
            this.btnRVentas.FlatAppearance.BorderSize = 0;
            this.btnRVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnRVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRVentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRVentas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnRVentas.Image")));
            this.btnRVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRVentas.Location = new System.Drawing.Point(9, 0);
            this.btnRVentas.Name = "btnRVentas";
            this.btnRVentas.Size = new System.Drawing.Size(184, 35);
            this.btnRVentas.TabIndex = 25;
            this.btnRVentas.Text = "Ventas";
            this.btnRVentas.UseVisualStyleBackColor = true;
            this.btnRVentas.Click += new System.EventHandler(this.btnRVentas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 35);
            this.panel2.TabIndex = 24;
            // 
            // btnReporteSt
            // 
            this.btnReporteSt.FlatAppearance.BorderSize = 0;
            this.btnReporteSt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnReporteSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteSt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteSt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReporteSt.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteSt.Image")));
            this.btnReporteSt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteSt.Location = new System.Drawing.Point(9, 278);
            this.btnReporteSt.Name = "btnReporteSt";
            this.btnReporteSt.Size = new System.Drawing.Size(194, 46);
            this.btnReporteSt.TabIndex = 27;
            this.btnReporteSt.Text = "Reporte Stock";
            this.btnReporteSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteSt.UseVisualStyleBackColor = true;
            this.btnReporteSt.Click += new System.EventHandler(this.btnReporteSt_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PeachPuff;
            this.panel6.Location = new System.Drawing.Point(2, 386);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 46);
            this.panel6.TabIndex = 26;
            // 
            // btnReporteG
            // 
            this.btnReporteG.FlatAppearance.BorderSize = 0;
            this.btnReporteG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnReporteG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteG.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteG.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReporteG.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteG.Image")));
            this.btnReporteG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteG.Location = new System.Drawing.Point(7, 333);
            this.btnReporteG.Name = "btnReporteG";
            this.btnReporteG.Size = new System.Drawing.Size(194, 46);
            this.btnReporteG.TabIndex = 25;
            this.btnReporteG.Text = "Reporte Gastos";
            this.btnReporteG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteG.UseVisualStyleBackColor = true;
            this.btnReporteG.Click += new System.EventHandler(this.btnReporteG_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PeachPuff;
            this.panel5.Location = new System.Drawing.Point(1, 333);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 46);
            this.panel5.TabIndex = 24;
            // 
            // btnReportVenta
            // 
            this.btnReportVenta.FlatAppearance.BorderSize = 0;
            this.btnReportVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnReportVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportVenta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportVenta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReportVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnReportVenta.Image")));
            this.btnReportVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportVenta.Location = new System.Drawing.Point(10, 386);
            this.btnReportVenta.Name = "btnReportVenta";
            this.btnReportVenta.Size = new System.Drawing.Size(194, 46);
            this.btnReportVenta.TabIndex = 23;
            this.btnReportVenta.Text = "Reporte Ventas";
            this.btnReportVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportVenta.UseVisualStyleBackColor = true;
            this.btnReportVenta.Click += new System.EventHandler(this.btnReportVenta_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 46);
            this.panel3.TabIndex = 22;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Tan;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(8, 509);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(186, 46);
            this.btnCerrarSesion.TabIndex = 19;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lHora
            // 
            this.lHora.AutoSize = true;
            this.lHora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHora.ForeColor = System.Drawing.Color.Sienna;
            this.lHora.Location = new System.Drawing.Point(61, 167);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(54, 22);
            this.lHora.TabIndex = 18;
            this.lHora.Text = "Hora";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lFecha.Location = new System.Drawing.Point(63, 199);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(47, 16);
            this.lFecha.TabIndex = 17;
            this.lFecha.Text = "Fecha";
            // 
            // lGerente
            // 
            this.lGerente.AutoSize = true;
            this.lGerente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGerente.ForeColor = System.Drawing.Color.Sienna;
            this.lGerente.Location = new System.Drawing.Point(6, 233);
            this.lGerente.Name = "lGerente";
            this.lGerente.Size = new System.Drawing.Size(75, 20);
            this.lGerente.TabIndex = 16;
            this.lGerente.Text = "Gerente:";
            // 
            // nombreGerente
            // 
            this.nombreGerente.AutoSize = true;
            this.nombreGerente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGerente.ForeColor = System.Drawing.Color.Maroon;
            this.nombreGerente.Location = new System.Drawing.Point(114, 235);
            this.nombreGerente.Name = "nombreGerente";
            this.nombreGerente.Size = new System.Drawing.Size(68, 18);
            this.nombreGerente.TabIndex = 15;
            this.nombreGerente.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelDesdeHasta
            // 
            this.panelDesdeHasta.Controls.Add(this.lHasta);
            this.panelDesdeHasta.Controls.Add(this.dateTimePicker2);
            this.panelDesdeHasta.Controls.Add(this.lDesde);
            this.panelDesdeHasta.Controls.Add(this.dateTimePicker1);
            this.panelDesdeHasta.Location = new System.Drawing.Point(265, 117);
            this.panelDesdeHasta.Name = "panelDesdeHasta";
            this.panelDesdeHasta.Size = new System.Drawing.Size(490, 51);
            this.panelDesdeHasta.TabIndex = 10;
            this.panelDesdeHasta.Visible = false;
            // 
            // lHasta
            // 
            this.lHasta.AutoSize = true;
            this.lHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHasta.ForeColor = System.Drawing.Color.SlateBlue;
            this.lHasta.Location = new System.Drawing.Point(287, 1);
            this.lHasta.Name = "lHasta";
            this.lHasta.Size = new System.Drawing.Size(49, 21);
            this.lHasta.TabIndex = 3;
            this.lHasta.Text = "Hasta";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(284, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // lDesde
            // 
            this.lDesde.AutoSize = true;
            this.lDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDesde.ForeColor = System.Drawing.Color.SlateBlue;
            this.lDesde.Location = new System.Drawing.Point(7, 1);
            this.lDesde.Name = "lDesde";
            this.lDesde.Size = new System.Drawing.Size(53, 21);
            this.lDesde.TabIndex = 1;
            this.lDesde.Text = "Desde";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Enabled = true;
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(262, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = "Reportes de Centurion Maderas ";
            // 
            // lreporteNombre
            // 
            this.lreporteNombre.AutoSize = true;
            this.lreporteNombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lreporteNombre.ForeColor = System.Drawing.Color.SlateBlue;
            this.lreporteNombre.Location = new System.Drawing.Point(476, 74);
            this.lreporteNombre.Name = "lreporteNombre";
            this.lreporteNombre.Size = new System.Drawing.Size(22, 33);
            this.lreporteNombre.TabIndex = 36;
            this.lreporteNombre.Text = ".";
            this.lreporteNombre.Visible = false;
            // 
            // GridCompras
            // 
            this.GridCompras.BackgroundColor = System.Drawing.Color.Wheat;
            this.GridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.GridCompras.Location = new System.Drawing.Point(213, 197);
            this.GridCompras.Name = "GridCompras";
            this.GridCompras.Size = new System.Drawing.Size(675, 279);
            this.GridCompras.TabIndex = 38;
            this.GridCompras.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio Compra por Metro";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad en Metros";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // gridStock
            // 
            this.gridStock.BackgroundColor = System.Drawing.Color.Wheat;
            this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.gridStock.Location = new System.Drawing.Point(213, 219);
            this.gridStock.Name = "gridStock";
            this.gridStock.Size = new System.Drawing.Size(563, 279);
            this.gridStock.TabIndex = 39;
            this.gridStock.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad en Metros";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // gridVentas
            // 
            this.gridVentas.BackgroundColor = System.Drawing.Color.Wheat;
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.Column5});
            this.gridVentas.Location = new System.Drawing.Point(213, 229);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.Size = new System.Drawing.Size(585, 279);
            this.gridVentas.TabIndex = 40;
            this.gridVentas.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 350;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Vendido";
            this.Column5.Name = "Column5";
            // 
            // gridMasVendido
            // 
            this.gridMasVendido.BackgroundColor = System.Drawing.Color.Wheat;
            this.gridMasVendido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMasVendido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gridMasVendido.Location = new System.Drawing.Point(213, 241);
            this.gridMasVendido.Name = "gridMasVendido";
            this.gridMasVendido.Size = new System.Drawing.Size(585, 279);
            this.gridMasVendido.TabIndex = 41;
            this.gridMasVendido.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 350;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Cantidad Total Ventas";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerar.BorderRadius = 40;
            this.btnGenerar.BorderSize = 0;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(761, 121);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(118, 40);
            this.btnGenerar.TabIndex = 37;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.textColor = System.Drawing.Color.White;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Visible = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
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
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(600, 511);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 40);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "Volver";
            this.btnVolver.textColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // MenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.gridMasVendido);
            this.Controls.Add(this.gridVentas);
            this.Controls.Add(this.gridStock);
            this.Controls.Add(this.GridCompras);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lreporteNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelDesdeHasta);
            this.Controls.Add(this.panelVertical);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuGerente";
            this.Load += new System.EventHandler(this.MenuGerente_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelVertical.ResumeLayout(false);
            this.panelVertical.PerformLayout();
            this.panelSubMenuReportVent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesdeHasta.ResumeLayout(false);
            this.panelDesdeHasta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMasVendido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.Label lMenuGere;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesdeHasta;
        private System.Windows.Forms.Label lHasta;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lDesde;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lGerente;
        private System.Windows.Forms.Label nombreGerente;
        private InicioSistema.Controles.botonPersonalizado btnVolver;
        private System.Windows.Forms.Button btnReportVenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelSubMenuReportVent;
        private System.Windows.Forms.Button btnRePMV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRVentas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReporteSt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReporteG;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lreporteNombre;
        private InicioSistema.Controles.botonPersonalizado btnGenerar;
        private System.Windows.Forms.Label lminizar;
        private System.Windows.Forms.DataGridView GridCompras;
        private System.Windows.Forms.DataGridView gridStock;
        private System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView gridMasVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}