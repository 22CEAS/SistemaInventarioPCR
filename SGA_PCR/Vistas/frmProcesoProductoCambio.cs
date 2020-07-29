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
    public partial class frmProcesoProductoCambio : Form
    {
        public frmProcesoProductoCambio()
        {
            InitializeComponent();
        }

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        //    this.Close();
        //}

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnEditarLicencia_Click(object sender, EventArgs e)
        {

        }
    }
}
