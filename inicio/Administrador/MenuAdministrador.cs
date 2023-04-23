using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Runtime.InteropServices;

namespace inicio.Administrador
{
    public partial class MenuAdministrador : Form
    {
        string usuario;
        ventanaR formularioNombre;
        
        public MenuAdministrador()
        {
            InitializeComponent();
            customizeDesing();
           // formularioNombre = new ventanaR();
        }

        private void customizeDesing()
        {
            panelSubmenuProducto.Visible = false;
            panelSubMenuUsuarios.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubmenuProducto.Visible == true)
                panelSubmenuProducto.Visible = false;
            //probar
            if (panelSubMenuUsuarios.Visible == true)
                panelSubMenuUsuarios.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        public MenuAdministrador(string nombre)
        {
            InitializeComponent();
            nombreAdmin.Text = nombre;
            usuario = nombreAdmin.Text;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //para capturar y poder mover el fomrulario
  /*      [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMenssage")]
        private extern static void SendMenssage(System.IntPtr hWnd, int wMsg, int wParam,  int lPparam);
        */

        int posy = 0;
        int posx = 0;

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //releaseCapture();
            //SendMenssage(this.Handle, 0x112, 0xf012, 0);

            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {            
            showSubMenu(panelSubmenuProducto);
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        
        private void AgregarP_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnUusuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuUsuarios);



        }

        private void agregarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loguin = new Form1();
            loguin.Show();
        }

        private void TfechaHora_Tick(object sender, EventArgs e)
        {
            lHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //showSubMenu(panelSubmenuProducto);
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio5());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //showSubMenu(panelSubmenuProducto);
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio2());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
          
            hideSubMenu();
            //showSubMenu(panelSubmenuProducto);
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio4());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            
            hideSubMenu();
            //showSubMenu(panelSubMenuUsuarios);
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio3());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //showSubMenu(panelSubmenuProducto);
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio2());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnListarProducto_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //showSubMenu(panelSubmenuProducto);
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio4());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            //showSubMenu(panelSubMenuUsuarios);//probar
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnLIstarUsuario_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            //showSubMenu(panelSubMenuUsuarios);
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio3());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //showSubMenu(panelSubmenuProducto);
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio6());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            //formularioNombre = new ventanaR();
            //formularioNombre.ShowDialog();
            
            hideSubMenu();
                if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            AbrirFormHija(new Inicio7());
            lHora.Visible = false;
            lFecha.Visible = false;
            pictureBox2.Visible = false;

        }
    }
}
