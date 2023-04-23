namespace inicio.Administrador
{
    partial class Inicio7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio7));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxClave = new inicio.Controles.textBoxPersozalizado();
            this.botonPersonalizado1 = new InicioSistema.Controles.botonPersonalizado();
            this.botonVolver = new InicioSistema.Controles.botonPersonalizado();
            this.restoreButton = new InicioSistema.Controles.botonPersonalizado();
            this.botonRutaGuardar = new InicioSistema.Controles.botonPersonalizado();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restauración de Base de Datos";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 263);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(211, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ubicación";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "CLAVE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(214, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 158);
            this.panel2.TabIndex = 19;
            this.panel2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxClave
            // 
            this.textBoxClave.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxClave.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxClave.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBoxClave.BorderSize = 2;
            this.textBoxClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxClave.Location = new System.Drawing.Point(348, 153);
            this.textBoxClave.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClave.Multilinie = false;
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxClave.PassWordChar = true;
            this.textBoxClave.Size = new System.Drawing.Size(188, 31);
            this.textBoxClave.TabIndex = 17;
            this.textBoxClave.Texts = "";
            this.textBoxClave.UnderLineStyle = false;
            this.textBoxClave.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxClave_Validating);
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
            this.botonPersonalizado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado1.Location = new System.Drawing.Point(366, 214);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(150, 40);
            this.botonPersonalizado1.TabIndex = 16;
            this.botonPersonalizado1.Text = "Aceptar";
            this.botonPersonalizado1.textColor = System.Drawing.Color.White;
            this.botonPersonalizado1.UseVisualStyleBackColor = false;
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click);
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
            this.botonVolver.TabIndex = 15;
            this.botonVolver.Text = "Volver";
            this.botonVolver.textColor = System.Drawing.Color.White;
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.restoreButton.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.restoreButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.restoreButton.BorderRadius = 40;
            this.restoreButton.BorderSize = 0;
            this.restoreButton.FlatAppearance.BorderSize = 0;
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreButton.ForeColor = System.Drawing.Color.White;
            this.restoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restoreButton.Location = new System.Drawing.Point(359, 289);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(177, 37);
            this.restoreButton.TabIndex = 14;
            this.restoreButton.Text = "Restaurar";
            this.restoreButton.textColor = System.Drawing.Color.White;
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Visible = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // botonRutaGuardar
            // 
            this.botonRutaGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRutaGuardar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRutaGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonRutaGuardar.BorderRadius = 40;
            this.botonRutaGuardar.BorderSize = 0;
            this.botonRutaGuardar.FlatAppearance.BorderSize = 0;
            this.botonRutaGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRutaGuardar.ForeColor = System.Drawing.Color.White;
            this.botonRutaGuardar.Location = new System.Drawing.Point(569, 252);
            this.botonRutaGuardar.Name = "botonRutaGuardar";
            this.botonRutaGuardar.Size = new System.Drawing.Size(96, 40);
            this.botonRutaGuardar.TabIndex = 12;
            this.botonRutaGuardar.Text = "Buscar";
            this.botonRutaGuardar.textColor = System.Drawing.Color.White;
            this.botonRutaGuardar.UseVisualStyleBackColor = false;
            this.botonRutaGuardar.Visible = false;
            this.botonRutaGuardar.Click += new System.EventHandler(this.botonRutaGuardar_Click);
            // 
            // Inicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(715, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.botonPersonalizado1);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.botonRutaGuardar);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio7";
            this.Text = "Inicio7";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private InicioSistema.Controles.botonPersonalizado restoreButton;
        private System.Windows.Forms.TextBox textBox2;
        private InicioSistema.Controles.botonPersonalizado botonRutaGuardar;
        private System.Windows.Forms.Label label3;
        private InicioSistema.Controles.botonPersonalizado botonVolver;
        private System.Windows.Forms.Label label2;
        private Controles.textBoxPersozalizado textBoxClave;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}