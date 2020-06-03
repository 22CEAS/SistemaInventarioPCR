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
    public partial class frmAlquiler : Form
    {
        public frmAlquiler()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void superGridControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarMemoria_Click(object sender, EventArgs e)
        {
            using (frmEditarMemoria frm = new frmEditarMemoria())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void btnEditarDisco_Click(object sender, EventArgs e)
        {
            using (frmEditarDisco frm = new frmEditarDisco())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void btnEditarLicencia_Click(object sender, EventArgs e)
        {
            using (frmEditarLicencia frm = new frmEditarLicencia())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            using (frmAgregarProducto frm = new frmAgregarProducto())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }
    }
}
