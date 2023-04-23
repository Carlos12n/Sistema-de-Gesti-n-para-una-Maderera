namespace inicio.Administrador
{
    partial class ventanaR
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
            this.botonPersonalizado1 = new InicioSistema.Controles.botonPersonalizado();
            this.textBoxPersozalizado2 = new inicio.Controles.textBoxPersozalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.botonPersonalizado1.Location = new System.Drawing.Point(112, 250);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(150, 40);
            this.botonPersonalizado1.TabIndex = 0;
            this.botonPersonalizado1.Text = "Aceptar";
            this.botonPersonalizado1.textColor = System.Drawing.Color.White;
            this.botonPersonalizado1.UseVisualStyleBackColor = false;
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click);
            // 
            // textBoxPersozalizado2
            // 
            this.textBoxPersozalizado2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPersozalizado2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxPersozalizado2.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBoxPersozalizado2.BorderSize = 2;
            this.textBoxPersozalizado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersozalizado2.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPersozalizado2.Location = new System.Drawing.Point(94, 158);
            this.textBoxPersozalizado2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPersozalizado2.Multilinie = false;
            this.textBoxPersozalizado2.Name = "textBoxPersozalizado2";
            this.textBoxPersozalizado2.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPersozalizado2.PassWordChar = false;
            this.textBoxPersozalizado2.Size = new System.Drawing.Size(188, 31);
            this.textBoxPersozalizado2.TabIndex = 2;
            this.textBoxPersozalizado2.Texts = "";
            this.textBoxPersozalizado2.UnderLineStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLAVE";
            // 
            // ventanaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(390, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPersozalizado2);
            this.Controls.Add(this.botonPersonalizado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventanaR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventanaR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InicioSistema.Controles.botonPersonalizado botonPersonalizado1;
        private Controles.textBoxPersozalizado textBoxPersozalizado2;
        private System.Windows.Forms.Label label1;
    }
}