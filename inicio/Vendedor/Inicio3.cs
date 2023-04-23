using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inicio.Vendedor
{
    public partial class Inicio3 : Form
    {
        Clientes clienteEntity = new Clientes();
        SqlConnection con = new SqlConnection("server= DESKTOP-88G85UN\\; database=Maderera1; integrated security=true");
        public Inicio3()
        {
            InitializeComponent();
        }
        string dni_cb;
        string estad;
        string tipo;
        string estadosistema;
        string apellidoB;
        string nombreB;

        private void BtnListar_Click(object sender, EventArgs e)
        {
            lTitulo.Visible = false;
            lVariable.Visible = true;
            lVariable.Text = "Activos";
            PopulateDataGridViewActivos();
            /*
            //definio una estructura de datos de tipo tabla
            DataTable datos = new DataTable();
            datos.Columns.Add("id usuario");
            datos.Columns.Add("id rol");
            datos.Columns.Add("nombre");
            datos.Columns.Add("apellido");
            datos.Columns.Add("nombre usuario");
            datos.Columns.Add("contraseña");
            datos.Columns.Add("Estado Vigencia");
            datos.Columns.Add("Sexo");
            datos.Columns.Add("Edad");
            datos.Columns.Add("Estado Civil");
            datos.Columns.Add("Telefono");
            datos.Columns.Add("Domicilio");
            datos.Columns.Add("Correo");
            datos.Columns.Add("DNI");
            datos.Columns.Add("Fecha Nacimiento");
            //se establece la conexion
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = inicio.Properties.Settings.Default.rutaConex;
            //realizo la consulta
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "select u.Id_usuario as id_usu,u.Id_rol_usuario as id_rol,u.apellido as apellido, u.nombre as nombre, u.nombre_usuario as usuario_nombre, u.pass as contraseña, u.estado_vigencia as estadoV,u.sexo as sexo, u.edad as edad, u.estado_civil as civil_est, u.telefono as telefono,  u.domicilio as direccion, u.correo as email, u.dni as DNI, u.fecha_Nacimiento as nacimiento from Usuarios u; ";
            consulta.Connection = conexion;
            //verifico si esta abierto la conxion
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            //defino un variable para recorrer los datos obtenidos
            SqlDataReader lectura = consulta.ExecuteReader();

            if (lectura.HasRows)
            {
                while (lectura.Read())
                {
                    datos.Rows.Add(lectura["Id_usu"].ToString(), lectura["Id_rol"].ToString(), lectura["apellido"].ToString(),
                        lectura["nombre"].ToString(), lectura["usuario_nombre"].ToString(), lectura["contraseña"].ToString(),
                        lectura["estadoV"].ToString(), lectura["sexo"].ToString(), lectura["edad"].ToString(),
                        lectura["civil_est"].ToString(), lectura["telefono"].ToString(), lectura["direccion"].ToString(),
                        lectura["email"].ToString(), lectura["DNI"].ToString(), lectura["nacimiento"].ToString());
                }//fin mientras
                lectura.Close();
            }//fin if hasRows

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            dataGridListado.DataSource = datos;
    */
        }


        void PopulateDataGridViewActivos()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {
                var varClientes = (from cli in db.Clientes
                                   where cli.estado_vigencia == true
                                   select cli
                            );

                dataGridView1.DataSource = varClientes.ToList(); //db.Clientes.ToList<Clientes>();

            }
        }

        void PopulateDataGridViewInactivos()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {
                var varClientes = (from cli in db.Clientes
                                   where cli.estado_vigencia == false
                                   select cli
                            );

                dataGridView1.DataSource = varClientes.ToList(); ;//db.Clientes.ToList<Clientes>();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lVariable.Text = "Inactivos";
            lVariable.Visible = true;
            lTitulo.Visible = true;
            PopulateDataGridViewInactivos();
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {



            if (dataGridView1.CurrentRow.Index != -1)
            {

                clienteEntity.Id_cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Cliente"].Value);

                //if (MessageBox.Show("¿Desea Dar de alta el Cliente con DNI: " + "?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{


                using (MadereraEntities db = new MadereraEntities())
                {
                    clienteEntity = db.Clientes.Where(x => x.Id_cliente == clienteEntity.Id_cliente).FirstOrDefault();

                    if (clienteEntity.estado_vigencia == false)
                    {
                        if (MessageBox.Show("¿Desea Dar de alta el Cliente con DNI: " + "?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            clienteEntity.estado_vigencia = true;
                            MessageBox.Show("Se Dio de Alta Con Exito");
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("El cliente esta vigente");
                        PopulateDataGridViewActivos();
                    }

                    db.Entry(clienteEntity).State = System.Data.Entity.EntityState.Modified; //probar
                    db.SaveChanges();
                    PopulateDataGridViewInactivos();
                }

               


            }
            }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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
        void ClearBuscar()
        {
            textBox6.Texts = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }
        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (ValidarCampoBuscar())
            {
                if (radioButton1.Checked == true)
                {
                    string consulta = "select * from Clientes where dni =" + textBox6.Texts + "";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, con);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                }
                else
                    if (radioButton2.Checked == true)
                {
                    string consulta = "select * from Clientes where nombre ='" + textBox6.Texts + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, con);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                }
                else
                    if (radioButton3.Checked == true)
                {
                    string consulta = "select * from Clientes where apellido ='" + textBox6.Texts + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, con);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                }

            }
            con.Close();
            ClearBuscar();
            /*
            using (MadereraEntities db = new MadereraEntities())
            {

                if (textBoxPersozalizado3.Texts.Trim().Length != 0)
                {
                    if (textBoxPersozalizado3.Texts.All(char.IsDigit))
                    {
                        dni_cb = textBoxPersozalizado3.Texts;

                        var climo = (from cli in db.Clientes
                                     where cli.dni == dni_cb
                                     select cli);

                        Clientes encontrado = climo.FirstOrDefault();
                        if (climo.FirstOrDefault() != null)
                        {
                            //aca compara si es el estado correccto

                            if (encontrado.estado_vigencia == true)
                            {
                                estadosistema = "Alta";
                                if (encontrado.Id_tipo_cliente == 1)
                                {
                                    tipo = "Comsumidor Final";

                                }
                                else
                                {
                                    if (encontrado.Id_tipo_cliente == 2)
                                    {
                                        tipo = "Otro";

                                    }
                                    else
                                    {
                                        if (encontrado.Id_tipo_cliente == 3)
                                        {
                                            tipo = "Responsable Inscripto";

                                        }

                                    }

                                }
                            }

                            else
                            {
                                if (encontrado.estado_vigencia == false)
                                {

                                    estadosistema = "Baja";

                                    if (encontrado.Id_tipo_cliente == 1)
                                    {
                                        tipo = "Comsumidor Final";

                                    }
                                    else
                                    {
                                        if (encontrado.Id_tipo_cliente == 2)
                                        {
                                            tipo = "Responsable Inscripto";

                                        }
                                        else
                                        {
                                            if (encontrado.Id_tipo_cliente == 3)
                                            {
                                                tipo = "Otro";

                                            }

                                        }

                                    }
                                }

                            }
                            dataGridView1.Rows.Add(encontrado.dni, encontrado.apellido, encontrado.nombre, tipo, encontrado.telefono, estadosistema, encontrado.correo);
                            // textBoxCliente.Texts = dni_cb;
                            //textBoxTipoCliente.Texts = tipo;
                            textBoxPersozalizado3.Texts = "";
                        }
                        else
                        {
                            MessageBox.Show("El Cliente No Existe", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                    else //es en caso de que no encuentre el dni
                    {

                        apellidoB = textBoxPersozalizado3.Texts.Trim();

                        List<Clientes> ClientesB = (from clientesB in db.Clientes
                                                    where clientesB.apellido.Trim() == apellidoB
                                                    select clientesB).ToList();

                        if (ClientesB.FirstOrDefault() == null)
                        {
                            nombreB = textBoxPersozalizado3.Texts.Trim();
                            ClientesB = (from clientesB in db.Clientes
                                         where clientesB.nombre == nombreB
                                         select clientesB).ToList();

                        }

                        if (ClientesB.FirstOrDefault() != null)
                        {

                            foreach (Clientes cli in ClientesB)
                            {

                                if (cli.estado_vigencia == true)
                                {
                                    estadosistema = "Alta";
                                    if (cli.Id_tipo_cliente == 1)
                                    {
                                        tipo = "Comsumidor Final";

                                    }
                                    else
                                    {
                                        if (cli.Id_tipo_cliente == 2)
                                        {
                                            tipo = "Otro";

                                        }
                                        else
                                        {
                                            if (cli.Id_tipo_cliente == 3)
                                            {
                                                tipo = "Responsable Inscripto";

                                            }

                                        }

                                    }
                                }

                                else
                                {
                                    if (cli.estado_vigencia == false)
                                    {

                                        estadosistema = "Baja";

                                        if (cli.Id_tipo_cliente == 1)
                                        {
                                            tipo = "Comsumidor Final";

                                        }
                                        else
                                        {
                                            if (cli.Id_tipo_cliente == 2)
                                            {
                                                tipo = "Otro";

                                            }
                                            else
                                            {
                                                if (cli.Id_tipo_cliente == 3)
                                                {
                                                    tipo = "Responsable Inscripto";

                                                }

                                            }

                                        }
                                    }

                                }
                                // textBoxCliente.Texts = nombreB;
                                //textBoxTipoCliente.Texts = tipo;
                                //ACA AGERGAR CAMPOS FALTANTES
                                textBoxPersozalizado3.Texts = "";
                                this.dataGridView1.Rows.Add(cli.dni, cli.apellido, cli.nombre, tipo, cli.telefono, estadosistema, cli.correo);
                            }
                        }

                        else
                        {
                            MessageBox.Show("El Cliente " + textBoxPersozalizado3.Texts + " No se Encontro Vuelva A intentar", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else//si no hay caracteres en el textbox
                {
                    MessageBox.Show("Ingrese datos para realizar busqueda", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */
        }

        private void textBox6__textChanged(object sender, EventArgs e)
        {

        }

        private void botonPersonalizado2_Click(object sender, EventArgs e)
        {
            
            ClearBuscar();
            
        }
    }
    }
