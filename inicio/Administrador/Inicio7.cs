using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inicio.Administrador
{
    public partial class Inicio7 : Form
    {
        SqlConnection con = new SqlConnection("server= DESKTOP-88G85UN\\; database=Maderera1; integrated security=true");
        public Inicio7()
        {
            InitializeComponent();
            
        }

        private void botonRutaGuardar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                restoreButton.Enabled = true;
                panel2.Visible = false;
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            con.Open();

            try
            {

                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox2.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();

                string srt3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(srt3, con);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Database restaurada con éxito");
                con.Close();
                panel2.Visible = false;


            }
            catch
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            string clave;
            clave="ob2022jk";
            if (textBoxClave.Texts == clave)
            {
                label3.Visible = true;
                textBox2.Visible = true;
                botonRutaGuardar.Visible = true;
                restoreButton.Visible = true;
                panel2.Visible = true;
                label2.Visible = false;
                textBoxClave.Visible = false;
                botonPersonalizado1.Visible = false;

            }
            else
            {
                MessageBox.Show("Contraseña Incorrectos Intente De Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxClave.Texts = "";
            }
        }

        private void textBoxClave_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxClave.Texts != "")
                errorProvider1.SetError(textBoxClave, "");
            else
            {
                errorProvider1.SetError(textBoxClave, "Ingrese la clave");
                e.Cancel = false;
            }
        }
    }
}
