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
    public partial class Inicio2 : Form
    {
        Maderas model = new Maderas();
        SqlConnection con = new SqlConnection("server= DESKTOP-88G85UN\\; database=Maderera1; integrated security=true");
        bool vigencia;
        int tipoActual;
        public Inicio2()
        {
            InitializeComponent();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {

        }

        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {

                MessageBox.Show("Datos Ingresados correctamente");
            }
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(textBox1DEscripcion, "");
            errorProvider1.SetError(textBox2PrecioVenta, "");
            errorProvider1.SetError(textBox3StockActual, "");
            
           
            errorProvider1.SetError(comboBox1Estado, "");
            errorProvider1.SetError(comboBox2TipoMad, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (textBox1DEscripcion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1DEscripcion, "Ingresar Descripción");
            }
            if (textBox2PrecioVenta.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox2PrecioVenta, "Ingresar Precio Venta");
            }
            if (textBox1Costo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1Costo, "Ingresar Precio Costo");
            }
            if (textBox3StockActual.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox3StockActual, "Ingresar Stock");
            }
            if (textBox1StockMinimo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1StockMinimo, "Ingresar Stock");
            }
            if (comboBox1Estado.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox1Estado, "Seleccione una opción");
            }
            if (comboBox2TipoMad.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox2TipoMad, "Seleccione una opción");
            }
            return ok;
        }

        private void textBox3Stock_Validating(object sender, CancelEventArgs e)
        {

            int num;
            if (!int.TryParse(textBox3StockActual.Text, out num))
            {
                errorProvider1.SetError(textBox3StockActual, "Ingrese valor numerico");
            }
            else
            {
                errorProvider1.SetError(textBox3StockActual, "");
            }
        }

        private void textBox1DEscripcion_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1DEscripcion.Text != "")
                errorProvider1.SetError(textBox1DEscripcion, "");
            else
            {
                errorProvider1.SetError(textBox1DEscripcion, "Debe ingresar una descripción");
                e.Cancel = false;//cambio a false
            }
        }

        private void textBox3Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Nuneros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1DEscripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void botonPersonalizado2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
                object itemTipoMad = comboBox2TipoMad.SelectedItem;
                string variableTipo = itemTipoMad.ToString();
               
                switch (variableTipo)
                {
                    case "Tirante":
                        tipoActual = 1;
                        break;
                    case "Clavadoras":
                        tipoActual = 2;
                        break;
                    case "Tablas":
                        tipoActual = 3;
                        break;
                    case "Machimbre":
                        tipoActual = 4;
                        break;
                    case "Tablon":
                        tipoActual = 5;
                        break;
                    case "Tirantillo":
                        tipoActual = 6;
                        break;
                    default:
                        tipoActual = 7;
                        break;
                }
                model.id_tipoMad = tipoActual;


                object itemComboxEstadoV = comboBox1Estado.SelectedItem;
                string variableEstV = itemComboxEstadoV.ToString();

                if (variableEstV == "Activo")
                {
                    vigencia = true;

                }
                else
                {
                    vigencia = false;
                }
                model.estadoVigencia = vigencia;
                
                
                
                int stockA = Convert.ToInt32(textBox3StockActual.Text);
                String Astock = stockA.ToString("11");
                int stockM = Convert.ToInt32(textBox1StockMinimo.Text);
                String Mstock = stockM.ToString("11");
                model.stockActual = stockA;
                model.stockMinimo = stockM;

                model.descipcion = textBox1DEscripcion.Text.Trim();

                string valorig = textBox1Costo.Text;
                decimal valdec = Convert.ToDecimal(valorig);


                model.precioCosto = valdec;

                string valor = textBox2PrecioVenta.Text;
                decimal venta = Convert.ToDecimal(valor);
                model.precioVenta = venta;
                using (MadereraEntities db = new MadereraEntities())
                {
                    if (model.idMaderas == 0)//Insert
                        db.Maderas.Add(model);
                    else //Actualizar
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified; //probar
                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Enviado satisfactoriamente");

            }
        }
        void Clear()
        {
            textBox1DEscripcion.Text = comboBox1Estado.Text = comboBox2TipoMad.Text = textBox1Costo.Text = textBox2PrecioVenta.Text = textBox3StockActual.Text = textBox1StockMinimo.Text  = "";
            
            model.idMaderas = 0;
        }
        void PopulateDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {
                var varMaderas = (from cli in db.Maderas
                                   where cli.estadoVigencia == true
                                   select cli
                            );

                dataGridView.DataSource = varMaderas.ToList();

            }
        }

        private void Inicio2_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Realmente quiere eliminar el registro?", "EF-Crud Opeacxion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (MadereraEntities db = new MadereraEntities())
                {

                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Maderas.Attach(model);
                    db.Maderas.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Eliminado Correctamente");
                }*/
            if (MessageBox.Show("Realmente quiere eliminar el registro?", "Centurion Maderas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                object itemComboxEstadoV = comboBox1Estado.SelectedItem;
                string variableEstV = itemComboxEstadoV.ToString();

                if (variableEstV == "Activo")
                {
                    vigencia = false;

                }

                model.estadoVigencia = vigencia;
                object itemTipoMad = comboBox2TipoMad.SelectedItem;
                string variableTipo = itemTipoMad.ToString();

                switch (variableTipo)
                {
                    case "Tirante":
                        tipoActual = 1;
                        break;
                    case "Clavadoras":
                        tipoActual = 2;
                        break;
                    case "Tablas":
                        tipoActual = 3;
                        break;
                    case "Machimbre":
                        tipoActual = 4;
                        break;
                    case "Tablon":
                        tipoActual = 5;
                        break;
                    case "Tirantillo":
                        tipoActual = 6;
                        break;
                    default:
                        tipoActual = 7;
                        break;
                }
                model.id_tipoMad = tipoActual;


                int stockA = Convert.ToInt32(textBox3StockActual.Text);
                String Astock = stockA.ToString("11");
                int stockM = Convert.ToInt32(textBox1StockMinimo.Text);
                String Mstock = stockM.ToString("11");
                model.stockActual = stockA;
                model.stockMinimo = stockM;

                model.descipcion = textBox1DEscripcion.Text.Trim();

                string valorig = textBox1Costo.Text;
                decimal valdec = Convert.ToDecimal(valorig);


                model.precioCosto = valdec;

                string valor = textBox2PrecioVenta.Text;
                decimal venta = Convert.ToDecimal(valor);
                model.precioVenta = venta;
                using (MadereraEntities db = new MadereraEntities())
                {
                    if (model.idMaderas == 0)//Insert
                        db.Maderas.Add(model);
                    else //Actualizar
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified; //probar
                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();

                MessageBox.Show("Eliminado Correctamente");
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {
                model.idMaderas = Convert.ToInt32(dataGridView.CurrentRow.Cells["idMaderas"].Value);

                using (MadereraEntities db = new MadereraEntities())
                {
                    model = db.Maderas.Where(x => x.idMaderas == model.idMaderas).FirstOrDefault();
                  
                    switch (model.id_tipoMad)
                    {
                        case 1:
                            comboBox2TipoMad.Text = "Tirante";
                            break;
                        case 2:
                            comboBox2TipoMad.Text = "Clavadoras";
                            break;
                        case 3:
                            comboBox2TipoMad.Text = "Tablas";
                            break;
                        case 4:
                            comboBox2TipoMad.Text = "Machimbre";
                            break;
                        case 5:
                            comboBox2TipoMad.Text = "Tablon";
                            break;
                        case 6:
                            comboBox2TipoMad.Text = "Tirantillo";
                            break;
                        default:
                            comboBox2TipoMad.Text = "Poste";
                            break;
                    }




                    //////////////////////////////////

                    if (model.estadoVigencia == true)
                    {
                        comboBox1Estado.Text = "Activo";
                    }
                    else
                    {
                        if (model.estadoVigencia == false)
                        {
                            comboBox1Estado.Text = "Inactivo";
                        }

                    }


                    comboBox2TipoMad.Text = comboBox2TipoMad.Text;
                    textBox1DEscripcion.Text = model.descipcion;
                    comboBox1Estado.Text = comboBox1Estado.Text;
                    textBox1StockMinimo.Text = model.stockMinimo.ToString();
                    textBox3StockActual.Text = model.stockActual.ToString();
                    textBox1Costo.Text = model.precioCosto.ToString();
                    textBox2PrecioVenta.Text = model.precioVenta.ToString();
                }
                btnGuardar.Text = "Actualizar";
                btnEliminar.Enabled = true;
            }
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
        private void botonPersonalizado1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            if (ValidarCampoBuscar())
            {
                if (radioButton1.Checked == true)
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
                                
            }
            con.Close();
            ClearBuscar();
        }

        private void comboBox1Estado_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1Estado.Text != "")
                errorProvider1.SetError(comboBox1Estado, "");
            else
            {
                errorProvider1.SetError(comboBox1Estado, "Seleccione un estado vigencia");
                e.Cancel = false;
            }
        }

        private void comboBox2TipoMad_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox2TipoMad.Text != "")
                errorProvider1.SetError(comboBox2TipoMad, "");
            else
            {
                errorProvider1.SetError(comboBox2TipoMad, "Seleccione un tipo de madera");
                e.Cancel = false;
            }
        }

        private void textBox1Costo_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1Costo.Text != "")
                errorProvider1.SetError(textBox1Costo, "");
            else
            {
                errorProvider1.SetError(textBox1Costo, "Debe ingresar el costo");
                e.Cancel = false;
            }
        }

        private void textBox2PrecioVenta_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2PrecioVenta.Text != "")
                errorProvider1.SetError(textBox2PrecioVenta, "");
            else
            {
                errorProvider1.SetError(textBox2PrecioVenta, "Debe ingresar el precio de venta");
                e.Cancel = false;
            }
        }

        private void textBox1StockMinimo_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox1StockMinimo.Text, out num))
            {
                errorProvider1.SetError(textBox1StockMinimo, "Ingrese valor numerico");
            }
            else
            {
                errorProvider1.SetError(textBox1StockMinimo, "");
            }
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

        private void textBox1Costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("solo numeros y puntos decimales");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2PrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("solo numeros y puntos decimales");
 }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            /*if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("solo numeros y utilizar ',' para decimales");
            }*/
        }

        private void botonPersonalizado2_Click_1(object sender, EventArgs e)
        {
            Clear();
            ClearBuscar();
            PopulateDataGridView();
        }
    }
}
