using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace inicio.Vendedor
{
    public partial class Inicio : Form
    {
        Clientes clienteEntity = new Clientes();
        SqlConnection con = new SqlConnection("server= DESKTOP-88G85UN\\; database=Maderera1; integrated security=true");
        bool vigencia;
        int rolActual;

        public Inicio()
        {
            InitializeComponent();
        }
        //int idRolConvertido = 0;
        //bool estadoVigenciaConvertido;

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            panelDatos.Visible = true;

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            panelDatos.Visible = true;
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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
        private void botonInsertar_Click(object sender, EventArgs e)
        {
            /*
            BorrarMensajeError();
            if (ValidarCampos())
            {
               
               

                int edadConvertido = Int32.Parse(textBox9Edad.Text);
                // MessageBox.Show("Datos Ingresados correctamente");

              
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = inicio.Properties.Settings.Default.rutaConex;

                object itemComboxRol = comboBox2Rol.SelectedItem;
                string variableCompara = itemComboxRol.ToString();

                if (variableCompara == "Administrador")
                {
                    idRolConvertido = 1;
                }
                else
                {
                    if (variableCompara == "Gerente")
                    {
                        idRolConvertido = 2;
                    }
                    else
                    {
                        idRolConvertido = 3;
                    }
                }

                object itemComboxEstadoV = comboBox3Estado.SelectedItem;
                string variableCompara1 = itemComboxRol.ToString();

                if (variableCompara == "Activo")
                {
                    estadoVigenciaConvertido = true;
                }
                else
                {
                    if (variableCompara == "Inactivo")
                    {
                        estadoVigenciaConvertido = false;
                    }
                    
                }

                conexion.Open();

                string cadenaInsert = "insert into Usuarios (Id_rol_usuario, apellido, nombre, nombre_usuario, pass, estado_vigencia, sexo, edad, estado_civil,telefono, domicilio, correo, dni, fecha_Nacimiento)values('" + idRolConvertido + "', '" + textBox2Apellido.Text + "', '" + textBox1Nombre.Text + "', '" +"', '" + estadoVigenciaConvertido + "', '" + comboBox1Genero.Text + "', '" + edadConvertido + "', '" + comboBox4EstadoCivil.Text + "', '" + textBox8Telefono.Text + "', '" + textBox6Direccion.Text + "', '" + textBox5Correo.Text + "','" + textBox10DNI.Text + "', CAST(N'" + textBox7FechaNaci.Text + "' AS Date)); ";
                SqlCommand comando2 = new SqlCommand(cadenaInsert, conexion);
                comando2.ExecuteNonQuery();

                MessageBox.Show("Se Agrego con Exito el Usuario: " + textBox1Nombre.Text);
               // mostrar();
                /*              aca agregar metodo para que aparezca la nueva insecion en el data grid
                                 este metedo es afuera de este boton es decir un listar aparte        
                                 
    
                                comboBox2Rol.Text = "";
                                textBox2Apellido.Text = "";
                                textBox1Nombre.Text = "";
                                textBox3NombreUsuario.Text = "";
                                textBox4Pass.Text = "";
                                comboBox3Estado.Text = "";
                                comboBox1Genero.Text = "";
                                textBox9Edad.Text = "";
                                comboBox4EstadoCivil.Text = "";
                                textBox8Telefono.Text = "";
                                textBox6Direccion.Text = "";
                                textBox5Correo.Text = "";
                                textBox10DNI.Text = "";
                                textBox7FechaNaci.Text = "";
                
                conexion.Close();
                
        }
        */
        }
        /*
        private void mostrar()
        {
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

            dataGridView1.DataSource = datos;

        }*/
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(textBox1Nombre, "");
            errorProvider1.SetError(textBox2Apellido, "");
            //errorProvider1.SetError(textBox3NombreUsuario, "");
            //errorProvider1.SetError(textBox4Pass, "");
            errorProvider1.SetError(textBox5Correo, "");
            errorProvider1.SetError(textBox6Direccion, "");
            errorProvider1.SetError(dateTimePicker1, "");
            errorProvider1.SetError(textBox8Telefono, "");
            //errorProvider1.SetError(textBox9Edad, "");
            


            errorProvider1.SetError(comboBox1Genero, "");
            errorProvider1.SetError(comboBox2TipoCliente, "");
            errorProvider1.SetError(comboBox3Estado, "");
            errorProvider1.SetError(comboBox4EstadoCivil, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (textBox1Nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1Nombre, "Ingresar Nombre");
            }
            if (textBox8Telefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox8Telefono, "Ingresar Tèlefono");
            }
            if (textBox2Apellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox2Apellido, "Ingresar Apelido");
            }
            if (textBox10DNI.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox10DNI, "Ingresar Dni");
            }
            if (comboBox1Genero.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox1Genero, "Seleccione una opción");
            }
            if (comboBox2TipoCliente.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox2TipoCliente, "Seleccione una opción");
            }
            if (comboBox4EstadoCivil.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox4EstadoCivil, "Seleccione una opción");
            }
            if (comboBox3Estado.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox3Estado, "Seleccione una opción");
            }
            if (textBox5Correo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox5Correo, "Ingresar Correo Eléctronico");
            }
            if (textBox6Direccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox6Direccion, "Ingresar Dirección");
            }
            if (dateTimePicker1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePicker1, "Ingresar Fecha Nacimiento");
            }
            return ok;
        }

        private void textBox9Edad_Validating(object sender, CancelEventArgs e)
        {
            /*
            int num;
            if (!int.TryParse(textBox9Edad.Text, out num))
            {
                errorProvider1.SetError(textBox9Edad, "Ingrese valor numerico");
            }
            else
            {
                errorProvider1.SetError(textBox9Edad, "");
            }*/
        }

        private void textBox7FechaNaci_Validating(object sender, CancelEventArgs e)
        {
            DateTime cumple;
            if (!DateTime.TryParse(dateTimePicker1.Text, out cumple))
            {
                errorProvider1.SetError(dateTimePicker1, "El formato debe ser DD-MM-YY");
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, "");
            }
        }

        private void textBox10DNI_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox10DNI.Text, out num))
            {
                errorProvider1.SetError(textBox10DNI, "Ingrese valor numerico");
            }
            else
            {
                errorProvider1.SetError(textBox10DNI, "");
            }
        }

        private void textBox8Telefono_Validating(object sender, CancelEventArgs e)
        {
            if (textBox8Telefono.Text != "")
                errorProvider1.SetError(textBox8Telefono, "");
            else
            {
                errorProvider1.SetError(textBox8Telefono, "Debe ingresar telefono");
                e.Cancel = true;
            }
        }

        private void textBox9Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Nuneros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox10DNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Nuneros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten Letras", "::::::::::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //textBox1Nombre.CharacterCasing = CharacterCasing.Upper; //para mayuscula
            }
        }

        private void textBox2Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten Letras", "::::::::::", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
        public static bool ValidarEmail(string comprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(comprobarEmail, emailFormato))
            {
                if (Regex.Replace(comprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textCorreo(object sender, EventArgs e)
        {
            if (ValidarEmail(textBox5Correo.Text) == false)
            {
                MessageBox.Show("Ingrese un email Valido", "nombre@dominio.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void botonPersonalizado3_Click(object sender, EventArgs e)
        {
            //this.Close();
            Clear();
            btnGuardar.Text = "Insertar";
            btnEliminaar.Visible = false;

        }
        void Clear()
        {
            comboBox2TipoCliente.Text = textBox2Apellido.Text = textBox1Nombre.Text = comboBox3Estado.Text = comboBox1Genero.Text = comboBox4EstadoCivil.Text = textBox8Telefono.Text =textBox6Direccion.Text = textBox5Correo.Text = textBox10DNI.Text=dateTimePicker1.Text = "";
            //textNombre.Text = textApellido.Text = textCiudad.Text = textDireccion.Text = "";
            //btnGuardar.Text = "Guardar";
            //btnEliminar.Enabled = false;
            clienteEntity.Id_cliente = 0;
        }

        private void textBox6Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                object itemComboxEstadoV = comboBox3Estado.SelectedItem;
                string variableEstV = itemComboxEstadoV.ToString();

                if (variableEstV == "Activo")
                {
                    vigencia = true;

                }
                else
                {
                    vigencia = false;
                }

                object itemComboxRol = comboBox2TipoCliente.SelectedItem;
                string variableRol = itemComboxRol.ToString();
                if (variableRol == "Consumidor Final")
                {
                    rolActual = 1;
                }
                else
                {
                    if (variableRol == "Responsable Inscripto")
                    {
                        rolActual = 2;
                    }
                    else
                    {
                        if (variableRol == "Otro")
                        {
                            rolActual = 3;
                        }
                    }
                }


                DateTime DFN = Convert.ToDateTime(dateTimePicker1.Text);
                String FechaNac = DFN.ToString("yyyy-MM-dd");
                clienteEntity.estado_vigencia = vigencia;
                clienteEntity.nombre = textBox1Nombre.Text.Trim();
                clienteEntity.apellido = textBox2Apellido.Text.Trim();
                clienteEntity.dni = textBox10DNI.Text.Trim();
                // model.nombre_usuario = textBox3NombreUsuario.Text.Trim();
                //model.pass = textBox4Pass.Text.Trim();
                clienteEntity.sexo = comboBox1Genero.Text.Trim();
                clienteEntity.estado_civil = comboBox4EstadoCivil.Text.Trim();
                clienteEntity.telefono = textBox8Telefono.Text.Trim();
                clienteEntity.Id_tipo_cliente = rolActual;
                clienteEntity.fecha_Nacimiento = DFN;
                clienteEntity.correo = textBox5Correo.Text.Trim();
                clienteEntity.domicilio = textBox6Direccion.Text.Trim();
                //            int edadC = Convert.ToInt32(textBox9Edad.Text);
                //          String Cedad = edadC.ToString("11");
                //        clienteEntity.edad = edadC;//probar
                using (MadereraEntities db = new MadereraEntities())
                {
                    if (clienteEntity.Id_cliente == 0)//Insert
                        db.Clientes.Add(clienteEntity);

                    else //Actualizar
                        db.Entry(clienteEntity).State = System.Data.Entity.EntityState.Modified; //probar
                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Enviado satisfactoriamente");
            }
        }
        void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {
                var varClientes = (from cli in db.Clientes
                                   where cli.estado_vigencia == true
                                   select cli
                            );

                dataGridView1.DataSource = varClientes.ToList();
                
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnEliminaar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente quiere eliminar el registro?", "EF-Crud Opeacxion", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
                object itemComboxEstadoV = comboBox3Estado.SelectedItem;
            string variableEstV = itemComboxEstadoV.ToString();

            if (variableEstV == "Activo")
            {
                vigencia = false;

            }
            /*
            else
            {
                vigencia = false;
            }*/

            object itemComboxRol = comboBox2TipoCliente.SelectedItem;
            string variableRol = itemComboxRol.ToString();
            if (variableRol == "Consumidor Final")
            {
                rolActual = 1;
            }
            else
            {
                if (variableRol == "Responsable Inscripto")
                {
                    rolActual = 2;
                }
                else
                {
                    if (variableRol == "Otro")
                    {
                        rolActual = 3;
                    }
                }
            }


            DateTime DFN = Convert.ToDateTime(dateTimePicker1.Text);
            String FechaNac = DFN.ToString("yyyy-MM-dd");
            clienteEntity.estado_vigencia = vigencia;
            clienteEntity.nombre = textBox1Nombre.Text.Trim();
            clienteEntity.apellido = textBox2Apellido.Text.Trim();
            clienteEntity.dni = textBox10DNI.Text.Trim();
            // model.nombre_usuario = textBox3NombreUsuario.Text.Trim();
            //model.pass = textBox4Pass.Text.Trim();
            clienteEntity.sexo = comboBox1Genero.Text.Trim();
            clienteEntity.estado_civil = comboBox4EstadoCivil.Text.Trim();
            clienteEntity.telefono = textBox8Telefono.Text.Trim();
            clienteEntity.Id_tipo_cliente = rolActual;
            clienteEntity.fecha_Nacimiento = DFN;
            clienteEntity.correo = textBox5Correo.Text.Trim();
            clienteEntity.domicilio = textBox6Direccion.Text.Trim();
            //int edadC = Convert.ToInt32(textBox9Edad.Text);
            //String Cedad = edadC.ToString("11");
            //clienteEntity.edad = edadC;//probar
            using (MadereraEntities db = new MadereraEntities())
            {
                if (clienteEntity.Id_cliente == 0)//Insert
                    db.Clientes.Add(clienteEntity);

                else //Actualizar
                    db.Entry(clienteEntity).State = System.Data.Entity.EntityState.Modified; //probar
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            
            MessageBox.Show("Eliminado Correctamente");
                }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                clienteEntity.Id_cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Cliente"].Value);

                using (MadereraEntities db = new MadereraEntities())
                {
                    clienteEntity = db.Clientes.Where(x => x.Id_cliente == clienteEntity.Id_cliente).FirstOrDefault();
                                        
                    if (clienteEntity.Id_tipo_cliente == 1)
                    {
                        comboBox2TipoCliente.Text = "Consumidor Final";
                    }
                    else
                    {
                        if (clienteEntity.Id_tipo_cliente == 2)
                        {
                            comboBox2TipoCliente.Text = "Responsable Inscripto";
                        }
                        else
                        {
                            if (clienteEntity.Id_tipo_cliente == 3)
                            {
                                comboBox2TipoCliente.Text = "Otro";
                            }
                        }
                    }

                    if (clienteEntity.estado_vigencia == true)
                    {
                        comboBox3Estado.Text = "Activo";
                    }
                    else
                    {
                        if (clienteEntity.estado_vigencia == false)
                        {
                            comboBox3Estado.Text = "Inactivo";
                        }

                    }

                    textBox1Nombre.Text = clienteEntity.nombre;
                    textBox2Apellido.Text = clienteEntity.apellido;
                    // textBox3NombreUsuario.Text = model.nombre_usuario;
                    textBox6Direccion.Text = clienteEntity.domicilio;
                    textBox5Correo.Text = clienteEntity.correo;
                    //  textBox4Pass.Text = model.pass;
                    comboBox4EstadoCivil.Text = clienteEntity.estado_civil;
                    comboBox2TipoCliente.Text = comboBox2TipoCliente.Text;
                    textBox10DNI.Text = clienteEntity.dni.ToString();
                    //textBox9Edad.Text = clienteEntity.edad.ToString();
                    comboBox1Genero.Text = clienteEntity.sexo;
                    textBox8Telefono.Text = clienteEntity.telefono.ToString();
                    dateTimePicker1.Text = clienteEntity.fecha_Nacimiento.ToString();
                    //  textBox1.Text = textBox1.Text;
                    comboBox3Estado.Text = comboBox3Estado.Text;

                }
                btnGuardar.Text = "Modificar";
                //btnEliminaar.Enabled = true;
                btnEliminaar.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            //errorProvider1.SetError(textBox6, "");
        }

        private void botonPersonalizado2_Click(object sender, EventArgs e)
        {
            Clear();
            ClearBuscar();
            PopulateDataGridView();
        }

        private void textBox1Nombre_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1Nombre.Text != "")
                errorProvider1.SetError(textBox1Nombre, "");
            else
            {
                errorProvider1.SetError(textBox1Nombre, "Debe ingresar nombre");
                e.Cancel = true;
            }
        }

        private void textBox2Apellido_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2Apellido.Text != "")
                errorProvider1.SetError(textBox2Apellido, "");
            else
            {
                errorProvider1.SetError(textBox2Apellido, "Debe ingresar apellido");
                e.Cancel = true;
            }
        }

        private void textBox10DNI_Validating_1(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox10DNI.Text, out num))
            {
                errorProvider1.SetError(textBox10DNI, "Ingrese valor numerico");
            }
            else
            {
                errorProvider1.SetError(textBox10DNI, "");
            }
        }

        private void textBox8Telefono_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBox8Telefono.Text != "")
                errorProvider1.SetError(textBox8Telefono, "");
            else
            {
                errorProvider1.SetError(textBox8Telefono, "Debe ingresar telefono");
                e.Cancel = true;
            }
        }

        private void comboBox2TipoCliente_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox2TipoCliente.Text != "")
                errorProvider1.SetError(comboBox2TipoCliente, "");
            else
            {
                errorProvider1.SetError(comboBox2TipoCliente, "Seleccione un tipo de cliente");
                e.Cancel = true;
            }
        }

        private void comboBox4EstadoCivil_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox4EstadoCivil.Text != "")
                errorProvider1.SetError(comboBox4EstadoCivil, "");
            else
            {
                errorProvider1.SetError(comboBox4EstadoCivil, "Seleccione su estado civil");
                e.Cancel = true;
            }
        }

        private void comboBox1Genero_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1Genero.Text != "")
                errorProvider1.SetError(comboBox1Genero, "");
            else
            {
                errorProvider1.SetError(comboBox1Genero, "Seleccione su genero");
                e.Cancel = true;
            }
        }

        private void textBox5Correo_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5Correo.Text != "")
                errorProvider1.SetError(textBox5Correo, "");
            else
            {
                errorProvider1.SetError(textBox5Correo, "Debe ingresar un correo");
                e.Cancel = true;
            }
        }

        private void textBox6Direccion_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6Direccion.Text != "")
                errorProvider1.SetError(textBox6Direccion, "");
            else
            {
                errorProvider1.SetError(textBox6Direccion, "Debe ingresar telefono");
                e.Cancel = true;
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Texts != "")
                errorProvider1.SetError(textBox6, "");
            else
            {
                errorProvider1.SetError(textBox6, "Ingrese el DNI, nombre o apellido");
                e.Cancel = true;
            }
        }

        private void comboBox3Estado_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox3Estado.Text != "")
                errorProvider1.SetError(comboBox3Estado, "");
            else
            {
                errorProvider1.SetError(comboBox3Estado, "Seleccione su estado vigencia");
                e.Cancel = false;///probando false para que me deje seleccionar otros texboxs
            }
        }

        private void textBox5Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox5Correo_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(textBox5Correo.Text) == false)
            {
                MessageBox.Show("Ingrese un email Valido", "nombre@dominio.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void textBox5Correo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
