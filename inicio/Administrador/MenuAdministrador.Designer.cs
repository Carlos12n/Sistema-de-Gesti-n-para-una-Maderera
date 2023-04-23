namespace inicio.Administrador
{
    partial class MenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.MenuAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelSubMenuUsuarios = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnLIstarUsuario = new System.Windows.Forms.Button();
            this.panelSubmenuProducto = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnListarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lAdmin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreAdmin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnBackUp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnUusuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lHora = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TfechaHora = new System.Windows.Forms.Timer(this.components);
            this.BarraTitulo.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            this.panelSubMenuUsuarios.SuspendLayout();
            this.panelSubmenuProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Tan;
            this.BarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarraTitulo.Controls.Add(this.MenuAdmin);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1240, 35);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // MenuAdmin
            // 
            this.MenuAdmin.AutoSize = true;
            this.MenuAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.MenuAdmin.Location = new System.Drawing.Point(0, 14);
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.Size = new System.Drawing.Size(156, 20);
            this.MenuAdmin.TabIndex = 2;
            this.MenuAdmin.Text = "Menu Administrador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(917, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoScroll = true;
            this.MenuVertical.BackColor = System.Drawing.Color.Tan;
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.panelSubMenuUsuarios);
            this.MenuVertical.Controls.Add(this.panelSubmenuProducto);
            this.MenuVertical.Controls.Add(this.lAdmin);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.nombreAdmin);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.BtnBackUp);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.BtnUusuarios);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.BtnProductos);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(210, 555);
            this.MenuVertical.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tan;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "Restauración";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Facturas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelSubMenuUsuarios
            // 
            this.panelSubMenuUsuarios.Controls.Add(this.panel5);
            this.panelSubMenuUsuarios.Controls.Add(this.panel4);
            this.panelSubMenuUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.panelSubMenuUsuarios.Controls.Add(this.btnLIstarUsuario);
            this.panelSubMenuUsuarios.Location = new System.Drawing.Point(11, 330);
            this.panelSubMenuUsuarios.Name = "panelSubMenuUsuarios";
            this.panelSubMenuUsuarios.Size = new System.Drawing.Size(177, 94);
            this.panelSubMenuUsuarios.TabIndex = 11;
            this.panelSubMenuUsuarios.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PeachPuff;
            this.panel5.Location = new System.Drawing.Point(0, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 42);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 42);
            this.panel4.TabIndex = 9;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.Tan;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.Image")));
            this.btnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(2, -2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(182, 42);
            this.btnAgregarUsuario.TabIndex = 8;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click_1);
            // 
            // btnLIstarUsuario
            // 
            this.btnLIstarUsuario.BackColor = System.Drawing.Color.Tan;
            this.btnLIstarUsuario.FlatAppearance.BorderSize = 0;
            this.btnLIstarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnLIstarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIstarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIstarUsuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnLIstarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnLIstarUsuario.Image")));
            this.btnLIstarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLIstarUsuario.Location = new System.Drawing.Point(-5, 46);
            this.btnLIstarUsuario.Name = "btnLIstarUsuario";
            this.btnLIstarUsuario.Size = new System.Drawing.Size(182, 42);
            this.btnLIstarUsuario.TabIndex = 5;
            this.btnLIstarUsuario.Text = "Buscar";
            this.btnLIstarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLIstarUsuario.UseVisualStyleBackColor = false;
            this.btnLIstarUsuario.Click += new System.EventHandler(this.btnLIstarUsuario_Click_1);
            // 
            // panelSubmenuProducto
            // 
            this.panelSubmenuProducto.Controls.Add(this.panel7);
            this.panelSubmenuProducto.Controls.Add(this.panel6);
            this.panelSubmenuProducto.Controls.Add(this.btnListarProducto);
            this.panelSubmenuProducto.Controls.Add(this.btnAgregarProducto);
            this.panelSubmenuProducto.Location = new System.Drawing.Point(12, 275);
            this.panelSubmenuProducto.Name = "panelSubmenuProducto";
            this.panelSubmenuProducto.Size = new System.Drawing.Size(180, 108);
            this.panelSubmenuProducto.TabIndex = 10;
            this.panelSubmenuProducto.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PeachPuff;
            this.panel7.Location = new System.Drawing.Point(1, 58);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 42);
            this.panel7.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PeachPuff;
            this.panel6.Location = new System.Drawing.Point(1, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 42);
            this.panel6.TabIndex = 10;
            // 
            // btnListarProducto
            // 
            this.btnListarProducto.BackColor = System.Drawing.Color.Tan;
            this.btnListarProducto.FlatAppearance.BorderSize = 0;
            this.btnListarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnListarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProducto.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnListarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnListarProducto.Image")));
            this.btnListarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarProducto.Location = new System.Drawing.Point(8, 60);
            this.btnListarProducto.Name = "btnListarProducto";
            this.btnListarProducto.Size = new System.Drawing.Size(169, 42);
            this.btnListarProducto.TabIndex = 3;
            this.btnListarProducto.Text = "Buscar";
            this.btnListarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarProducto.UseVisualStyleBackColor = false;
            this.btnListarProducto.Click += new System.EventHandler(this.btnListarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Tan;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(4, 7);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(166, 42);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lAdmin
            // 
            this.lAdmin.AutoSize = true;
            this.lAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAdmin.ForeColor = System.Drawing.Color.Sienna;
            this.lAdmin.Location = new System.Drawing.Point(1, 182);
            this.lAdmin.Name = "lAdmin";
            this.lAdmin.Size = new System.Drawing.Size(113, 20);
            this.lAdmin.TabIndex = 9;
            this.lAdmin.Text = "Administrador:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(8, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar Sesión";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreAdmin
            // 
            this.nombreAdmin.AutoSize = true;
            this.nombreAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.nombreAdmin.Location = new System.Drawing.Point(119, 186);
            this.nombreAdmin.Name = "nombreAdmin";
            this.nombreAdmin.Size = new System.Drawing.Size(61, 16);
            this.nombreAdmin.TabIndex = 7;
            this.nombreAdmin.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Location = new System.Drawing.Point(0, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 42);
            this.panel3.TabIndex = 6;
            // 
            // BtnBackUp
            // 
            this.BtnBackUp.BackColor = System.Drawing.Color.Tan;
            this.BtnBackUp.FlatAppearance.BorderSize = 0;
            this.BtnBackUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackUp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackUp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BtnBackUp.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackUp.Image")));
            this.BtnBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBackUp.Location = new System.Drawing.Point(12, 328);
            this.BtnBackUp.Name = "BtnBackUp";
            this.BtnBackUp.Size = new System.Drawing.Size(186, 42);
            this.BtnBackUp.TabIndex = 5;
            this.BtnBackUp.Text = "Back Up";
            this.BtnBackUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBackUp.UseVisualStyleBackColor = false;
            this.BtnBackUp.Click += new System.EventHandler(this.BtnBackUp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 42);
            this.panel2.TabIndex = 4;
            // 
            // BtnUusuarios
            // 
            this.BtnUusuarios.BackColor = System.Drawing.Color.Tan;
            this.BtnUusuarios.FlatAppearance.BorderSize = 0;
            this.BtnUusuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnUusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUusuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUusuarios.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BtnUusuarios.Image = ((System.Drawing.Image)(resources.GetObject("BtnUusuarios.Image")));
            this.BtnUusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUusuarios.Location = new System.Drawing.Point(12, 282);
            this.BtnUusuarios.Name = "BtnUusuarios";
            this.BtnUusuarios.Size = new System.Drawing.Size(186, 42);
            this.BtnUusuarios.TabIndex = 3;
            this.BtnUusuarios.Text = "Usuarios";
            this.BtnUusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUusuarios.UseVisualStyleBackColor = false;
            this.BtnUusuarios.Click += new System.EventHandler(this.BtnUusuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 42);
            this.panel1.TabIndex = 2;
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.Tan;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BtnProductos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductos.Image")));
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(12, 237);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(189, 42);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Wheat;
            this.panelContenedor.Controls.Add(this.lHora);
            this.panelContenedor.Controls.Add(this.lFecha);
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(210, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1030, 555);
            this.panelContenedor.TabIndex = 2;
            // 
            // lHora
            // 
            this.lHora.AutoSize = true;
            this.lHora.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHora.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lHora.Location = new System.Drawing.Point(418, 231);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(83, 36);
            this.lHora.TabIndex = 2;
            this.lHora.Text = "Hora";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lFecha.Location = new System.Drawing.Point(473, 275);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(75, 24);
            this.lFecha.TabIndex = 1;
            this.lFecha.Text = "Fecha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1013, 344);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // TfechaHora
            // 
            this.TfechaHora.Enabled = true;
            this.TfechaHora.Tick += new System.EventHandler(this.TfechaHora_Tick);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministrador";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.panelSubMenuUsuarios.ResumeLayout(false);
            this.panelSubmenuProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBackUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnUusuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MenuAdmin;
        private System.Windows.Forms.Label nombreAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Timer TfechaHora;
        private System.Windows.Forms.Label lAdmin;
        private System.Windows.Forms.Panel panelSubmenuProducto;
        private System.Windows.Forms.Panel panelSubMenuUsuarios;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnListarProducto;
        private System.Windows.Forms.Button btnLIstarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}