using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //btnIngreso.Enabled = false;
            frmProcesoIngreso frm = new frmProcesoIngreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearProcesador_Click(object sender, EventArgs e)
        {
            //btnCrearProcesador.Enabled = false;
            frmArchivoCrearProcesador frm = new frmArchivoCrearProcesador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearMemoria_Click(object sender, EventArgs e)
        {
            //btnCrearMemoria.Enabled = false;
            frmArchivoCrearMemoria frm = new frmArchivoCrearMemoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearDisco_Click(object sender, EventArgs e)
        {
            //btnCrearDisco.Enabled = false;
            frmArchivoCrearDiscoDuro frm = new frmArchivoCrearDiscoDuro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearTarjetaVideo_Click(object sender, EventArgs e)
        {
            //btnCrearTarjetaVideo.Enabled = false;
            frmArchivoCrearTarjetaVideo frm = new frmArchivoCrearTarjetaVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            //btnCrearCliente.Enabled = false;
            frmArchivoCrearCliente frm = new frmArchivoCrearCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            //btnProveedor.Enabled = false;
            frmArchivoCrearProveedor frm = new frmArchivoCrearProveedor();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            //btnDevolucion.Enabled = false;
            frmProcesoDevolucion frm = new frmProcesoDevolucion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            //btnAlquiler.Enabled = false;
            frmProcesoAlquiler frm = new frmProcesoAlquiler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            //btnCambio.Enabled = false;
            frmProcesoCambio frm = new frmProcesoCambio();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnCambioComponente_Click(object sender, EventArgs e)
        {
            frmProcesoCambioComponentes frm = new frmProcesoCambioComponentes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            frmProcesoReparacion frm = new frmProcesoReparacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReportMantenimiento_Click(object sender, EventArgs e)
        {
            frmReporteMantenimiento frm = new frmReporteMantenimiento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmReporteInventario frm = new frmReporteInventario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnVencimientos_Click(object sender, EventArgs e)
        {
            frmReporteCuadroVencimiento frm = new frmReporteCuadroVencimiento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSubirFactura_Click(object sender, EventArgs e)
        {
            frmProcesoSubirFacturas frm = new frmProcesoSubirFacturas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReportePendienteFacturar_Click(object sender, EventArgs e)
        {
            frmReportePendienteFacturar frm = new frmReportePendienteFacturar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnLevantarObservacion_Click(object sender, EventArgs e)
        {
            frmProcesoLevantamientoObservaciones frm = new frmProcesoLevantamientoObservaciones();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            frmReporteCompras frm = new frmReporteCompras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReporteAlquileres_Click(object sender, EventArgs e)
        {
            frmReporteAlquiler frm = new frmReporteAlquiler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMemorias_Click(object sender, EventArgs e)
        {
            frmReporteMemoria frm = new frmReporteMemoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            frmReporteStocksLaptops frm = new frmReporteStocksLaptops();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPendienteRecoger_Click(object sender, EventArgs e)
        {
            frmReportePendienteRecoger frm = new frmReportePendienteRecoger();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPendienteReposicion_Click(object sender, EventArgs e)
        {
            frmReportePendienteReposicion frm = new frmReportePendienteReposicion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            frmArchivoClienteSucursal frm = new frmArchivoClienteSucursal();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRenovacion_Click(object sender, EventArgs e)
        {
            frmProcesoRenovacion frm = new frmProcesoRenovacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            frmReporteAlquileresPorVencer frm = new frmReporteAlquileresPorVencer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDiscos_Click(object sender, EventArgs e)
        {
            frmReporteDisco frm = new frmReporteDisco();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
