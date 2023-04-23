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

namespace inicio.Administrador
{
    public partial class Inicio : Form
    {
        Usuarios model = new Usuarios();
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

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(textBox1Nombre, "");
            errorProvider1.SetError(textBox2Apellido, "");
            errorProvider1.SetError(textBox3NombreUsuario, "");
            errorProvider1.SetError(textBox4Pass, "");
            errorProvider1.SetError(textBox5Correo, "");
            errorProvider1.SetError(textBox6Direccion, "");
            //errorProvider1.SetError(textBox7FechaNaci, "");
            errorProvider1.SetError(textBox8Telefono, "");
            //errorProvider1.SetError(textBox9Edad, "");



            errorProvider1.SetError(comboBox1Genero, "");
            errorProvider1.SetError(comboBox2Rol, "");
            errorProvider1.SetError(comboBox3Estado, "");
            errorProvider1.SetError(comboBox4EstadoCivil, "");

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
        private bool ValidarCampos()
        {
            bool ok = true;
            if (textBox1Nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1Nombre, "Ingresar Nombre");
            }
            if (textBox4Pass.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox4Pass, "Ingresar Contraseña");
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
            if (comboBox2Rol.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox2Rol, "Seleccione una opción");
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

        }
        void ClearBuscar()
        {
            textBox6.Texts = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }
        void Clear()
        {
            comboBox2Rol.Text = textBox2Apellido.Text = textBox1Nombre.Text = textBox3NombreUsuario.Text = textBox4Pass.Text = comboBox3Estado.Text = comboBox1Genero.Text = comboBox4EstadoCivil.Text = textBox8Telefono.Text = textBox6Direccion.Text = textBox5Correo.Text = textBox10DNI.Text = dateTimePicker1.Text = "";
            //textNombre.Text = textApellido.Text = textCiudad.Text = textDireccion.Text = "";
            //btnGuardar.Text = "Guardar";
            //btnEliminar.Enabled = false;
            model.Id_usuario = 0;
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

                object itemComboxRol = comboBox2Rol.SelectedItem;
                string variableRol = itemComboxRol.ToString();
                if (variableRol == "Administrador")
                {
                    rolActual = 1;
                }
                else
                {
                    if (variableRol == "Gerente")
                    {
                        rolActual = 2;
                    }
                    else
                    {
                        if (variableRol == "Vendedor")
                        {
                            rolActual = 3;
                        }
                    }
                }


                DateTime DFN = Convert.ToDateTime(dateTimePicker1.Text);
                String FechaNac = DFN.ToString("yyyy-MM-dd");
                model.estado_vigencia = vigencia;
                model.nombre = textBox1Nombre.Text.Trim();
                model.apellido = textBox2Apellido.Text.Trim();
                model.dni = textBox10DNI.Text.Trim();
                model.nombre_usuario = textBox3NombreUsuario.Text.Trim();
                model.pass = textBox4Pass.Text.Trim();
                model.sexo = comboBox1Genero.Text.Trim();
                model.estado_civil = comboBox4EstadoCivil.Text.Trim();
                model.telefono = textBox8Telefono.Text.Trim();
                model.Id_rol_usuario = rolActual;
                model.fecha_Nacimiento = DFN;
                model.correo = textBox5Correo.Text.Trim();
                model.domicilio = textBox6Direccion.Text.Trim();

                using (MadereraEntities db = new MadereraEntities())
                {
                    if (model.Id_usuario == 0)//Insert
                        db.Usuarios.Add(model);
                    else //Actualizar
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified; //probar
                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Enviado satisfactoriamente");
            }
        }
        void PopulateDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {
                var varUsuarios = (from cli in db.Usuarios
                                   where cli.estado_vigencia == true
                                   select cli
                            );

                dataGridView.DataSource = varUsuarios.ToList();

            }
            /*dataGridView.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {

                dataGridView.DataSource = db.Usuarios.ToList<Usuarios>();
            }*/
        }

        private void btnEliminaar_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Realmente quiere eliminar el registro?", "Centurion Maderas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (MadereraEntities db = new MadereraEntities())
                {

                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Usuarios.Attach(model);
                    db.Usuarios.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Eliminado Correctamente");
                }*/

            if (MessageBox.Show("Realmente quiere eliminar el registro?", "Centurion Maderas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                object itemComboxEstadoV = comboBox3Estado.SelectedItem;
                string variableEstV = itemComboxEstadoV.ToString();

                if (variableEstV == "Activo")
                {
                    vigencia = false;

                }


                object itemComboxRol = comboBox2Rol.SelectedItem;
                string variableRol = itemComboxRol.ToString();
                if (variableRol == "Administrador")
                {
                    rolActual = 1;
                }
                else
                {
                    if (variableRol == "Gerente")
                    {
                        rolActual = 2;
                    }
                    else
                    {
                        if (variableRol == "Vendedor")
                        {
                            rolActual = 3;
                        }
                    }
                }


                DateTime DFN = Convert.ToDateTime(dateTimePicker1.Text);
                String FechaNac = DFN.ToString("yyyy-MM-dd");
                model.estado_vigencia = vigencia;
                model.nombre = textBox1Nombre.Text.Trim();
                model.apellido = textBox2Apellido.Text.Trim();
                model.dni = textBox10DNI.Text.Trim();
                // model.nombre_usuario = textBox3NombreUsuario.Text.Trim();
                //model.pass = textBox4Pass.Text.Trim();
                model.sexo = comboBox1Genero.Text.Trim();
                model.estado_civil = comboBox4EstadoCivil.Text.Trim();
                model.telefono = textBox8Telefono.Text.Trim();
                model.Id_rol_usuario = rolActual;
                model.fecha_Nacimiento = DFN;
                model.correo = textBox5Correo.Text.Trim();
                model.domicilio = textBox6Direccion.Text.Trim();

                using (MadereraEntities db = new MadereraEntities())
                {
                    if (model.Id_usuario == 0)//Insert
                        db.Usuarios.Add(model);

                    else //Actualizar
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified; //probar
                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();

                MessageBox.Show("Eliminado Correctamente");
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {
                model.Id_usuario = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id_usuario"].Value);

                using (MadereraEntities db = new MadereraEntities())
                {
                    model = db.Usuarios.Where(x => x.Id_usuario == model.Id_usuario).FirstOrDefault();

                    if (model.Id_rol_usuario == 1)
                    {
                        comboBox2Rol.Text = "Administrador";
                    }
                    else
                    {
                        if (model.Id_rol_usuario == 2)
                        {
                            comboBox2Rol.Text = "Gerente";
                        }
                        else
                        {
                            if (model.Id_rol_usuario == 3)
                            {
                                comboBox2Rol.Text = "Vendedor";
                            }
                        }
                    }

                    if (model.estado_vigencia == true)
                    {
                        comboBox3Estado.Text = "Activo";
                    }
                    else
                    {
                        if (model.estado_vigencia == false)
                        {
                            comboBox3Estado.Text = "Inactivo";
                        }

                    }


                    comboBox2Rol.Text = comboBox2Rol.Text;
                    textBox1Nombre.Text = model.nombre;
                    textBox2Apellido.Text = model.apellido;
                    textBox3NombreUsuario.Text = model.nombre_usuario;
                    textBox6Direccion.Text = model.domicilio;
                    textBox5Correo.Text = model.correo;
                    textBox4Pass.Text = model.pass;
                    comboBox4EstadoCivil.Text = model.estado_civil;
                    textBox10DNI.Text = model.dni.ToString();
                    //textBox9Edad.Text = model.edad.ToString();
                    comboBox1Genero.Text = model.sexo;
                    textBox8Telefono.Text = model.telefono.ToString();
                    dateTimePicker1.Text = model.fecha_Nacimiento.ToString();
                    comboBox3Estado.Text = comboBox3Estado.Text;

                }
                btnGuardar.Text = "Actualizar";
                btnEliminaar.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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
            //model.Id_usuario = 0;
        }

        private void botonPersonalizado2_Click(object sender, EventArgs e)
        {
            Clear();
            ClearBuscar();
            PopulateDataGridView();
        }

        private void textBox1Nombre_Validating(object sender, CancelEventArgs e)
        {
            if(textBox1Nombre.Text != "")
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

        private void textBox3NombreUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3NombreUsuario.Text != "")
                errorProvider1.SetError(textBox3NombreUsuario, "");
            else
            {
                errorProvider1.SetError(textBox3NombreUsuario, "Debe ingresar nombre de usuario");
                e.Cancel = true;
            }
        }

        private void textBox4Pass_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4Pass.Text != "")
                errorProvider1.SetError(textBox4Pass, "");
            else
            {
                errorProvider1.SetError(textBox4Pass, "Debe ingresar contraseña");
                e.Cancel = true;
            }
        }

        private void textBox5Correo_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5Correo.Text != "")
                errorProvider1.SetError(textBox5Correo, "");
            else
            {
                errorProvider1.SetError(textBox5Correo, "Debe ingresar un correo eléctronico");
                e.Cancel = true;
            }
        }

        private void textBox6Direccion_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6Direccion.Text != "")
                errorProvider1.SetError(textBox6Direccion, "");
            else
            {
                errorProvider1.SetError(textBox6Direccion, "Debe ingresar una dirección");
                e.Cancel = true;
            }
        }

        private void comboBox2Rol_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox2Rol.Text != "")
                errorProvider1.SetError(comboBox2Rol, "");
            else
            {
                errorProvider1.SetError(comboBox2Rol, "Seleccione un rol de usuario");
                e.Cancel = true;
            }
        }

        private void comboBox4EstadoCivil_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox4EstadoCivil.Text != "")
                errorProvider1.SetError(comboBox4EstadoCivil, "");
            else
            {
                errorProvider1.SetError(comboBox4EstadoCivil, "Seleccione un estado civil");
                e.Cancel = true;
            }
        }

        private void comboBox3Estado_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox3Estado.Text != "")
                errorProvider1.SetError(comboBox3Estado, "");
            else
            {
                errorProvider1.SetError(comboBox3Estado, "Seleccione un estado vigencia");
                e.Cancel = true;
            }
        }

        private void comboBox1Genero_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1Genero.Text != "")
                errorProvider1.SetError(comboBox1Genero, "");
            else
            {
                errorProvider1.SetError(comboBox1Genero, "Seleccione un rol de usuario");
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
                e.Cancel = false;
            }
        }
    }
}
