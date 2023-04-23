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
    public partial class Inicio3 : Form
    {
        Usuarios model = new Usuarios();

        SqlConnection con = new SqlConnection("server= DESKTOP-88G85UN\\; database=Maderera1; integrated security=true");
        public Inicio3()
        {
            InitializeComponent();
        }
        
        private void BtnListar_Click(object sender, EventArgs e)
        {
            
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void PopulateDataGridView()
        {
            
            dataGridView.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {

                dataGridView.DataSource = db.Usuarios.ToList<Usuarios>();
            }
        }

        private void Inicio3_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void BtnListar_Click_1(object sender, EventArgs e)
        {
            lTitulo.Visible = false;
            lVariable.Visible = true;
            lVariable.Text = "Activos";
            PopulateDataGridViewActivos();
        }

        void PopulateDataGridViewActivos()
        {
            dataGridView.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {
                var varUsuarios = (from cli in db.Usuarios
                                   where cli.estado_vigencia == true
                                   select cli
                            );

                dataGridView.DataSource = varUsuarios.ToList(); //db.Clientes.ToList<Clientes>();

            }
        }

        void PopulateDataGridViewInactivos()
        {
            dataGridView.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {
                var varUsuarios = (from cli in db.Usuarios
                                   where cli.estado_vigencia == false
                                   select cli
                            );

                dataGridView.DataSource = varUsuarios.ToList(); ;//db.Clientes.ToList<Clientes>();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lVariable.Text = "Inactivos";
            lVariable.Visible = true;
            lTitulo.Visible = true;
            PopulateDataGridViewInactivos();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {

                model.Id_usuario = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id_usuario"].Value);

                using (MadereraEntities db = new MadereraEntities())
                {
                    model = db.Usuarios.Where(x => x.Id_usuario == model.Id_usuario).FirstOrDefault();

                    if (model.estado_vigencia == false)
                    {
                        if (MessageBox.Show("¿Desea Dar de alta el Cliente con DNI: " + "?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            model.estado_vigencia = true;
                            MessageBox.Show("Se Dio de Alta Con Exito");

                        }
                    }
                    else
                    {
                        MessageBox.Show("El cliente esta vigente");
                        PopulateDataGridViewActivos();
                    }

                    db.Entry(model).State = System.Data.Entity.EntityState.Modified; 
                    db.SaveChanges();
                    PopulateDataGridViewInactivos();
                }
            }
        }
        void ClearBuscar()
        {
            textBox6.Texts = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }
        private bool ValidarCampoBuscar()
        {
            bool ok = true;
            if (textBox6.Texts == "")
            {
                ok = false;
                errorProvider1.SetError(textBox6, "Ingresar Nombre, Apellido o DNI");
            }

            return ok;
        }
        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            con.Open();

            if (ValidarCampoBuscar())
            {
                if (radioButton1.Checked == true)
                {
                    string consulta = "select * from Usuarios where dni =" + textBox6.Texts + "";
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
                    string consulta = "select * from Usuarios where nombre ='" + textBox6.Texts + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, con);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                }
                else
                if (radioButton3.Checked == true)
                {
                    string consulta = "select * from Usuarios where apellido ='" + textBox6.Texts + "'";
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

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Texts != "")
                errorProvider1.SetError(textBox6, "");
            else
            {
                errorProvider1.SetError(textBox6, "Ingrese el DNI, nombre o apellido");
                e.Cancel = false;
            }
        }
    }
}
