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
            frmIngreso frm = new frmIngreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearProcesador_Click(object sender, EventArgs e)
        {
            //btnCrearProcesador.Enabled = false;
            frmCrearProcesador frm = new frmCrearProcesador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearMemoria_Click(object sender, EventArgs e)
        {
            //btnCrearMemoria.Enabled = false;
            frmCrearMemoria frm = new frmCrearMemoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearDisco_Click(object sender, EventArgs e)
        {
            //btnCrearDisco.Enabled = false;
            frmCrearDiscoDuro frm = new frmCrearDiscoDuro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearTarjetaVideo_Click(object sender, EventArgs e)
        {
            //btnCrearTarjetaVideo.Enabled = false;
            frmCrearTarjetaVideo frm = new frmCrearTarjetaVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            //btnCrearCliente.Enabled = false;
            frmCrearCliente frm = new frmCrearCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            //btnProveedor.Enabled = false;
            frmCrearProveedor frm = new frmCrearProveedor();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            //btnDevolucion.Enabled = false;
            frmDevolucion frm = new frmDevolucion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            //btnAlquiler.Enabled = false;
            frmAlquiler frm = new frmAlquiler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            //btnCambio.Enabled = false;
            frmCambio frm = new frmCambio();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnCambioComponente_Click(object sender, EventArgs e)
        {
            frmCambioPieza frm = new frmCambioPieza();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimiento frm = new frmMantenimiento();
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
            frmInventario frm = new frmInventario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnVencimientos_Click(object sender, EventArgs e)
        {
            frmCuadroVencimiento frm = new frmCuadroVencimiento();
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
            frmLevantamientoObservaciones frm = new frmLevantamientoObservaciones();
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

        private void btnMemoriasDiscos_Click(object sender, EventArgs e)
        {
            frmReporteMemoriaDisco frm = new frmReporteMemoriaDisco();
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
    }
}
