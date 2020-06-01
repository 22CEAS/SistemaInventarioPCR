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
            btnIngreso.Enabled = false;
            frmIngreso frm = new frmIngreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearProcesador_Click(object sender, EventArgs e)
        {
            btnCrearProcesador.Enabled = false;
            frmCrearProcesador frm = new frmCrearProcesador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearMemoria_Click(object sender, EventArgs e)
        {
            btnCrearMemoria.Enabled = false;
            frmCrearMemoria frm = new frmCrearMemoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearDisco_Click(object sender, EventArgs e)
        {
            btnCrearDisco.Enabled = false;
            frmCrearDiscoDuro frm = new frmCrearDiscoDuro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearTarjetaVideo_Click(object sender, EventArgs e)
        {
            btnCrearTarjetaVideo.Enabled = false;
            frmCrearTarjetaVideo frm = new frmCrearTarjetaVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            btnCrearCliente.Enabled = false;
            frmCrearCliente frm = new frmCrearCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            btnProveedor.Enabled = false;
            frmCrearProveedor frm = new frmCrearProveedor();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            btnDevolucion.Enabled = false;
            frmDevolucion frm = new frmDevolucion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            btnAlquiler.Enabled = false;
            frmAlquiler frm = new frmAlquiler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {

        }
    }
}
