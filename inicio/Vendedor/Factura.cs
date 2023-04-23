using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inicio.Vendedor
{
    public partial class Factura : Form
    {
        Clientes clienteEntity = new Clientes();
        public Factura()
        {
            InitializeComponent();
        }

        public Factura(string usuario, string fecha)
        {
            InitializeComponent();
            lNombreVendFac.Text = usuario;
            lblFecha.Text = fecha;
        }

        string dni_cb;
        int codigoProducto;
        string estad;
        string tipo;
        string estadosistema;
        string apellidoB;
        string nombreB;
        string descripcionB;
        private void btnCancelarFac_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        void ActualizarStock(int pCantidad, int pidmadera)
        {
            using (MadereraEntities db = new MadereraEntities())
            {
                var varmadera = (from madera in db.Maderas
                                 where madera.idMaderas == pidmadera
                                 select madera
                                           );
                Maderas maderaActualizada = varmadera.FirstOrDefault();

                maderaActualizada.stockActual = maderaActualizada.stockActual - pCantidad;

            }

        }

        void PopulateDataGridViewActivos()
        {
            // dataGridView1.AutoGenerateColumns = false;
            using (MadereraEntities db = new MadereraEntities())
            {
                var varClientes = (from cli in db.Clientes
                                   where cli.estado_vigencia == true
                                   select cli
                            );

                //   dataGridView1.DataSource = varClientes.ToList(); //db.Clientes.ToList<Clientes>();

            }
        }


        int totalFacturas;
        private void botonConfirmarDatos_Click(object sender, EventArgs e)
        {
            lblTipoFac.Text = comboxTipoFactura.SelectedItem.ToString();
            lblFormaPago.Text = comboxFormaPago.SelectedItem.ToString();
            lClienteNomb.Text = textBoxCliente.Texts;
            label12.Text = textBoxTipoCliente.Texts;
            this.panelDatosCab.Visible = false;

            panelCabecera.Visible = true;
            panelProductoDetalle.Visible = true;
            lPrecioSubTotal.Visible = true;
            lPrecioTotal.Visible = true;

            btnQuitarDet.Visible = true;
            btnRegistrar.Visible = true;
            btnCancelarFac.Visible = true;
            GridDetalle.Visible = true;
            lSubTotal.Visible = true;
            lTotal.Visible = true;
            using (MadereraEntities db = new MadereraEntities())
            {
                List<Facturas> CantidadFACTURAS = (from cantidadFac in db.Facturas
                                                   select cantidadFac).ToList();
                totalFacturas = CantidadFACTURAS.Count();

                if (totalFacturas == 0)
                {
                    totalFacturas = 1;
                }
                else
                {
                    totalFacturas = totalFacturas + 1;
                }
                lblCantFacNueva.Text = totalFacturas.ToString();
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Proceso de Facturacion
        int idUsuario;
        int idCliente;
        int numeroFactura;
        int idTipoFactura;
        int tipoMadera;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //verifica si el GRID esta VACIO
            if (GridDetalle.Rows.Count != 0)
            {
                lPrecioTotal.Text = lPrecioSubTotal.Text;
                //aca condicion de total != 0
                if (MessageBox.Show("Desea Registrar Factura?", "FACTURACION", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (MadereraEntities db = new MadereraEntities())
                    {
                        if (lblTipoFac.Text == "A")
                        {
                            idTipoFactura = 1;
                        }
                        else
                        {
                            if (lblTipoFac.Text == "B")
                            {
                                idTipoFactura = 2;
                            }
                            else
                            {
                                idTipoFactura = 3;
                            }
                        }

                        var usuarioFactura = (from usu in db.Usuarios
                                              where usu.nombre == lNombreVendFac.Text
                                              select usu);

                        Usuarios UsuarioEncontrado = usuarioFactura.FirstOrDefault();
                        if (usuarioFactura.FirstOrDefault() != null)
                        {
                            idUsuario = UsuarioEncontrado.Id_usuario;
                        }

                        var clienteFactura = (from client in db.Clientes
                                              where client.nombre == lClienteNomb.Text
                                              select client);

                        Clientes ClienteEncontrado = clienteFactura.FirstOrDefault();
                        if (clienteFactura.FirstOrDefault() != null)
                        {
                            idCliente = ClienteEncontrado.Id_cliente;
                        }

                        using (var dbContextTransaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                Facturas obFactura = new Facturas();

                                obFactura.NumeroFac = totalFacturas;
                                obFactura.id_usuarioFac = idUsuario;
                                obFactura.id_tipoFac = idTipoFactura;
                                obFactura.formaPago = lblFormaPago.Text;
                                obFactura.fecha = DateTime.Now;
                                obFactura.id_clienteFac = idCliente;
                                obFactura.total = decimal.Parse(lPrecioTotal.Text.ToString());
                                obFactura.estado_vigencia = true;

                                //inserto factura
                                db.Facturas.Add(obFactura);
                                // paso a la base la factura creada para poder asigna el id_factura en los detalles

                                db.SaveChanges();

                                //para mostrar msj de facturacion
                                numeroFactura = obFactura.NumeroFac;

                                //recorro los items del detalle

                                foreach (DataGridViewRow dgvD in GridDetalle.Rows)
                                {
                                    if (dgvD.Cells[1].Value.ToString() == "Tirante")
                                    {
                                        tipoMadera = 1;
                                    }
                                    else
                                    {
                                        if (dgvD.Cells[1].Value.ToString() == "Clavadoras")
                                        {
                                            tipoMadera = 2;
                                        }

                                    }
                                    Detalles obDetalle = new Detalles();
                                    obDetalle.id_facturaDet = obFactura.id_factura;
                                    obDetalle.id_maderaDet = tipoMadera;
                                    obDetalle.precioUnitario = decimal.Parse(dgvD.Cells[2].Value.ToString());
                                    obDetalle.cantidad = int.Parse(dgvD.Cells[3].Value.ToString());
                                    obDetalle.importeDetalle = decimal.Parse(dgvD.Cells[4].Value.ToString());

                                    //inserto el detalle
                                    db.Detalles.Add(obDetalle);
                                    //actualizo el stock
                                    
                                    
                                        var varmadera = (from madera in db.Maderas
                                                         where madera.idMaderas == obDetalle.id_maderaDet
                                                         select madera
                                                                   );
                                        Maderas maderaActualizada = varmadera.FirstOrDefault();

                                        maderaActualizada.stockActual = maderaActualizada.stockActual - obDetalle.cantidad;
                                    }
                                //paso los detalles generados a la base
                                db.SaveChanges();

                                dbContextTransaction.Commit();
                                MessageBox.Show("Se Registro con Exito la Factura: " + numeroFactura, "FACTURACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                            }

                        }


                    }

                }
            }
            else
            {
                MessageBox.Show("Ingrese Datos en el Detalle de la Factura", "FACTURACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBoxTipoCliente.Visible = true;
            using (MadereraEntities db = new MadereraEntities())
            {

                if (textBoxCliente.Texts.Trim().Length != 0)
                {
                    if (textBoxCliente.Texts.All(char.IsDigit))
                    {
                        dni_cb = textBoxCliente.Texts;

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
                            textBoxCliente.Texts = dni_cb;
                            textBoxTipoCliente.Texts = tipo;
                        }
                        else
                        {
                            MessageBox.Show("El Cliente No Existe", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                    else
                    {

                        apellidoB = textBoxCliente.Texts.Trim();

                        List<Clientes> ClientesB = (from clientesB in db.Clientes
                                                    where clientesB.apellido.Trim() == apellidoB
                                                    select clientesB).ToList();
                        if (ClientesB.Count > 1)
                        {
                            MessageBox.Show("Ingrese DNI del Cliente ", "FACTURACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lDNICliente.Visible = true;
                            textBoxDni.Visible = true;

                            if (textBoxDni.Texts.Trim().Length != 0)
                            {
                                if (textBoxDni.Texts.All(char.IsDigit))
                                {
                                    dni_cb = textBoxDni.Texts;

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

                                                MessageBox.Show("El Cliente Ha Sido Eliminado", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                textBoxDni.Texts = "";
                                                textBoxCliente.Texts = "";
                                            }

                                        }

                                        textBoxDni.Texts = dni_cb;
                                        textBoxTipoCliente.Texts = tipo;
                                    }
                                    else
                                    {
                                        MessageBox.Show("El Cliente No Existe", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        textBoxDni.Texts = "";
                                        textBoxCliente.Texts = "";
                                    }

                                }
                            }
                        }

                        if (ClientesB.FirstOrDefault() == null)
                        {
                            nombreB = textBoxCliente.Texts.Trim();
                            ClientesB = (from clientesB in db.Clientes
                                         where clientesB.nombre == nombreB
                                         select clientesB).ToList();

                        }
                        //
                        if (ClientesB.Count > 1)
                        {
                            lDNICliente.Visible = true;
                            textBoxDni.Visible = true;

                            MessageBox.Show("Ingrese DNI del Cliente ", "FACTURACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        textBoxDni.Focus();       
                            if (textBoxDni.Texts.Trim().Length != 0)
                            {
                                if (textBoxDni.Texts.All(char.IsDigit))
                                {
                                    dni_cb = textBoxDni.Texts;

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

                                                MessageBox.Show("El Cliente Ha Sido Eliminado", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                textBoxDni.Texts = "";
                                                textBoxCliente.Texts = "";
                                            }

                                        }

                                        textBoxDni.Texts = dni_cb;
                                        textBoxTipoCliente.Texts = tipo;
                                    }
                                    else
                                    {
                                        MessageBox.Show("El Cliente No Existe", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        textBoxDni.Texts = "";
                                        textBoxCliente.Texts = "";
                                    }

                                }
                            }
                        //
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
                                        MessageBox.Show("El Cliente Ha Sido Eliminado", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        textBoxDni.Texts = "";
                                        textBoxCliente.Texts = "";

                                    }

                                }
                                textBoxCliente.Texts = nombreB;
                                textBoxTipoCliente.Texts = tipo;
                            }
                        }

                        else
                        {
                            MessageBox.Show("El Cliente " + textBoxCliente.Text + " No se Encontro Vuelva A intentar", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese datos para realizar busqueda", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        string nombreProd;
        private void btnBuscaProd_Click(object sender, EventArgs e)
        {

            using (MadereraEntities db = new MadereraEntities())
            {

                if (textBoxDatoProducto.Texts.Trim().Length != 0)
                {
                    if (textBoxDatoProducto.Texts.All(char.IsDigit))
                    {
                        codigoProducto = int.Parse(textBoxDatoProducto.Texts);

                        var productos = (from mad in db.Maderas
                                         where mad.idMaderas == codigoProducto
                                         select mad);

                        Maderas ProductoEncontrado = productos.FirstOrDefault();
                        if (productos.FirstOrDefault() != null)
                        {
                            //aca compara si es el estado es correccto

                            if (ProductoEncontrado.estadoVigencia == true)
                            {

                                int opcion;

                                opcion = ProductoEncontrado.id_tipoMad;
                                switch (opcion)
                                {
                                    case 1:
                                        nombreProd = "Tirante";
                                        break;
                                    case 2:
                                        nombreProd = "Clavadoras";
                                        break;

                                }
                                btnBuscaProd.Visible = false;

                                textBoxDatoProducto.Texts = nombreProd;
                                btnAgregar.Visible = true;
                                btnCancelar.Visible = true;
                                lCantidad.Visible = true;
                                textBoxCantidad.Visible = true;


                            }


                        }
                        else
                        {
                            MessageBox.Show("El Producto No Existe", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                    else
                    {

                        descripcionB = textBoxDatoProducto.Texts.Trim();

                        List<TipoMadera> PRODUCTOSB = (from productosB in db.TipoMadera
                                                       where productosB.descripcion.Trim() == descripcionB
                                                       select productosB).ToList();


                        TipoMadera ProductoEncontrado = PRODUCTOSB.FirstOrDefault();
                        if (PRODUCTOSB.FirstOrDefault() != null)
                        {
                            if (ProductoEncontrado.estadoVigencia == true)
                            {
                                btnBuscaProd.Visible = false;
                                textBoxDatoProducto.Texts = ProductoEncontrado.descripcion;
                                btnAgregar.Visible = true;
                                btnCancelar.Visible = true;
                                lCantidad.Visible = true;
                                textBoxCantidad.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("El Producto No Existe", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("El Producto " + textBoxDatoProducto.Text + " No se Encontro Vuelva A intentar", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese datos para realizar busqueda", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textBoxDatoProducto.Texts = "";
            lCantidad.Visible = false;
            textBoxCantidad.Visible = false;
            btnAgregar.Visible = false;
            btnCancelar.Visible = false;
            btnBuscaProd.Visible = true;

        }

        //PROCESO DE CONTROL DE STOCK
        int stockMemoria;
        int codigoProducDGV;
        string descripcionDGV;
        string precioUnitarioDGV;
        string precioTotalDGV;
        string cantidadDGV;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (MadereraEntities db = new MadereraEntities())
            {
                descripcionB = textBoxDatoProducto.Texts.Trim();

                List<TipoMadera> PRODUCTOSB = (from productosB in db.TipoMadera
                                                   // join prod in db.Maderas on productosB.id_tipoMadera equals prod.id_tipoMad
                                               where productosB.descripcion.Trim() == descripcionB
                                               select productosB).ToList();

                TipoMadera ProductoEncontrado = PRODUCTOSB.FirstOrDefault();

                List<Maderas> MADERASB = (from maderaB in db.Maderas
                                              // join prod in db.TipoMadera on productosB.id_tipoMad equals prod.id_tipoMadera
                                          where maderaB.id_tipoMad == ProductoEncontrado.id_tipoMadera
                                          select maderaB).ToList();

                Maderas maderaEncontrada = MADERASB.FirstOrDefault();

                int stockRequerido = int.Parse(textBoxCantidad.Texts.Trim());

                //si el detalle esta vacio
                if (GridDetalle.Rows.Count == 0)
                {
                    //verifica si existe stock en la base
                    if (maderaEncontrada.stockActual >= stockRequerido)
                    {
                        if (PRODUCTOSB.FirstOrDefault() != null)
                        {
                            int opcion;

                            opcion = ProductoEncontrado.id_tipoMadera;
                            switch (opcion)
                            {
                                case 1:
                                    descripcionDGV = "Tirante";
                                    break;
                                case 2:
                                    descripcionDGV = "Clavadoras";
                                    break;

                            }


                            cantidadDGV = textBoxCantidad.Texts.Trim();
                            precioUnitarioDGV = maderaEncontrada.precioVenta.ToString();

                            codigoProducDGV = maderaEncontrada.idMaderas;
                            precioTotalDGV = (decimal.Parse(cantidadDGV) * decimal.Parse(precioUnitarioDGV)).ToString();
                            textBoxDatoProducto.Texts = descripcionDGV;
                        }

                        GridDetalle.Rows.Add(new object[] { codigoProducDGV, descripcionDGV, precioUnitarioDGV, cantidadDGV, precioTotalDGV });

                        textBoxCantidad.Texts = "";
                        textBoxDatoProducto.Texts = "";
                        textBoxCantidad.Visible = false;
                        lCantidad.Visible = false;
                        btnAgregar.Visible = false;
                        btnCancelar.Visible = false;
                        btnBuscaProd.Visible = true;

                        CalcularTotal();
                    }
                }
                //si no esta vacio el detalle entonces recorre el gridDetlle
                //y verifico si esta el mismo producto que se desea agregar al detalle
                //y actualizo el stock en memoria
                else
                {

                    //prueba
                    int contador = 0;//GridDetalle.Rows.Count;
                    int i = GridDetalle.Rows.Count;
                    stockMemoria = maderaEncontrada.stockActual;
                    foreach (DataGridViewRow dgvD in GridDetalle.Rows)
                    {
                        //prueba condicion salir
                        // contador = contador + 1;

                        if (contador <= i)
                        {
                            //i = i - 1;
                            int codigoRecorriendo = int.Parse(dgvD.Cells[0].Value.ToString());
                            if (maderaEncontrada.idMaderas == codigoRecorriendo)
                            {
                                //actualiza el stock en memoria
                                stockMemoria = stockMemoria - int.Parse(dgvD.Cells[3].Value.ToString());
                                contador = contador + 1;
                                //si el stock en memoria es superior a la cantidad solicitada agrega al detalle
                                /* PRUEBAULTIMA if (stockMemoria >= stockRequerido)
                                {

                                    string cantidadDGV2;

                                    if (PRODUCTOSB.FirstOrDefault() != null)
                                    {
                                        int opcion;

                                        opcion = ProductoEncontrado.id_tipoMadera;
                                        switch (opcion)
                                        {
                                            case 1:
                                                descripcionDGV = "Tirante";
                                                break;
                                            case 2:
                                                descripcionDGV = "Clavadoras";
                                                break;

                                        }


                                        cantidadDGV2 = textBoxCantidad.Texts.Trim();
                                        precioUnitarioDGV = maderaEncontrada.precioVenta.ToString();

                                        codigoProducDGV = maderaEncontrada.idMaderas;
                                        precioTotalDGV = (decimal.Parse(cantidadDGV2) * decimal.Parse(precioUnitarioDGV)).ToString();
                                        textBoxDatoProducto.Texts = descripcionDGV;
                                    }

                                    GridDetalle.Rows.Add(new object[] { codigoProducDGV, descripcionDGV, precioUnitarioDGV, cantidadDGV, precioTotalDGV });

                                    textBoxCantidad.Texts = "";
                                    textBoxDatoProducto.Texts = "";
                                    textBoxCantidad.Visible = false;
                                    lCantidad.Visible = false;
                                    btnAgregar.Visible = false;
                                    btnCancelar.Visible = false;
                                    btnBuscaProd.Visible = true;

                                    CalcularTotal();
                                }
                                else
                                {
                                    textBoxCantidad.Texts = "";
                                    textBoxDatoProducto.Texts = "";
                                    textBoxCantidad.Visible = false;
                                    lCantidad.Visible = false;
                                    btnAgregar.Visible = false;
                                    btnCancelar.Visible = false;
                                    btnBuscaProd.Visible = true;
                                    MessageBox.Show("Stock Insufuciente para la cantidad Solicitada", "VERIFICACION STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }*/
                            }
                            //en caso de que no sean iguales el producto a ingresar
                            // y los productos que se encuntran en el gridDetalle
                            // entonces se compara el stock de base con la cantidad requerida
                            // para ver si se puede agregar al detalle
                            /*else //PRUEBA
                            {
                                if (maderaEncontrada.stockActual >= stockRequerido)
                                {

                                    if (PRODUCTOSB.FirstOrDefault() != null)
                                    {
                                        int opcion;

                                        opcion = ProductoEncontrado.id_tipoMadera;
                                        switch (opcion)
                                        {
                                            case 1:
                                                descripcionDGV = "Tirante";
                                                break;
                                            case 2:
                                                descripcionDGV = "Clavadoras";
                                                break;

                                        }


                                        cantidadDGV = textBoxCantidad.Texts.Trim();
                                        precioUnitarioDGV = maderaEncontrada.precioVenta.ToString();

                                        codigoProducDGV = maderaEncontrada.idMaderas;
                                        precioTotalDGV = (decimal.Parse(cantidadDGV) * decimal.Parse(precioUnitarioDGV)).ToString();



                                        textBoxDatoProducto.Texts = descripcionDGV;
                                    }

                                    GridDetalle.Rows.Add(new object[] { codigoProducDGV, descripcionDGV, precioUnitarioDGV, cantidadDGV, precioTotalDGV });

                                    textBoxCantidad.Texts = "";
                                    textBoxDatoProducto.Texts = "";
                                    textBoxCantidad.Visible = false;
                                    lCantidad.Visible = false;
                                    btnAgregar.Visible = false;
                                    btnCancelar.Visible = false;
                                    btnBuscaProd.Visible = true;

                                    CalcularTotal();

                                }
                                else
                                {
                                    textBoxCantidad.Texts = "";
                                    textBoxDatoProducto.Texts = "";
                                    textBoxCantidad.Visible = false;
                                    lCantidad.Visible = false;
                                    btnAgregar.Visible = false;
                                    btnCancelar.Visible = false;
                                    btnBuscaProd.Visible = true;
                                    MessageBox.Show("Stock Insufuciente para la cantidad Solicitada", "VERIFICACION STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            */

                        }
                        i = i - 1;
                        //contador = contador + 1;
                    }//fincondicion prueba
                     //
                    codigoProducDGV = maderaEncontrada.idMaderas;

                    if (maderaEncontrada.idMaderas == codigoProducDGV)
                    {
                        if (stockMemoria != 0 && stockMemoria >= stockRequerido)
                        {
                            stockMemoria = stockMemoria - stockRequerido;
                            if (PRODUCTOSB.FirstOrDefault() != null)
                            {
                                int opcion;

                                opcion = ProductoEncontrado.id_tipoMadera;
                                switch (opcion)
                                {
                                    case 1:
                                        descripcionDGV = "Tirante";
                                        break;
                                    case 2:
                                        descripcionDGV = "Clavadoras";
                                        break;

                                }


                                cantidadDGV = stockRequerido.ToString();// textBoxCantidad.Texts.Trim();
                                precioUnitarioDGV = maderaEncontrada.precioVenta.ToString();

                                codigoProducDGV = maderaEncontrada.idMaderas;
                                precioTotalDGV = (decimal.Parse(cantidadDGV) * decimal.Parse(precioUnitarioDGV)).ToString();



                                textBoxDatoProducto.Texts = descripcionDGV;
                            }

                            GridDetalle.Rows.Add(new object[] { codigoProducDGV, descripcionDGV, precioUnitarioDGV, cantidadDGV, precioTotalDGV });

                            textBoxCantidad.Texts = "";
                            textBoxDatoProducto.Texts = "";
                            textBoxCantidad.Visible = false;
                            lCantidad.Visible = false;
                            btnAgregar.Visible = false;
                            btnCancelar.Visible = false;
                            btnBuscaProd.Visible = true;

                            CalcularTotal();

                        }
                        else
                        {
                            if (maderaEncontrada.stockActual >= stockRequerido && stockMemoria == 0)
                            {

                                if (PRODUCTOSB.FirstOrDefault() != null)
                                {
                                    int opcion;

                                    opcion = ProductoEncontrado.id_tipoMadera;
                                    switch (opcion)
                                    {
                                        case 1:
                                            descripcionDGV = "Tirante";
                                            break;
                                        case 2:
                                            descripcionDGV = "Clavadoras";
                                            break;

                                    }


                                    cantidadDGV = stockRequerido.ToString();// textBoxCantidad.Texts.Trim();
                                    precioUnitarioDGV = maderaEncontrada.precioVenta.ToString();

                                    codigoProducDGV = maderaEncontrada.idMaderas;
                                    precioTotalDGV = (decimal.Parse(cantidadDGV) * decimal.Parse(precioUnitarioDGV)).ToString();



                                    textBoxDatoProducto.Texts = descripcionDGV;
                                }

                                GridDetalle.Rows.Add(new object[] { codigoProducDGV, descripcionDGV, precioUnitarioDGV, cantidadDGV, precioTotalDGV });

                                textBoxCantidad.Texts = "";
                                textBoxDatoProducto.Texts = "";
                                textBoxCantidad.Visible = false;
                                lCantidad.Visible = false;
                                btnAgregar.Visible = false;
                                btnCancelar.Visible = false;
                                btnBuscaProd.Visible = true;

                                CalcularTotal();

                            }
                            else
                            {
                                if (stockMemoria >= stockRequerido)
                                {

                                    if (PRODUCTOSB.FirstOrDefault() != null)
                                    {
                                        int opcion;

                                        opcion = ProductoEncontrado.id_tipoMadera;
                                        switch (opcion)
                                        {
                                            case 1:
                                                descripcionDGV = "Tirante";
                                                break;
                                            case 2:
                                                descripcionDGV = "Clavadoras";
                                                break;

                                        }


                                        cantidadDGV = stockRequerido.ToString();// textBoxCantidad.Texts.Trim();
                                        precioUnitarioDGV = maderaEncontrada.precioVenta.ToString();

                                        codigoProducDGV = maderaEncontrada.idMaderas;
                                        precioTotalDGV = (decimal.Parse(cantidadDGV) * decimal.Parse(precioUnitarioDGV)).ToString();



                                        textBoxDatoProducto.Texts = descripcionDGV;
                                    }

                                    GridDetalle.Rows.Add(new object[] { codigoProducDGV, descripcionDGV, precioUnitarioDGV, cantidadDGV, precioTotalDGV });

                                    textBoxCantidad.Texts = "";
                                    textBoxDatoProducto.Texts = "";
                                    textBoxCantidad.Visible = false;
                                    lCantidad.Visible = false;
                                    btnAgregar.Visible = false;
                                    btnCancelar.Visible = false;
                                    btnBuscaProd.Visible = true;

                                    CalcularTotal();

                                }
                                else
                                {




                                    textBoxCantidad.Texts = "";
                                    textBoxDatoProducto.Texts = "";
                                    textBoxCantidad.Visible = false;
                                    lCantidad.Visible = false;
                                    btnAgregar.Visible = false;
                                    btnCancelar.Visible = false;
                                    btnBuscaProd.Visible = true;
                                    MessageBox.Show("Stock Insufuciente para la cantidad Solicitada", "VERIFICACION STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);


                                }
                            }

                        }

                    }
                }
            }
        }
    

        int posicion;
        private void GridDetalle_Click(object sender, EventArgs e)
        {
            if (GridDetalle.CurrentRow.Index != -1)
            {
                posicion = GridDetalle.CurrentRow.Index;
            }
        }


/*        private void VerificarStock(int pIdmadera, int pCantidad)
        {

            //  if (GridDetalle.Rows.Count != 0)
            //{
                using (MadereraEntities db = new MadereraEntities())
                {
                    List<Maderas> MADERASB = (from maderaB in db.Maderas
                                                  // join prod in db.TipoMadera on productosB.id_tipoMad equals prod.id_tipoMadera
                                              where maderaB.idMaderas == pIdmadera
                                              select maderaB).ToList();

                    Maderas maderaEncontrada = MADERASB.FirstOrDefault();

                    if (maderaEncontrada != null)
                    {
                     if (stockMemoria >= pCantidad)
                     {

                        foreach (DataGridViewRow dgvD in GridDetalle.Rows)
                        {
                            if (maderaEncontrada.idMaderas == codigoProducDGV)
                            {

                                stockMemoria = maderaEncontrada.stockActual - pCantidad;
                            }
                        }
                    }
                }
                else
                {
                    
                }
            }
        }*/
            //}
        private void CalcularTotal()
        {
            decimal TOTAL = 0;
            foreach (DataGridViewRow dgvD in GridDetalle.Rows)
            {
                decimal importe = decimal.Parse(dgvD.Cells[4].Value.ToString());
                TOTAL += importe;
            }
            lPrecioSubTotal.Text = TOTAL.ToString();

        }
        private void btnQuitarDet_Click(object sender, EventArgs e)
        {
            GridDetalle.Rows.RemoveAt(posicion);
            CalcularTotal();
        }
    }
}
