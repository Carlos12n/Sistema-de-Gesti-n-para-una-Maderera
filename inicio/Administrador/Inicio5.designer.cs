namespace inicio.Administrador
{
    partial class Inicio5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonConectar = new InicioSistema.Controles.botonPersonalizado();
            this.botonRutaGuardar = new InicioSistema.Controles.botonPersonalizado();
            this.btnbackup = new InicioSistema.Controles.botonPersonalizado();
            this.botonVolver = new InicioSistema.Controles.botonPersonalizado();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.restoreButton = new InicioSistema.Controles.botonPersonalizado();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup de Base de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(184, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(21, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ubicación";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 4;
            // 
            // botonConectar
            // 
            this.botonConectar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonConectar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonConectar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonConectar.BorderRadius = 40;
            this.botonConectar.BorderSize = 0;
            this.botonConectar.FlatAppearance.BorderSize = 0;
            this.botonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConectar.ForeColor = System.Drawing.Color.White;
            this.botonConectar.Location = new System.Drawing.Point(542, 177);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(96, 40);
            this.botonConectar.TabIndex = 5;
            this.botonConectar.Text = "Buscar";
            this.botonConectar.textColor = System.Drawing.Color.White;
            this.botonConectar.UseVisualStyleBackColor = false;
            this.botonConectar.Click += new System.EventHandler(this.botonConectar_Click);
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
            this.botonRutaGuardar.Location = new System.Drawing.Point(379, 39);
            this.botonRutaGuardar.Name = "botonRutaGuardar";
            this.botonRutaGuardar.Size = new System.Drawing.Size(96, 40);
            this.botonRutaGuardar.TabIndex = 6;
            this.botonRutaGuardar.Text = "Buscar";
            this.botonRutaGuardar.textColor = System.Drawing.Color.White;
            this.botonRutaGuardar.UseVisualStyleBackColor = false;
            this.botonRutaGuardar.Click += new System.EventHandler(this.botonRutaGuardar_Click);
            // 
            // btnbackup
            // 
            this.btnbackup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbackup.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbackup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnbackup.BorderRadius = 40;
            this.btnbackup.BorderSize = 0;
            this.btnbackup.FlatAppearance.BorderSize = 0;
            this.btnbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbackup.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackup.ForeColor = System.Drawing.Color.White;
            this.btnbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbackup.Location = new System.Drawing.Point(332, 214);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(177, 37);
            this.btnbackup.TabIndex = 7;
            this.btnbackup.Text = "Back Up";
            this.btnbackup.textColor = System.Drawing.Color.White;
            this.btnbackup.UseVisualStyleBackColor = false;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
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
            this.botonVolver.TabIndex = 8;
            this.botonVolver.Text = "Volver";
            this.botonVolver.textColor = System.Drawing.Color.White;
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 9;
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
            this.restoreButton.Location = new System.Drawing.Point(169, 76);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(177, 37);
            this.restoreButton.TabIndex = 10;
            this.restoreButton.Text = "Restaurar";
            this.restoreButton.textColor = System.Drawing.Color.White;
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.restoreButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.botonRutaGuardar);
            this.panel2.Location = new System.Drawing.Point(131, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 116);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // Inicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(715, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.btnbackup);
            this.Controls.Add(this.botonConectar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio5";
            this.Text = "Inicio5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private InicioSistema.Controles.botonPersonalizado botonConectar;
        private InicioSistema.Controles.botonPersonalizado botonRutaGuardar;
        private InicioSistema.Controles.botonPersonalizado btnbackup;
        private InicioSistema.Controles.botonPersonalizado botonVolver;
        private System.Windows.Forms.TextBox textBox2;
        private InicioSistema.Controles.botonPersonalizado restoreButton;
        private System.Windows.Forms.Panel panel2;
    }
}