namespace inicio.Administrador
{
    partial class Inicio6
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox6 = new inicio.Controles.textBoxPersozalizado();
            this.botonPersonalizado2 = new InicioSistema.Controles.botonPersonalizado();
            this.botonPersonalizado1 = new InicioSistema.Controles.botonPersonalizado();
            this.labelBuscarDescri = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.id_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuarioFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipoFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_clienteFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVolver = new InicioSistema.Controles.botonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_factura,
            this.NumeroFac,
            this.id_usuarioFac,
            this.id_tipoFac,
            this.formaPago,
            this.fecha,
            this.id_clienteFac,
            this.total,
            this.estado_vigencia});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView.Location = new System.Drawing.Point(1, 178);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.MediumPurple;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView.Size = new System.Drawing.Size(960, 210);
            this.dataGridView.TabIndex = 78;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.radioButton2);
            this.panelBusqueda.Controls.Add(this.radioButton1);
            this.panelBusqueda.Controls.Add(this.textBox6);
            this.panelBusqueda.Controls.Add(this.botonPersonalizado2);
            this.panelBusqueda.Controls.Add(this.botonPersonalizado1);
            this.panelBusqueda.Controls.Add(this.labelBuscarDescri);
            this.panelBusqueda.Location = new System.Drawing.Point(580, 3);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(388, 159);
            this.panelBusqueda.TabIndex = 79;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(254, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nro de Factura";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click);
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
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(254, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cliente";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // id_factura
            // 
            this.id_factura.DataPropertyName = "id_factura";
            this.id_factura.HeaderText = "Id factura";
            this.id_factura.Name = "id_factura";
            this.id_factura.ReadOnly = true;
            this.id_factura.Visible = false;
            // 
            // NumeroFac
            // 
            this.NumeroFac.DataPropertyName = "NumeroFac";
            this.NumeroFac.HeaderText = "Nro Factura";
            this.NumeroFac.Name = "NumeroFac";
            this.NumeroFac.ReadOnly = true;
            // 
            // id_usuarioFac
            // 
            this.id_usuarioFac.DataPropertyName = "id_usuarioFac";
            this.id_usuarioFac.HeaderText = "Id Usuario";
            this.id_usuarioFac.Name = "id_usuarioFac";
            this.id_usuarioFac.ReadOnly = true;
            // 
            // id_tipoFac
            // 
            this.id_tipoFac.DataPropertyName = "id_tipoFac";
            this.id_tipoFac.HeaderText = "Id tipo factura";
            this.id_tipoFac.Name = "id_tipoFac";
            this.id_tipoFac.ReadOnly = true;
            // 
            // formaPago
            // 
            this.formaPago.DataPropertyName = "formaPago";
            this.formaPago.HeaderText = "Forma de Pago";
            this.formaPago.Name = "formaPago";
            this.formaPago.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // id_clienteFac
            // 
            this.id_clienteFac.DataPropertyName = "id_clienteFac";
            this.id_clienteFac.HeaderText = "Id Cliente";
            this.id_clienteFac.Name = "id_clienteFac";
            this.id_clienteFac.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // estado_vigencia
            // 
            this.estado_vigencia.DataPropertyName = "estado_vigencia";
            this.estado_vigencia.HeaderText = "Estado";
            this.estado_vigencia.Name = "estado_vigencia";
            this.estado_vigencia.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnVolver.TabIndex = 80;
            this.btnVolver.Text = "Volver";
            this.btnVolver.textColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // Inicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1001, 545);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio6";
            this.Text = "Inicio6";
            this.Load += new System.EventHandler(this.Inicio6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuarioFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipoFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clienteFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_vigencia;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Controles.textBoxPersozalizado textBox6;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado2;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado1;
        private System.Windows.Forms.Label labelBuscarDescri;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private InicioSistema.Controles.botonPersonalizado btnVolver;
    }
}