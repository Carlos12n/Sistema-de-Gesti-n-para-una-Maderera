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
    public partial class Inicio6 : Form
    {
        Facturas model = new Facturas();
        SqlConnection con = new SqlConnection("server= DESKTOP-88G85UN\\; database=Maderera1; integrated security=true");
        public Inicio6()
        {
            InitializeComponent();
        }
        private bool ValidarCampoBuscar()
        {
            bool ok = true;
            if (textBox6.Texts == "")
            {
                ok = false;
                errorProvider1.SetError(textBox6, "Ingresar Tipo o Descripción");
            }

            return ok;
        }
        void ClearBuscar()
        {
            textBox6.Texts = "";
            radioButton1.Checked = false;


        }
        void PopulateDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {

                dataGridView.DataSource = db.Maderas.ToList<Maderas>();
            }
        }

        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (ValidarCampoBuscar())
            {
                if (radioButton1.Checked == true)
                {
                    string consulta = "select * from Facturas where NumeroFac =" + textBox6.Texts + "";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, con);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                }
                else
                    if (radioButton2.Checked == true)
                {
                    string consulta = "select * from Facturas where fecha ='" + textBox6.Texts + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, con);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                }
               }
            con.Close();
            ClearBuscar();
        }

        private void Inicio6_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
