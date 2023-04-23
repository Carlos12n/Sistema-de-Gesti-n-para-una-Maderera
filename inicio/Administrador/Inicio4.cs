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
    public partial class Inicio4 : Form
    {
        public Inicio4()
        {
            InitializeComponent();
        }
        Maderas model = new Maderas();
        SqlConnection con = new SqlConnection("server= DESKTOP-88G85UN\\; database=Maderera1; integrated security=true");
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonPersonalizado4_Click(object sender, EventArgs e)
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
                var varMaderas = (from cli in db.Maderas
                                   where cli.estadoVigencia == true
                                   select cli
                            );

                dataGridView.DataSource = varMaderas.ToList(); //db.Clientes.ToList<Clientes>();

            }
        }

        void PopulateDataGridViewInactivos()
        {
            dataGridView.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {
                var varMaderas = (from cli in db.Maderas
                                   where cli.estadoVigencia == false
                                   select cli
                            );

                dataGridView.DataSource = varMaderas.ToList(); ;
            }
        }

        private void botonPersonalizado3_Click(object sender, EventArgs e)
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

                model.idMaderas = Convert.ToInt32(dataGridView.CurrentRow.Cells["idMaderas"].Value);

                using (MadereraEntities db = new MadereraEntities())
                {
                    model = db.Maderas.Where(x => x.idMaderas == model.idMaderas).FirstOrDefault();

                    if (model.estadoVigencia == false)
                    {
                        if (MessageBox.Show("¿Desea Dar de alta el Producto con: " + "?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            model.estadoVigencia = true;
                            MessageBox.Show("Se Dio de Alta Con Exito");

                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto esta vigente");
                        PopulateDataGridViewActivos();
                    }

                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    PopulateDataGridViewInactivos();
                }
            }
        }

        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (ValidarCampoBuscar())
            {
                    string consulta = "select * from Maderas where id_tipoMad =" + textBox6.Texts + "";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, con);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
              
            }
            con.Close();
            ClearBuscar();
        }
        private bool ValidarCampoBuscar()
        {
            bool ok = true;
            if (textBox6.Texts == "")
            {
                ok = false;
                errorProvider1.SetError(textBox6, "Ingresar Tipo");
            }

            return ok;
        }
        void ClearBuscar()
        {
            textBox6.Texts = "";
            //radioButton1.Checked = false;


        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Texts != "")
                errorProvider1.SetError(textBox6, "");
            else
            {
                errorProvider1.SetError(textBox6, "Ingrese el Tipo Madera");
                e.Cancel = false;
            }
        }
    }
}
