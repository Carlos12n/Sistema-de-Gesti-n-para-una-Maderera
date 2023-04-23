using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inicio.Gerente
{
    public partial class MenuGerente : Form
    {
        public MenuGerente()
        {
            InitializeComponent();
        }

        public MenuGerente(string nombre)
        {
            InitializeComponent();
            nombreGerente.Text = nombre;
            
            //usuario = labelNombreVen.Text;
        }

        private void MenuGerente_Load(object sender, EventArgs e)
        {

            //  this.reportViewer1.RefreshReport();
           // this.reportViewer1.RefreshReport();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loguin = new Form1();
            loguin.Show();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnReportVenta_Click(object sender, EventArgs e)
        {
            if (panelSubMenuReportVent.Visible == false)
            {
                panelSubMenuReportVent.Visible = true;
            }
            else
            {
                panelSubMenuReportVent.Visible = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelDesdeHasta.Visible = false;
            lreporteNombre.Visible = false;
            btnGenerar.Visible = false;
            if(GridCompras.Visible == true)
            GridCompras.Visible = false;
            if (gridStock.Visible == true)
                gridStock.Visible = false;
            if (gridVentas.Visible == true)
            {
                gridVentas.Visible = false;
            }
            if(gridMasVendido.Visible == true)
            {
                gridMasVendido.Visible = false;
            }
        }

        private void btnReporteSt_Click(object sender, EventArgs e)
        {
            if (gridMasVendido.Visible == true)
            {
                gridMasVendido.Visible = false;
            }
            else
            {
                if (gridVentas.Visible == true)
                {
                    gridVentas.Visible = false;
                }
                else
                {
                    if (GridCompras.Visible == true)
                    {
                        GridCompras.Visible = false;
                    }
                    else
                    {
                        if (gridStock.Visible == true)
                        {
                            gridStock.Visible = false;
                        }
                    }
                }

                if(lreporteNombre.Visible==true)
                {
                    lreporteNombre.Visible = false;
                }

                lreporteNombre.Text = "STOCK";
                lreporteNombre.Visible = true;
                panelDesdeHasta.Visible = true;
                btnGenerar.Visible = true;

            }
        }

        private void btnReporteG_Click(object sender, EventArgs e)
        {
            if (gridMasVendido.Visible == true)
            {
                gridMasVendido.Visible = false;
            }
            else
            {
                if (gridVentas.Visible == true)
                {
                    gridVentas.Visible = false;
                }
                else
                {
                    if (GridCompras.Visible == true)
                    {
                        GridCompras.Visible = false;
                    }
                    else
                    {
                        if (gridStock.Visible == true)
                        {
                            gridStock.Visible = false;
                        }
                    }
                }
            }

            if (lreporteNombre.Visible == true)
            {
                lreporteNombre.Visible = false;
            }

            lreporteNombre.Text = "GASTOS";
            lreporteNombre.Visible = true;
            panelDesdeHasta.Visible = true;
            btnGenerar.Visible = true;
            
        }

        private void btnRVentas_Click(object sender, EventArgs e)
        {
            if (gridMasVendido.Visible == true)
            {
                gridMasVendido.Visible = false;
            }
            else
            {
                if (gridVentas.Visible == true)
                {
                    gridVentas.Visible = false;
                }
                else
                {
                    if (GridCompras.Visible == true)
                    {
                        GridCompras.Visible = false;
                    }
                    else
                    {
                        if (gridStock.Visible == true)
                        {
                            gridStock.Visible = false;
                        }
                    }
                }
            }

            if (lreporteNombre.Visible == true)
            {
                lreporteNombre.Visible = false;
            }

            lreporteNombre.Text = "VENTAS";
            lreporteNombre.Visible = true;
            panelDesdeHasta.Visible = true;
            btnGenerar.Visible = true;
        }

        private void lminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRePMV_Click(object sender, EventArgs e)
        {
            if (gridMasVendido.Visible == true)
            {
                gridMasVendido.Visible = false;
            }
            else
            {
                if (gridVentas.Visible == true)
                {
                    gridVentas.Visible = false;
                }
                else
                {
                    if (GridCompras.Visible == true)
                    {
                        GridCompras.Visible = false;
                    }
                    else
                    {
                        if (gridStock.Visible == true)
                        {
                            gridStock.Visible = false;
                        }
                    }
                }
            }

            if (lreporteNombre.Visible == true)
            {
                lreporteNombre.Visible = false;
            }

            lreporteNombre.Text = "PRODUCTOS CON MAS VENTAS";
            lreporteNombre.Visible = true;
            panelDesdeHasta.Visible = true;
            btnGenerar.Visible = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(lreporteNombre.Text == "STOCK")
            {
                gridStock.Visible = true;
            }
            else
            {
                if(lreporteNombre.Text == "GASTOS")
                {
                    GridCompras.Visible = true;
                }
                else
                {
                    if (lreporteNombre.Text == "VENTAS")
                    {
                        gridVentas.Visible = true;
                    }
                    else
                    {
                        gridMasVendido.Visible = true;
                    }
                }
            }
        }
    }
}
